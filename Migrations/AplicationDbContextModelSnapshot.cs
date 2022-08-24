﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiTienda;

#nullable disable

namespace apiTienda.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("apiTienda.Entities.Caracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otros")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Caracteristica");
                });

            modelBuilder.Entity("apiTienda.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("apiTienda.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ci")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dirrecion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("apiTienda.Entities.Preventa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<double>("PrecioTotal")
                        .HasColumnType("float");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Preventa");
                });

            modelBuilder.Entity("apiTienda.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("CaracteristicaId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int?>("TiendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaracteristicaId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("TiendaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("apiTienda.Entities.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dirrecion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tienda");
                });

            modelBuilder.Entity("apiTienda.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personaId")
                        .HasColumnType("int")
                        .HasColumnName("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("personaId")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("apiTienda.Entities.Preventa", b =>
                {
                    b.HasOne("apiTienda.Entities.Producto", "Producto")
                        .WithMany("Preventa")
                        .HasForeignKey("ProductoId");

                    b.HasOne("apiTienda.Entities.Usuario", "Usuario")
                        .WithMany("Preventa")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("apiTienda.Entities.Producto", b =>
                {
                    b.HasOne("apiTienda.Entities.Caracteristica", "Caracteristica")
                        .WithMany("Producto")
                        .HasForeignKey("CaracteristicaId");

                    b.HasOne("apiTienda.Entities.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("apiTienda.Entities.Tienda", "Productos")
                        .WithMany("Productos")
                        .HasForeignKey("TiendaId");

                    b.Navigation("Caracteristica");

                    b.Navigation("Categoria");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("apiTienda.Entities.Tienda", b =>
                {
                    b.HasOne("apiTienda.Entities.Usuario", "Usuario")
                        .WithMany("Tienda")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("apiTienda.Entities.Usuario", b =>
                {
                    b.HasOne("apiTienda.Entities.Persona", "Persona")
                        .WithOne("Usuario")
                        .HasForeignKey("apiTienda.Entities.Usuario", "personaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("apiTienda.Entities.Caracteristica", b =>
                {
                    b.Navigation("Producto");
                });

            modelBuilder.Entity("apiTienda.Entities.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("apiTienda.Entities.Persona", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("apiTienda.Entities.Producto", b =>
                {
                    b.Navigation("Preventa");
                });

            modelBuilder.Entity("apiTienda.Entities.Tienda", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("apiTienda.Entities.Usuario", b =>
                {
                    b.Navigation("Preventa");

                    b.Navigation("Tienda");
                });
#pragma warning restore 612, 618
        }
    }
}
