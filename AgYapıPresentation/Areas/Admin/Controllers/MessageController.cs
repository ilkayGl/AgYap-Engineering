using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        Context c = new Context();
        private readonly IContactService _cts;

        public MessageController(IContactService cts)
        {
            _cts = cts;
        }

        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.writerID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.writerImage = userImage;


            return View();
        }

        public IActionResult ContactMessage()
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.writerID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.writerImage = userImage;



            var value = _cts.GetList().OrderByDescending(x => x.ContactDate).ToList();
            return View(value);
        }

        public IActionResult MessageDetails(int id)
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.writerID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.writerImage = userImage;



            var values = _cts.GetByID(id);
            return View(values);
        }
    }
}
