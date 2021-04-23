using System;
using System.IO;
using System.Net.Security;
using System.Text;

namespace AppooProjectClasses
{
    public class SMTPClient : System.Net.Sockets.TcpClient
    {
        private SslStream sslStream;
        private StreamWriter writer;
        private StreamReader reader;

        public String Email { get; set; }
        public String Password { get; set; }
        public String EmailTo { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
        public String Host { get; set; }
        public Int32 Port { get; set; }

        public SMTPClient()
        {

        }

        public void Connect()
        {
            Connect(Host, Port);
            sslStream = new SslStream(GetStream());
            sslStream.AuthenticateAsClient(Host);
            writer = new StreamWriter(sslStream);
            reader = new StreamReader(sslStream);
            String response = reader.ReadLine();
            if (response.Substring(0, 3) != "220")
            {
                throw new Exception(response);
            }
        }

        public void Send(String filePath)
        {
            String response;
            writer.WriteLine("helo");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "250")
            {
                throw new Exception(response);
            }

            writer.WriteLine("auth login");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "334")
            {
                throw new Exception(response);
            }

            String base64Email = Tools.ToBase64(Email);
            writer.WriteLine(base64Email);
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "334")
            {
                throw new Exception(response);
            }

            String base64Password = Tools.ToBase64(Password);
            writer.WriteLine(base64Password);
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "235")
            {
                throw new Exception(response);
            }

            writer.WriteLine("mail from:<" + Email + ">");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "250")
            {
                throw new Exception(response);
            }

            writer.WriteLine("rcpt to:<" + EmailTo + ">");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "250")
            {
                throw new Exception(response);
            }

            writer.WriteLine("data");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "354")
            {
                throw new Exception(response);
            }

            writer.WriteLine("from:" + Email);
            writer.WriteLine("to:" + EmailTo);
            writer.WriteLine("subject:" + Subject);
            if (!String.IsNullOrEmpty(filePath))
            {
                writer.WriteLine("Mime-Version: 1.0");
                writer.WriteLine("Content-Type: multipart/mixed; boundary=0001frontier");
                writer.WriteLine("--0001frontier");
                writer.WriteLine("Content-Type: text/plain");
                writer.WriteLine(Body);
                writer.WriteLine("--0001frontier");
                writer.WriteLine("Content-Type: application/octet-stream ");
                String[] fileNames = filePath.Split('\\');
                String filename = fileNames[fileNames.Length - 1];
                writer.WriteLine("Content-Disposition: attachment; filename=" + filename + "; ");
                writer.WriteLine("Content-Transfer-Encoding: base64");
                FileStream file = File.Open(filePath, FileMode.Open, FileAccess.Read);
                Byte[] data = new Byte[file.Length];
                file.Read(data, 0, (int)file.Length);
                String base64file = Convert.ToBase64String(data);
                writer.WriteLine(base64file);
                writer.WriteLine("--0001frontier");

            }
            else
            {
                writer.WriteLine(Body);
            }
            writer.WriteLine(".");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "250")
            {
                throw new Exception(response);
            }

            writer.WriteLine("quit");
            writer.Flush();
            response = reader.ReadLine();
            if (response.Substring(0, 3) != "221")
            {
                throw new Exception(response);
            }
        }
    }
}
