using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthApp.Storage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HealthApp");

            migrationBuilder.CreateTable(
                name: "MonitoringDevices",
                schema: "HealthApp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoringDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "HealthApp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthData",
                schema: "HealthApp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Pulse = table.Column<int>(type: "integer", nullable: false),
                    ActivityLevel = table.Column<int>(type: "integer", nullable: false),
                    Dream = table.Column<int>(type: "integer", nullable: false),
                    Steps = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthData_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "HealthApp",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthRepors",
                schema: "HealthApp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Decription = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRepors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRepors_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "HealthApp",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthData_UserId",
                schema: "HealthApp",
                table: "HealthData",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRepors_UserId",
                schema: "HealthApp",
                table: "HealthRepors",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthData",
                schema: "HealthApp");

            migrationBuilder.DropTable(
                name: "HealthRepors",
                schema: "HealthApp");

            migrationBuilder.DropTable(
                name: "MonitoringDevices",
                schema: "HealthApp");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "HealthApp");
        }
    }
}
