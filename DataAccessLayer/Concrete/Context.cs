using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("server=205.144.171.95\\MSSQL2019;database=db_a83576_dbcoreblog;user id=db_a83576_dbcoreblog_admin;password=ilkaygl5995;");
        //    //optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=DbAGYapı; integrated security=true;");

        //}

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactLocation> ContactLocations { get; set; }
        public DbSet<MyProject> MyProjects { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }

        //,builder=>builder.EnableRetryOnFailure()

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; port=3306; database=AgYapiDb; user=root; password=cincon5995**; Persist Security Info=False");

        }


    }
}
