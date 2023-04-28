using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STI.DAT.Migrations
{
    /// <inheritdoc />
    public partial class AddTableRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserInternalID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "User_InternalID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Permissions = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.InternalID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Role_InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleInternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.InternalID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleInternalID",
                        column: x => x.RoleInternalID,
                        principalTable: "Roles",
                        principalColumn: "InternalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserInternalID",
                table: "Students",
                column: "UserInternalID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleInternalID",
                table: "Users",
                column: "RoleInternalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UserInternalID",
                table: "Students",
                column: "UserInternalID",
                principalTable: "Users",
                principalColumn: "InternalID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UserInternalID",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserInternalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UserInternalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "User_InternalID",
                table: "Students");
        }
    }
}
