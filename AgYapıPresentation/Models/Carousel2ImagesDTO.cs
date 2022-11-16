using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AgYapıPresentation.Models
{
    public class Carousel2ImagesDTO
    {
        [Key]
        public int Carousel2ID { get; set; }

        public IFormFile BackImages { get; set; }

        public bool Status { get; set; }
    }
}
