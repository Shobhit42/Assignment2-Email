using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Email
{
    public class UserEmail
    {
        public string? Subject { get; set; }
        public string? Body { get; set; }

        public List<string> Recipients;

        public UserEmail()
        {
            Subject = "";
            Body = "";
            Recipients = new List<string>();
        }

        public void AddRecipient(UserEmail userEmail)
        {
            string? selectedOption = "1";
            while (selectedOption == "1" || selectedOption == "Invalid")
            {
                bool exception = false;
                if (selectedOption == "1")
                {
                    string? recipient = "";
                    Console.Write("Add Recipient : ");
                    try
                    {
                        recipient = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(recipient))
                        {
                            throw new ArgumentNullException("Recipient can't be Empty");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        exception = true;
                        continue;
                    }
                    userEmail.Recipients.Add(recipient);
                    Console.WriteLine();
                }

                if (exception == true) continue;

                UserConsole.PrintOptions();

                selectedOption = Console.ReadLine();
                if (selectedOption == "3")
                {
                    Environment.Exit(0);
                }
                else if (selectedOption == "2") break;
                else if (selectedOption != "1" && selectedOption != "2")
                {
                    Console.WriteLine("Invalid Option selected, ");
                    selectedOption = "Invalid";
                }
            }
        }
    }
}
