using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Email
{
    public class UserConsole
    {
        public static void PrintOptions()
        {
            Console.WriteLine("Select from following options");
            Console.WriteLine("[1]. Add another recipient");
            Console.WriteLine("[2]. Continue");
            Console.WriteLine("[3]. Exit \n");
        }

        public static UserEmail GetUserInputs(string senderEmail)
        {
            UserEmail userEmail = new UserEmail();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Email Sending Service");
            PrintBoilerPlate("From : " + senderEmail);

            userEmail.AddRecipient(userEmail);

            Console.Write("Add Subject : ");
            userEmail.Subject = Console.ReadLine();
            Console.WriteLine("Add Body : ");
            string? body = Console.ReadLine();
            userEmail.Body = "<html><body> " + body + "</body></html>";

            return userEmail;
        }

        public static void PrintBoilerPlate(string message)
        {
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
