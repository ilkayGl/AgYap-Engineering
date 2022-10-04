using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgYapıPresentation.ViewComponents.Project
{
    public class ProjectList : ViewComponent
    {
        private readonly IMyProjectService _myps;

        public ProjectList(IMyProjectService myps)
        {
            _myps = myps;
        }

        public IViewComponentResult Invoke()
        {
            var values = _myps.GetList();
            return View(values);
        }
    }
}
