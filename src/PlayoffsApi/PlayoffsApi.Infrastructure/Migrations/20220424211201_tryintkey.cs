using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PlayoffsApi.Infrastructure.Migrations
{
    public partial class tryintkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    TemperatureF = table.Column<int>(type: "integer", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(440), "Warm", -3, 27 },
                    { 2, new DateTime(2022, 4, 26, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(481), "Warm", 1, 33 },
                    { 3, new DateTime(2022, 4, 27, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(483), "Bracing", 36, 96 },
                    { 4, new DateTime(2022, 4, 28, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(485), "Freezing", 13, 55 },
                    { 5, new DateTime(2022, 4, 29, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(488), "Hot", 22, 71 },
                    { 6, new DateTime(2022, 4, 30, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(490), "Chilly", -18, 0 },
                    { 7, new DateTime(2022, 5, 1, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(492), "Warm", 13, 55 },
                    { 8, new DateTime(2022, 5, 2, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(494), "Warm", 11, 51 },
                    { 9, new DateTime(2022, 5, 3, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(496), "Balmy", 14, 57 },
                    { 10, new DateTime(2022, 5, 4, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(499), "Warm", 30, 85 },
                    { 11, new DateTime(2022, 5, 5, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(501), "Balmy", -9, 16 },
                    { 12, new DateTime(2022, 5, 6, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(503), "Hot", 9, 48 },
                    { 13, new DateTime(2022, 5, 7, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(505), "Mild", 5, 40 },
                    { 14, new DateTime(2022, 5, 8, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(507), "Bracing", 46, 114 },
                    { 15, new DateTime(2022, 5, 9, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(509), "Cool", 32, 89 },
                    { 16, new DateTime(2022, 5, 10, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(511), "Mild", 54, 129 },
                    { 17, new DateTime(2022, 5, 11, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(513), "Mild", 52, 125 },
                    { 18, new DateTime(2022, 5, 12, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(515), "Chilly", 21, 69 },
                    { 19, new DateTime(2022, 5, 13, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(517), "Cool", -17, 2 },
                    { 20, new DateTime(2022, 5, 14, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(519), "Mild", 43, 109 },
                    { 21, new DateTime(2022, 5, 15, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(521), "Freezing", -15, 6 },
                    { 22, new DateTime(2022, 5, 16, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(523), "Warm", 6, 42 },
                    { 23, new DateTime(2022, 5, 17, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(525), "Chilly", 9, 48 },
                    { 24, new DateTime(2022, 5, 18, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(527), "Freezing", 29, 84 },
                    { 25, new DateTime(2022, 5, 19, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(529), "Freezing", 6, 42 },
                    { 26, new DateTime(2022, 5, 20, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(531), "Scorching", 44, 111 },
                    { 27, new DateTime(2022, 5, 21, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(533), "Bracing", 38, 100 },
                    { 28, new DateTime(2022, 5, 22, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(535), "Freezing", 0, 32 },
                    { 29, new DateTime(2022, 5, 23, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(538), "Balmy", -3, 27 },
                    { 30, new DateTime(2022, 5, 24, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(540), "Mild", 34, 93 },
                    { 31, new DateTime(2022, 5, 25, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(542), "Warm", -3, 27 },
                    { 32, new DateTime(2022, 5, 26, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(544), "Bracing", -13, 9 },
                    { 33, new DateTime(2022, 5, 27, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(546), "Freezing", 20, 67 },
                    { 34, new DateTime(2022, 5, 28, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(548), "Bracing", 15, 58 },
                    { 35, new DateTime(2022, 5, 29, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(550), "Chilly", -15, 6 },
                    { 36, new DateTime(2022, 5, 30, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(552), "Chilly", 9, 48 },
                    { 37, new DateTime(2022, 5, 31, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(555), "Bracing", 17, 62 },
                    { 38, new DateTime(2022, 6, 1, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(557), "Chilly", 18, 64 },
                    { 39, new DateTime(2022, 6, 2, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(559), "Hot", 33, 91 },
                    { 40, new DateTime(2022, 6, 3, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(561), "Mild", -5, 24 },
                    { 41, new DateTime(2022, 6, 4, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(563), "Freezing", 30, 85 },
                    { 42, new DateTime(2022, 6, 5, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(565), "Freezing", -2, 29 },
                    { 43, new DateTime(2022, 6, 6, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(567), "Chilly", 4, 39 },
                    { 44, new DateTime(2022, 6, 7, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(569), "Chilly", 40, 103 },
                    { 45, new DateTime(2022, 6, 8, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(571), "Freezing", 45, 112 },
                    { 46, new DateTime(2022, 6, 9, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(573), "Cool", -7, 20 },
                    { 47, new DateTime(2022, 6, 10, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(575), "Balmy", -16, 4 },
                    { 48, new DateTime(2022, 6, 11, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(577), "Sweltering", 50, 121 },
                    { 49, new DateTime(2022, 6, 12, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(579), "Sweltering", 28, 82 },
                    { 50, new DateTime(2022, 6, 13, 23, 12, 0, 891, DateTimeKind.Local).AddTicks(581), "Scorching", -1, 31 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
