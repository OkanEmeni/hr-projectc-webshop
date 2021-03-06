﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using klaas.Models;

namespace klaas.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20181008182925_ImprovedModel1")]
    partial class ImprovedModel1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("klaas.products.Attribuutsoort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attrbuut");

                    b.Property<int>("ProductsoortId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ProductsoortId");

                    b.ToTable("Attribuutsoort");
                });

            modelBuilder.Entity("klaas.products.Attribuutwaarde", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttribuutsoortId");

                    b.Property<int>("ProductwaardeId");

                    b.Property<string>("Waarde");

                    b.HasKey("Id");

                    b.HasIndex("AttribuutsoortId");

                    b.HasIndex("ProductwaardeId");

                    b.ToTable("Attribuutwaarde");
                });

            modelBuilder.Entity("klaas.products.Extra_Atributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Atribute");

                    b.Property<int>("ProductsId");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("Extra_Atributes");
                });

            modelBuilder.Entity("klaas.products.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Price");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("klaas.products.Productsoort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naam");

                    b.HasKey("Id");

                    b.ToTable("Productsoort");
                });

            modelBuilder.Entity("klaas.products.Productwaarde", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Price");

                    b.Property<int>("ProductsoortId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProductsoortId");

                    b.ToTable("Productwaarde");
                });

            modelBuilder.Entity("klaas.products.Attribuutsoort", b =>
                {
                    b.HasOne("klaas.products.Productsoort", "productsoort")
                        .WithMany("Attribuutsoort")
                        .HasForeignKey("ProductsoortId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("klaas.products.Attribuutwaarde", b =>
                {
                    b.HasOne("klaas.products.Attribuutsoort", "attribuutsoort")
                        .WithMany("Attribuutwaarde")
                        .HasForeignKey("AttribuutsoortId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("klaas.products.Productwaarde", "productwaarde")
                        .WithMany("Attribuutwaarde")
                        .HasForeignKey("ProductwaardeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("klaas.products.Extra_Atributes", b =>
                {
                    b.HasOne("klaas.products.Products", "products")
                        .WithMany("Extra_Atributes")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("klaas.products.Productwaarde", b =>
                {
                    b.HasOne("klaas.products.Productsoort", "productsoort")
                        .WithMany("Productwaarde")
                        .HasForeignKey("ProductsoortId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
