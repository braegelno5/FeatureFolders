using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderWebApplication.Features.ResetPassword
{
    public static class ResetPasswordExtensions
    {
        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(ResetPasswordController.ResetPassword),
                controller: "ResetPassword",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
