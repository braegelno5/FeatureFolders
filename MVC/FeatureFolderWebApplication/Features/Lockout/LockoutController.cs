using FeatureFolderWebApplication.Features.FeatureFolders;
using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderWebApplication.Features.Lockout
{
    [Feature("Lockout")]
    [Route("Account/Lockout")]
    public class LockoutController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
    }
}
