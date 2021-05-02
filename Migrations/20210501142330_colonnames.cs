using Microsoft.EntityFrameworkCore.Migrations;

namespace BenimHesabim.Migrations
{
    public partial class colonnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_ReceiverIDID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_SenderIDID",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "SenderIDID",
                table: "Logs",
                newName: "SenderID");

            migrationBuilder.RenameColumn(
                name: "ReceiverIDID",
                table: "Logs",
                newName: "ReceiverID");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_SenderIDID",
                table: "Logs",
                newName: "IX_Logs_SenderID");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_ReceiverIDID",
                table: "Logs",
                newName: "IX_Logs_ReceiverID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_ReceiverID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_SenderID",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "SenderID",
                table: "Logs",
                newName: "SenderIDID");

            migrationBuilder.RenameColumn(
                name: "ReceiverID",
                table: "Logs",
                newName: "ReceiverIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_SenderID",
                table: "Logs",
                newName: "IX_Logs_SenderIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_ReceiverID",
                table: "Logs",
                newName: "IX_Logs_ReceiverIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Customers_ReceiverIDID",
                table: "Logs",
                column: "ReceiverIDID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Customers_SenderIDID",
                table: "Logs",
                column: "SenderIDID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
