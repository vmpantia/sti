using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STI.DAT.Migrations
{
    /// <inheritdoc />
    public partial class InitialTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.InternalID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalContactNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PersonalEmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ICOEFullName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ICOEContactNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ICOEAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ICOEReletion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProvincialAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.InternalID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TotalUnit = table.Column<int>(type: "int", nullable: false),
                    Category_InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryInternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.InternalID);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryInternalID",
                        column: x => x.CategoryInternalID,
                        principalTable: "Categories",
                        principalColumn: "InternalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Category_InternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryInternalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.InternalID);
                    table.ForeignKey(
                        name: "FK_Subjects_Categories_CategoryInternalID",
                        column: x => x.CategoryInternalID,
                        principalTable: "Categories",
                        principalColumn: "InternalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryInternalID",
                table: "Courses",
                column: "CategoryInternalID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CategoryInternalID",
                table: "Subjects",
                column: "CategoryInternalID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
