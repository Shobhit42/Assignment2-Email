using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Assignment2_Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string senderEmail = ConfigurationManager.GetSenderEmail();
                string senderDisplayName = ConfigurationManager.GetSenderDisplayName();
                string senderAppPassword = ConfigurationManager.GetSenderAppPassword();
                string gmailSmtpServer = ConfigurationManager.GetGmailSmtpServer();
                int smtpPort = ConfigurationManager.GetSmtpPort();

                UserEmail userEmail = UserConsole.GetUserInputs(senderEmail);
                EmailService emailService = new EmailService();

                MailMessage message = emailService.CreateEmailMessage(userEmail, senderEmail, senderDisplayName);
                SmtpClient smtpClient = emailService.CreateSmtpClient(gmailSmtpServer, senderEmail, smtpPort, senderAppPassword);
                UserConsole.PrintBoilerPlate("Sending...");
                smtpClient.Send(message);
                UserConsole.PrintBoilerPlate("Email is Successfully Sent !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
