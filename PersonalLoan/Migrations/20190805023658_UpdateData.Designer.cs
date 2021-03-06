﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalLoan.Data.Models;

namespace PersonalLoan.Migrations
{
    [DbContext(typeof(PersonalLoanContext))]
    [Migration("20190805023658_UpdateData")]
    partial class UpdateData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalLoan.Data.Models.PersonalLoanDetail", b =>
                {
                    b.Property<long>("PersonalLoanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountNumber");

                    b.Property<long>("Balance");

                    b.Property<long>("CarryOverAmount");

                    b.Property<int>("Fee");

                    b.Property<long>("Interest");

                    b.Property<long>("Loan_UserID");

                    b.HasKey("PersonalLoanId");

                    b.ToTable("PersonalLoanDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
