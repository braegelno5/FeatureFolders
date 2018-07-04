using FeatureFolderWebApplication.Features.EmailSender;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EmailSenderServiceCollectionExtensions
    {
        public static IServiceCollection AddEmailSender(this IServiceCollection services)
        {
            services.AddTransient<IEmailSender, LoggerEmailSender>();

            return services;
        }
    }
}
