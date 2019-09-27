using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public partial class TradingCompanyContext : DbContext
    {
        public TradingCompanyContext()
        {
        }

        public TradingCompanyContext(DbContextOptions<TradingCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryDiscount> CategoryDiscounts { get; set; }
        public virtual DbSet<CategoryGroupDiscount> CategoryGroupDiscounts { get; set; }
        public virtual DbSet<CategoryGroup> CategoryGroups { get; set; }
        public virtual DbSet<CustomerUser> CustomerUsers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TradingCompany;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasIndex(e => e.Name).IsUnique();

                entity.HasOne(d => d.CategoryGroup)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.CategoryGroupId);
            });

            modelBuilder.Entity<CategoryDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryDiscounts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.CategoryDiscounts)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CategoryGroupDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.CategoryGroup)
                    .WithMany(p => p.CategoryGroupDiscounts)
                    .HasForeignKey(d => d.CategoryGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.CategoryGroupDiscounts)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CategoryGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasIndex(e => e.Name).IsUnique();
            });

            modelBuilder.Entity<CustomerUser>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerUsers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(10);
                
                entity.HasIndex(e => e.Name).IsUnique();
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasIndex(e => e.Name).IsUnique();
            });

            modelBuilder.Entity<ProductDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Price)
                    .IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ManufacturerId);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasIndex(e => e.Name).IsUnique();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasIndex(e => e.Email).IsUnique();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasIndex(e => e.Login).IsUnique();

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

         partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
