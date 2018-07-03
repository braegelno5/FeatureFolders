using FeatureFolderWebApplication.Features.FeatureFolders;
using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderWebApplication.Features.Aboutpage
{
    [Feature("Aboutpage")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
    }
}
