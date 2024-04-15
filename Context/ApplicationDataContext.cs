using AMST4.Store.Shoes.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMST4.Store.Shoes.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Product> Products { get; set; }
}
}