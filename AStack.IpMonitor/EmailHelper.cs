using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AStack.IpMonitor
{
    public class EmailHelper
    {
        private string _emailUserName;
        private string _emailPassword;
        private string _smtpClientHost;
        private string _mailTo;

        public EmailHelper(ILogger<EmailHelper> logger, IConfiguration configuration)
        {
            _emailUserName = configuration["EmailUserName"];
            _emailPassword = configuration["EmailPassword"];
            _smtpClientHost = configuration["SmtpClientHost"];
            _mailTo = configuration["MailTo"];
        }

        public void SendIpEmail(string ip)
        {
            SendEmail(ip);
        }

        private void SendEmail(string ip)
        {
            var mailMessage = new MailMessage();
            mailMessage.Subject = "公网IP";
            mailMessage.From = new MailAddress(_emailUserName);
            mailMessage.To.Add(new MailAddress(_mailTo));
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = Encoding.Default;
            mailMessage.Body = ip;

            var smtpClient = new SmtpClient();
            smtpClient.Host = _smtpClientHost;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(_emailUserName, _emailPassword);
            smtpClient.Send(mailMessage);
        }
    }
}
