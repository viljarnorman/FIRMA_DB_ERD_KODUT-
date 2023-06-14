using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIRMADB_VN.Migrations
{
    /// <inheritdoc />
    public partial class Firma_Kõik_Tabelid_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Objects");

            migrationBuilder.RenameColumn(
                name: "Vanus",
                table: "Töötaja",
                newName: "IdKood");

            migrationBuilder.RenameColumn(
                name: "Perenimi",
                table: "Töötaja",
                newName: "Nimi");

            migrationBuilder.RenameColumn(
                name: "Eesnimi",
                table: "Töötaja",
                newName: "ArveldusArve");

            migrationBuilder.RenameColumn(
                name: "Registrikood",
                table: "Haru",
                newName: "RegistriKood");

            migrationBuilder.AddColumn<string>(
                name: "Aadress",
                table: "Töötaja",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AmetinimetusteAjaluguId",
                table: "Töötaja",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HaruId",
                table: "Töötaja",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TöölepinguAlguseKuupäev",
                table: "Töötaja",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TöölepinguLõpuKuupäev",
                table: "Töötaja",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "AmetinimetusteNimekiri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ametinimetused = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmetinimetusteNimekiri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmetinimetusteNimekiri_Haru_HaruId",
                        column: x => x.HaruId,
                        principalTable: "Haru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haigusleht",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LiikHaiguslehtHooldusleht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaigusleheKestvusePikkus = table.Column<int>(type: "int", nullable: false),
                    HaigusleAvamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaigusleLõpetamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleht", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haigusleht_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaenutatavInventar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventariNimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaenutatavInventar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaenutatavInventar_Haru_HaruId",
                        column: x => x.HaruId,
                        principalTable: "Haru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TöötajaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laps_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Palved",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Olek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palved", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palved_Haru_HaruId",
                        column: x => x.HaruId,
                        principalTable: "Haru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Palved_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    PuhkuseLiik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuhkusePikkus = table.Column<int>(type: "int", nullable: false),
                    PuhkuseAlguseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuhkuseLõpuKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkused_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    SooritamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KehtivuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Piirangud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abivahendid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Olek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vihjed_Haru_HaruId",
                        column: x => x.HaruId,
                        principalTable: "Haru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AmetinimetusteAjalugu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ametinimetused = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmetinimetusteNimekiriId = table.Column<int>(type: "int", nullable: false),
                    AmetisseMääramiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmetisOldudAeg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmetinimetusteAjalugu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmetinimetusteAjalugu_AmetinimetusteNimekiri_AmetinimetusteNimekiriId",
                        column: x => x.AmetinimetusteNimekiriId,
                        principalTable: "AmetinimetusteNimekiri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuluba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmetinimetusteNimekiriId = table.Column<int>(type: "int", nullable: false),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KehtivuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KehtivuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuluba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipääsuluba_AmetinimetusteNimekiri_AmetinimetusteNimekiriId",
                        column: x => x.AmetinimetusteNimekiriId,
                        principalTable: "AmetinimetusteNimekiri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ligipääsuluba_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventariNimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaenutatavInventarId = table.Column<int>(type: "int", nullable: false),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LaenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutus_LaenutatavInventar_LaenutatavInventarId",
                        column: x => x.LaenutatavInventarId,
                        principalTable: "LaenutatavInventar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laenutus_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TöötajaLapsSeos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LapsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TöötajaLapsSeos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TöötajaLapsSeos_Laps_LapsId",
                        column: x => x.LapsId,
                        principalTable: "Laps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TöötajaLapsSeos_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_AmetinimetusteAjaluguId",
                table: "Töötaja",
                column: "AmetinimetusteAjaluguId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_HaruId",
                table: "Töötaja",
                column: "HaruId");

            migrationBuilder.CreateIndex(
                name: "IX_AmetinimetusteAjalugu_AmetinimetusteNimekiriId",
                table: "AmetinimetusteAjalugu",
                column: "AmetinimetusteNimekiriId");

            migrationBuilder.CreateIndex(
                name: "IX_AmetinimetusteNimekiri_HaruId",
                table: "AmetinimetusteNimekiri",
                column: "HaruId");

            migrationBuilder.CreateIndex(
                name: "IX_Haigusleht_TöötajaId",
                table: "Haigusleht",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_LaenutatavInventar_HaruId",
                table: "LaenutatavInventar",
                column: "HaruId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_LaenutatavInventarId",
                table: "Laenutus",
                column: "LaenutatavInventarId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_TöötajaId",
                table: "Laenutus",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laps_TöötajaId",
                table: "Laps",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuluba_AmetinimetusteNimekiriId",
                table: "Ligipääsuluba",
                column: "AmetinimetusteNimekiriId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuluba_TöötajaId",
                table: "Ligipääsuluba",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Palved_HaruId",
                table: "Palved",
                column: "HaruId");

            migrationBuilder.CreateIndex(
                name: "IX_Palved_TöötajaId",
                table: "Palved",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_TöötajaId",
                table: "Puhkused",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_TöötajaId",
                table: "Tervisekontroll",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaLapsSeos_LapsId",
                table: "TöötajaLapsSeos",
                column: "LapsId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaLapsSeos_TöötajaId",
                table: "TöötajaLapsSeos",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vihjed_HaruId",
                table: "Vihjed",
                column: "HaruId");

            migrationBuilder.AddForeignKey(
                name: "FK_Töötaja_AmetinimetusteAjalugu_AmetinimetusteAjaluguId",
                table: "Töötaja",
                column: "AmetinimetusteAjaluguId",
                principalTable: "AmetinimetusteAjalugu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Töötaja_Haru_HaruId",
                table: "Töötaja",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Töötaja_AmetinimetusteAjalugu_AmetinimetusteAjaluguId",
                table: "Töötaja");

            migrationBuilder.DropForeignKey(
                name: "FK_Töötaja_Haru_HaruId",
                table: "Töötaja");

            migrationBuilder.DropTable(
                name: "AmetinimetusteAjalugu");

            migrationBuilder.DropTable(
                name: "Haigusleht");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Ligipääsuluba");

            migrationBuilder.DropTable(
                name: "Palved");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "TöötajaLapsSeos");

            migrationBuilder.DropTable(
                name: "Vihjed");

            migrationBuilder.DropTable(
                name: "LaenutatavInventar");

            migrationBuilder.DropTable(
                name: "AmetinimetusteNimekiri");

            migrationBuilder.DropTable(
                name: "Laps");

            migrationBuilder.DropIndex(
                name: "IX_Töötaja_AmetinimetusteAjaluguId",
                table: "Töötaja");

            migrationBuilder.DropIndex(
                name: "IX_Töötaja_HaruId",
                table: "Töötaja");

            migrationBuilder.DropColumn(
                name: "Aadress",
                table: "Töötaja");

            migrationBuilder.DropColumn(
                name: "AmetinimetusteAjaluguId",
                table: "Töötaja");

            migrationBuilder.DropColumn(
                name: "HaruId",
                table: "Töötaja");

            migrationBuilder.DropColumn(
                name: "TöölepinguAlguseKuupäev",
                table: "Töötaja");

            migrationBuilder.DropColumn(
                name: "TöölepinguLõpuKuupäev",
                table: "Töötaja");

            migrationBuilder.RenameColumn(
                name: "Nimi",
                table: "Töötaja",
                newName: "Perenimi");

            migrationBuilder.RenameColumn(
                name: "IdKood",
                table: "Töötaja",
                newName: "Vanus");

            migrationBuilder.RenameColumn(
                name: "ArveldusArve",
                table: "Töötaja",
                newName: "Eesnimi");

            migrationBuilder.RenameColumn(
                name: "RegistriKood",
                table: "Haru",
                newName: "Registrikood");

            migrationBuilder.CreateTable(
                name: "Objects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vanus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objects", x => x.Id);
                });
        }
    }
}
