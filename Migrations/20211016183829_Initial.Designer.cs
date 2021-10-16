﻿// <auto-generated />
using System;
using AvaliaçãoTecnobyte.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AvaliaçãoTecnobyte.Migrations
{
    [DbContext(typeof(ContextSystem))]
    [Migration("20211016183829_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AvaliaçãoTecnobyte.Models.People", b =>
                {
                    b.Property<long>("PeopleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CpfCnpj")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateRegister")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("Situation")
                        .HasColumnType("boolean");

                    b.Property<int>("TypePeople")
                        .HasColumnType("integer");

                    b.HasKey("PeopleId");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
