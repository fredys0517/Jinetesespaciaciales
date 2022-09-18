﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RBT.App.Persistencia;

#nullable disable

namespace RBT.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RBT.App.Dominio.Auxiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auxiliares");
                });

            modelBuilder.Entity("RBT.App.Dominio.JefeOperaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JefesOperaciones");
                });

            modelBuilder.Entity("RBT.App.Dominio.Mantenimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FechaMantenimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelAceite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelLiquidoDireccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelLiquidoFrenos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelRefrigerante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("vehiculoId");

                    b.ToTable("Mantenimientos");
                });

            modelBuilder.Entity("RBT.App.Dominio.Mecanico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelEstudios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("RBT.App.Dominio.Propietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadResidencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("RBT.App.Dominio.Reparacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FechaReparacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepuestosCambiados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mantenimientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("mantenimientoId");

                    b.ToTable("Reparaciones");
                });

            modelBuilder.Entity("RBT.App.Dominio.Soat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FechaCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVencimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("vehiculoId");

                    b.ToTable("Soats");
                });

            modelBuilder.Entity("RBT.App.Dominio.UsuarioApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsuariosApp");
                });

            modelBuilder.Entity("RBT.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CaracteristicasExtra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cilindraje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisOrigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasajero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoVehiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mecanicoId")
                        .HasColumnType("int");

                    b.Property<int>("propietarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("mecanicoId");

                    b.HasIndex("propietarioId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("RBT.App.Dominio.Mantenimiento", b =>
                {
                    b.HasOne("RBT.App.Dominio.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("RBT.App.Dominio.Reparacion", b =>
                {
                    b.HasOne("RBT.App.Dominio.Mantenimiento", "mantenimiento")
                        .WithMany()
                        .HasForeignKey("mantenimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mantenimiento");
                });

            modelBuilder.Entity("RBT.App.Dominio.Soat", b =>
                {
                    b.HasOne("RBT.App.Dominio.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("RBT.App.Dominio.Vehiculo", b =>
                {
                    b.HasOne("RBT.App.Dominio.Mecanico", "mecanico")
                        .WithMany()
                        .HasForeignKey("mecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RBT.App.Dominio.Propietario", "propietario")
                        .WithMany()
                        .HasForeignKey("propietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mecanico");

                    b.Navigation("propietario");
                });
#pragma warning restore 612, 618
        }
    }
}
