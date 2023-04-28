using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Profitability;

public partial class PovlTeContext : DbContext
{
    public PovlTeContext()
    {
    }

    public PovlTeContext(DbContextOptions<PovlTeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MobileCommunication> MobileCommunications { get; set; }

    public virtual DbSet<PaymentClientsPlanned> PaymentClientsPlanneds { get; set; }

    public virtual DbSet<WorkingDaysMercenary> WorkingDaysMercenaries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.0.116;database=POVL_te;user id=sa;password=compasdt;Integrated Security=false;Trusted_Connection=False;Persist Security Info=True;MultipleActiveResultSets=true;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MobileCommunication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MobileCommunication");

            entity.HasIndex(e => e.Date, "UQ__MobileCo__1FFD6BF98965FCCC").IsUnique();

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PaymentClientsPlanned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentClientsPlanned");

            entity.HasIndex(e => e.Date, "UQ__PaymentC__3DCF46488DE13DC8").IsUnique();

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WorkingDaysMercenary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkingDaysMercenary");

            entity.HasIndex(e => e.Date, "UQ__WorkingD__7FC03A07DC9F16C5").IsUnique();

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
