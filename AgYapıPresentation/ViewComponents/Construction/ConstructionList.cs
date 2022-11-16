using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgYapıPresentation.ViewComponents.Construction
{
    public class ConstructionList : ViewComponent
    {
        private readonly IMyProjectService _myProjectService;

        public ConstructionList(IMyProjectService myProjectService)
        {
            _myProjectService = myProjectService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _myProjectService.GetList();
            return View(values);
        }
    }
}
