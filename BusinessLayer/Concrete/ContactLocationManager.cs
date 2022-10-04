
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
    public class ContactLocationManager : IContactLocationService
    {
        private readonly IContactLocationDal _contactLocationDal;

        public ContactLocationManager(IContactLocationDal contactLocationDal)
        {
            _contactLocationDal = contactLocationDal;
        }

        public ContactLocation GetByID(int id)
        {
            return _contactLocationDal.Get(x => x.ContactLocationId == id);
        }

        public List<ContactLocation> GetList()
        {
            return _contactLocationDal.List();
        }

        public void TAddBL(ContactLocation t)
        {
            _contactLocationDal.Insert(t);
        }

        public void TDeleteBL(ContactLocation t)
        {
            _contactLocationDal.Delete(t);
        }

        public void TUpdateBL(ContactLocation t)
        {
            _contactLocationDal.Update(t);
        }
    }
}
