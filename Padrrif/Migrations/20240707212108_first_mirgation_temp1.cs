using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Padrrif.Migrations
{
    /// <inheritdoc />
    public partial class first_mirgation_temp1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GovernorateId",
                table: "Village",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Village_GovernorateId",
                table: "Village",
                column: "GovernorateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Village_Governorate_GovernorateId",
                table: "Village",
                column: "GovernorateId",
                principalTable: "Governorate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Village_Governorate_GovernorateId",
                table: "Village");

            migrationBuilder.DropIndex(
                name: "IX_Village_GovernorateId",
                table: "Village");

            migrationBuilder.DropColumn(
                name: "GovernorateId",
                table: "Village");
        }
    }
}
