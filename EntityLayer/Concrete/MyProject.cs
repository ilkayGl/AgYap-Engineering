using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MyProject
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectImage { get; set; }
        public string ProjectDetails { get; set; }
        public string ProjectImage2 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public string Detail4 { get; set; }
        public bool ProjectStatus { get; set; }


    }
}
