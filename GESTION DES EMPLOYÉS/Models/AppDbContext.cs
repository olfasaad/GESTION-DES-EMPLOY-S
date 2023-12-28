using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GESTION_DES_EMPLOYÉS.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
