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
    public class ProjectDetail : Controller
    {
        IMyProjectService _myProjectService;

        public ProjectDetail(IMyProjectService myProjectService)
        {
            _myProjectService = myProjectService;
        }

        public IActionResult Index(int id)
        {
            var values = _myProjectService.GetList().Where(x=>x.ProjectId==id).ToList();
            return View(values);
        }
    }
}
