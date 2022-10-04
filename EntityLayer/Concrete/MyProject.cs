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
        public string ProjectTitle2 { get; set; }
        public string ProjectKategori { get; set; }
        public string ProjectImage { get; set; }
        public string ProjectDetails { get; set; }
        public bool ProjectStatus { get; set; }


    }
}
