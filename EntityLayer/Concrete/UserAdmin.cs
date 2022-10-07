using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserAdmin
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserImage { get; set; }
        public string UserPassword { get; set; }
        public bool Status { get; set; }
    }
}
