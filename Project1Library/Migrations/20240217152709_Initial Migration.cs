using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calcylate",
                columns: table => new
                {
                    CalcylateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tal1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tal2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resultat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calcylate", x => x.CalcylateId);
                });

            migrationBuilder.CreateTable(
                name: "RockPaperScissor",
                columns: table => new
                {
                    RPSId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vinst = table.Column<int>(type: "int", nullable: false),
                    Oavgjort = table.Column<int>(type: "int", nullable: false),
                    Förlust = table.Column<int>(type: "int", nullable: false),
                    Genomsnitt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpelarensDrag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatornsDrag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resultat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RockPaperScissor", x => x.RPSId);
                });

            migrationBuilder.CreateTable(
                name: "Shape",
                columns: table => new
                {
                    ShapeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShapeForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Circumference = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Side = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Lenght = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Base = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Katet1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Katet2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hypotenusan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shape", x => x.ShapeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calcylate");

            migrationBuilder.DropTable(
                name: "RockPaperScissor");

            migrationBuilder.DropTable(
                name: "Shape");
        }
    }
}
