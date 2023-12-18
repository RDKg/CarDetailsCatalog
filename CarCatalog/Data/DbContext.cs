using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Data
{
    public class CarCatalogDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<TypeDetail> TypeDetails { get; set; }
        public DbSet<CarDetail> CarDetails { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Catalog.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Brand)
                .WithMany(b => b.Cars)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Detail>()
                .HasOne(d => d.TypeDetail)
                .WithMany(td => td.Details)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CarDetail>()
                .HasOne(cd => cd.Car)
                .WithMany(c => c.CarDetails)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CarDetail>()
                .HasOne(cd => cd.Detail)
                .WithMany(d => d.CarDetails)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
