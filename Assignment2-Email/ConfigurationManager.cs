using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Email
{
    public static class ConfigurationManager
    {
        public static string GetSenderEmail()
        {
            return System.Configuration.ConfigurationManager.AppSettings["SenderEmail"]
                ?? throw new ArgumentException("Sender Email not found!!");
        }

        public static string GetSenderDisplayName()
        {
            return System.Configuration.ConfigurationManager.AppSettings["SenderDisplayName"]
                ?? throw new ArgumentNullException("SenderDisplayName", "SenderDisplayName not found!!");
        }

        public static string GetSenderAppPassword()
        {
            return System.Configuration.ConfigurationManager.AppSettings["SenderAppPassword"]
                ?? throw new ArgumentNullException("SenderAppPassword not found!!");
        }

        public static string GetGmailSmtpServer()
        {
            return System.Configuration.ConfigurationManager.AppSettings["GmailSmtpServer"]
                ?? throw new ArgumentNullException("GmailSmtpServer", "GmailSmtpServer not found!!");
        }

        public static int GetSmtpPort()
        {
            if (!int.TryParse(System.Configuration.ConfigurationManager.AppSettings["SmtpPort"], out int smtpPort))
            {
                throw new ArgumentNullException("SmtpPort is invalid or not found");
            }
            return smtpPort;
        }

        
    }

}
