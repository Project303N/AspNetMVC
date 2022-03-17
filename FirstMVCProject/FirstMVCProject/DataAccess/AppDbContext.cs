using FirstMVCProject.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace FirstMVCProject.DataAccess
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
    }
}