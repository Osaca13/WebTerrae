﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebTerrae.Data.Data
{
    public partial class WebterraeContext : DbContext
    {
        private readonly string _connectionString;
        public WebterraeContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public WebterraeContext(DbContextOptions<WebterraeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carnets> Carnets { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public virtual DbSet<Ofertas> Ofertas { get; set; }
        public virtual DbSet<SubscripcionEmpleadoOferta> SubscripcionEmpleadoOferta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Carnets>(entity =>
            {
                entity.HasKey(e => e.CarnetId);

                entity.Property(e => e.Tipo).HasMaxLength(10);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Carnets)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK_Carnets_Empleados");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre).IsRequired();
            });

            modelBuilder.Entity<ExperienciaLaboral>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId);

                entity.Property(e => e.EmpleadoId).ValueGeneratedNever();

                entity.Property(e => e.ExperienciaLaboralId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Empleado)
                    .WithOne(p => p.ExperienciaLaboral)
                    .HasForeignKey<ExperienciaLaboral>(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExperienciaLaboral_Empleados");
            });

            modelBuilder.Entity<Ofertas>(entity =>
            {
                entity.HasKey(e => e.OfertaId);
            });

            modelBuilder.Entity<SubscripcionEmpleadoOferta>(entity =>
            {
                entity.HasKey(e => e.SubscripcionId);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.SubscripcionEmpleadoOferta)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscripcionEmpleadoOferta_Empleados");

                entity.HasOne(d => d.Oferta)
                    .WithMany(p => p.SubscripcionEmpleadoOferta)
                    .HasForeignKey(d => d.OfertaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscripcionEmpleadoOferta_Ofertas");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}