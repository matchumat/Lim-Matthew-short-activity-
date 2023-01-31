using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lim_Matthew;

public partial class Entprg12101094LimContext : DbContext
{
    public Entprg12101094LimContext()
    {
    }

    public Entprg12101094LimContext(DbContextOptions<Entprg12101094LimContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SupplierTbl> SupplierTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=csb-entpro.wongph.com;Database=ENTPRG_12101094_LIM;User Id=12106751; Password=oW0vO5yO; TrustServerCertificate =true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SupplierTbl>(entity =>
        {
            entity.HasKey(e => e.SupplierId);

            entity.ToTable("SupplierTbl");

            entity.Property(e => e.SupplierId).HasColumnName("supplierID");
            entity.Property(e => e.Address).HasMaxLength(9);
            entity.Property(e => e.Contact).HasMaxLength(12);
            entity.Property(e => e.DateAdded).HasColumnType("date");
            entity.Property(e => e.DateModified).HasColumnType("date");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .HasColumnName("supplierName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
