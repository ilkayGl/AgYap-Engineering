using AgYapıPresentation.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace AgYapıPresentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Carousel2Controller : Controller
    {
        Context c = new();

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ICarousel2Service _carousel2Service;

        public Carousel2Controller(IWebHostEnvironment hostEnvironment, ICarousel2Service carousel2Service)
        {
            _hostEnvironment = hostEnvironment;
            _carousel2Service = carousel2Service;
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

            var contactMessage = c.Contacts.Count().ToString();
            ViewBag.contactMessage = contactMessage;

            var values = _carousel2Service.GetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Carousel2Add()
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


            return View();
        }



        [HttpPost]
        public IActionResult Carousel2Add(Carousel2 u, Carousel2ImagesDTO p)
        {

            var dosyaYolu = Path.Combine(_hostEnvironment.WebRootPath, "Carousel2Images"); //birleştir
            if (!Directory.Exists(dosyaYolu)) //yoksa
            {
                Directory.CreateDirectory(dosyaYolu); //oluştur
            }
            var tamDosyaAdi = Path.Combine(dosyaYolu, p.BackImages.FileName); //wwwroote içine  dosya yolu tanımlıyor
                                                                              //file upload
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                p.BackImages.CopyTo(dosyaAkisi);
            }//using ekleme amacımız Gc beklemeden kaynağı yok etmesidir.

            u.BackImages = p.BackImages.FileName;


            u.Carousel2ID = p.Carousel2ID;
            u.Status = true;

            _carousel2Service.TAddBL(u);

            //_notyf.Success("Başarıyla Güncellendi.");

            return RedirectToAction("Index", "Carousel2");

        }



        public IActionResult Carousel2Remove(int id)
        {

            var aboutRemove = _carousel2Service.GetByID(id);
            _carousel2Service.TDeleteBL(aboutRemove);

            return RedirectToAction("Index", "Carousel2");
        }
    }
}
