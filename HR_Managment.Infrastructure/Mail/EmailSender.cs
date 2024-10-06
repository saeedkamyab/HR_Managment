using System.Net;
using HR_Managment.Application.Contracts.Infrastructure;
using HR_Managment.Application.Models;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace HR_Managment.Infrastructure.Mail
{
    public class EmailSender:IEmailSender
    {
        private EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_emailSettings.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName,

            };
            var message = MailHelper.CreateSingleEmail(from,to,email.Subject,email.Body,email.Body);
            var re = await client.SendEmailAsync(message);
            return re.StatusCode==HttpStatusCode.OK || re.StatusCode==HttpStatusCode.Accepted;
        }
    }
}
