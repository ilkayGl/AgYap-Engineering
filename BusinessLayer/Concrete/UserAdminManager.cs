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
    public class UserAdminManager : IUserAdminService
    {
        private readonly IUserAdminDal _userAdminDal;

        public UserAdminManager(IUserAdminDal userAdminDal)
        {
            _userAdminDal = userAdminDal;
        }

        public UserAdmin GetByID(int id)
        {
            return _userAdminDal.Get(x => x.UserId == id);
        }

        public List<UserAdmin> GetList()
        {
            return _userAdminDal.List();
        }

        public void TAddBL(UserAdmin t)
        {
            _userAdminDal.Insert(t);
        }

        public void TDeleteBL(UserAdmin t)
        {
            _userAdminDal.Delete(t);
        }

        public void TUpdateBL(UserAdmin t)
        {
            _userAdminDal.Update(t);
        }
    }
}
