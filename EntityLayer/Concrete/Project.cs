using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectImages { get; set; }
        public string ProjectDetails { get; set; }
        public bool Status { get; set; }

        public int ProjectCategoryID { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }

    }
}
