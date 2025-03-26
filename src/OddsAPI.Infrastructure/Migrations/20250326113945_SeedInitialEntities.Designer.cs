﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OddsAPI.Infrastructure.Data;

#nullable disable

namespace OddsAPI.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250326113945_SeedInitialEntities")]
    partial class SeedInitialEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OddsAPI.Core.Entities.Entity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Metadata")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ExternalId");

                    b.HasIndex("Type");

                    b.ToTable("Entities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e9c0d886-2966-4d50-b18d-b3b2d34ed9cf"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Basketball",
                            Type = "Sport",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("d18cc3a7-0412-43f9-bca5-9a18f6cadf34"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Tennis",
                            Type = "Sport",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("c351f102-476a-4d76-8eca-4a5bace1d253"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Football",
                            Type = "Sport",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("82aa09f6-abce-4f7e-b6c9-f42d96322549"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Rugby Union",
                            Type = "Sport",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("e8391225-3b4f-4001-8871-7c1c2821227d"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "American Football",
                            Type = "Sport",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("73135895-d36c-4056-b8da-ac52368ce47b"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Los Angeles Lakers",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("52f804a7-0fbd-46ef-b114-6ad9bb3180c6"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Golden State Warriors",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("e09a4cf6-e1cf-4fa9-b30c-cc3527ff5c25"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Boston Celtics",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("e7e0e4d8-de28-4a1e-a3ec-97deffea867d"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Chicago Bulls",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("51b9fa76-4256-4cd9-b1c2-ce3cf3c84641"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Miami Heat",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("1da8c331-527d-4a45-8356-e354646d0d45"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Manchester United",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("36da8f91-8436-4476-a021-ff3e78668b3c"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Real Madrid",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("e3a638d5-9f57-4707-b91d-ea1477aedb2b"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Barcelona",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("e1e336f0-7393-4ec2-a6ac-20746b115ba8"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Bayern Munich",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("16d4a652-fbb2-4666-b6fb-73a2e3e432e0"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Liverpool",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("3c449444-d831-432e-bba1-e83a83bd953a"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "New Zealand",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("851ef7f9-2d26-4565-bc76-130ff3512e3a"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "South Africa",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("acf1e2d5-ff24-4000-ade0-8b873cf82a73"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "England",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("1c1d7ee5-f87e-4db7-adff-c96e1994448e"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Ireland",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("2e358c37-2348-46db-aef6-51a1adeaa034"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "France",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("e0adb06c-ca95-42df-b803-e8dff135cedc"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Kansas City Chiefs",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("ccad54f4-f538-4666-9c26-7fbca1ff3475"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "San Francisco 49ers",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("4a06fe75-ea9a-4ce4-b693-3c003f953a75"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Dallas Cowboys",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("a34eafd7-6299-4efd-b4d7-525e73100594"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Green Bay Packers",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("ef8b7238-f461-4762-a8cb-6744318396ff"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "New England Patriots",
                            Type = "Team",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("80b060e8-6e8f-4b65-a31c-6f6ff1a9a9f0"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "LeBron James",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("8643d8d6-8117-49ae-a378-2d5169d4a6a1"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Stephen Curry",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("85ab3cff-a75e-4d01-b612-8af393317655"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Kevin Durant",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("106f83bb-d875-49b6-9c45-5c6db80464c6"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Giannis Antetokounmpo",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("775246a3-80f9-490b-98de-c3e8c078c34d"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Nikola Jokić",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("94e6df03-2500-4025-ab59-3327de45c96c"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Novak Djokovic",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("4c1ed276-4903-4079-92de-78d982833c18"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Carlos Alcaraz",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("ab7675fa-a4e6-4201-b1be-1759994217d2"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Daniil Medvedev",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("2b2e321b-add5-4ff5-8b2e-349a8b86ab41"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Jannik Sinner",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("9f254c49-d46d-4e4d-87c3-2221ca089641"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Alexander Zverev",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("4c9cad3a-d54f-44da-a91a-b8a41eae0e03"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Erling Haaland",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("223366ed-bcd6-4413-95f5-4cdbca6eaf73"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Kylian Mbappé",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("d3611ff2-e124-451e-add7-a563cff6f5d7"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Jude Bellingham",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("89bbb87e-1d9d-43ed-8090-e362db275d72"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Vinicius Jr",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("ecd2d6d8-1ac6-4b7f-9932-b878e1625f1b"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Kevin De Bruyne",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("62f8582a-f218-4f3e-8e8c-a30602ffb76d"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Antoine Dupont",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("1c622bc5-ce9c-4356-8e8d-95a5249efb90"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Ardie Savea",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("a1538d9c-0bc5-4f2f-ad56-e71a29d08f29"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Eben Etzebeth",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("be23a3e5-3179-432f-abc4-db42befa8ec7"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Maro Itoje",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("c8942c7f-342b-44b1-96bf-a96598f788c9"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Caelan Doris",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("50f4657e-48d4-4736-99b8-24b885321ecd"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Patrick Mahomes",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("f6fa2452-5a03-47c6-8aa4-5fd0f694f6fb"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Brock Purdy",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("446f0c4d-3b81-4d5e-89b2-ce23a10b5350"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Christian McCaffrey",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("c4ae4402-3719-4a9b-a987-b59d932d97e4"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Myles Garrett",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        },
                        new
                        {
                            Id = new Guid("bb9b55ce-c17d-49cf-bd78-c3559c64fe6e"),
                            CreatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860),
                            IsActive = true,
                            Name = "Justin Jefferson",
                            Type = "Player",
                            UpdatedAt = new DateTime(2025, 3, 26, 11, 39, 45, 426, DateTimeKind.Utc).AddTicks(4860)
                        });
                });

            modelBuilder.Entity("OddsAPI.Core.Entities.EntityInterest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<bool>("NotifyOnNewMarkets")
                        .HasColumnType("boolean");

                    b.Property<bool>("NotifyOnOddsChange")
                        .HasColumnType("boolean");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("Tags")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("UserId");

                    b.ToTable("EntityInterests");
                });

            modelBuilder.Entity("OddsAPI.Core.Entities.Odds", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("MarketId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("Selection")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Odds");
                });

            modelBuilder.Entity("OddsAPI.Core.Entities.OddsHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ChangeReason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MarketContext")
                        .HasColumnType("text");

                    b.Property<decimal>("NewPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<Guid>("OddsId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("PreviousPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("OddsId");

                    b.ToTable("OddsHistory");
                });

            modelBuilder.Entity("OddsAPI.Core.Entities.EntityInterest", b =>
                {
                    b.HasOne("OddsAPI.Core.Entities.Entity", "Entity")
                        .WithMany("EntityInterests")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("OddsAPI.Core.Entities.OddsHistory", b =>
                {
                    b.HasOne("OddsAPI.Core.Entities.Odds", "Odds")
                        .WithMany()
                        .HasForeignKey("OddsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Odds");
                });

            modelBuilder.Entity("OddsAPI.Core.Entities.Entity", b =>
                {
                    b.Navigation("EntityInterests");
                });
#pragma warning restore 612, 618
        }
    }
}
