using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OddsAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityAndHistoryTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: true),
                    Metadata = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OddsHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OddsId = table.Column<Guid>(type: "uuid", nullable: false),
                    PreviousPrice = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    NewPrice = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    ChangeReason = table.Column<string>(type: "text", nullable: false),
                    MarketContext = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OddsHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OddsHistory_Odds_OddsId",
                        column: x => x.OddsId,
                        principalTable: "Odds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityInterests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    NotifyOnOddsChange = table.Column<bool>(type: "boolean", nullable: false),
                    NotifyOnNewMarkets = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityInterests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityInterests_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ExternalId",
                table: "Entities",
                column: "ExternalId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_Type",
                table: "Entities",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_EntityInterests_EntityId",
                table: "EntityInterests",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityInterests_UserId",
                table: "EntityInterests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OddsHistory_OddsId",
                table: "OddsHistory",
                column: "OddsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityInterests");

            migrationBuilder.DropTable(
                name: "OddsHistory");

            migrationBuilder.DropTable(
                name: "Entities");
        }
    }
}
