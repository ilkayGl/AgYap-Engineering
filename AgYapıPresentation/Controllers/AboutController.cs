using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgYapıPresentation.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private readonly IAboutService _about;

        public AboutController(IAboutService about)
        {
            _about = about;
        }

        public IActionResult Index()
        {
            var value = _about.GetList();

            return View(value);
        }
    }
}
