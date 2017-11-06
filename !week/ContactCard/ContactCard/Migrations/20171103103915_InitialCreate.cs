using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContactCardApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardStyle = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    FacebookLink = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    ImageLink = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LinkedInLink = table.Column<string>(nullable: true),
                    PhoneNum = table.Column<string>(nullable: true),
                    TwitterLink = table.Column<string>(nullable: true),
                    WebAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactCards");
        }
    }
}
