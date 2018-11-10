using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesSample.Services
{
    public interface IEmailSender
    {
        void SendEmails(string recipient, string title, string body);
    }
}
