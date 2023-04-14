using Colab.config;
using MailKit.Net.Smtp;
using Colab.Models;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Colab.Services;

public class EmailService : IEmailService
{
    private readonly MailSettings _mailSettings;
    public EmailService(IOptions<MailSettings> mailSettingsOptions)
    {
        _mailSettings = mailSettingsOptions.Value;
    }

    public bool SendEmail(MailData mailData)
    {
        try
        {
            using (MimeMessage emailMessage = new MimeMessage())
            {
                MailboxAddress emailFrom = new MailboxAddress(_mailSettings.FromName, _mailSettings.From);
                emailMessage.From.Add(emailFrom);
                MailboxAddress emailTo = new MailboxAddress("", mailData.To);
                emailMessage.To.Add(emailTo);

                emailMessage.Subject = mailData.Subject;

                BodyBuilder emailBodyBuilder = new BodyBuilder();
                emailBodyBuilder.TextBody = mailData.Body;

                emailMessage.Body = emailBodyBuilder.ToMessageBody();

                using (SmtpClient mailClient = new SmtpClient())
                {
                    mailClient.Connect(_mailSettings.Host, _mailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                    mailClient.Authenticate(_mailSettings.UserName, _mailSettings.Password);
                    mailClient.Send(emailMessage);
                    mailClient.Disconnect(true);
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            // Exception Details
            return false;
        }
    }
}