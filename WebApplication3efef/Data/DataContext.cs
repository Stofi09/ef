using Microsoft.EntityFrameworkCore;
using WebApplication3efef.Models;

namespace WebApplication3efef.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Human> Humans { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
