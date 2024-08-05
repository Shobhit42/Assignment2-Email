using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Email
{
    public class EmailService
    {
        public MailMessage CreateEmailMessage(UserEmail userEmail, string senderEmail, string senderDisplayName)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(senderEmail,"Shobhit Singh");
            message.Subject = userEmail.Subject;

            foreach (string recipientEmail in userEmail.Recipients)
            {
                message.To.Add(new MailAddress(recipientEmail));
            }
            message.Body = userEmail.Body;
            message.IsBodyHtml = true;

            return message;
        }

        public SmtpClient CreateSmtpClient(string gmailSmtpServer, string senderEmail, int smtpPort, string senderAppPassword)
        {
            var smtpClient = new SmtpClient(gmailSmtpServer);
            smtpClient.Port = smtpPort;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderAppPassword);
            smtpClient.EnableSsl = true;
            return smtpClient;
        }
    }
}
