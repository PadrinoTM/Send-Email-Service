using EmailSenders.Entity;
using System.Threading.Tasks;

namespace EmailSenders.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
