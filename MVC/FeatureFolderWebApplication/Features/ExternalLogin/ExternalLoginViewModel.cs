using System.ComponentModel.DataAnnotations;

namespace FeatureFolderWebApplication.Features.ExternalLogin
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
