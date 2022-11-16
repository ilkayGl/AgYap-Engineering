using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProjectCategory
    {
        public int ProjectCategoryID { get; set; }
        public string ProjectCategoryName { get; set; }
        public bool Status { get; set; }

        public List<Project> Projects { get; set; }
    }
}
