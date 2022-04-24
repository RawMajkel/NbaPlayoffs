using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayoffsApi.Infrastructure.Migrations
{
    public partial class uuidtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("36f1d51c-aeab-43a4-95ef-d0aee6c541ce"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("457fc787-eedd-4b80-b77e-ad27d9a17f52"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5d962d2c-92ee-481c-84e3-b3e2af87382f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5f55ce1a-f96c-411b-a0ad-5ea38c15d0d4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("781471d5-6a4e-4936-a00f-db47eeac1d78"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("952ab700-211c-4c3e-8585-617d71e8a918"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d24bec45-880d-4ac1-9f2a-a7f6af3fa374"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dde0933e-8b6c-4f32-94a2-89e584c73e35"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f21ea0dc-4077-4c80-b0de-70faf87f70c2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ffdff2b2-c061-4027-954f-bb2428444fd5"));

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[,]
                {
                    { new Guid("077afa32-f2b8-4dc7-9077-1c85a5d21c3f"), new DateTime(2022, 5, 2, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2632), "Hot", 35, 94 },
                    { new Guid("14debaa8-adcf-4a15-8414-0447a098abd9"), new DateTime(2022, 4, 26, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2603), "Cool", 47, 116 },
                    { new Guid("42980804-6af3-4bd8-ad77-f8769ecd8920"), new DateTime(2022, 4, 30, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2615), "Cool", 45, 112 },
                    { new Guid("4e7fac3d-f31d-4f9e-814c-a34280dfa486"), new DateTime(2022, 5, 3, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2635), "Bracing", 8, 46 },
                    { new Guid("6beffc68-f397-4e9a-ac1f-fb803893cc15"), new DateTime(2022, 4, 27, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2606), "Balmy", 30, 85 },
                    { new Guid("7af6971e-1f31-4ed6-be5b-bd4f15db3715"), new DateTime(2022, 4, 28, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2609), "Cool", -13, 9 },
                    { new Guid("93eaff97-d122-4fac-880b-80580a8ea322"), new DateTime(2022, 4, 25, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2543), "Freezing", 49, 120 },
                    { new Guid("96952a10-ce81-4fd0-8421-414266c96f73"), new DateTime(2022, 5, 1, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2618), "Chilly", 40, 103 },
                    { new Guid("a03625af-ba79-490d-b744-72ac3a6cb3c3"), new DateTime(2022, 4, 29, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2612), "Freezing", 46, 114 },
                    { new Guid("fa8f7338-3a43-4ab7-89a6-6463e9b5c6a4"), new DateTime(2022, 5, 4, 15, 7, 2, 177, DateTimeKind.Local).AddTicks(2637), "Bracing", 42, 107 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("077afa32-f2b8-4dc7-9077-1c85a5d21c3f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("14debaa8-adcf-4a15-8414-0447a098abd9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("42980804-6af3-4bd8-ad77-f8769ecd8920"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4e7fac3d-f31d-4f9e-814c-a34280dfa486"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6beffc68-f397-4e9a-ac1f-fb803893cc15"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7af6971e-1f31-4ed6-be5b-bd4f15db3715"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("93eaff97-d122-4fac-880b-80580a8ea322"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("96952a10-ce81-4fd0-8421-414266c96f73"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a03625af-ba79-490d-b744-72ac3a6cb3c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fa8f7338-3a43-4ab7-89a6-6463e9b5c6a4"));

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[,]
                {
                    { new Guid("36f1d51c-aeab-43a4-95ef-d0aee6c541ce"), new DateTime(2022, 4, 26, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5328), "Chilly", 31, 87 },
                    { new Guid("457fc787-eedd-4b80-b77e-ad27d9a17f52"), new DateTime(2022, 5, 2, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5351), "Cool", 15, 58 },
                    { new Guid("5d962d2c-92ee-481c-84e3-b3e2af87382f"), new DateTime(2022, 4, 25, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5325), "Balmy", -6, 22 },
                    { new Guid("5f55ce1a-f96c-411b-a0ad-5ea38c15d0d4"), new DateTime(2022, 5, 3, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5354), "Balmy", 12, 53 },
                    { new Guid("781471d5-6a4e-4936-a00f-db47eeac1d78"), new DateTime(2022, 5, 1, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5348), "Freezing", 10, 49 },
                    { new Guid("952ab700-211c-4c3e-8585-617d71e8a918"), new DateTime(2022, 4, 24, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5261), "Sweltering", 53, 127 },
                    { new Guid("d24bec45-880d-4ac1-9f2a-a7f6af3fa374"), new DateTime(2022, 4, 30, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5346), "Balmy", -14, 7 },
                    { new Guid("dde0933e-8b6c-4f32-94a2-89e584c73e35"), new DateTime(2022, 4, 28, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5333), "Freezing", 53, 127 },
                    { new Guid("f21ea0dc-4077-4c80-b0de-70faf87f70c2"), new DateTime(2022, 4, 27, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5330), "Warm", 49, 120 },
                    { new Guid("ffdff2b2-c061-4027-954f-bb2428444fd5"), new DateTime(2022, 4, 29, 20, 25, 28, 334, DateTimeKind.Local).AddTicks(5343), "Hot", 31, 87 }
                });
        }
    }
}
