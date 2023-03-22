﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerMecanico.Models.Domain;

namespace TallerMecanico.Migrations
{
    [DbContext(typeof(TallerMecanicoDBContext))]
    partial class TallerMecanicoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.AgrupadoModulos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Descripcion");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AgrupadoModulos");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Modulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AgrupadoModulosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Controller")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Controller");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Metodo")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Metodo");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("AgrupadoModulosId");

                    b.ToTable("Modulo");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.ModulosRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.HasIndex("RolId");

                    b.ToTable("ModulosRoles");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Descripcion2")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Descripcion2");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Correo");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Password");

                    b.Property<Guid>("RolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Modulo", b =>
                {
                    b.HasOne("TallerMecanico.Models.Domain.Entities.AgrupadoModulos", "AgrupadoModulos")
                        .WithMany("Modulos")
                        .HasForeignKey("AgrupadoModulosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgrupadoModulos");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.ModulosRoles", b =>
                {
                    b.HasOne("TallerMecanico.Models.Domain.Entities.Modulo", "Modulo")
                        .WithMany("ModulosRoles")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerMecanico.Models.Domain.Entities.Rol", "Rol")
                        .WithMany("ModulosRoles")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("TallerMecanico.Models.Domain.Entities.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.AgrupadoModulos", b =>
                {
                    b.Navigation("Modulos");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Modulo", b =>
                {
                    b.Navigation("ModulosRoles");
                });

            modelBuilder.Entity("TallerMecanico.Models.Domain.Entities.Rol", b =>
                {
                    b.Navigation("ModulosRoles");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
