using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarouselController : Controller
    {
        Context c = new();

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ICarouselService _carouselService;

        public CarouselController(IWebHostEnvironment hostEnvironment, ICarouselService carouselService)
        {
            _hostEnvironment = hostEnvironment;
            _carouselService = carouselService;
        }

        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.userID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserImage).FirstOrDefault();
            ViewBag.userImage = userImage;


            var values = _carouselService.GetList();
            return View(values);
        }
    }
}
