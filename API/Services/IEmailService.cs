using Colab.Models;

namespace Colab.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmail(MailData mailData);
    }
}