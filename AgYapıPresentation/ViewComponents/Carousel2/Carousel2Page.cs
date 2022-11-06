using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgYapıPresentation.ViewComponents.Carousel2
{
    public class Carousel2Page : ViewComponent
    {
        private readonly ICarousel2Service _carousel2Service;

        public Carousel2Page(ICarousel2Service carousel2Service)
        {
            _carousel2Service = carousel2Service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carousel2Service.GetList();

            return View(values);
        }
    }
}
