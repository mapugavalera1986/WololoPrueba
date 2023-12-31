﻿// <auto-generated />
using System;
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
    [Migration("20231019004741_initial")]
    partial class initial
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
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/f/f8/Assyrian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 2,
                            CivName = "Babilonios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/f/fe/Babylonian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 3,
                            CivName = "Cartagineses",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/b/b9/Carthaginian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 4,
                            CivName = "Choson",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/a/ad/Choson_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 5,
                            CivName = "Egipcios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/0/03/Egyptian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 6,
                            CivName = "Fenicios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/8/82/Phoenician_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 7,
                            CivName = "Griegos",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/1/13/Greek_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 8,
                            CivName = "Hititas",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/a/aa/Hittite_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 9,
                            CivName = "Lac Viet",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/9/98/Lac_Viet_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 10,
                            CivName = "Macedonios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/7/7d/Macedonian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 11,
                            CivName = "Minoicos",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/e/ec/Minoan_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 12,
                            CivName = "Palmireños",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/7/7b/Palmyran_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 13,
                            CivName = "Persas",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/5/57/Persian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 14,
                            CivName = "Romanos",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/4/44/Roman_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 15,
                            CivName = "Shang",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/e/e4/Shang_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 16,
                            CivName = "Sumerios",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/4/44/Sumerian_AOE_DE_ROR_icon.png"
                        },
                        new
                        {
                            CivId = 17,
                            CivName = "Yamato",
                            FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/8/82/Yamato_AOE_DE_ROR_icon.png"
                        });
                });

            modelBuilder.Entity("WololoPrueba.Models.Colegio", b =>
                {
                    b.Property<int>("ColegioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColegioId"), 1L, 1);

                    b.Property<string>("Direccn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nivel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nmbr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColegioId");

                    b.ToTable("LosColegios");
                });

            modelBuilder.Entity("WololoPrueba.Models.Ensayo", b =>
                {
                    b.Property<int>("EnsayoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnsayoId"), 1L, 1);

                    b.Property<int>("CivId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int");

                    b.HasKey("EnsayoId");

                    b.ToTable("LosEnsayos");
                });

            modelBuilder.Entity("WololoPrueba.Models.Participante", b =>
                {
                    b.Property<int>("ParticipanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipanteId"), 1L, 1);

                    b.Property<string>("Aplld")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColegioId")
                        .HasColumnType("int");

                    b.Property<string>("CorreoE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nmbrs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParticipanteId");

                    b.HasIndex("ColegioId");

                    b.ToTable("LosParticipantes");
                });

            modelBuilder.Entity("WololoPrueba.Models.Premiaciones", b =>
                {
                    b.Property<int>("PremiacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PremiacionesId"), 1L, 1);

                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int");

                    b.Property<int>("PremioId")
                        .HasColumnType("int");

                    b.HasKey("PremiacionesId");

                    b.HasIndex("ParticipanteId");

                    b.ToTable("LasPremiaciones");
                });

            modelBuilder.Entity("WololoPrueba.Models.Premios", b =>
                {
                    b.Property<int>("PremioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PremioId"), 1L, 1);

                    b.Property<string>("nombPremio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PremioId");

                    b.ToTable("LosPremios");
                });

            modelBuilder.Entity("WololoPrueba.Models.Participante", b =>
                {
                    b.HasOne("WololoPrueba.Models.Colegio", "Colegio")
                        .WithMany()
                        .HasForeignKey("ColegioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colegio");
                });

            modelBuilder.Entity("WololoPrueba.Models.Premiaciones", b =>
                {
                    b.HasOne("WololoPrueba.Models.Participante", "Participante")
                        .WithMany()
                        .HasForeignKey("ParticipanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participante");
                });
#pragma warning restore 612, 618
        }
    }
}
