﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WololoPrueba.DbContexts;

#nullable disable

namespace WololoPrueba.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231004231205_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WololoPrueba.Models.Civ", b =>
                {
                    b.Property<int>("CivId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CivId"), 1L, 1);

                    b.Property<string>("CivName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CivId");

                    b.ToTable("LasCivs");

                    b.HasData(
                        new
                        {
                            CivId = 1,
                            CivName = "Asirios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/f/f8/Assyrian_AOE_DE_ROR_icon.png/revision/latest?cb=20230611040714"
                        },
                        new
                        {
                            CivId = 2,
                            CivName = "Babilonios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/f/fe/Babylonian_AOE_DE_ROR_icon.png/revision/latest?cb=20230611040835"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}