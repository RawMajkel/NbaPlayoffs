using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayoffsApi.Infrastructure.Migrations
{
    public partial class entitytest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0c85cf38-aa37-4b11-a67e-def0ecb006ef"), new DateTime(2022, 4, 28, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8796), "Cool", 23, 73 },
                    { new Guid("48fe7442-f058-463f-9359-b2c1490d1aa9"), new DateTime(2022, 5, 2, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8812), "Cool", 20, 67 },
                    { new Guid("5018a7d4-976c-4d00-aecf-1e543e7b81cb"), new DateTime(2022, 5, 1, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8809), "Warm", 5, 40 },
                    { new Guid("a84d8d51-c925-4f2f-8c7d-c979ae3e0db8"), new DateTime(2022, 5, 3, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8816), "Sweltering", 1, 33 },
                    { new Guid("ca4e57d4-87a4-4b1f-88ab-24f1d344c451"), new DateTime(2022, 4, 25, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8597), "Cool", 49, 120 },
                    { new Guid("cb6bba76-bea6-4bd6-91d4-376f194acc9a"), new DateTime(2022, 4, 30, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8804), "Mild", 15, 58 },
                    { new Guid("cbe99199-8384-4b67-a2bb-718f757d6838"), new DateTime(2022, 4, 27, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8792), "Bracing", 22, 71 },
                    { new Guid("d2098dc3-8bf3-4488-8853-9dfc93804101"), new DateTime(2022, 4, 26, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8785), "Sweltering", 24, 75 },
                    { new Guid("da792482-3721-4059-8f66-78fd7d8ee341"), new DateTime(2022, 4, 29, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8800), "Scorching", 29, 84 },
                    { new Guid("dc475e09-859c-4be6-b5f6-287811aa41da"), new DateTime(2022, 5, 4, 19, 44, 32, 834, DateTimeKind.Local).AddTicks(8826), "Cool", 15, 58 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0c85cf38-aa37-4b11-a67e-def0ecb006ef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("48fe7442-f058-463f-9359-b2c1490d1aa9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5018a7d4-976c-4d00-aecf-1e543e7b81cb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a84d8d51-c925-4f2f-8c7d-c979ae3e0db8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ca4e57d4-87a4-4b1f-88ab-24f1d344c451"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cb6bba76-bea6-4bd6-91d4-376f194acc9a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cbe99199-8384-4b67-a2bb-718f757d6838"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d2098dc3-8bf3-4488-8853-9dfc93804101"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("da792482-3721-4059-8f66-78fd7d8ee341"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dc475e09-859c-4be6-b5f6-287811aa41da"));

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
    }
}
