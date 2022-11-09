using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AgYapıPresentation.Models
{
    public class AboutImageDTO
    {
        [Key]
        public int AboutId { get; set; }

        public string AboutTitle { get; set; }

        public string AboutTitle2 { get; set; }

        public IFormFile AboutImage1 { get; set; }

        public string AboutDetails { get; set; }

        public bool AboutStatus { get; set; }

    }
}
