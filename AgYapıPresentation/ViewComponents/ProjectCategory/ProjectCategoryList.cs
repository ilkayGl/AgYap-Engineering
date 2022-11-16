using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgYapıPresentation.ViewComponents.ProjectCategory
{
    public class ProjectCategoryList : ViewComponent
    {
        private readonly IProjectCategoryService _projectCategoryService;

        public ProjectCategoryList(IProjectCategoryService projectCategoryService)
        {
            _projectCategoryService = projectCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _projectCategoryService.GetList();
            return View(values);
        }
    }
}
