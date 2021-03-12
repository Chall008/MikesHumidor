﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MikesHumidor.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MikesHumidor.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210312145846_RemoveBrandId")]
    partial class RemoveBrandId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MikesHumidor.Models.Cigar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DateBought")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("InStock")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<string>("Strength")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cigars");
                });
#pragma warning restore 612, 618
        }
    }
}
