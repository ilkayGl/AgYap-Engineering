using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AgYapıPresentation.Models
{
    public class CanstructionImagesDTO
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectTitle2 { get; set; }
        public string ProjectKategori { get; set; }
        public IFormFile ProjectImage { get; set; }
        public string ProjectDetails { get; set; }
        public bool ProjectStatus { get; set; }
    }
}
