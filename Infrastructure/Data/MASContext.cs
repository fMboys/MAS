using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MASContext : DbContext
    {
        public MASContext(DbContextOptions<MASContext> options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
    }
}