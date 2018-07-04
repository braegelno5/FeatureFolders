using FeatureFolderWebApplication.Features.ConfirmEmail;

namespace Microsoft.AspNetCore.Mvc
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(ConfirmEmailController.ConfirmEmail),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
