using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgYapıPresentation.Controllers
{
    [AllowAnonymous]
    public class ServiceDetails : Controller
    {
        private readonly IMyProjectService _myProjectService;

        public ServiceDetails(IMyProjectService myProjectService)
        {
            _myProjectService = myProjectService;
        }

        public IActionResult Index(int id)
        {
            var values = _myProjectService.GetByID(id);
            return View(values);
        }
    }
}
