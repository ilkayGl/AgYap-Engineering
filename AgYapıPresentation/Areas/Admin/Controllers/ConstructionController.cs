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
    public class ConstructionController : Controller
    {
        Context c = new();

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IMyProjectService _myProjectService;

        public ConstructionController(IWebHostEnvironment hostEnvironment, IMyProjectService myProjectService)
        {
            _hostEnvironment = hostEnvironment;
            _myProjectService = myProjectService;
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


            var values = _myProjectService.GetList();
            return View(values);
        }



        [HttpGet]
        public IActionResult ConstructionAdd()
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
        public IActionResult ConstructionAdd(MyProject u, CanstructionImagesDTO p)
        {

            var dosyaYolu = Path.Combine(_hostEnvironment.WebRootPath, "CanstructionImages"); //birleştir
            if (!Directory.Exists(dosyaYolu)) //yoksa
            {
                Directory.CreateDirectory(dosyaYolu); //oluştur
            }
            var tamDosyaAdi = Path.Combine(dosyaYolu, p.ProjectImage.FileName); //wwwroote içine  dosya yolu tanımlıyor
                                                                                //file upload
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                p.ProjectImage.CopyTo(dosyaAkisi);
            }//using ekleme amacımız Gc beklemeden kaynağı yok etmesidir.

            u.ProjectImage = p.ProjectImage.FileName;


            u.ProjectId = p.ProjectId;
            u.ProjectTitle = p.ProjectTitle;
            u.ProjectDetails = p.ProjectDetails;
            u.ProjectStatus = true;

            _myProjectService.TAddBL(u);

            //_notyf.Success("Başarıyla Güncellendi.");

            return RedirectToAction("Index", "Construction");

        }

        [HttpPost]
        public IActionResult ConstructionEdit(MyProject u, CanstructionImagesDTO p)
        {

            var dosyaYolu = Path.Combine(_hostEnvironment.WebRootPath, "CanstructionImages"); //birleştir
            if (!Directory.Exists(dosyaYolu)) //yoksa
            {
                Directory.CreateDirectory(dosyaYolu); //oluştur
            }
            var tamDosyaAdi = Path.Combine(dosyaYolu, p.ProjectImage.FileName); //wwwroote içine  dosya yolu tanımlıyor
                                                                                //file upload
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                p.ProjectImage.CopyTo(dosyaAkisi);
            }//using ekleme amacımız Gc beklemeden kaynağı yok etmesidir.

            u.ProjectImage = p.ProjectImage.FileName;


            u.ProjectId = p.ProjectId;
            u.ProjectTitle = p.ProjectTitle;
            u.ProjectDetails = p.ProjectDetails;
            u.ProjectStatus = true;

            _myProjectService.TUpdateBL(u);

            //_notyf.Success("Başarıyla Güncellendi.");

            return RedirectToAction("Index", "Construction");

        }



        public IActionResult ConstructionRemove(int id)
        {

            var aboutRemove = _myProjectService.GetByID(id);
            _myProjectService.TDeleteBL(aboutRemove);

            return RedirectToAction("Index", "Construction");
        }


        //Hizmet servis detayları
        [HttpGet]
        public IActionResult ConstructionAdd2()
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


            var values = _myProjectService.GetList();

            return View(values);
        }


        [HttpPost]
        public IActionResult ConstructionAdd2(MyProject u, CanstructionImagesDTO p)
        {

            var dosyaYolu = Path.Combine(_hostEnvironment.WebRootPath, "CanstructionImages"); //birleştir
            if (!Directory.Exists(dosyaYolu)) //yoksa
            {
                Directory.CreateDirectory(dosyaYolu); //oluştur
            }
            var tamDosyaAdi = Path.Combine(dosyaYolu, p.ProjectImage.FileName); //wwwroote içine  dosya yolu tanımlıyor
                                                                                //file upload
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                p.ProjectImage.CopyTo(dosyaAkisi);
            }//using ekleme amacımız Gc beklemeden kaynağı yok etmesidir.

            u.ProjectImage = p.ProjectImage.FileName;


            u.ProjectId = p.ProjectId;
            u.ProjectTitle = p.ProjectTitle;
            u.ProjectDetails = p.ProjectDetails;
            u.ProjectStatus = true;

            _myProjectService.TAddBL(u);

            //_notyf.Success("Başarıyla Güncellendi.");

            return RedirectToAction("Index", "Construction");

        }
    }
}
