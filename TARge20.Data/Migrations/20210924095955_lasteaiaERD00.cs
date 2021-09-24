using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class lasteaiaERD00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_children_workers_WorkerID",
                table: "children");

            migrationBuilder.DropForeignKey(
                name: "FK_vacations_workers_WorkerID",
                table: "vacations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerProffessions_workers_WorkerID",
                table: "WorkerProffessions");

            migrationBuilder.DropTable(
                name: "Rentings");

            migrationBuilder.DropTable(
                name: "sickDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_workers",
                table: "workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vacations",
                table: "vacations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_children",
                table: "children");

            migrationBuilder.RenameTable(
                name: "workers",
                newName: "Workers");

            migrationBuilder.RenameTable(
                name: "vacations",
                newName: "Vacations");

            migrationBuilder.RenameTable(
                name: "children",
                newName: "Children");

            migrationBuilder.RenameIndex(
                name: "IX_vacations_WorkerID",
                table: "Vacations",
                newName: "IX_Vacations_WorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_children_WorkerID",
                table: "Children",
                newName: "IX_Children_WorkerID");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkerID",
                table: "Workers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacations",
                table: "Vacations",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Children",
                table: "Children",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Absences",
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
                    table.PrimaryKey("PK_Absences", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Absences_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CookIDs",
                columns: table => new
                {
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    PositionID = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookIDs", x => x.FirstName);
                    table.ForeignKey(
                        name: "FK_CookIDs_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EatingHistories",
                columns: table => new
                {
                    Date = table.Column<string>(nullable: false),
                    Dish = table.Column<string>(nullable: true),
                    Portions = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatingHistories", x => x.Date);
                    table.ForeignKey(
                        name: "FK_EatingHistories_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    GroupType = table.Column<string>(nullable: true),
                    NumberOfPeople = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Groups_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KitchenMenus",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Dish = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    ToGroup = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenMenus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KitchenMenus_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PositionIDs",
                columns: table => new
                {
                    PositionType = table.Column<string>(nullable: false),
                    PositionName = table.Column<string>(nullable: true),
                    WorkerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionIDs", x => x.PositionType);
                    table.ForeignKey(
                        name: "FK_PositionIDs_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorkerID",
                table: "Workers",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_WorkerID",
                table: "Absences",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_CookIDs_WorkerID",
                table: "CookIDs",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_EatingHistories_WorkerID",
                table: "EatingHistories",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_WorkerID",
                table: "Groups",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_KitchenMenus_WorkerID",
                table: "KitchenMenus",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_PositionIDs_WorkerID",
                table: "PositionIDs",
                column: "WorkerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Workers_WorkerID",
                table: "Children",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Workers_WorkerID",
                table: "Vacations",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerProffessions_Workers_WorkerID",
                table: "WorkerProffessions",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Workers_WorkerID",
                table: "Workers",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Workers_WorkerID",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Workers_WorkerID",
                table: "Vacations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerProffessions_Workers_WorkerID",
                table: "WorkerProffessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Workers_WorkerID",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Absences");

            migrationBuilder.DropTable(
                name: "CookIDs");

            migrationBuilder.DropTable(
                name: "EatingHistories");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "KitchenMenus");

            migrationBuilder.DropTable(
                name: "PositionIDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorkerID",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacations",
                table: "Vacations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Children",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "WorkerID",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "workers");

            migrationBuilder.RenameTable(
                name: "Vacations",
                newName: "vacations");

            migrationBuilder.RenameTable(
                name: "Children",
                newName: "children");

            migrationBuilder.RenameIndex(
                name: "IX_Vacations_WorkerID",
                table: "vacations",
                newName: "IX_vacations_WorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_Children_WorkerID",
                table: "children",
                newName: "IX_children_WorkerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workers",
                table: "workers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vacations",
                table: "vacations",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_children",
                table: "children",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Rentings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Rentings_WorkerID",
                table: "Rentings",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_sickDays_WorkerID",
                table: "sickDays",
                column: "WorkerID");

            migrationBuilder.AddForeignKey(
                name: "FK_children_workers_WorkerID",
                table: "children",
                column: "WorkerID",
                principalTable: "workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vacations_workers_WorkerID",
                table: "vacations",
                column: "WorkerID",
                principalTable: "workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerProffessions_workers_WorkerID",
                table: "WorkerProffessions",
                column: "WorkerID",
                principalTable: "workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
