using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSProject.Core;
using Microsoft.EntityFrameworkCore;

namespace CMSProject.Data.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> dbContext) : base(dbContext)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J08CACC;Database=CMSDataBase;Encrypt=false ;Trusted_Connection=True");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
