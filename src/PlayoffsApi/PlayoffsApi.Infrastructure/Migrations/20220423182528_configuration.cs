using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayoffsApi.Infrastructure.Migrations
{
    public partial class configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2de75c7a-9cf5-4e3c-986f-eb5103565128"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("30614f19-b700-4156-9a21-e8a40a760c6f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("772d9eec-da84-4ba4-8046-c2022882b040"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8b1d6012-2294-4135-a7f3-dfe8f3b81366"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b380705e-4b0e-4b89-9984-196727e9c72d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c08f0d4b-f28d-4aa7-b3b4-7970936b9805"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c55b964b-4a14-4353-81ca-3f4584682d93"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d5a37545-9b6c-4d64-8081-bd2964ee2373"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e8e21bfc-8c21-446c-9702-896ee538a54e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd89c10b-8f82-45f7-86bb-9cd08d4feb6e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("2de75c7a-9cf5-4e3c-986f-eb5103565128"), new DateTime(2022, 5, 1, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3765), "Warm", 52, 125 },
                    { new Guid("30614f19-b700-4156-9a21-e8a40a760c6f"), new DateTime(2022, 4, 27, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3753), "Chilly", 48, 118 },
                    { new Guid("772d9eec-da84-4ba4-8046-c2022882b040"), new DateTime(2022, 4, 30, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3762), "Freezing", -1, 31 },
                    { new Guid("8b1d6012-2294-4135-a7f3-dfe8f3b81366"), new DateTime(2022, 5, 2, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3777), "Freezing", -17, 2 },
                    { new Guid("b380705e-4b0e-4b89-9984-196727e9c72d"), new DateTime(2022, 4, 25, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3747), "Mild", 31, 87 },
                    { new Guid("c08f0d4b-f28d-4aa7-b3b4-7970936b9805"), new DateTime(2022, 4, 28, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3756), "Bracing", -18, 0 },
                    { new Guid("c55b964b-4a14-4353-81ca-3f4584682d93"), new DateTime(2022, 4, 26, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3750), "Chilly", 9, 48 },
                    { new Guid("d5a37545-9b6c-4d64-8081-bd2964ee2373"), new DateTime(2022, 4, 29, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3759), "Warm", 21, 69 },
                    { new Guid("e8e21bfc-8c21-446c-9702-896ee538a54e"), new DateTime(2022, 5, 3, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3780), "Chilly", 20, 67 },
                    { new Guid("fd89c10b-8f82-45f7-86bb-9cd08d4feb6e"), new DateTime(2022, 4, 24, 20, 13, 7, 996, DateTimeKind.Local).AddTicks(3672), "Warm", 23, 73 }
                });
        }
    }
}
