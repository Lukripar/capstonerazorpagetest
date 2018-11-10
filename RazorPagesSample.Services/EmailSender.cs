using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesSample.Services
{
    public class EmailSender : IEmailSender
    {
        public void SendEmails(string recipient, string title, string body)
        {
            Console.WriteLine($"I am going to now send an email to: {recipient} saying {body} with a title of {title}");
        }
    }
}
