using System.ComponentModel.DataAnnotations;

namespace FeatureFolderWebApplication.Features.LoginWith2fa
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
