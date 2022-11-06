using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Carousel2
    {
        [Key]
        public int Carousel2ID { get; set; }

        public string BackImages { get; set; }

        public bool Status { get; set; }
    }
}
