using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Burada Sql Serverda Oluşturacağımız Database'nin İsmini ve Erişim İçin Sertifika İzni Veriyoruz.
            optionsBuilder.UseSqlServer("server=DESKTOP-KI81GQD;database=DbNewProject2;integrated security= true;Trust server certificate=true");
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Costomer> costomers { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
