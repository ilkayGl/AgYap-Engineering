using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly Context c = new Context();


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserAdmin admin)
        {
            var userMail = User.Identity.Name;
            var userAdminID = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserId).FirstOrDefault();
            ViewBag.writerID = userAdminID;

            var userName = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.userName = userName;

            var userImage = c.UserAdmins.Where(x => x.UserMail == userMail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.writerImage = userImage;



            var datavalue = c.UserAdmins.FirstOrDefault(x => x.UserMail == admin.UserMail && x.UserPassword == admin.UserPassword);

            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.UserMail),

                };

                var useridentity = new ClaimsIdentity(claims, "Admin");


                ClaimsPrincipal principal = new ClaimsPrincipal(new[] { useridentity });

                await HttpContext.SignInAsync(principal);


                return RedirectToAction("Index", "Message");


            }
            else
            {
                return View();
            }

        }
    }
}
