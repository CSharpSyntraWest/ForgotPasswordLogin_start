using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using MailKit.Net.Smtp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("hcobpo@gmail.com"));
            email.To.Add(MailboxAddress.Parse("hcoppieters@hotmail.com"));
            email.Subject = "Test Email Subject";
            email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

            // send email
            using var smtp = new SmtpClient();
            // gmail
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls); //465
            smtp.Authenticate("hcobpo@gmail.com", "*******");
            smtp.Send(email);
            smtp.Disconnect(true);

        }
    }
}
