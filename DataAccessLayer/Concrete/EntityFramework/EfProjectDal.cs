using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfProjectDal : GenericRepository<Project>, IProjectDal
    {
        public List<Project> GetProjectListWithProjectCategoryDal()
        {
            using var c = new Context();

            return c.Projects.Include(x => x.ProjectCategory).ToList();
        }
    }
}
