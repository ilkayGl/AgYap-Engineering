using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactLocationController : Controller
    {
        Context c = new();

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IContactLocationService _contactLocationService;

        public ContactLocationController(IWebHostEnvironment hostEnvironment, IContactLocationService contactLocationService)
        {
            _hostEnvironment = hostEnvironment;
            _contactLocationService = contactLocationService;
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

            var values = _contactLocationService.GetList();
            return View(values);
        }


    }
}
