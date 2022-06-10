﻿// <auto-generated />
using EdicoesEmMassa.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EdicoesEmMassa.Migrations
{
    [DbContext(typeof(bancoContext))]
    [Migration("20220609020606_CriandoTabelaContatos")]
    partial class CriandoTabelaContatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EdicoesEmMassa.Model.IncubadoraModel", b =>
                {
                    b.Property<int>("IdIncubadora")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodIncubadora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TemperaturaFixada")
                        .HasColumnType("float");

                    b.HasKey("IdIncubadora");

                    b.ToTable("Incubadora");
                });
#pragma warning restore 612, 618
        }
    }
}
