using System;
using System.Collections.Generic;
using EF_DBFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_DBFirst.Contexts;

public partial class DissellingContext : DbContext
{
    public DissellingContext()
    {
    }

    public DissellingContext(DbContextOptions<DissellingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OfferModel> OfferModels { get; set; }

    public virtual DbSet<OutApplicationInformation> OutApplicationInformations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=194.61.118.220; Initial Catalog= DISSELLING; Persist Security Info=True;User ID= disusr;Password=Dis%022;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dis");

        modelBuilder.Entity<OfferModel>(entity =>
        {
            entity.ToTable("OfferModel");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FixedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PtfYekdem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OutApplicationInformation>(entity =>
        {
            entity.ToTable("OutApplicationInformation");

            entity.HasIndex(e => e.OutRegionalApplicationId, "NonClusteredIndex-OutRegionalApplicationId");

            entity.Property(e => e.Birthdate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
