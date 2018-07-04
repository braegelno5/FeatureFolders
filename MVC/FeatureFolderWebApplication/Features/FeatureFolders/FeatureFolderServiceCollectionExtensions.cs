using FeatureFolderWebApplication.Features.FeatureFolders;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FeatureFolderServiceCollectionExtensions
    {
        public static IServiceCollection AddFeatureFolders(this IServiceCollection services)
        {
            services.PostConfigure<RazorViewEngineOptions>(
                options => options.ViewLocationExpanders.Add(new FeatureViewLocationExpander())
            );
            return services;
        }
    }
}
