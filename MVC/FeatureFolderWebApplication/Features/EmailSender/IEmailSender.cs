using System.Threading.Tasks;

namespace FeatureFolderWebApplication.Features.EmailSender
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
