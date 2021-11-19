using Microsoft.EntityFrameworkCore.Migrations;

namespace OFTI_Service.Migrations
{
    public partial class kurwa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkersAddress_UsersWorkers_UsersWorkerId",
                table: "WorkersAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersAddress",
                table: "WorkersAddress");

            migrationBuilder.RenameTable(
                name: "WorkersAddress",
                newName: "WorkersAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersAddress_UsersWorkerId",
                table: "WorkersAddresses",
                newName: "IX_WorkersAddresses_UsersWorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersAddresses",
                table: "WorkersAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersAddresses_UsersWorkers_UsersWorkerId",
                table: "WorkersAddresses",
                column: "UsersWorkerId",
                principalTable: "UsersWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkersAddresses_UsersWorkers_UsersWorkerId",
                table: "WorkersAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersAddresses",
                table: "WorkersAddresses");

            migrationBuilder.RenameTable(
                name: "WorkersAddresses",
                newName: "WorkersAddress");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersAddresses_UsersWorkerId",
                table: "WorkersAddress",
                newName: "IX_WorkersAddress_UsersWorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersAddress",
                table: "WorkersAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersAddress_UsersWorkers_UsersWorkerId",
                table: "WorkersAddress",
                column: "UsersWorkerId",
                principalTable: "UsersWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
