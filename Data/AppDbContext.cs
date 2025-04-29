using Microsoft.EntityFrameworkCore;
using gestor_backend.Data.Entities;

namespace gestor_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(tb =>
            {
                tb.HasKey(u => u.UserId);
                tb.Property(u => u.UserId)
                    .UseIdentityColumn()
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<User>().ToTable("Users");

            // ========================
            // Relaciones Client
            // ========================

            modelBuilder.Entity<Client>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.Provincia)
                .WithMany()
                .HasForeignKey(c => c.ProvinceId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Client>()
                .HasOne(c => c.City)
                .WithMany()
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            // ========================
            // Relaciones Product
            // ========================

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ========================
            // Relaciones Order
            // ========================

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany()
                .HasForeignKey(o => o.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.State)
                .WithMany()
                .HasForeignKey(o => o.StateId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.PaymentMethod)
                .WithMany()
                .HasForeignKey(o => o.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne<Client>()
                .WithMany()
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
            // ========================
            // Relaciones Provincia -> Ciudad
            // ========================

            modelBuilder.Entity<Provincia>(pb =>
            {
                pb.HasKey(p => p.ProvinceId);
                pb.Property(p => p.ProvinceId).UseIdentityColumn();
                pb.Property(p => p.Name)
                  .IsRequired()
                  .HasMaxLength(100);

                pb.HasMany<City>()
                  .WithOne()
                  .HasForeignKey(c => c.ProvinceId)
                  .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<City>(cb =>
            {
                cb.HasKey(c => c.CityId);
                cb.Property(c => c.CityId)
                  .UseIdentityColumn();
                cb.Property(c => c.Name)
                  .IsRequired()
                  .HasMaxLength(100);

                cb.HasOne<Provincia>()
                  .WithMany()
                  .HasForeignKey(c => c.ProvinceId)
                  .OnDelete(DeleteBehavior.Restrict);
            });
        }



    }
}
