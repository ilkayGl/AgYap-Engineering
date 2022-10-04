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

        public ContactController(IContactService contactService, IContactLocationService contactLocationService)
        {
            _contactService = contactService;
            _contactLocationService = contactLocationService;
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
            return RedirectToAction("Index","Contact");
        }
    }
}
