using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class FirmaERD1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "workers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "children",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.ID);
                    table.ForeignKey(
                        name: "FK_children_workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rentings",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rentings_workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sickDays",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<DateTime>(nullable: false),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sickDays", x => x.ID);
                    table.ForeignKey(
                        name: "FK_sickDays_workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vacations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vacations_workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkerProffessions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerProffessions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkerProffessions_workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_children_WorkerID",
                table: "children",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Rentings_WorkerID",
                table: "Rentings",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_sickDays_WorkerID",
                table: "sickDays",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_vacations_WorkerID",
                table: "vacations",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerProffessions_WorkerID",
                table: "WorkerProffessions",
                column: "WorkerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "children");

            migrationBuilder.DropTable(
                name: "Rentings");

            migrationBuilder.DropTable(
                name: "sickDays");

            migrationBuilder.DropTable(
                name: "vacations");

            migrationBuilder.DropTable(
                name: "WorkerProffessions");

            migrationBuilder.DropTable(
                name: "workers");

            migrationBuilder.CreateTable(
                name: "Töötajad",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötajad", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetused",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Põhjus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöötajaID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Põhjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sünnipäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöötajaID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Põhjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
    }
}
