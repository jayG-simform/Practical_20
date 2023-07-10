using Microsoft.EntityFrameworkCore;
using Practical_20.Models;

namespace Practical_20.Data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
