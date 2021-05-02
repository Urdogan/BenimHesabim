using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BenimHesabim.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Sender",
                table: "Logs");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Logs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ReceiverIDID",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderIDID",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_ReceiverIDID",
                table: "Logs",
                column: "ReceiverIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_SenderIDID",
                table: "Logs",
                column: "SenderIDID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_ReceiverIDID",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Customers_SenderIDID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_ReceiverIDID",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_SenderIDID",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "ReceiverIDID",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "SenderIDID",
                table: "Logs");

            migrationBuilder.AddColumn<string>(
                name: "Receiver",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sender",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
