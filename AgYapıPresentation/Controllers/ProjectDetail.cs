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
        private readonly IProjectService _projectService;

        public ProjectDetail(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index(int id)
        {
            var values = _projectService.GetProjectListWithProjectCategory().Where(x => x.ProjectID == id).ToList();
            return View(values);
        }
    }
}
