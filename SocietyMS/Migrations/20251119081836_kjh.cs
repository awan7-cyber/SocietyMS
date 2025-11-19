using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocietyMS.Migrations
{
    /// <inheritdoc />
    public partial class kjh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Blk_Id",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlockssId",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Plots_BlockssId",
                table: "Plots",
                column: "BlockssId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plots_Blocks_BlockssId",
                table: "Plots",
                column: "BlockssId",
                principalTable: "Blocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plots_Blocks_BlockssId",
                table: "Plots");

            migrationBuilder.DropIndex(
                name: "IX_Plots_BlockssId",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "Blk_Id",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "BlockssId",
                table: "Plots");
        }
    }
}
