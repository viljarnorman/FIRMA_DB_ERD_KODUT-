﻿// <auto-generated />
using FIRMADB_VN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FIRMADB_VN.Migrations
{
    [DbContext(typeof(FIRMADB_VN_Context))]
    [Migration("20230614185408_Firma_laenutatav_inventar")]
    partial class Firma_laenutatav_inventar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FIRMADB_VN.Models.Haru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaruNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Registrikood")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Haru");
                });

            modelBuilder.Entity("FIRMADB_VN.Models.Objektid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Eesnimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perenimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vanus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Objects");
                });

            modelBuilder.Entity("FIRMADB_VN.Models.Töötaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Eesnimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perenimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vanus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Töötaja");
                });
#pragma warning restore 612, 618
        }
    }
}