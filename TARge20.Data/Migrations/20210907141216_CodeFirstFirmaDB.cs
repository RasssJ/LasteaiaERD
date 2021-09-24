using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class CodeFirstFirmaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Töötajad",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Eesnimi = table.Column<string>(nullable: true),
                    Perenimi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötajad", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetused",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nimetus = table.Column<string>(nullable: true),
                    TöötajaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetused", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ametinimetused_Töötajad_TöötajaID",
                        column: x => x.TöötajaID,
                        principalTable: "Töötajad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Algus = table.Column<DateTime>(nullable: false),
                    Lõpp = table.Column<DateTime>(nullable: false),
                    Põhjus = table.Column<DateTime>(nullable: false),
                    TöötajaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Töötajad_TöötajaID",
                        column: x => x.TöötajaID,
                        principalTable: "Töötajad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenutused",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Algus = table.Column<DateTime>(nullable: false),
                    Lõpp = table.Column<DateTime>(nullable: false),
                    Põhjus = table.Column<string>(nullable: true),
                    TöötajaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutused", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Laenutused_Töötajad_TöötajaID",
                        column: x => x.TöötajaID,
                        principalTable: "Töötajad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lapsed",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nimi = table.Column<string>(nullable: true),
                    Sünnipäev = table.Column<DateTime>(nullable: false),
                    TöötajaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapsed", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lapsed_Töötajad_TöötajaID",
                        column: x => x.TöötajaID,
                        principalTable: "Töötajad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Algus = table.Column<DateTime>(nullable: false),
                    Lõpp = table.Column<DateTime>(nullable: false),
                    Põhjus = table.Column<string>(nullable: true),
                    TöötajaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Puhkused_Töötajad_TöötajaID",
                        column: x => x.TöötajaID,
                        principalTable: "Töötajad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetused_TöötajaID",
                table: "Ametinimetused",
                column: "TöötajaID");

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_TöötajaID",
                table: "Haiguslehed",
                column: "TöötajaID");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutused_TöötajaID",
                table: "Laenutused",
                column: "TöötajaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lapsed_TöötajaID",
                table: "Lapsed",
                column: "TöötajaID");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_TöötajaID",
                table: "Puhkused",
                column: "TöötajaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ametinimetused");

            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutused");

            migrationBuilder.DropTable(
                name: "Lapsed");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Töötajad");
        }
    }
}
