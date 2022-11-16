using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgYapıPresentation.ViewComponents.Project
{
    public class ProjectList : ViewComponent
    {
        private readonly IProjectService _projectService;

        public ProjectList(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _projectService.GetProjectListWithProjectCategory();
            return View(values);
        }
    }
}
