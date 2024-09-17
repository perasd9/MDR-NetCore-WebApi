using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeModelBookConfirmation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Confirmations_ConfirmationId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ConfirmationId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ConfirmationId",
                table: "Books");

            migrationBuilder.AddColumn<Guid>(
                name: "BookId",
                table: "Confirmations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Confirmations_BookId",
                table: "Confirmations",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Confirmations_Books_BookId",
                table: "Confirmations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Confirmations_Books_BookId",
                table: "Confirmations");

            migrationBuilder.DropIndex(
                name: "IX_Confirmations_BookId",
                table: "Confirmations");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Confirmations");

            migrationBuilder.AddColumn<Guid>(
                name: "ConfirmationId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Books_ConfirmationId",
                table: "Books",
                column: "ConfirmationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Confirmations_ConfirmationId",
                table: "Books",
                column: "ConfirmationId",
                principalTable: "Confirmations",
                principalColumn: "ConfirmationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
