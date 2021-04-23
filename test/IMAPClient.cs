using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace AppooProjectClasses
{
    public class IMAPClient : IDisposable
    {
        private TcpClient client;
        private SslStream sslStream;
        private StreamReader reader;
        private StreamWriter writer;
        public String Host { get; set; }
        public Int32 Port { get; set; }
        public Int32 MailsCount { get; set; }

        public MyMail GetMail(Int32 index)
        {
            MyMail mail = new MyMail();
            mail.hasAttachments = false;
            String command = ". fetch " + (index + 1) + " (body[header.fields (to from subject)])";
            Command(command);
            String temp;
            StringBuilder stringBuilder = new StringBuilder();
            while (!(temp = reader.ReadLine()).StartsWith(". "))
            {
                stringBuilder.Append(temp + "\n");
            }
            String response = stringBuilder.ToString();
            response = response.Replace("\n)", "");
            mail.Subject = Tools.GetSubject(response);
            mail.From = Tools.GetSender(response);
            mail.To = Tools.GetDestination(response);
            command = String.Format(". fetch {0} (body[header.fields (Content-Type Content-Transfer-Encoding)])", index + 1);
            Command(command);
            stringBuilder.Clear();
            temp = reader.ReadLine();
            while (!(temp = reader.ReadLine()).StartsWith(". OK"))
            {
                if (temp != "" && temp != ")")
                {
                    stringBuilder.Append(temp + "\n");
                }
            }
            response = stringBuilder.ToString();

            String contentType = Tools.GetContentType(response);
            if (contentType.Contains("multipart"))
            {
                if (contentType.Contains("mixed"))
                {
                    command = String.Format(". fetch {0} (body[1.2.mime])", index + 1);
                    mail.hasAttachments = true;
                }
                else
                {
                    command = String.Format(". fetch {0} (body[2.mime])", index + 1);
                }
                Command(command);
                stringBuilder.Clear();
                temp = reader.ReadLine();
                while (!(temp = reader.ReadLine()).StartsWith(". OK"))
                {
                    if (temp != "" && temp != ")")
                    {
                        stringBuilder.Append(temp + "\n");
                    }
                }
                response = stringBuilder.ToString();
                if (contentType.Contains("mixed"))
                {
                    command = String.Format(". fetch {0} (body[1.2])", index + 1);
                }
                else
                {
                    command = String.Format(". fetch {0} (body[2])", index + 1);
                }

            }
            else
            {
                command = String.Format(". fetch {0} (body[text])", index + 1);
            }
            Command(command);
            stringBuilder.Clear();
            temp = reader.ReadLine();
            while (!(temp = reader.ReadLine()).StartsWith(". OK"))
            {
                if (temp != "" && temp != ")")
                {
                    stringBuilder.Append(temp + "\n");
                }
            }
            String mailBody = stringBuilder.ToString().Trim();
            if (!String.IsNullOrEmpty(mailBody) && mailBody[mailBody.Length - 1] == ')')
            {
                mailBody = mailBody.Substring(0, mailBody.Length - 1);
            }
            //Get charset
            Regex charsetRegex = new Regex("charset=\"?(?<charset>[^\\s\";]+)\"?;?\n?");
            Match charsetMatch = charsetRegex.Match(response);
            String charset = charsetMatch.Groups["charset"].Value;
            //Get encoding
            Regex encodingRegex = new Regex(
                "Content-Transfer-Encoding: \"?(?<encoding>.*)\"?\n",
                RegexOptions.IgnoreCase);
            Match encodingMatch = encodingRegex.Match(response);
            String encodeing = encodingMatch.Groups["encoding"].Value;
            switch (encodeing)
            {
                case "base64":
                    {
                        Byte[] base64Bytes = Convert.FromBase64String(mailBody);
                        if (String.IsNullOrEmpty(charset))
                        {
                            charset = "UTF-8";
                        }
                        mail.Body = Encoding.GetEncoding(charset).GetString(base64Bytes);
                        break;
                    }
                case "quoted-printable":
                    {
                        mail.Body = Tools.DecodeQP(mailBody, charset);
                        break;
                    }
                default:
                    {
                        mail.Body = mailBody;
                        break;
                    }
            }
            return mail;
        }

        public void DeleteMail(Int32 index)
        {
            String response;
            //Delete mail
            String command = String.Format(". fetch {0} uid",index + 1);
            Command(command);
            response = reader.ReadLine();
            Regex uidRegex = new Regex("\\(UID\\s(?<uid>\\d+)\\)");
            Match uidMatch = uidRegex.Match(response);
            String uid = uidMatch.Groups["uid"].Value;
            reader.ReadLine();
            command = String.Format(". uid store {0} +flags (\\Deleted)", uid);
            Command(command);
            reader.ReadLine();
            reader.ReadLine();
            Command(". expunge");
            while (!(response = reader.ReadLine()).StartsWith(". ")) ;
        }

        private void Command(String command)
        {
            writer.WriteLine(command);
            writer.Flush();
        }

        public void Connect(String email, String password)
        {
            try
            {
                client = new TcpClient();
                client.Connect(Host, Port);
                sslStream = new SslStream(client.GetStream());
                sslStream.AuthenticateAsClient(Host);
                reader = new StreamReader(sslStream);
                writer = new StreamWriter(sslStream);
                StringBuilder stringBuilder = new StringBuilder();
                String temp;
                while (!(temp = reader.ReadLine()).StartsWith("* OK"))
                {
                    stringBuilder.Append(temp + "\n");
                }
                stringBuilder.Append(temp);
                Command(". login " + email + " " + password);
                stringBuilder.Clear();
                while ((temp = reader.ReadLine()).StartsWith("*"))
                {
                    stringBuilder.Append(temp + "\n");
                }
                if (!temp.Contains(". OK"))
                {
                    throw new Exception("Email sau Parola incorecta");
                }
            }
            catch
            {
                CloseConnection();
                throw;
            }
        }

        public List<Folder> GetFolders()
        {
            List<Folder> folders = new List<Folder>();
            Command(". list \"\" \"*\"");
            StringBuilder stringBuilder = new StringBuilder();
            String temp;
            while ((temp = reader.ReadLine()).StartsWith("*"))
            {
                if (!temp.Contains("Noselect"))
                {
                    String[] strarr = temp.Split('"');
                    folders.Add(new Folder(strarr[3]));
                }
            }
            return folders;
        }

        public void SelectFolder(String Folder)
        {
            Command(". select \"" + Folder + "\"");
            StringBuilder stringBuilder = new StringBuilder();
            String temp;
            MailsCount = -1;
            while ((temp = reader.ReadLine()).StartsWith("*"))
            {
                if (temp.Contains("EXISTS"))
                {
                    String[] strarr = temp.Trim().Split(' ');
                    MailsCount = Convert.ToInt32(strarr[1]);
                }
            }
        }

        public void CloseConnection()
        {
            //Close connection
            if (client == null || !client.Connected) return;
            Command("logout");
            reader.ReadLine();
            reader.Close();
            writer.Close();
            sslStream.Close();
            client.Close();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                CloseConnection();
            }
        }
    }
}
