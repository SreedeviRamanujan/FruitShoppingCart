namespace FruitCart.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<CartDetail> CartDetails { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartItems)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartItems1)
                .WithOptional(e => e.Product1)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.Country)
                .IsUnicode(false);
        }
    }
}
