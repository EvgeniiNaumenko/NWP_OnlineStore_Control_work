using Microsoft.EntityFrameworkCore;

namespace OnlineStoreServer.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-C317JNM;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;");   // EvgeniiPath
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-V6G1V7P;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;");     // DenisPath
        }

        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Description)
                .WithOne()
                .HasForeignKey<Product>(p => p.ProductDescriptionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Products)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }

}
