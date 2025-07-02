using CRUDOperation.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
      
    }
}
