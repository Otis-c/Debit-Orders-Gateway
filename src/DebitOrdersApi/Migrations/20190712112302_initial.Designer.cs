﻿// <auto-generated />
using System;
using DebitOrdersApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DebitOrdersApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190712112302_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DebitOrdersApi.Models.DebitInstruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName");

                    b.Property<string>("AccountNumber");

                    b.Property<string>("BankCode");

                    b.Property<string>("BranchCode");

                    b.Property<string>("Creditor");

                    b.Property<decimal>("DebitAmount");

                    b.Property<string>("DebitNarration");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("IDNumber");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("DebitInstructions");
                });
#pragma warning restore 612, 618
        }
    }
}
