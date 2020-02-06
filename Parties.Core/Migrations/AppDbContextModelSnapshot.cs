﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parties.Core.Domain;

namespace Parties.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parties.Core.Models.GuestResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("PartiesId");

                    b.Property<bool>("WillAttend");

                    b.HasKey("Id");

                    b.HasIndex("PartiesId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Parties.Core.Models.Parties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PartiesName");

                    b.HasKey("Id");

                    b.ToTable("ResponsePartieses");
                });

            modelBuilder.Entity("Parties.Core.Models.GuestResponse", b =>
                {
                    b.HasOne("Parties.Core.Models.Parties", "Parties")
                        .WithMany("GuestResponses")
                        .HasForeignKey("PartiesId");
                });
#pragma warning restore 612, 618
        }
    }
}
