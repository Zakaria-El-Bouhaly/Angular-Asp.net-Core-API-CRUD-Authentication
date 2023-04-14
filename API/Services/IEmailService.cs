using Colab.Models;

namespace Colab.Services
{
    public interface IEmailService
    {
        bool SendEmail(MailData mailData);
    }
}