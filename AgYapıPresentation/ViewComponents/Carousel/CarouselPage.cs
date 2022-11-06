using AgYapıPresentation.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgYapıPresentation.ViewComponents.Carousel
{
    public class CarouselPage : ViewComponent
    {
        Context c = new();
        private readonly ICarouselService _carouselService;

        public CarouselPage(ICarouselService carouselService)
        {
            _carouselService = carouselService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carouselService.GetList();

            return View(values);
        }
    }
}
