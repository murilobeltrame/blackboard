using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blackboard.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anomalies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnomalyType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VehicleLicensePlate = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LoadKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Closed = table.Column<bool>(type: "bit", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anomalies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssociatedVehicleLicensePlate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssociationStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastKnownPositionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Monitored = table.Column<bool>(type: "bit", nullable: false),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Scaled = table.Column<bool>(type: "bit", nullable: true),
                    EventName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anomalies_LoadKey",
                table: "Anomalies",
                column: "LoadKey");

            migrationBuilder.CreateIndex(
                name: "IX_Anomalies_VehicleLicensePlate",
                table: "Anomalies",
                column: "VehicleLicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_DocumentNumber",
                table: "Loads",
                column: "DocumentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_DocumentType",
                table: "Loads",
                column: "DocumentType");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_Key",
                table: "Loads",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePositions_LicensePlate",
                table: "VehiclePositions",
                column: "LicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_LicensePlate",
                table: "Vehicles",
                column: "LicensePlate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anomalies");

            migrationBuilder.DropTable(
                name: "Loads");

            migrationBuilder.DropTable(
                name: "VehiclePositions");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
