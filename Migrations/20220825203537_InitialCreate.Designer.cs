﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiTienda;

#nullable disable

namespace apiTienda.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20220825203537_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("ProductoTiendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoTiendaId");

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

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
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

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Preventa");
                });

            modelBuilder.Entity("apiTienda.Entities.PreventaProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PreventaId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreventaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("PreventaProducto");
                });

            modelBuilder.Entity("apiTienda.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("apiTienda.Entities.ProductoTienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("TiendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("TiendaId");

                    b.ToTable("ProductoTienda");
                });

            modelBuilder.Entity("apiTienda.Entities.SubCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("SubCategoria");
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

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

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

                    b.Property<int>("PersonaId")
                        .HasColumnType("int")
                        .HasColumnName("PersonaId");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("apiTienda.Entities.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ci")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dirrecion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("apiTienda.Entities.VendedorArchivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extencion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tamaño")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId")
                        .IsUnique();

                    b.ToTable("VendedorArchivo");
                });

            modelBuilder.Entity("apiTienda.Entities.Caracteristica", b =>
                {
                    b.HasOne("apiTienda.Entities.ProductoTienda", "ProductoTienda")
                        .WithMany("Caracteristica")
                        .HasForeignKey("ProductoTiendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductoTienda");
                });

            modelBuilder.Entity("apiTienda.Entities.Preventa", b =>
                {
                    b.HasOne("apiTienda.Entities.Usuario", "Usuario")
                        .WithMany("Preventa")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("apiTienda.Entities.PreventaProducto", b =>
                {
                    b.HasOne("apiTienda.Entities.Preventa", "Preventa")
                        .WithMany("PreventaProducto")
                        .HasForeignKey("PreventaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiTienda.Entities.Producto", "Producto")
                        .WithMany("PreventaProducto")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preventa");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("apiTienda.Entities.Producto", b =>
                {
                    b.HasOne("apiTienda.Entities.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("apiTienda.Entities.ProductoTienda", b =>
                {
                    b.HasOne("apiTienda.Entities.Producto", "Producto")
                        .WithMany("ProductosTienda")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiTienda.Entities.Tienda", "Tienda")
                        .WithMany("ProductosTienda")
                        .HasForeignKey("TiendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Tienda");
                });

            modelBuilder.Entity("apiTienda.Entities.SubCategoria", b =>
                {
                    b.HasOne("apiTienda.Entities.Categoria", "Categoria")
                        .WithMany("Subcategoria")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("apiTienda.Entities.Tienda", b =>
                {
                    b.HasOne("apiTienda.Entities.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("apiTienda.Entities.Usuario", b =>
                {
                    b.HasOne("apiTienda.Entities.Persona", "Persona")
                        .WithOne("Usuario")
                        .HasForeignKey("apiTienda.Entities.Usuario", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("apiTienda.Entities.Vendedor", b =>
                {
                    b.HasOne("apiTienda.Entities.Persona", "Persona")
                        .WithOne("Vendedor")
                        .HasForeignKey("apiTienda.Entities.Vendedor", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("apiTienda.Entities.VendedorArchivo", b =>
                {
                    b.HasOne("apiTienda.Entities.Vendedor", "Vendedor")
                        .WithOne("Archivo")
                        .HasForeignKey("apiTienda.Entities.VendedorArchivo", "VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("apiTienda.Entities.Categoria", b =>
                {
                    b.Navigation("Productos");

                    b.Navigation("Subcategoria");
                });

            modelBuilder.Entity("apiTienda.Entities.Persona", b =>
                {
                    b.Navigation("Usuario");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("apiTienda.Entities.Preventa", b =>
                {
                    b.Navigation("PreventaProducto");
                });

            modelBuilder.Entity("apiTienda.Entities.Producto", b =>
                {
                    b.Navigation("PreventaProducto");

                    b.Navigation("ProductosTienda");
                });

            modelBuilder.Entity("apiTienda.Entities.ProductoTienda", b =>
                {
                    b.Navigation("Caracteristica");
                });

            modelBuilder.Entity("apiTienda.Entities.Tienda", b =>
                {
                    b.Navigation("ProductosTienda");
                });

            modelBuilder.Entity("apiTienda.Entities.Usuario", b =>
                {
                    b.Navigation("Preventa");
                });

            modelBuilder.Entity("apiTienda.Entities.Vendedor", b =>
                {
                    b.Navigation("Archivo");
                });
#pragma warning restore 612, 618
        }
    }
}