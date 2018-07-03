using System.ComponentModel.DataAnnotations;

namespace FeatureFolderWebApplication.Features.ResetPassword
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
