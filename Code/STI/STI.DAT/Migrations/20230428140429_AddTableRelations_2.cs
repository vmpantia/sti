using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STI.DAT.Migrations
{
    /// <inheritdoc />
    public partial class AddTableRelations_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role_InternalID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Category_InternalID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "User_InternalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Category_InternalID",
                table: "Courses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Role_InternalID",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Category_InternalID",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "User_InternalID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Category_InternalID",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
