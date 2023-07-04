﻿// <auto-generated />
using AseguradoraViamatica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AseguradoraViamatica.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230703211230_Seguros_Asegurados")]
    partial class Seguros_Asegurados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AseguradoraViamatica.Entidades.Asegurado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Asegurados");
                });

            modelBuilder.Entity("AseguradoraViamatica.Entidades.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodigoSeguro")
                        .HasColumnType("int");

                    b.Property<string>("NombreSeguro")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<double>("Prima")
                        .HasColumnType("float");

                    b.Property<double>("SumadaAsegurada")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("AseguradoraViamatica.Entidades.SegurosAsegurados", b =>
                {
                    b.Property<int>("SeguroId")
                        .HasColumnType("int");

                    b.Property<int>("AseguradoId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("SeguroId", "AseguradoId");

                    b.HasIndex("AseguradoId");

                    b.ToTable("SegurosAsegurados");
                });

            modelBuilder.Entity("AseguradoraViamatica.Entidades.SegurosAsegurados", b =>
                {
                    b.HasOne("AseguradoraViamatica.Entidades.Asegurado", "Asegurado")
                        .WithMany("SegurosAsegurados")
                        .HasForeignKey("AseguradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AseguradoraViamatica.Entidades.Seguro", "Seguro")
                        .WithMany("SegurosAsegurados")
                        .HasForeignKey("SeguroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asegurado");

                    b.Navigation("Seguro");
                });

            modelBuilder.Entity("AseguradoraViamatica.Entidades.Asegurado", b =>
                {
                    b.Navigation("SegurosAsegurados");
                });

            modelBuilder.Entity("AseguradoraViamatica.Entidades.Seguro", b =>
                {
                    b.Navigation("SegurosAsegurados");
                });
#pragma warning restore 612, 618
        }
    }
}
