using FeatureFolderWebApplication.Features.FeatureFolders;
using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderWebApplication.Features.Homepage
{
    [Feature("Homepage")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
