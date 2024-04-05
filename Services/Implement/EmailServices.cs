using Project_XemPhim.Helper.HelperEmail;
using Project_XemPhim.Services.Interface;
using System.Net;
using System.Net.Mail;

namespace Project_XemPhim.Services.Implement
{
    public class EmailServices : IEmailServices
    {
        private readonly EmailConfig emailconfig = new EmailConfig();
        //public EmailServices(EmailConfig _emailConfig)
        //{
        //    emailconfig = _emailConfig;
        //}
        public bool SendEmail(string to, string subject, string message)
        {
            try
            {
                MailMessage msg = new MailMessage(emailconfig.EmailSender,to,subject,message);
                SmtpClient client = new SmtpClient(emailconfig.SmtpServer,emailconfig.Port);
                client.EnableSsl = true;
                NetworkCredential credential = new NetworkCredential(emailconfig.EmailSender,emailconfig.PassWordSender);
                client.UseDefaultCredentials = false;
                client.Credentials = credential;
                client.Send(msg);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
