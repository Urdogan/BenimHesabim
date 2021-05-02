using Microsoft.EntityFrameworkCore.Migrations;

namespace BenimHesabim.Migrations
{
    public partial class changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_ReceiverID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_SenderID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_ReceiverID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_SenderID",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "Logs");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Logs");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_ReceiverID",
                table: "Logs",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_SenderID",
                table: "Logs",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Customers_ReceiverID",
                table: "Logs",
                column: "ReceiverID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Customers_SenderID",
                table: "Logs",
                column: "SenderID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
