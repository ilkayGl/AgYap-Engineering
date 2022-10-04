using Microsoft.AspNetCore.Mvc;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
