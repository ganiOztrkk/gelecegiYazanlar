using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CampingApp.Infrastructure.data
{
    public class CampingDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public CampingDbContext(DbContextOptions<CampingDbContext> options): base(options)
        {
        }
    }
}
