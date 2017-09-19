namespace OnlineShop.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=OnlineShopConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        public virtual DbSet<TblAssortment> TblAssortments { get; set; }
        public virtual DbSet<TblBrend> TblBrends { get; set; }
        public virtual DbSet<TblPrice> TblPrices { get; set; }
        public virtual DbSet<TblQuantityStock> TblQuantityStocks { get; set; }
        public virtual DbSet<TblStatu> TblStatus { get; set; }
        public virtual DbSet<TblStorageLocation> TblStorageLocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAssortment>()
                .HasMany(e => e.TblQuantityStocks)
                .WithRequired(e => e.TblAssortment)
                .HasForeignKey(e => e.IdPrice);

            modelBuilder.Entity<TblBrend>()
                .HasMany(e => e.TblAssortments)
                .WithOptional(e => e.TblBrend)
                .HasForeignKey(e => e.IdBrand);

            modelBuilder.Entity<TblPrice>()
                .HasMany(e => e.TblStatus)
                .WithRequired(e => e.TblPrice)
                .HasForeignKey(e => e.IdPrice);

            modelBuilder.Entity<TblQuantityStock>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TblQuantityStock>()
                .HasMany(e => e.TblPrices)
                .WithRequired(e => e.TblQuantityStock)
                .HasForeignKey(e => e.IdQuantity);

            modelBuilder.Entity<TblStatu>()
                .Property(e => e.MinOrder)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TblStorageLocation>()
                .HasMany(e => e.TblQuantityStocks)
                .WithRequired(e => e.TblStorageLocation)
                .HasForeignKey(e => e.IdStorageLocation)
                .WillCascadeOnDelete(false);
        }
    }
}
