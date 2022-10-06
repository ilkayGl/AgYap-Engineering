using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgYapıPresentation.Models
{
    public class AddProfileImageDTO
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public IFormFile UserImages { get; set; }
        public string UserPassword { get; set; }
        public bool Status { get; set; }
    }
}
