using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFTI_Service.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkersAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkersAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersWorkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LoginName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Master = table.Column<bool>(type: "bit", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    LastLogged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstLogged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkersAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersWorkers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersWorkers_WorkersAddresses_WorkersAddressId",
                        column: x => x.WorkersAddressId,
                        principalTable: "WorkersAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersWorkers_WorkersAddressId",
                table: "UsersWorkers",
                column: "WorkersAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersWorkers");

            migrationBuilder.DropTable(
                name: "WorkersAddresses");
        }
    }
}
