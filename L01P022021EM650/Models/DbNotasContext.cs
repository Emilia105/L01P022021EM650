using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace L01P022021EM650.Models;

public partial class DbNotasContext : DbContext
{
    public DbNotasContext()
    {
    }

    public DbNotasContext(DbContextOptions<DbNotasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Facultade> Facultades { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__alumnos__3213E83F14FF9C5A");

            entity.ToTable("alumnos", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Dui).HasColumnName("dui");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__departam__3213E83FB011BCF5");

            entity.ToTable("departamentos", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Departamento1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departamento");
        });

        modelBuilder.Entity<Facultade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__facultad__3213E83FC7B1A020");

            entity.ToTable("facultades", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Facultad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("facultad");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__materias__3213E83F1696DBD1");

            entity.ToTable("materias", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Materia1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("materia");
            entity.Property(e => e.UnidadesValorativas).HasColumnName("unidades_valorativas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
