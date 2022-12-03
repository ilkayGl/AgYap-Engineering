using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly INotyfService _notyf;

        public MessageController(IContactService cts, INotyfService notyf)
        {
            _cts = cts;
            _notyf = notyf;
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



            return View();
        }

        public IActionResult ContactMessage()
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.userID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserImage).FirstOrDefault();
            ViewBag.userImage = userImage;

            var contactMessage = c.Contacts.Count().ToString();
            ViewBag.contactMessage = contactMessage;


            var value = _cts.GetList().OrderByDescending(x => x.ContactDate).ToList();
            return View(value);
        }

        public IActionResult MessageDetails(int id)
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.userID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserImage).FirstOrDefault();
            ViewBag.userImage = userImage;

            var contactMessage = c.Contacts.Count().ToString();
            ViewBag.contactMessage = contactMessage;


            var values = _cts.GetByID(id);
            return View(values);
        }

        public IActionResult MessageRemove(int id)
        {
            var deleteValues = _cts.GetByID(id);
            _cts.TDeleteBL(deleteValues);
            _notyf.Success("Mesaj Başarıyla Silindi.");
            return RedirectToAction("ContactMessage", "Message");
        }
    }
}
