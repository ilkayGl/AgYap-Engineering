using AgYapıPresentation.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Linq;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {

        Context c = new();

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IAboutService _aboutService;

        public AboutController(IWebHostEnvironment hostEnvironment, IAboutService aboutService)
        {
            _hostEnvironment = hostEnvironment;
            _aboutService = aboutService;
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


            var values = _aboutService.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AboutImageEdit()
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

        [HttpPost]
        public IActionResult AboutImageEdit(About u, AboutImageDTO p)
        {

            var dosyaYolu = Path.Combine(_hostEnvironment.WebRootPath, "AboutImage"); //birleştir
            if (!Directory.Exists(dosyaYolu)) //yoksa
            {
                Directory.CreateDirectory(dosyaYolu); //oluştur
            }
            var tamDosyaAdi = Path.Combine(dosyaYolu, p.AboutImage1.FileName); //wwwroote içine  dosya yolu tanımlıyor
                                                                               //file upload
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                p.AboutImage1.CopyTo(dosyaAkisi);
            }//using ekleme amacımız Gc beklemeden kaynağı yok etmesidir.

            u.AboutImage1 = p.AboutImage1.FileName;


            u.AboutId = p.AboutId;
            u.AboutTitle = p.AboutTitle;
            u.AboutDetails = p.AboutDetails;
            u.AboutTitle2 = p.AboutTitle2;
            u.AboutStatus = true;

            _aboutService.TUpdateBL(u);

            //_notyf.Success("Başarıyla Güncellendi.");

            return RedirectToAction("Index", "About");

        }


       
        public IActionResult AboutRemove(int id)
        {

            var aboutRemove = _aboutService.GetByID(id);
            _aboutService.TDeleteBL(aboutRemove);

            return RedirectToAction("Index", "About");
        }
    }
}
