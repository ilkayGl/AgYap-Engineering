using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Carousel
    {
        [Key]
        public int CarouselID { get; set; }

        public string Title { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public string ButtonTitle { get; set; }

        public bool Status { get; set; }
    }
}
