using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocietyMS.Migrations
{
    /// <inheritdoc />
    public partial class jhj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Block_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Block_Id);
                });

            migrationBuilder.CreateTable(
                name: "Charges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personalinfos",
                columns: table => new
                {
                    member_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CnicNo = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    postaladress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    permanentadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    membercast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneno = table.Column<int>(type: "int", nullable: false),
                    Kin_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kin_Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kin_cnic = table.Column<int>(type: "int", nullable: false),
                    kin_adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personalinfos", x => x.member_id);
                });

            migrationBuilder.CreateTable(
                name: "Trsfrmemberships",
                columns: table => new
                {
                    transfer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<int>(type: "int", nullable: false),
                    past_member_id = table.Column<int>(type: "int", nullable: false),
                    new_member_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trsfrmemberships", x => x.transfer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Membershipinfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personal_Id = table.Column<int>(type: "int", nullable: false),
                    Personalinfomember_id = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charges = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membershipinfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Membershipinfos_Personalinfos_Personalinfomember_id",
                        column: x => x.Personalinfomember_id,
                        principalTable: "Personalinfos",
                        principalColumn: "member_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    membershipId = table.Column<int>(type: "int", nullable: false),
                    membershipinfoId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dues_Membershipinfos_membershipinfoId",
                        column: x => x.membershipinfoId,
                        principalTable: "Membershipinfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dues_membershipinfoId",
                table: "Dues",
                column: "membershipinfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Membershipinfos_Personalinfomember_id",
                table: "Membershipinfos",
                column: "Personalinfomember_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "Dues");

            migrationBuilder.DropTable(
                name: "Trsfrmemberships");

            migrationBuilder.DropTable(
                name: "Membershipinfos");

            migrationBuilder.DropTable(
                name: "Personalinfos");
        }
    }
}
