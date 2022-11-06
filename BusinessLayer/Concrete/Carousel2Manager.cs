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
    public class Carousel2Manager : ICarousel2Service
    {
        private readonly ICarousel2Dal _carousel2Dal;

        public Carousel2Manager(ICarousel2Dal carousel2Dal)
        {
            _carousel2Dal = carousel2Dal;
        }


        public Carousel2 GetByID(int id)
        {
            return _carousel2Dal.Get(x => x.Carousel2ID == id);
        }

        public List<Carousel2> GetList()
        {
            return _carousel2Dal.List();
        }

        public void TAddBL(Carousel2 t)
        {
            _carousel2Dal.Insert(t);
        }

        public void TDeleteBL(Carousel2 t)
        {
            _carousel2Dal.Delete(t);
        }

        public void TUpdateBL(Carousel2 t)
        {
            _carousel2Dal.Update(t);
        }
    }
}
