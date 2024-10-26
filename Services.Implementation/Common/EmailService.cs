using Microsoft.Extensions.Hosting;
using MimeKit;
using Services.Common;

namespace Services.Implementation.Common
{
    public class EmailService : IEmailService
    {
        private readonly IHostEnvironment _env;

        public EmailService(IHostEnvironment env)
        {
            _env = env;
        }

        public async Task Send(string from, string to, string subject)
        {
            // Path to the email template

            string path = Path.Combine(_env.ContentRootPath, "wwwroot", "assets", "Templates", "EmailTemplate.html");

            // Read the template file
            string emailTemplate;
            using (StreamReader sourceReader = new StreamReader(path))
            {
                emailTemplate = await sourceReader.ReadToEndAsync();
            }

            // Create MimeMessage
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sender Name", "malikov.mm7@mail.ru"));
            message.To.Add(new MailboxAddress("Recipient Name", to));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = emailTemplate
            };
            message.Body = bodyBuilder.ToMessageBody();

            // Configure SMTP client and send email
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 465, MailKit.Security.SecureSocketOptions.SslOnConnect);
                await client.AuthenticateAsync("malikov.mm7@mail.ru", "UPnpkVSigtijeA7kdxhR");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
