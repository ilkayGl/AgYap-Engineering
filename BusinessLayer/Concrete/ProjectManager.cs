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
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public Project GetByID(int id)
        {
            return _projectDal.Get(x => x.ProjectID == id);
        }

        public List<Project> GetList()
        {
            return _projectDal.List();
        }

        public List<Project> GetProjectListWithProjectCategory()
        {
            return _projectDal.GetProjectListWithProjectCategoryDal();
        }

        public void TAddBL(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDeleteBL(Project t)
        {
            _projectDal.Delete(t);
        }

        public void TUpdateBL(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
