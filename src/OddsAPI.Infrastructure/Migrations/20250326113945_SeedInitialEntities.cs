using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OddsAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "CreatedAt", "Description", "ExternalId", "IsActive", "Metadata", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("106f83bb-d875-49b6-9c45-5c6db80464c6"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Giannis Antetokounmpo", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("16d4a652-fbb2-4666-b6fb-73a2e3e432e0"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Liverpool", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("1c1d7ee5-f87e-4db7-adff-c96e1994448e"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Ireland", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("1c622bc5-ce9c-4356-8e8d-95a5249efb90"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Ardie Savea", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("1da8c331-527d-4a45-8356-e354646d0d45"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Manchester United", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("223366ed-bcd6-4413-95f5-4cdbca6eaf73"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Kylian Mbappé", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("2b2e321b-add5-4ff5-8b2e-349a8b86ab41"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Jannik Sinner", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("2e358c37-2348-46db-aef6-51a1adeaa034"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "France", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("36da8f91-8436-4476-a021-ff3e78668b3c"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Real Madrid", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("3c449444-d831-432e-bba1-e83a83bd953a"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "New Zealand", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("446f0c4d-3b81-4d5e-89b2-ce23a10b5350"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Christian McCaffrey", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("4a06fe75-ea9a-4ce4-b693-3c003f953a75"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Dallas Cowboys", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("4c1ed276-4903-4079-92de-78d982833c18"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Carlos Alcaraz", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("4c9cad3a-d54f-44da-a91a-b8a41eae0e03"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Erling Haaland", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("50f4657e-48d4-4736-99b8-24b885321ecd"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Patrick Mahomes", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("51b9fa76-4256-4cd9-b1c2-ce3cf3c84641"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Miami Heat", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("52f804a7-0fbd-46ef-b114-6ad9bb3180c6"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Golden State Warriors", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("62f8582a-f218-4f3e-8e8c-a30602ffb76d"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Antoine Dupont", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("73135895-d36c-4056-b8da-ac52368ce47b"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Los Angeles Lakers", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("775246a3-80f9-490b-98de-c3e8c078c34d"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Nikola Jokić", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("80b060e8-6e8f-4b65-a31c-6f6ff1a9a9f0"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "LeBron James", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("82aa09f6-abce-4f7e-b6c9-f42d96322549"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Rugby Union", "Sport", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("851ef7f9-2d26-4565-bc76-130ff3512e3a"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "South Africa", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("85ab3cff-a75e-4d01-b612-8af393317655"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Kevin Durant", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("8643d8d6-8117-49ae-a378-2d5169d4a6a1"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Stephen Curry", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("89bbb87e-1d9d-43ed-8090-e362db275d72"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Vinicius Jr", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("94e6df03-2500-4025-ab59-3327de45c96c"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Novak Djokovic", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("9f254c49-d46d-4e4d-87c3-2221ca089641"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Alexander Zverev", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("a1538d9c-0bc5-4f2f-ad56-e71a29d08f29"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Eben Etzebeth", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("a34eafd7-6299-4efd-b4d7-525e73100594"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Green Bay Packers", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("ab7675fa-a4e6-4201-b1be-1759994217d2"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Daniil Medvedev", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("acf1e2d5-ff24-4000-ade0-8b873cf82a73"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "England", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("bb9b55ce-c17d-49cf-bd78-c3559c64fe6e"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Justin Jefferson", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("be23a3e5-3179-432f-abc4-db42befa8ec7"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Maro Itoje", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("c351f102-476a-4d76-8eca-4a5bace1d253"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Football", "Sport", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("c4ae4402-3719-4a9b-a987-b59d932d97e4"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Myles Garrett", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("c8942c7f-342b-44b1-96bf-a96598f788c9"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Caelan Doris", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("ccad54f4-f538-4666-9c26-7fbca1ff3475"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "San Francisco 49ers", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("d18cc3a7-0412-43f9-bca5-9a18f6cadf34"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Tennis", "Sport", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("d3611ff2-e124-451e-add7-a563cff6f5d7"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Jude Bellingham", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e09a4cf6-e1cf-4fa9-b30c-cc3527ff5c25"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Boston Celtics", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e0adb06c-ca95-42df-b803-e8dff135cedc"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Kansas City Chiefs", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e1e336f0-7393-4ec2-a6ac-20746b115ba8"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Bayern Munich", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e3a638d5-9f57-4707-b91d-ea1477aedb2b"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Barcelona", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e7e0e4d8-de28-4a1e-a3ec-97deffea867d"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Chicago Bulls", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e8391225-3b4f-4001-8871-7c1c2821227d"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "American Football", "Sport", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("e9c0d886-2966-4d50-b18d-b3b2d34ed9cf"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Basketball", "Sport", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("ecd2d6d8-1ac6-4b7f-9932-b878e1625f1b"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Kevin De Bruyne", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("ef8b7238-f461-4762-a8cb-6744318396ff"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "New England Patriots", "Team", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) },
                    { new Guid("f6fa2452-5a03-47c6-8aa4-5fd0f694f6fb"), new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860), null, null, true, null, "Brock Purdy", "Player", new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("106f83bb-d875-49b6-9c45-5c6db80464c6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("16d4a652-fbb2-4666-b6fb-73a2e3e432e0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1c1d7ee5-f87e-4db7-adff-c96e1994448e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1c622bc5-ce9c-4356-8e8d-95a5249efb90"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1da8c331-527d-4a45-8356-e354646d0d45"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("223366ed-bcd6-4413-95f5-4cdbca6eaf73"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2b2e321b-add5-4ff5-8b2e-349a8b86ab41"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2e358c37-2348-46db-aef6-51a1adeaa034"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("36da8f91-8436-4476-a021-ff3e78668b3c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3c449444-d831-432e-bba1-e83a83bd953a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("446f0c4d-3b81-4d5e-89b2-ce23a10b5350"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4a06fe75-ea9a-4ce4-b693-3c003f953a75"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4c1ed276-4903-4079-92de-78d982833c18"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4c9cad3a-d54f-44da-a91a-b8a41eae0e03"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("50f4657e-48d4-4736-99b8-24b885321ecd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("51b9fa76-4256-4cd9-b1c2-ce3cf3c84641"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("52f804a7-0fbd-46ef-b114-6ad9bb3180c6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("62f8582a-f218-4f3e-8e8c-a30602ffb76d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("73135895-d36c-4056-b8da-ac52368ce47b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("775246a3-80f9-490b-98de-c3e8c078c34d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("80b060e8-6e8f-4b65-a31c-6f6ff1a9a9f0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("82aa09f6-abce-4f7e-b6c9-f42d96322549"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("851ef7f9-2d26-4565-bc76-130ff3512e3a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("85ab3cff-a75e-4d01-b612-8af393317655"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8643d8d6-8117-49ae-a378-2d5169d4a6a1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("89bbb87e-1d9d-43ed-8090-e362db275d72"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("94e6df03-2500-4025-ab59-3327de45c96c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9f254c49-d46d-4e4d-87c3-2221ca089641"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a1538d9c-0bc5-4f2f-ad56-e71a29d08f29"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a34eafd7-6299-4efd-b4d7-525e73100594"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ab7675fa-a4e6-4201-b1be-1759994217d2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("acf1e2d5-ff24-4000-ade0-8b873cf82a73"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bb9b55ce-c17d-49cf-bd78-c3559c64fe6e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("be23a3e5-3179-432f-abc4-db42befa8ec7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c351f102-476a-4d76-8eca-4a5bace1d253"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c4ae4402-3719-4a9b-a987-b59d932d97e4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c8942c7f-342b-44b1-96bf-a96598f788c9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ccad54f4-f538-4666-9c26-7fbca1ff3475"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d18cc3a7-0412-43f9-bca5-9a18f6cadf34"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d3611ff2-e124-451e-add7-a563cff6f5d7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e09a4cf6-e1cf-4fa9-b30c-cc3527ff5c25"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e0adb06c-ca95-42df-b803-e8dff135cedc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e1e336f0-7393-4ec2-a6ac-20746b115ba8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e3a638d5-9f57-4707-b91d-ea1477aedb2b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e7e0e4d8-de28-4a1e-a3ec-97deffea867d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e8391225-3b4f-4001-8871-7c1c2821227d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e9c0d886-2966-4d50-b18d-b3b2d34ed9cf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ecd2d6d8-1ac6-4b7f-9932-b878e1625f1b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef8b7238-f461-4762-a8cb-6744318396ff"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f6fa2452-5a03-47c6-8aa4-5fd0f694f6fb"));
        }
    }
}
