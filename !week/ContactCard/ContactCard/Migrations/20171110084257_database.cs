using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactCardApp.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WebAdress",
                table: "ContactCards",
                newName: "WebAddress");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "ContactCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "ContactCards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "ContactCards");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "ContactCards");

            migrationBuilder.RenameColumn(
                name: "WebAddress",
                table: "ContactCards",
                newName: "WebAdress");
        }
    }
}
