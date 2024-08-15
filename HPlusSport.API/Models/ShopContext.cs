using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options) : base(options) { }

        // DbSet<TEntity>
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Category> ()
                 .HasMany ( c => c.Products )
                 .WithOne ( a => a.Category )
                 .HasForeignKey ( a => a.CategoryId );
            
            
            // base.OnModelCreating ( modelBuilder );
            modelBuilder.Seed ();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
