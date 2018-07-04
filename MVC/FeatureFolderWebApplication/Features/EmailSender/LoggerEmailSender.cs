using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FeatureFolderWebApplication.Features.EmailSender
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class LoggerEmailSender : IEmailSender
    {
        private readonly ILogger<LoggerEmailSender> _logger;

        public LoggerEmailSender(ILogger<LoggerEmailSender> logger)
        {
            _logger = logger;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            _logger.LogInformation("Sending Email to {email}. Subject {subject}. Message {message}", email, subject, message);
            return Task.CompletedTask;
        }
    }
}
