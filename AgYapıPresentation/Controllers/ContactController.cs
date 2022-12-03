using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgYapıPresentation.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IContactLocationService _contactLocationService;
        private readonly INotyfService _notyf;

        public ContactController(IContactService contactService, IContactLocationService contactLocationService, INotyfService notyf)
        {
            _contactService = contactService;
            _contactLocationService = contactLocationService;
            _notyf = notyf;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactLocationService.GetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactStatus = true;
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToString());
            _contactService.TAddBL(contact);
            _notyf.Success("Mesajınız Başarıyla İletildi.");
            return RedirectToAction("Index","Contact");
        }
    }
}
