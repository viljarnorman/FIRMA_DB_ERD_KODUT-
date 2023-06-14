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
    [Migration("20230614105426_Firma_migration_1")]
    partial class Firma_migration_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
