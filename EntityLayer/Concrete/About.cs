using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        public string AboutTitle { get; set; }

        public string AboutTitle2 { get; set; }

        public string AboutImage1 { get; set; }

        public string AboutDetails { get; set; }

        public bool AboutStatus { get; set; }
    }
}
