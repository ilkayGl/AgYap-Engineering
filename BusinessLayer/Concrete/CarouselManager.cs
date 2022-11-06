using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarouselManager : ICarouselService
    {
        private readonly ICarouselDal _carouselDal;

        public CarouselManager(ICarouselDal carouselDal)
        {
            _carouselDal = carouselDal;
        }


        public Carousel GetByID(int id)
        {
            return _carouselDal.Get(x => x.CarouselID == id);
        }

        public List<Carousel> GetList()
        {
            return _carouselDal.List();
        }

        public void TAddBL(Carousel t)
        {
            _carouselDal.Insert(t);
        }

        public void TDeleteBL(Carousel t)
        {
            _carouselDal.Delete(t);
        }

        public void TUpdateBL(Carousel t)
        {
            _carouselDal.Update(t);
        }
    }
}
