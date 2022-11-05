﻿// <auto-generated />
using ControleEstoque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleEstoque.Migrations
{
    [DbContext(typeof(PedidoContext))]
    partial class PedidoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControleEstoque.Models.Pedido", b =>
                {
                    b.Property<string>("CodigoProduto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumeroProduto")
                        .HasColumnType("integer");

                    b.Property<int>("QuantidadeProduto")
                        .HasColumnType("integer");

                    b.Property<double>("ValorProduto")
                        .HasColumnType("double precision");

                    b.ToTable("Encomendas");
                });
#pragma warning restore 612, 618
        }
    }
}