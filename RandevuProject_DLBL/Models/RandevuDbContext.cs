using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RandevuProject_DLBL.Models;

public partial class RandevuDbContext : DbContext
{
    public RandevuDbContext()
    {
    }

    public RandevuDbContext(DbContextOptions<RandevuDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kisiler> Kisilers { get; set; }

    public virtual DbSet<KisilerinRolleri> KisilerinRolleris { get; set; }

    public virtual DbSet<RandevuTipleri> RandevuTipleris { get; set; }

    public virtual DbSet<Randevular> Randevulars { get; set; }

    public virtual DbSet<Roller> Rollers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MODELSUDE;Database=RandevuDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Kisiler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kisiler__3214EC0712F9F41D");

            entity.ToTable("Kisiler");

            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber).HasMaxLength(11);
            entity.Property(e => e.Surname).HasMaxLength(250);
        });

        modelBuilder.Entity<KisilerinRolleri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KisilerinRolleri");

            entity.Property(e => e.RoleId).HasMaxLength(450);
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany()
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KisilerinRolleri_Roller");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KisilerinRolleri_Kisiler");
        });

        modelBuilder.Entity<RandevuTipleri>(entity =>
        {
            entity.ToTable("RandevuTipleri");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<Randevular>(entity =>
        {
            entity.ToTable("Randevular");

            entity.Property(e => e.CancellReason).HasMaxLength(500);
            entity.Property(e => e.DoctorId).HasMaxLength(450);
            entity.Property(e => e.EndHour).HasMaxLength(5);
            entity.Property(e => e.PatientId).HasMaxLength(450);
            entity.Property(e => e.StartHour).HasMaxLength(5);

            entity.HasOne(d => d.AppointmentType).WithMany(p => p.Randevulars)
                .HasForeignKey(d => d.AppointmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Randevular_RandevuTipleri");

            entity.HasOne(d => d.Doctor).WithMany(p => p.RandevularDoctors)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Randevular_Kisiler1");

            entity.HasOne(d => d.Patient).WithMany(p => p.RandevularPatients)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Randevular_Kisiler");
        });

        modelBuilder.Entity<Roller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roller__3214EC07C0DF0B02");

            entity.ToTable("Roller");

            entity.Property(e => e.Name).HasMaxLength(256);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
