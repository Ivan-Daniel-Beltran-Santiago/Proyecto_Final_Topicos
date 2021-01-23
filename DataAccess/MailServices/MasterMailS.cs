using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DataAccess.MailServices
{
    public abstract class MasterMailS
    {
        private SmtpClient smtpClient;

        protected string senderMail { get; set; }
        protected string passw { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeStmlClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, passw);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMsg = new MailMessage();
            try
            {
                mailMsg.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMsg.To.Add(mail);
                }

                mailMsg.Subject = subject;
                mailMsg.Body = body;
                mailMsg.Priority = MailPriority.Normal;

                smtpClient.Send(mailMsg);
            } 
            catch(Exception ex)
            {

            }
            finally
            {
                mailMsg.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
