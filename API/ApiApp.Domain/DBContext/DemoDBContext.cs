// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIApp
{
    public partial class DemoDBContext : DbContext
    {
        public DemoDBContext()
        {
        }

        public DemoDBContext(DbContextOptions<DemoDBContext> options)  : base(options)
        {
        }

        public virtual DbSet<ConversionUnit> ConversionUnit { get; set; }
        public virtual DbSet<EmissionItem> EmissionItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NEXT-DESK-11;Initial Catalog=DemoDB;Integrated Security=True");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConversionUnit>(entity =>
            {
                entity.Property(e => e.UnitName).IsUnicode(false);
            });

            modelBuilder.Entity<EmissionItem>(entity =>
            {
                entity.Property(e => e.CarbonCoefficient).IsUnicode(false);

                entity.Property(e => e.DQI).IsUnicode(false);

                entity.Property(e => e.DataSource).IsUnicode(false);

                entity.Property(e => e.ItemName).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.HasOne(d => d.ConversionUnit)
                    .WithMany(p => p.EmissionItem)
                    .HasForeignKey(d => d.ConversionUnitID)
                    .HasConstraintName("FK__EmissionI__Conve__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}