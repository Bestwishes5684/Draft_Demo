using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class Draft_DemoContext : DbContext
    {
        public Draft_DemoContext()
        {
        }

        public Draft_DemoContext(DbContextOptions<Draft_DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<AgentPriorityHistory> AgentPriorityHistory { get; set; }
        public virtual DbSet<AgentType> AgentType { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialCountHistory> MaterialCountHistory { get; set; }
        public virtual DbSet<MaterialSupplier> MaterialSupplier { get; set; }
        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductMaterial> ProductMaterial { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-T9MJ8MA\\SQLEXPRESS; Database=Draft_Demo; Integrated Security=false; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.AgentTypeId).HasColumnName("AgentTypeID");

                entity.Property(e => e.DirectorName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("INN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Kpp)
                    .HasColumnName("KPP")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Logo).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.AgentType)
                    .WithMany(p => p.Agent)
                    .HasForeignKey(d => d.AgentTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Agent_AgentType");
            });

            modelBuilder.Entity<AgentPriorityHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.AgentPriorityHistory)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AgentPriorityHistory_Agent");
            });

            modelBuilder.Entity<AgentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Unit).HasMaxLength(10);
                entity.Property(e=>e.Image);

                entity.HasOne(d => d.MaterialType)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.MaterialTypeId)
                    .HasConstraintName("FK_Material_MaterialType");
            });

            modelBuilder.Entity<MaterialCountHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialCountHistory)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MaterialCountHistory_Material");
            });

            modelBuilder.Entity<MaterialSupplier>(entity =>
            {
                entity.HasKey(e => new { e.MaterialId, e.SupplierId });

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialSupplier)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MaterialSupplier_Material");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.MaterialSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MaterialSupplier_Supplier");
            });

            modelBuilder.Entity<MaterialType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.MinCostForAgent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductTypeId)
                    .HasConstraintName("FK_Product_ProductType");
            });

            modelBuilder.Entity<ProductCostHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CostValue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCostHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductCostHistory_Product");
            });

            modelBuilder.Entity<ProductMaterial>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.MaterialId });

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.ProductMaterial)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductMaterial_Material");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMaterial)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductMaterial_Product");
            });

            modelBuilder.Entity<ProductSale>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SaleDate).HasColumnType("date");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.ProductSale)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductSale_Agent");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSale)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductSale_Product");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Shop_Agent");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("INN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SupplierType).HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
