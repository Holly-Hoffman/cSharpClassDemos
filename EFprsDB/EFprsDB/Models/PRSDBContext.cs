using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFprsDB.Models;

public partial class PRSDBContext : DbContext
{
    public PRSDBContext()
    {
    }

    public PRSDBContext(DbContextOptions<PRSDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-E9NT78D\\SQLEXPRESS;Database=PRSDB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LineItem__3214EC072CB025BA");

            entity.HasOne(d => d.Product).WithMany(p => p.LineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LineItem__Produc__3A81B327");

            entity.HasOne(d => d.Request).WithMany(p => p.LineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LineItem__Reques__398D8EEE");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC0751895C0D");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Products)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__Vendor__35BCFE0A");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Request__3214EC073B660DE9");

            entity.Property(e => e.Status).HasDefaultValue("New");
            entity.Property(e => e.SubmittedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.User).WithMany(p => p.Requests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Request__UserId__2E1BDC42");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC070CE1E6F9");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vendor__3214EC07578271C8");

            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
