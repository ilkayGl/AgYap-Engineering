using AgYapıPresentation.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Linq;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserAdminController : Controller
    {
        Context c = new Context();
        private readonly IUserAdminService _userAdmin;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UserAdminController(IUserAdminService userAdmin, IWebHostEnvironment hostEnvironment)
        {
            _userAdmin = userAdmin;
            _hostEnvironment = hostEnvironment;
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


            var values = _userAdmin.GetByID(userAdminID);
            return View(values);
        }

        [HttpPost]
        public IActionResult UserAdminEditProfile(UserAdmin u, AddProfileImageDTO p)
        {

            var dosyaYolu = Path.Combine(_hostEnvironment.WebRootPath, "UserAdminImage"); //birleştir
            if (!Directory.Exists(dosyaYolu)) //yoksa
            {
                Directory.CreateDirectory(dosyaYolu); //oluştur
            }
            var tamDosyaAdi = Path.Combine(dosyaYolu, p.UserImages.FileName); //wwwroote içine  dosya yolu tanımlıyor
                                                                              //file upload
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                p.UserImages.CopyTo(dosyaAkisi);
            }//using ekleme amacımız Gc beklemeden kaynağı yok etmesidir.

            u.UserImage = p.UserImages.FileName;

            u.UserId = p.UserId;
            u.UserName = p.UserName;
            u.UserMail = p.UserMail;
            u.UserPassword = p.UserPassword;
            u.Status = true;

            _userAdmin.TUpdateBL(u);

            //_notyf.Success("Başarıyla Güncellendi.");

            return RedirectToAction("Index", "UserAdmin");

        }
    }
}
