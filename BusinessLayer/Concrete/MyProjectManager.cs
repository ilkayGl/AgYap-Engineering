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
    public class MyProjectManager : IMyProjectService
    {
        private readonly IMyProjectDal _myProjectDal;

        public MyProjectManager(IMyProjectDal myProjectDal)
        {
            _myProjectDal = myProjectDal;
        }

        public MyProject GetByID(int id)
        {
            return _myProjectDal.Get(x => x.ProjectId == id);
        }


        public List<MyProject> GetList()
        {
            return _myProjectDal.List();
        }

        public void TAddBL(MyProject t)
        {
            _myProjectDal.Insert(t);
        }

        public void TDeleteBL(MyProject t)
        {
            _myProjectDal.Delete(t);
        }

        public void TUpdateBL(MyProject t)
        {
            _myProjectDal.Update(t);
        }
    }
}
