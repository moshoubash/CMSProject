using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace CMSProject.Code
{
    public class EmailSender : IEmailSender
    {
        Task IEmailSender.SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com") {
                Port = 587,
                Credentials = new NetworkCredential("claya414@gmail.com", "idxihgzturnknnvk"),
                EnableSsl = true
            };

            return smtpClient.SendMailAsync("claya414@gmail.com", email, subject, htmlMessage);
        }
    }
}
