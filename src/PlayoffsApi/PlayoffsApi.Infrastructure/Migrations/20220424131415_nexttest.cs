using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayoffsApi.Infrastructure.Migrations
{
    public partial class nexttest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("059fcfd7-e4dd-4e78-b666-51c4610b589f"), new DateTime(2022, 5, 1, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8945), "Scorching", -6, 22 },
                    { new Guid("390dcffc-aae8-4c94-85a8-a61483d072c0"), new DateTime(2022, 4, 27, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8927), "Cool", -7, 20 },
                    { new Guid("6a29b27c-9db1-4c6e-aeb6-55e682aa6c68"), new DateTime(2022, 4, 26, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8924), "Warm", 10, 49 },
                    { new Guid("8310bd52-7519-4d94-ae6f-6093795e7598"), new DateTime(2022, 5, 3, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8950), "Sweltering", 45, 112 },
                    { new Guid("9011ebf3-2c93-4208-88c4-ad212f7bc088"), new DateTime(2022, 4, 25, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8864), "Freezing", 31, 87 },
                    { new Guid("c7cb4021-71a2-4e2a-956a-90f7f336ccc7"), new DateTime(2022, 4, 28, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8930), "Chilly", 44, 111 },
                    { new Guid("d831e576-6f25-4bf4-b8e7-b2c85805c36b"), new DateTime(2022, 5, 4, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8952), "Bracing", 8, 46 },
                    { new Guid("db20a32e-a10d-4c86-abc5-3f38e40280ea"), new DateTime(2022, 4, 30, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8943), "Hot", -8, 18 },
                    { new Guid("dce9aa72-c89d-4afb-bbeb-e5951d3504f2"), new DateTime(2022, 4, 29, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8940), "Freezing", 3, 37 },
                    { new Guid("f38d7432-798a-43a6-a32c-84f1fac8c711"), new DateTime(2022, 5, 2, 15, 14, 14, 887, DateTimeKind.Local).AddTicks(8948), "Chilly", -12, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("059fcfd7-e4dd-4e78-b666-51c4610b589f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("390dcffc-aae8-4c94-85a8-a61483d072c0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a29b27c-9db1-4c6e-aeb6-55e682aa6c68"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8310bd52-7519-4d94-ae6f-6093795e7598"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9011ebf3-2c93-4208-88c4-ad212f7bc088"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c7cb4021-71a2-4e2a-956a-90f7f336ccc7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d831e576-6f25-4bf4-b8e7-b2c85805c36b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("db20a32e-a10d-4c86-abc5-3f38e40280ea"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dce9aa72-c89d-4afb-bbeb-e5951d3504f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f38d7432-798a-43a6-a32c-84f1fac8c711"));

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
    }
}
