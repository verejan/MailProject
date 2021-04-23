using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AppooProjectClasses
{
    public struct MyMail
    {
        public String To;
        public String From;
        public String Subject;
        public String Body;
        public Boolean hasAttachments;
    }

    public struct Folder
    {
        public String name;
        public Folder(String _name)
        {
            name = _name;
        }
    }

    public class Tools
    {
        public static String ToBase64(String input)
        {
            Byte[] inputStringBytes = ASCIIEncoding.ASCII.GetBytes(input);
            return Convert.ToBase64String(inputStringBytes);
        }

        #region MailHeaderInfo
        public static String GetSubject(String mailSourceCode)
        {
            //Find Subject
            Regex subjectRegex = new Regex(
                "[sS]ubject:(?<subject>(\\s+.+)?)\n", 
                RegexOptions.IgnoreCase);
            Match subjectMatch = subjectRegex.Match(mailSourceCode);
            String subject = subjectMatch.Groups["subject"].Value;
            if (Regex.IsMatch(subject, "=\\?[^\\?]*\\?[qQbB]\\?"))
            {
                return QPorBase64ToString(subject).Trim();
            }
            else
            {
                return subject.Trim();
            }
        }

        public static String GetSender(String mailSourceCode)
        {
            //Find Sender
            Regex fromRegex = new Regex(
                "[fF]rom:\\s(\"?(?<name>[^\"<\n]*)\"?\\s*)?(?<email>\\s?<?[^:]*>?)\n", 
                RegexOptions.IgnoreCase);
            Match fromMatch = fromRegex.Match(mailSourceCode);
            String senderName = fromMatch.Groups["name"].Value;
            String senderEmail = fromMatch.Groups["email"].Value;
            if (Regex.IsMatch(senderName, "=\\?[^\\?]*\\?[qQbB]\\?"))
            {
                return QPorBase64ToString(senderName).Trim() + " " + senderEmail.Trim();
            }
            else
            {
                return senderName.Trim() + " " + senderEmail.Trim();
            }
        }

        public static String GetDestination(String mailSourceCode)
        {
            //Find destination
            Regex toRegex = new Regex(
                "[tT]o:\\s(\"?(?<name>[^\"<\n]*)\"?\\s*)?(?<email>\\s?<?[^:]*>?)\n",
                RegexOptions.IgnoreCase);
            Match toMatch = toRegex.Match(mailSourceCode);
            String toName = toMatch.Groups["name"].Value;
            String toEmail = toMatch.Groups["email"].Value;
            if (Regex.IsMatch(toName, "=\\?[^\\?]*\\?[qQbB]\\?"))
            {
                return QPorBase64ToString(toName).Trim() + " " + toEmail.Trim();
            }
            else
            {
                return toName.Trim() + " " + toEmail.Trim();
            }
        }

        public static String GetContentType(String mailSourceCode)
        {
            Regex typeRegex = new Regex(
                "Content-Type:\\s+?(?<type>[^;]+)\n?", 
                RegexOptions.IgnoreCase);
            Match typeMatch = typeRegex.Match(mailSourceCode);
            String Type = typeMatch.Groups["type"].Value;
            return Type;
        }
        #endregion MailHeaderInfo

        #region Decoders
        private static String QPorBase64ToString(String encodedString)
        {
            Regex encodeRegex = new Regex(
                "=\\?(?<charset>[^\\?]*)\\?(?<encodetype>[qQbB])\\?(?<encoded>\\S*)\\?=");
            MatchCollection encodedMatches = encodeRegex.Matches(encodedString);
            String decodedString = String.Empty;
            Encoding encoder;
            foreach (Match encodedMatch in encodedMatches)
            {
                String encodeType = encodedMatch.Groups["encodetype"].Value;
                String charset = encodedMatch.Groups["charset"].Value;
                String encodedText = encodedMatch.Groups["encoded"].Value;
                if (encodeType == "B" || encodeType == "b")
                {
                    encoder = Encoding.GetEncoding(charset);
                    Byte[] base64Bytes = Convert.FromBase64String(encodedText);
                    decodedString += encoder.GetString(base64Bytes);
                }
                else
                {
                    decodedString += DecodeQP(encodedText, charset);
                }
            }
            return decodedString;
        }

        public static String DecodeQP(String input, String encode)
        {
            input = input.Replace("=\n", "");
            Encoding enc;
            try
            {
                enc = Encoding.GetEncoding(encode);
            }
            catch
            {
                enc = Encoding.UTF8;
            }
            List<Byte> bytesList = new List<Byte>();
            for (Int32 i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 2 && Regex.IsMatch(
                    input.Substring(i, 3), 
                    "=[A-F0-9]{2}"))
                {
                    Byte hexByte = Convert.ToByte(input.Substring(i + 1, 2), 16);
                    bytesList.Add(hexByte);
                    i += 2;
                }
                else
                {
                    bytesList.Add(Convert.ToByte(input[i]));
                }
            }
            return enc.GetString(bytesList.ToArray());
        }
        #endregion Decoders
    }
}
