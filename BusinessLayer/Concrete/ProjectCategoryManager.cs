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
    public class ProjectCategoryManager : IProjectCategoryService
    {
        private readonly IProjectCategoryDal _projectCategoryDal;

        public ProjectCategoryManager(IProjectCategoryDal projectCategoryDal)
        {
            _projectCategoryDal = projectCategoryDal;
        }

        public ProjectCategory GetByID(int id)
        {
            return _projectCategoryDal.Get(x => x.ProjectCategoryID == id);
        }

        public List<ProjectCategory> GetList()
        {
            return _projectCategoryDal.List();
        }

        public void TAddBL(ProjectCategory t)
        {
            _projectCategoryDal.Insert(t);
        }

        public void TDeleteBL(ProjectCategory t)
        {
            _projectCategoryDal.Delete(t);
        }

        public void TUpdateBL(ProjectCategory t)
        {
            _projectCategoryDal.Update(t);
        }
    }
}
