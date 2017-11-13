using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ContactCardApp.Entities;

namespace ContactCardApp.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20171110084257_database")]
    partial class database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactCardApp.Models.ContactCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<int>("CardStyle");

                    b.Property<string>("CompanyName");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FacebookLink");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageLink");

                    b.Property<string>("InstagramLink");

                    b.Property<string>("Job");

                    b.Property<string>("LastName");

                    b.Property<string>("LinkedInLink");

                    b.Property<string>("PhoneNum");

                    b.Property<string>("TwitterLink");

                    b.Property<string>("WebAddress");

                    b.HasKey("Id");

                    b.ToTable("ContactCards");
                });
        }
    }
}
