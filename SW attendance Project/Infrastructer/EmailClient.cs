using SW_attendance_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SW_attendance_Project.Infrastructer
{
    public class EmailClient : IEmailClient
    {

        private SmtpClient _client;
        public EmailClient()
        {
            _client = new SmtpClient("localhost", 25);
        }
        public Task Send(string to, string subject, string body)
        {
            MailMessage msg = new MailMessage("info@attendance.just.edu.jo", to, subject, body);
            return _client.SendMailAsync(msg);
        }
    }
}
