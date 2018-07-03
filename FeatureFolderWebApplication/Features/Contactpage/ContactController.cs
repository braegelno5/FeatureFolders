using FeatureFolderWebApplication.Features.FeatureFolders;
using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderWebApplication.Features.Contactpage
{
    [Feature("Contactpage")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}
