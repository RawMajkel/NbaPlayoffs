using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayoffsApi.Infrastructure.Migrations
{
    public partial class moredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0039eed2-d22c-42a3-8c3f-d3254be77f58"), new DateTime(2023, 7, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6621), "Mild", 0, 32 },
                    { new Guid("003a1a57-d04f-4022-82ff-1c9c704ea19d"), new DateTime(2023, 1, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5577), "Warm", 45, 112 },
                    { new Guid("008a4074-47c4-47ba-8d3b-7a37c2e217be"), new DateTime(2024, 8, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8366), "Bracing", 16, 60 },
                    { new Guid("00d5a98d-bbf1-4a26-b0a8-2aec9f29ada8"), new DateTime(2023, 11, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7470), "Mild", -18, 0 },
                    { new Guid("00e3040c-5a6e-4e70-82ae-66c93110ce6c"), new DateTime(2023, 4, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6033), "Bracing", 0, 32 },
                    { new Guid("01396b64-5389-4edb-aa23-9f98a543f96e"), new DateTime(2023, 9, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6722), "Freezing", 49, 120 },
                    { new Guid("0149fe11-24fb-455f-b309-7d0ada27cc5a"), new DateTime(2022, 7, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4209), "Mild", -6, 22 },
                    { new Guid("0191d7db-e727-48ca-a491-687fe25f9bbc"), new DateTime(2023, 9, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6937), "Bracing", 32, 89 },
                    { new Guid("01d691e5-3e57-44eb-9893-18002cac189e"), new DateTime(2024, 1, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7665), "Bracing", 28, 82 },
                    { new Guid("0214b2ab-675f-4a22-9d02-85f1db3c637f"), new DateTime(2024, 1, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7709), "Mild", 2, 35 },
                    { new Guid("024aa2a4-892d-45d3-b82c-26b621937284"), new DateTime(2022, 8, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4476), "Chilly", -11, 13 },
                    { new Guid("0282d59c-0977-4693-b6c0-6d30bb88f637"), new DateTime(2024, 11, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8634), "Balmy", 39, 102 },
                    { new Guid("0330cf6b-0595-4345-855e-5858567ef2b0"), new DateTime(2024, 2, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7787), "Chilly", 40, 103 },
                    { new Guid("034e3506-ef0a-4caa-a5f0-0c844053a04c"), new DateTime(2024, 10, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8548), "Scorching", 11, 51 },
                    { new Guid("0372e42d-4957-49f4-8e0f-845cd3ade758"), new DateTime(2022, 8, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4747), "Freezing", -5, 24 },
                    { new Guid("0428c9c0-05ca-4935-b441-e7bc69b4f5d3"), new DateTime(2023, 12, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7523), "Bracing", 21, 69 },
                    { new Guid("0443bb02-24e8-4d51-929a-7338b0a7bdc1"), new DateTime(2024, 3, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7872), "Mild", -17, 2 },
                    { new Guid("04ad6e60-b7e1-4136-b4db-f0a8d4d70df1"), new DateTime(2024, 4, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7968), "Freezing", 51, 123 },
                    { new Guid("050ebb5d-01fc-433f-aaa7-97bef660e68f"), new DateTime(2022, 10, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4883), "Balmy", -14, 7 },
                    { new Guid("058a4043-94da-40ca-b51d-80ee7ca1b64b"), new DateTime(2023, 5, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6100), "Freezing", 30, 85 },
                    { new Guid("05a8f276-ddda-449a-8a2d-df9e93aa45fd"), new DateTime(2023, 3, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5753), "Scorching", 24, 75 },
                    { new Guid("06660027-38b7-4d3c-b8be-5e039b8e72ec"), new DateTime(2022, 8, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4461), "Freezing", 1, 33 },
                    { new Guid("066c3832-cd73-453f-9775-14604ae965ed"), new DateTime(2024, 1, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7655), "Hot", 28, 82 },
                    { new Guid("068c957c-2602-4ac3-9d39-8526dd08d4f6"), new DateTime(2022, 12, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5404), "Mild", 28, 82 },
                    { new Guid("06a0be64-deea-4666-a1f6-b8b149d7d7cb"), new DateTime(2023, 2, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5687), "Warm", -5, 24 },
                    { new Guid("06d1b9fb-b1ba-4f2b-9bfb-ad4f91ef966f"), new DateTime(2024, 2, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7779), "Bracing", 3, 37 },
                    { new Guid("076b3bf1-27b9-4834-80c1-62bb93fb9368"), new DateTime(2023, 9, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6914), "Balmy", 2, 35 },
                    { new Guid("07db197f-c544-4a07-b20a-bc49c5afa25a"), new DateTime(2022, 6, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4123), "Cool", -2, 29 },
                    { new Guid("07e872cb-ecb4-4bc4-bb51-dc029374333c"), new DateTime(2024, 8, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8299), "Freezing", -18, 0 },
                    { new Guid("07f2f9de-9441-4f42-aca6-29184ec60a9e"), new DateTime(2024, 8, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8364), "Chilly", -11, 13 },
                    { new Guid("07f6da5d-31da-4866-a83f-bb7b22d98fb5"), new DateTime(2024, 2, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7742), "Bracing", -20, -3 },
                    { new Guid("0839fc46-b393-42b2-9d83-d9fffcd34fc4"), new DateTime(2023, 8, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6660), "Mild", 13, 55 },
                    { new Guid("0848a22d-55f6-4757-8dd9-aeaa458273da"), new DateTime(2023, 8, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6676), "Hot", -17, 2 },
                    { new Guid("08aa3654-242a-412b-a7f1-ad2e5a611cbe"), new DateTime(2022, 9, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4803), "Chilly", -17, 2 },
                    { new Guid("091bbbf4-93af-4289-8820-ccd85aad9d48"), new DateTime(2024, 6, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8138), "Warm", 1, 33 },
                    { new Guid("0a00d39e-c101-4cf2-9796-0b67f574e08b"), new DateTime(2024, 10, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8469), "Hot", -15, 6 },
                    { new Guid("0a638589-6378-4529-bc84-55a537d49662"), new DateTime(2022, 5, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3990), "Sweltering", 1, 33 },
                    { new Guid("0a9652ca-a2b0-40bb-b451-342b14f7342a"), new DateTime(2024, 6, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8123), "Chilly", -2, 29 },
                    { new Guid("0aa4d846-5b88-4db7-97ff-c84560d56b2e"), new DateTime(2024, 8, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8296), "Mild", 32, 89 },
                    { new Guid("0aaf3148-ceef-4813-b930-018686a08ce3"), new DateTime(2022, 11, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5175), "Cool", 23, 73 },
                    { new Guid("0acec600-d213-4e76-91f1-601e0471d03c"), new DateTime(2025, 1, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8775), "Scorching", 22, 71 },
                    { new Guid("0b6f865e-4d2a-42db-b815-4f3fd73d9738"), new DateTime(2022, 12, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5407), "Hot", 44, 111 },
                    { new Guid("0b94ab7b-4b69-427c-a12f-29e2a0eabf2f"), new DateTime(2024, 9, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8389), "Balmy", 20, 67 },
                    { new Guid("0bac577d-38ef-49ac-b8cd-4449598a67b8"), new DateTime(2022, 7, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4220), "Cool", -19, -2 },
                    { new Guid("0bc188c5-f393-4257-bc06-4d16e1aeadd3"), new DateTime(2022, 8, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4504), "Mild", -1, 31 },
                    { new Guid("0bd4ea9b-81f7-4b40-90f9-72da75b86541"), new DateTime(2023, 3, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5703), "Bracing", 22, 71 },
                    { new Guid("0be8c9df-0a5a-4e96-8cf5-cba765a3f34e"), new DateTime(2024, 7, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8169), "Sweltering", -13, 9 },
                    { new Guid("0bf9188c-24b0-474f-b307-5256ed88230a"), new DateTime(2024, 6, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8155), "Chilly", -5, 24 },
                    { new Guid("0c17ddbd-86aa-4bee-a119-29c826458cd9"), new DateTime(2023, 11, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7416), "Sweltering", 31, 87 },
                    { new Guid("0c25ee30-5a33-4394-963e-f8f9a5747226"), new DateTime(2025, 1, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8772), "Cool", 23, 73 },
                    { new Guid("0c3a70cf-6069-479e-8fd0-e57cfd1d669f"), new DateTime(2023, 10, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6960), "Bracing", -3, 27 },
                    { new Guid("0c69e352-db2a-4dcc-9a7c-2ce0a5ed87cb"), new DateTime(2023, 8, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6658), "Chilly", 35, 94 },
                    { new Guid("0c8135a0-ff26-40fa-8384-dd69ed077453"), new DateTime(2024, 8, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8289), "Warm", 10, 49 },
                    { new Guid("0d04b3b8-9c28-41cf-a7c7-2594a75cead9"), new DateTime(2023, 6, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6479), "Warm", 40, 103 },
                    { new Guid("0d262b52-199d-4447-bd01-db33777da1e2"), new DateTime(2024, 10, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8546), "Freezing", -3, 27 },
                    { new Guid("0d524d4e-f7e1-4838-b9a2-b2311f9a06b1"), new DateTime(2024, 11, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8662), "Warm", 8, 46 },
                    { new Guid("0d6addee-6cb8-48a3-947a-7eaeb9c9606b"), new DateTime(2023, 10, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7243), "Mild", 47, 116 },
                    { new Guid("0e1e2027-15e2-45ad-a272-65beeb5d4a8b"), new DateTime(2022, 6, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4109), "Balmy", 48, 118 },
                    { new Guid("0e5bfe7f-ba87-4983-85ef-dad7ee9f4963"), new DateTime(2024, 2, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7716), "Chilly", 26, 78 },
                    { new Guid("0e8debb3-027d-4743-87c9-fff57dd21133"), new DateTime(2023, 1, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5542), "Mild", -9, 16 },
                    { new Guid("0f209ec4-1e13-4eef-9895-39ee958dc9b3"), new DateTime(2022, 11, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5121), "Sweltering", -15, 6 },
                    { new Guid("0fa4ba2a-cd76-496c-be26-d2c6543dfee1"), new DateTime(2023, 8, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6708), "Mild", 5, 40 },
                    { new Guid("0faf3c0a-c1e1-435d-bb80-8d713eabd56f"), new DateTime(2023, 11, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7447), "Scorching", -8, 18 },
                    { new Guid("10733b52-0575-4e38-8440-10452b4af05f"), new DateTime(2023, 12, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7519), "Sweltering", 24, 75 },
                    { new Guid("113de170-571b-45ca-b06b-2e52d36878f2"), new DateTime(2024, 7, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8184), "Freezing", 21, 69 },
                    { new Guid("116f1d9a-a619-4e64-8505-38e5a0279194"), new DateTime(2024, 6, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8094), "Hot", 45, 112 },
                    { new Guid("11a6dfbe-27d1-477d-b427-b652001c57d1"), new DateTime(2024, 6, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8097), "Balmy", 12, 53 },
                    { new Guid("11c19965-516a-4aa2-8d5a-e2580c75f189"), new DateTime(2024, 9, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8399), "Hot", 14, 57 },
                    { new Guid("121e285d-bfaa-45f8-8a94-ade8b56e0fb1"), new DateTime(2023, 6, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6451), "Cool", 24, 75 },
                    { new Guid("123ebfba-1586-461c-88dd-cec6c2701123"), new DateTime(2022, 12, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5468), "Mild", 24, 75 },
                    { new Guid("12d81dd5-b228-47cd-9194-32005ac34d31"), new DateTime(2022, 10, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4942), "Freezing", 7, 44 },
                    { new Guid("12d9e769-582a-47b8-86a6-514544ddeee3"), new DateTime(2024, 1, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7706), "Bracing", 40, 103 },
                    { new Guid("135fd134-e232-4876-b058-5adb53ae8670"), new DateTime(2024, 10, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8531), "Cool", 36, 96 },
                    { new Guid("1390190e-80be-481d-a287-d159dcd5a95c"), new DateTime(2022, 9, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4834), "Mild", 13, 55 },
                    { new Guid("13b9914c-7a6e-469f-b918-6ca87c2c7b73"), new DateTime(2023, 3, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5711), "Mild", 8, 46 },
                    { new Guid("13bf8380-81d7-41fb-be45-59721bbd496d"), new DateTime(2024, 6, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8136), "Hot", 3, 37 },
                    { new Guid("13fb7f33-dc90-4e0b-b5f5-da20ddab5df1"), new DateTime(2024, 4, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7892), "Mild", 0, 32 },
                    { new Guid("142dcb99-1672-4fc9-9b6e-01775a132224"), new DateTime(2024, 10, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8551), "Cool", 11, 51 },
                    { new Guid("142f8f36-4317-4b31-be77-81c9627f7e9d"), new DateTime(2024, 9, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8451), "Cool", 23, 73 },
                    { new Guid("1438f103-3cdf-4cda-a22b-17bb54846347"), new DateTime(2024, 3, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7805), "Cool", 19, 66 },
                    { new Guid("144ba891-d472-4605-9306-28497e20788e"), new DateTime(2024, 6, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8158), "Warm", -17, 2 },
                    { new Guid("1466a7be-a258-41db-b001-47009323008a"), new DateTime(2024, 8, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8284), "Warm", 46, 114 },
                    { new Guid("147be06c-75a5-4d6e-82d5-bb1810cdc907"), new DateTime(2022, 10, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4877), "Chilly", 26, 78 },
                    { new Guid("14ecdf16-3a96-4c92-875a-cfa7de05fdb4"), new DateTime(2024, 8, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8339), "Freezing", 46, 114 },
                    { new Guid("1520ab40-e2c7-466a-bd49-b1340403cb9a"), new DateTime(2022, 9, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4779), "Cool", -3, 27 },
                    { new Guid("1557adc1-c08c-4e15-a1a4-2870bf7444ab"), new DateTime(2023, 1, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5588), "Scorching", 35, 94 },
                    { new Guid("1576a8af-d2f3-4c50-87e3-b6cc4f91f6c0"), new DateTime(2025, 1, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8761), "Cool", 15, 58 },
                    { new Guid("161db75a-74a0-40e0-b368-2a8a08b746e7"), new DateTime(2023, 9, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6890), "Sweltering", 13, 55 },
                    { new Guid("1636fa47-495b-4ad9-8f32-88025dada2da"), new DateTime(2022, 11, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5165), "Chilly", 8, 46 },
                    { new Guid("1645e5ac-eb58-4312-a6d7-0f99d5f5dd98"), new DateTime(2023, 5, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6128), "Chilly", 44, 111 },
                    { new Guid("1652b76a-7d0d-4a86-8d4f-a2738649b292"), new DateTime(2023, 11, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7491), "Bracing", 4, 39 },
                    { new Guid("169e4908-14d2-4835-9923-825ef862d135"), new DateTime(2023, 5, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6053), "Cool", -3, 27 },
                    { new Guid("170c2b9c-2dd9-4a93-b867-ac1583c7f048"), new DateTime(2024, 2, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7774), "Sweltering", -12, 11 },
                    { new Guid("1713beec-757b-480b-b06a-d1723f69525b"), new DateTime(2024, 6, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8151), "Chilly", -17, 2 },
                    { new Guid("1750ca3e-f5c6-45be-be46-37942ee0a2af"), new DateTime(2022, 5, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4059), "Warm", 7, 44 },
                    { new Guid("178600db-7326-49cb-b7a8-3ad5a31859b7"), new DateTime(2023, 7, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6560), "Mild", 10, 49 },
                    { new Guid("17cce5c1-1080-4b30-bffe-bc3cd3d5b576"), new DateTime(2023, 3, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5776), "Cool", 8, 46 },
                    { new Guid("1817fb00-921a-40c2-85ec-965b8439fdbf"), new DateTime(2024, 3, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7845), "Mild", 17, 62 },
                    { new Guid("184ccb39-8e88-4f2c-9943-666116066be9"), new DateTime(2025, 1, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8777), "Balmy", 0, 32 },
                    { new Guid("1890e112-47a0-4b92-abb7-1e77b37b4380"), new DateTime(2023, 3, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5716), "Sweltering", 21, 69 },
                    { new Guid("18c5f613-e8e5-412a-8d0f-c1fef6adb649"), new DateTime(2024, 3, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7851), "Freezing", 40, 103 },
                    { new Guid("1978c1f9-5238-4e6c-bd8b-a1810604de1a"), new DateTime(2022, 5, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4080), "Sweltering", 30, 85 },
                    { new Guid("19ba5f45-f2ca-4d21-b672-88ab01ba84e2"), new DateTime(2022, 8, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4466), "Chilly", -2, 29 },
                    { new Guid("1a042f41-ae1c-4cd1-86ee-5e8d2540a3fa"), new DateTime(2024, 8, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8343), "Sweltering", -6, 22 },
                    { new Guid("1a0fb31d-d061-4a21-9d98-d5678b32060a"), new DateTime(2023, 6, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6143), "Freezing", -4, 25 },
                    { new Guid("1a670186-850b-443b-9565-d9ceaefcc077"), new DateTime(2023, 9, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6895), "Balmy", 31, 87 },
                    { new Guid("1a958014-f629-4ec7-a2dd-7246faca7272"), new DateTime(2022, 6, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4163), "Freezing", 49, 120 },
                    { new Guid("1b859959-a032-47d8-a66c-0489c20a0ec0"), new DateTime(2023, 10, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6952), "Cool", -6, 22 },
                    { new Guid("1bb638e5-f8a2-4a42-a7d5-659e3dee706e"), new DateTime(2024, 11, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8622), "Chilly", 2, 35 },
                    { new Guid("1c70b9f3-f7d4-40af-9897-668be353d4ef"), new DateTime(2022, 11, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5167), "Mild", 2, 35 },
                    { new Guid("1cb0eb20-6fc9-4e37-abe4-cc983c437046"), new DateTime(2022, 8, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4458), "Freezing", 54, 129 },
                    { new Guid("1d7f3dc3-dc3e-46f8-81de-b52c948c93c2"), new DateTime(2023, 7, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6505), "Balmy", 30, 85 },
                    { new Guid("1e0fbfe4-572d-4dee-953e-3d5ca4e611cc"), new DateTime(2022, 4, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3975), "Scorching", 21, 69 },
                    { new Guid("1e2b3737-6468-4388-8a61-545e982bee65"), new DateTime(2023, 12, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7569), "Warm", 15, 58 },
                    { new Guid("1e39d2af-58cd-4530-b353-695c99906fa6"), new DateTime(2025, 1, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8819), "Balmy", 1, 33 },
                    { new Guid("1e81e6aa-ed31-4081-976c-7216a1569de9"), new DateTime(2023, 6, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6138), "Balmy", 25, 76 },
                    { new Guid("1e8ce454-f035-46cd-a0d8-b8014c2bcaef"), new DateTime(2025, 1, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8829), "Warm", -18, 0 },
                    { new Guid("1ef4d58c-ad5f-4208-9208-45ac4fdfbb66"), new DateTime(2024, 8, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8302), "Cool", 49, 120 },
                    { new Guid("1f120b9d-0e60-4dd8-b417-f8b80d73b705"), new DateTime(2024, 12, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8685), "Hot", 31, 87 },
                    { new Guid("1f1a755a-25ab-49e9-9ca2-273953d135be"), new DateTime(2024, 12, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8703), "Hot", -12, 11 },
                    { new Guid("1f5fd86c-1918-4ba0-b485-56bc25c66631"), new DateTime(2024, 10, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8541), "Balmy", 37, 98 },
                    { new Guid("1fa4a02a-f6be-4f3c-9149-d143def5f091"), new DateTime(2023, 4, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5997), "Balmy", 19, 66 },
                    { new Guid("1fa750fa-ae62-463f-978d-f19ccdf77b2e"), new DateTime(2024, 10, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8578), "Sweltering", 50, 121 },
                    { new Guid("1ffa7366-9b11-49f7-8654-6ef42c00fd73"), new DateTime(2024, 3, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7884), "Balmy", 39, 102 },
                    { new Guid("2002f187-cb9a-4f57-9e62-b123298077c3"), new DateTime(2024, 8, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8357), "Chilly", -15, 6 },
                    { new Guid("201d3df1-cc73-445b-9eee-02365fb98c9c"), new DateTime(2022, 9, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4768), "Bracing", 41, 105 },
                    { new Guid("208f673f-eb3a-4df2-97f2-e3fc5bf56606"), new DateTime(2023, 3, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5779), "Chilly", 30, 85 },
                    { new Guid("20f9bbac-b847-4365-aff1-226d983ba7f2"), new DateTime(2024, 6, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8103), "Freezing", -8, 18 },
                    { new Guid("2107aae5-9384-4c6b-999a-01cb0a76b354"), new DateTime(2023, 11, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7496), "Balmy", 42, 107 },
                    { new Guid("2126e968-49fd-48e8-b6aa-45cda360eb10"), new DateTime(2023, 1, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5593), "Hot", 18, 64 },
                    { new Guid("212fb1df-b460-49e6-b4cc-1dd1d8c0ee81"), new DateTime(2024, 7, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8233), "Balmy", -17, 2 },
                    { new Guid("21a0788d-7ccb-467e-8292-96815256a439"), new DateTime(2022, 6, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4115), "Scorching", 52, 125 },
                    { new Guid("21e73fa2-aef9-45a2-b36e-625f2cca778d"), new DateTime(2022, 4, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3984), "Bracing", 13, 55 },
                    { new Guid("21eb3dc9-7e7e-4462-a8a8-c099c9a15a65"), new DateTime(2025, 1, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8785), "Bracing", -6, 22 },
                    { new Guid("221d83bd-18e5-474f-8720-905709b4322d"), new DateTime(2024, 5, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7996), "Chilly", -13, 9 },
                    { new Guid("229b1cf7-9ec4-45b6-b418-84b371a3f217"), new DateTime(2023, 2, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5669), "Freezing", -2, 29 },
                    { new Guid("22ee2076-cbbc-4417-9ce0-72af1e131525"), new DateTime(2024, 7, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8225), "Warm", 31, 87 },
                    { new Guid("23421a94-3fc6-493a-8523-77a7c9960a76"), new DateTime(2024, 1, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7680), "Mild", 49, 120 },
                    { new Guid("23dba211-71b9-4c46-96b7-3eba74eff208"), new DateTime(2022, 11, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5115), "Mild", 25, 76 },
                    { new Guid("23f95739-9bbc-4484-aa3d-e4b1707bcb22"), new DateTime(2024, 5, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8006), "Freezing", 32, 89 },
                    { new Guid("241f1a61-05df-4567-a67f-ad56997085d3"), new DateTime(2024, 1, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7587), "Cool", 37, 98 },
                    { new Guid("24455f03-d823-4634-ba5d-b324fa40104f"), new DateTime(2023, 3, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5719), "Balmy", -10, 15 },
                    { new Guid("255f1f83-abe2-4442-b140-2139276431ec"), new DateTime(2024, 10, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8474), "Hot", -13, 9 },
                    { new Guid("256814f8-fe3d-4fa6-a05d-a60b2e4f65a0"), new DateTime(2022, 6, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4101), "Sweltering", 3, 37 },
                    { new Guid("2590ad9b-7821-4364-b7b1-3810f6d718ea"), new DateTime(2023, 1, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5523), "Chilly", 7, 44 },
                    { new Guid("260c011c-63fb-4f51-8dd3-b9259ab7635a"), new DateTime(2023, 7, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6579), "Sweltering", 6, 42 },
                    { new Guid("2645e16e-c528-476a-a6a8-2a6a61b20f87"), new DateTime(2022, 8, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4720), "Scorching", 24, 75 },
                    { new Guid("26873973-6385-40ae-a003-ee6715bc9d91"), new DateTime(2023, 1, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5520), "Chilly", 24, 75 },
                    { new Guid("269fbf57-881e-4476-a028-97cf756da985"), new DateTime(2023, 1, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5567), "Balmy", 51, 123 },
                    { new Guid("26a5fb0c-2529-4689-89a7-a4972e612010"), new DateTime(2023, 12, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7581), "Freezing", 30, 85 },
                    { new Guid("26d50d90-aa9e-4a07-83b1-3adc2da4fc66"), new DateTime(2024, 10, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8454), "Balmy", -16, 4 },
                    { new Guid("26fc776f-a89a-47e0-968b-566d45620bb1"), new DateTime(2022, 11, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5181), "Balmy", -20, -3 },
                    { new Guid("27098fd7-a90b-48df-8513-fb9cd588549f"), new DateTime(2024, 3, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7822), "Hot", -16, 4 },
                    { new Guid("27324b14-e5ba-4d00-befc-686b4637ff39"), new DateTime(2023, 1, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5529), "Scorching", 52, 125 },
                    { new Guid("274ab388-f67b-4277-a82f-249941446c63"), new DateTime(2023, 9, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6908), "Freezing", 3, 37 },
                    { new Guid("27529f1c-1941-4813-a8ff-8ecb6dd23330"), new DateTime(2024, 10, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8467), "Balmy", 23, 73 },
                    { new Guid("278d9f5c-9908-4540-8b61-90b25094a06d"), new DateTime(2024, 8, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8334), "Scorching", 48, 118 },
                    { new Guid("28099df1-31b3-49c8-a060-c3e330b127c7"), new DateTime(2023, 11, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7464), "Bracing", -13, 9 },
                    { new Guid("287bdffb-057d-4e02-8df5-7347e408cd32"), new DateTime(2024, 10, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8563), "Sweltering", 0, 32 },
                    { new Guid("297395d1-c072-4fc1-878c-509026f56a38"), new DateTime(2022, 12, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5448), "Hot", 10, 49 },
                    { new Guid("298196f9-0800-4dc9-a2fa-23f4779c6e48"), new DateTime(2023, 8, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6714), "Mild", 15, 58 },
                    { new Guid("2a0ffdd4-31d6-4bfa-a836-8355a6651584"), new DateTime(2023, 1, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5604), "Chilly", -13, 9 },
                    { new Guid("2a269e4a-a839-45f8-93d3-9364db544023"), new DateTime(2023, 8, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6698), "Scorching", -13, 9 },
                    { new Guid("2a7c877b-39ac-4f29-be5b-e9a00f9788d1"), new DateTime(2023, 11, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7485), "Cool", 18, 64 },
                    { new Guid("2aaab1c5-997a-4ade-80f0-615f45a85e19"), new DateTime(2024, 10, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8580), "Cool", 40, 103 },
                    { new Guid("2c2f3995-cc8e-4f26-b949-c8849705e541"), new DateTime(2023, 1, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5598), "Cool", -20, -3 },
                    { new Guid("2c336723-b573-402e-8805-c8bfbc5ac6c1"), new DateTime(2022, 12, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5480), "Bracing", -12, 11 },
                    { new Guid("2c4a27b1-7727-448d-9ea8-bd517d268c91"), new DateTime(2022, 5, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4061), "Bracing", 12, 53 },
                    { new Guid("2d15457d-e2bb-4c03-b8df-3bd32ccba2c4"), new DateTime(2023, 1, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5601), "Balmy", -20, -3 },
                    { new Guid("2d8dd7ef-8691-49d8-87e0-079f3a9aca6e"), new DateTime(2023, 7, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6576), "Scorching", 14, 57 },
                    { new Guid("2dd15ffb-b583-4893-a579-65189a337f5c"), new DateTime(2023, 7, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6510), "Cool", 35, 94 },
                    { new Guid("2df35f57-09da-4971-af26-041f3ea49eaa"), new DateTime(2022, 11, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5146), "Balmy", 26, 78 },
                    { new Guid("2dfc3dfa-a9c7-45bd-b772-e0eaca499d66"), new DateTime(2024, 2, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7769), "Bracing", 17, 62 },
                    { new Guid("2e569237-7ddc-4607-ba8e-7c7bf741d246"), new DateTime(2022, 12, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5193), "Sweltering", -17, 2 },
                    { new Guid("2f719f20-550a-4129-a46a-cb5e069b4878"), new DateTime(2022, 8, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4744), "Balmy", 52, 125 },
                    { new Guid("2f74851e-ec9b-47df-bcca-ee6d33803cf2"), new DateTime(2024, 4, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7911), "Mild", 48, 118 },
                    { new Guid("2fb2fb37-19ad-461f-bdf8-42aea5752c5c"), new DateTime(2024, 7, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8251), "Cool", 19, 66 },
                    { new Guid("2fc16ec9-4e6d-4181-a617-1f40085cbaae"), new DateTime(2024, 12, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8693), "Mild", -1, 31 },
                    { new Guid("3051cd8a-8699-4af3-a4f9-a7296e5b10e2"), new DateTime(2023, 12, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7534), "Chilly", 13, 55 },
                    { new Guid("308c9f3d-2500-4cc8-b4d9-fded363a09cc"), new DateTime(2022, 4, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3867), "Sweltering", 30, 85 },
                    { new Guid("30f014c6-38d4-47ab-bfc9-9ea4b3af0997"), new DateTime(2022, 10, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4907), "Hot", 12, 53 },
                    { new Guid("31677f42-9457-4349-b64e-c313a6c41c05"), new DateTime(2024, 4, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7963), "Warm", -15, 6 },
                    { new Guid("31eca9a4-e5fa-4181-aeac-24e912d08cb3"), new DateTime(2024, 2, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7781), "Warm", -16, 4 },
                    { new Guid("32097233-e9a4-4fa4-b8a9-cf9a9ea72022"), new DateTime(2024, 5, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8054), "Cool", -9, 16 },
                    { new Guid("323eb473-bcae-44a1-80d7-f5248084abd1"), new DateTime(2022, 8, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4489), "Balmy", 52, 125 },
                    { new Guid("325b00fa-896a-454e-bdd0-953940fa5d05"), new DateTime(2023, 11, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7439), "Freezing", 54, 129 },
                    { new Guid("327f0630-f0b6-4a77-b3dd-c04ff9744997"), new DateTime(2024, 12, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8690), "Freezing", 22, 71 },
                    { new Guid("32a6716e-b9ae-4404-bd8c-89389ca013f1"), new DateTime(2024, 12, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8677), "Mild", 41, 105 },
                    { new Guid("32ba6c18-3418-44c8-abd6-ed8260d5e572"), new DateTime(2023, 1, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5537), "Scorching", -5, 24 },
                    { new Guid("32c4386e-4754-4279-9d46-9a0cc6f1ae3d"), new DateTime(2023, 2, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5621), "Chilly", 18, 64 },
                    { new Guid("32ebb246-da62-4889-89ed-f7f6b204d181"), new DateTime(2022, 7, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4200), "Bracing", 54, 129 },
                    { new Guid("33017606-99a5-47c5-8378-b37ee4ab85b2"), new DateTime(2022, 8, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4736), "Scorching", 46, 114 },
                    { new Guid("3310eb6c-d4be-4640-b77d-5e7d3286b858"), new DateTime(2023, 8, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6634), "Sweltering", 12, 53 },
                    { new Guid("33433021-7f08-4799-a3c1-cca4f26f9aa3"), new DateTime(2023, 7, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6547), "Hot", 53, 127 },
                    { new Guid("334db2c8-7cbe-4be9-962e-f137a572d963"), new DateTime(2024, 6, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8121), "Balmy", 35, 94 },
                    { new Guid("33bf6251-30df-4995-9786-f82a90ad7e5e"), new DateTime(2023, 3, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5740), "Balmy", 47, 116 },
                    { new Guid("33c2bc45-533e-45f0-98ef-31881364744d"), new DateTime(2022, 7, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4215), "Chilly", -5, 24 },
                    { new Guid("33c768a6-01e4-40ef-961a-b53078f93d63"), new DateTime(2024, 2, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7732), "Sweltering", 32, 89 },
                    { new Guid("34048f4a-e61b-42e8-b30e-a5286da2c572"), new DateTime(2023, 2, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5632), "Warm", 38, 100 },
                    { new Guid("341b72a5-e9e6-424b-bfd2-2dfbc7f9cdb3"), new DateTime(2022, 5, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4043), "Scorching", 45, 112 },
                    { new Guid("34811a86-034e-4e5f-8571-d1cc40f4f383"), new DateTime(2025, 1, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8790), "Balmy", 32, 89 },
                    { new Guid("34a89caf-7851-4a1f-b72b-c561828958de"), new DateTime(2024, 12, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8672), "Scorching", 51, 123 },
                    { new Guid("34fd11d7-8f44-40fc-8790-462827804652"), new DateTime(2022, 6, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4152), "Mild", 5, 40 },
                    { new Guid("360795ea-93c9-4dc6-b2ff-352619c4cd3a"), new DateTime(2022, 5, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4074), "Scorching", 45, 112 },
                    { new Guid("361f049b-19fc-451e-a77b-4178eb647eff"), new DateTime(2022, 12, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5422), "Balmy", 42, 107 },
                    { new Guid("363a26a8-33d6-4ba0-8d4d-de2b07680d4b"), new DateTime(2023, 6, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6495), "Freezing", -5, 24 },
                    { new Guid("364f149f-1f69-4b55-803b-2e438a6a3c28"), new DateTime(2023, 9, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6744), "Scorching", 41, 105 },
                    { new Guid("36c970b6-f765-4c0b-ae3f-464dc3264e18"), new DateTime(2023, 3, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5729), "Cool", 28, 82 },
                    { new Guid("36f9c6ac-75c1-4796-bb0a-1bcf4db4ffbf"), new DateTime(2022, 5, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4072), "Sweltering", 39, 102 },
                    { new Guid("3783dc68-9608-41b7-bee4-010e129c9aa8"), new DateTime(2023, 6, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6497), "Hot", -12, 11 },
                    { new Guid("37a623ed-3b20-42a2-87c2-739c2efa76c5"), new DateTime(2024, 9, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8419), "Warm", -14, 7 },
                    { new Guid("37acf2e5-9343-4add-bcb7-b36e855c7c5c"), new DateTime(2023, 11, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7442), "Bracing", -3, 27 },
                    { new Guid("37d7392e-aa60-4e4a-8476-ab918599880f"), new DateTime(2024, 4, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7958), "Sweltering", 0, 32 },
                    { new Guid("37e954bc-eea8-4bf5-a578-9f1cd04c5f9f"), new DateTime(2022, 7, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4270), "Hot", 29, 84 },
                    { new Guid("3811722f-54e6-4582-85a8-3933de352f65"), new DateTime(2023, 2, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5671), "Bracing", -16, 4 },
                    { new Guid("382c9993-275d-4321-93aa-d117e25342b4"), new DateTime(2023, 2, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5643), "Freezing", -16, 4 },
                    { new Guid("384ecad5-0a55-457a-9800-af9e0d8718c1"), new DateTime(2023, 2, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5624), "Freezing", -1, 31 },
                    { new Guid("3860454a-a8bc-433d-a2c3-f7ffe529fba1"), new DateTime(2022, 10, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4923), "Mild", -12, 11 },
                    { new Guid("38e3aef1-4399-4e76-b470-0b5fdbe20e48"), new DateTime(2024, 8, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8316), "Sweltering", -3, 27 },
                    { new Guid("390fe896-7cb3-4b6f-adf2-21398a3c3d88"), new DateTime(2022, 6, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4149), "Bracing", -13, 9 },
                    { new Guid("394a218b-53cb-4b17-a16e-2ca9de3009d4"), new DateTime(2024, 12, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8718), "Hot", 4, 39 },
                    { new Guid("39659acb-3016-41f8-842e-3e8f2e525313"), new DateTime(2022, 7, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4450), "Cool", 33, 91 },
                    { new Guid("39b85689-a40e-4253-bd4e-dc0d61eed665"), new DateTime(2024, 12, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8735), "Scorching", 37, 98 },
                    { new Guid("3a046be6-8649-4c85-b591-c6f6e9df5edd"), new DateTime(2022, 12, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5442), "Mild", -4, 25 },
                    { new Guid("3a266813-b493-4196-8b0c-83bb0d8787f1"), new DateTime(2023, 7, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6624), "Balmy", 53, 127 },
                    { new Guid("3a2f1e85-0dfb-4a29-bd74-4e2f28201366"), new DateTime(2023, 3, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5763), "Freezing", 13, 55 },
                    { new Guid("3a55afb3-4816-43a5-922a-3858d50c8e51"), new DateTime(2024, 11, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8642), "Scorching", 3, 37 },
                    { new Guid("3abca9dd-12a1-4be5-b225-80ec066d2180"), new DateTime(2022, 7, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4445), "Warm", 8, 46 },
                    { new Guid("3b24bdab-36c9-4bc2-8400-b6ec5fb40b31"), new DateTime(2023, 12, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7514), "Hot", -11, 13 },
                    { new Guid("3b2e2f85-bf0c-4df5-a01b-21c53cd365cd"), new DateTime(2023, 12, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7505), "Bracing", -6, 22 },
                    { new Guid("3b489561-0fb3-41ba-8f51-d95f85790596"), new DateTime(2023, 11, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7436), "Chilly", -5, 24 },
                    { new Guid("3b58e402-17a4-406b-9017-2980a292a19b"), new DateTime(2022, 12, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5434), "Sweltering", 54, 129 },
                    { new Guid("3b8024bb-c8a2-4e15-81b4-340f7033a77e"), new DateTime(2022, 9, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4787), "Chilly", -8, 18 },
                    { new Guid("3b833c11-fadb-4bb5-98c8-4f480327c9e0"), new DateTime(2023, 8, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6648), "Freezing", 31, 87 },
                    { new Guid("3bd14a5d-90b4-444e-ba1b-16d761bdef5b"), new DateTime(2024, 7, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8230), "Bracing", -16, 4 },
                    { new Guid("3be017fc-ee3c-4ece-9a55-bf72df42ace2"), new DateTime(2022, 10, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4901), "Scorching", 48, 118 },
                    { new Guid("3c16d2d0-d508-4286-a298-9bd6a2cd4791"), new DateTime(2023, 6, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6462), "Scorching", -20, -3 },
                    { new Guid("3c28080e-ccbc-47e4-89e3-de7bb6481f53"), new DateTime(2022, 7, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4260), "Chilly", 12, 53 },
                    { new Guid("3c2abdd9-4c4f-47d0-b512-242d0e6f3eeb"), new DateTime(2022, 7, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4228), "Hot", 46, 114 },
                    { new Guid("3c4ad31e-5beb-4f5c-a8b6-b4c16f6fab78"), new DateTime(2023, 4, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6028), "Sweltering", 30, 85 },
                    { new Guid("3c60f2ed-7f6b-4fd1-93c7-5bad13b35834"), new DateTime(2024, 10, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8575), "Chilly", 49, 120 },
                    { new Guid("3cf1b473-d89f-4bfe-ae18-bec2db8ac356"), new DateTime(2022, 9, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4763), "Chilly", -6, 22 },
                    { new Guid("3d18c7d5-844c-4eb7-a453-b95a6a0d72f9"), new DateTime(2023, 2, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5679), "Cool", 31, 87 },
                    { new Guid("3d237296-9335-4b36-842f-188b1408856b"), new DateTime(2022, 11, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5170), "Sweltering", 43, 109 },
                    { new Guid("3d2ce1b3-b382-4f25-a5f5-360eb815f52a"), new DateTime(2024, 10, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8533), "Scorching", -2, 29 },
                    { new Guid("3d34cc79-229e-4260-8de1-c618f43284b8"), new DateTime(2024, 2, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7776), "Hot", 27, 80 },
                    { new Guid("3d3e727d-3559-4c78-b74d-03b260eef0b8"), new DateTime(2023, 10, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7219), "Warm", -13, 9 },
                    { new Guid("3daa6473-f316-41f9-8bc3-55b87499b355"), new DateTime(2023, 9, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6947), "Balmy", 35, 94 },
                    { new Guid("3e0f7968-dc88-484c-bef5-e8c2741de429"), new DateTime(2023, 4, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5789), "Mild", 25, 76 },
                    { new Guid("3e48c685-59ed-4534-bdaf-a8f40cecf8e3"), new DateTime(2022, 11, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5111), "Freezing", 51, 123 },
                    { new Guid("3eec0189-e482-453d-a71f-27602d74a6d4"), new DateTime(2024, 6, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8086), "Cool", 42, 107 },
                    { new Guid("3f527512-0e57-4a54-a9eb-d933499e165f"), new DateTime(2024, 4, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7941), "Warm", 24, 75 },
                    { new Guid("3fc8609d-ee46-4d88-9e48-5acfd934d275"), new DateTime(2022, 6, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4112), "Bracing", -7, 20 },
                    { new Guid("3ffe5676-f810-4ab5-b8d7-036df0bd7751"), new DateTime(2022, 6, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4120), "Chilly", 20, 67 },
                    { new Guid("400d7871-3f98-40cb-bd1e-769a73854b5b"), new DateTime(2023, 6, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6449), "Scorching", 38, 100 },
                    { new Guid("402027ba-2617-4769-aa27-a10ded44e9a3"), new DateTime(2024, 3, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7869), "Freezing", 32, 89 },
                    { new Guid("404e0021-a8d2-413b-b67b-0496221a236c"), new DateTime(2023, 4, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6036), "Warm", 7, 44 },
                    { new Guid("4059be01-910f-4db4-850f-8664a11e9a7f"), new DateTime(2024, 7, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8195), "Chilly", -4, 25 },
                    { new Guid("40f328c4-34e6-4244-bdf0-9936beb098df"), new DateTime(2023, 8, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6687), "Chilly", -8, 18 },
                    { new Guid("40f906f7-52af-42fa-b135-0d19cec41320"), new DateTime(2023, 10, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7230), "Balmy", 53, 127 },
                    { new Guid("412c3d32-25c5-4d06-af85-312d4a47f413"), new DateTime(2023, 11, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7454), "Scorching", -20, -3 },
                    { new Guid("418681b4-5f90-4481-bbcd-a3c4ae47ed46"), new DateTime(2023, 1, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5608), "Mild", 6, 42 },
                    { new Guid("419fd37c-19d5-413f-aeee-dd0b4e6b77c1"), new DateTime(2023, 3, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5750), "Scorching", -13, 9 },
                    { new Guid("41b286c9-b817-4811-8443-743d9136f35d"), new DateTime(2024, 5, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8021), "Warm", -17, 2 },
                    { new Guid("41ebe996-e2de-4032-b247-a3b09bd15847"), new DateTime(2023, 5, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6090), "Scorching", 43, 109 },
                    { new Guid("421ab9a8-69af-4875-b377-8aa5055b6483"), new DateTime(2024, 2, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7797), "Balmy", 38, 100 },
                    { new Guid("422baf86-f389-4bad-8f0c-a9a8dc81dc68"), new DateTime(2024, 9, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8384), "Balmy", 46, 114 },
                    { new Guid("42cc8cc3-fdab-4757-bbb4-d56bd78e56ba"), new DateTime(2024, 3, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7856), "Chilly", 40, 103 },
                    { new Guid("42da01f8-68a8-412c-98ff-d782411d9acd"), new DateTime(2023, 4, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5787), "Freezing", 18, 64 },
                    { new Guid("43136578-fac3-44b7-a59c-fba668f833cf"), new DateTime(2024, 8, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8348), "Hot", -1, 31 },
                    { new Guid("4397db9d-5e23-41df-bb91-d4bc0a1a0c4b"), new DateTime(2022, 9, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4806), "Chilly", -9, 16 },
                    { new Guid("43e86f47-939b-4afa-baad-c0351cb91e12"), new DateTime(2022, 7, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4263), "Freezing", 19, 66 },
                    { new Guid("43fc235d-bd86-4b4a-81dd-ca016f13997c"), new DateTime(2023, 7, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6552), "Mild", -11, 13 },
                    { new Guid("44088817-055c-4cd7-9ae3-0d56cb6a666a"), new DateTime(2022, 10, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4880), "Sweltering", 43, 109 },
                    { new Guid("4449d00a-735c-4344-9e72-ca6e1df085bb"), new DateTime(2024, 1, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7651), "Chilly", 26, 78 },
                    { new Guid("44648c7d-ac59-498c-9950-77c00dba2432"), new DateTime(2023, 3, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5693), "Chilly", 7, 44 },
                    { new Guid("4469216e-fd18-4d12-8fdf-99b8ddcffc69"), new DateTime(2022, 6, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4128), "Warm", -20, -3 },
                    { new Guid("446b964d-0cbf-447d-9492-6da71b60fda2"), new DateTime(2024, 9, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8387), "Freezing", -10, 15 },
                    { new Guid("44c6f7d6-0d0f-4f5f-915b-32107c97ab6b"), new DateTime(2023, 8, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6706), "Warm", 13, 55 },
                    { new Guid("44f79c8e-d1ea-4609-a0a1-6974194bb475"), new DateTime(2023, 4, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6012), "Cool", 43, 109 },
                    { new Guid("453cd0a3-ec1f-428a-afb8-1d226d82a866"), new DateTime(2022, 5, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3992), "Warm", 33, 91 },
                    { new Guid("454b0afc-6fd3-4164-bc85-d8e625b56fcb"), new DateTime(2023, 9, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6741), "Chilly", 44, 111 },
                    { new Guid("45d35fae-1ed6-4977-9f22-0be2101a31a7"), new DateTime(2023, 1, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5572), "Mild", -12, 11 },
                    { new Guid("46b2763b-f304-4b5a-a992-92a4184e33a1"), new DateTime(2023, 2, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5663), "Sweltering", 2, 35 },
                    { new Guid("476fd57a-49df-48df-9f03-672d57fe2774"), new DateTime(2023, 10, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7211), "Chilly", 28, 82 },
                    { new Guid("48364687-ed23-4f5e-80f1-92414f9e04de"), new DateTime(2024, 11, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8667), "Balmy", 46, 114 },
                    { new Guid("483f8e50-49ad-4c11-826a-975be03c0a72"), new DateTime(2022, 6, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4125), "Balmy", 54, 129 },
                    { new Guid("48846cfd-c406-4a5b-ae93-97c0f36684eb"), new DateTime(2023, 10, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7235), "Sweltering", -8, 18 },
                    { new Guid("48bd67d0-7ad0-40da-aef5-7ac57c885c0d"), new DateTime(2024, 5, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8079), "Hot", 33, 91 },
                    { new Guid("49026d65-4659-42af-accf-d701be2798c1"), new DateTime(2023, 2, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5684), "Cool", 37, 98 },
                    { new Guid("49975658-6412-4f0c-abf0-e433adc8361a"), new DateTime(2024, 12, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8745), "Mild", 47, 116 },
                    { new Guid("499eb5d1-57d4-4253-a8df-d50632759790"), new DateTime(2022, 11, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5162), "Bracing", -5, 24 },
                    { new Guid("49a07d81-44ea-4bbc-8176-6f10a48c306a"), new DateTime(2022, 5, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4077), "Freezing", 32, 89 },
                    { new Guid("4a1d0810-1e95-4447-a90b-d25f4bf1c162"), new DateTime(2022, 9, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4760), "Chilly", 13, 55 },
                    { new Guid("4a917607-3457-4058-9bc8-ab1341414006"), new DateTime(2022, 12, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5471), "Bracing", 49, 120 },
                    { new Guid("4bd95cea-f9d0-4e0f-b4ec-a7e93e850c49"), new DateTime(2022, 5, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4067), "Mild", -6, 22 },
                    { new Guid("4c11cdbb-674c-4bcb-b6df-5f5ec63b9ad3"), new DateTime(2022, 11, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5128), "Cool", 36, 96 },
                    { new Guid("4c78fec9-2d5b-4b6b-b9dd-be2fda443c77"), new DateTime(2023, 9, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6942), "Bracing", 14, 57 },
                    { new Guid("4cc755cc-cb93-4982-a6e3-bf98a5c6c797"), new DateTime(2024, 3, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7802), "Bracing", 38, 100 },
                    { new Guid("4cf8cacd-4447-4d5d-8c02-21b360c2e5c1"), new DateTime(2022, 12, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5409), "Chilly", 36, 96 },
                    { new Guid("4d05461b-ed96-460e-ac72-5970b89454f2"), new DateTime(2023, 4, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6007), "Mild", 31, 87 },
                    { new Guid("4d0b057e-d9a9-49e7-af1f-b8ce74c6dea1"), new DateTime(2024, 4, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7953), "Warm", 17, 62 },
                    { new Guid("4d2d71ae-d368-4016-9bef-28b372a2f175"), new DateTime(2022, 5, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4051), "Freezing", 31, 87 },
                    { new Guid("4dee4729-e308-4c03-8ff4-be404e5a703e"), new DateTime(2022, 6, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4131), "Hot", -12, 11 },
                    { new Guid("4ebf8b0a-c8af-4025-a43a-1fd6294ac099"), new DateTime(2024, 7, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8261), "Cool", 43, 109 },
                    { new Guid("4f0fd730-f232-4394-b1de-7957fc65db5e"), new DateTime(2024, 9, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8422), "Balmy", -3, 27 },
                    { new Guid("4f3731ac-fa4d-4698-8484-69dded65f650"), new DateTime(2023, 7, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6593), "Bracing", -9, 16 },
                    { new Guid("4f96c1a6-c68a-4a61-9304-6b3a98f7baec"), new DateTime(2024, 5, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8026), "Balmy", 40, 103 },
                    { new Guid("5002c004-5c4d-4623-a365-f666f9b06855"), new DateTime(2023, 11, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7413), "Cool", 45, 112 },
                    { new Guid("500a98c9-b556-4d7e-a7ab-2d6dc4a13f00"), new DateTime(2024, 5, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8034), "Hot", -13, 9 },
                    { new Guid("500e9508-a37e-4d7d-b12e-56dc876b08d5"), new DateTime(2023, 12, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7556), "Chilly", -15, 6 },
                    { new Guid("501ac3ae-6d7f-41fc-86e2-e983bb62d9f8"), new DateTime(2024, 11, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8598), "Bracing", -16, 4 },
                    { new Guid("504338d6-06df-416f-a333-e0df74bfde24"), new DateTime(2024, 3, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7866), "Scorching", 31, 87 },
                    { new Guid("509339d0-2dab-4928-842d-10e6d44fe60f"), new DateTime(2023, 8, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6637), "Sweltering", -19, -2 },
                    { new Guid("513ad520-8815-4c7c-9e30-f614e495638d"), new DateTime(2023, 8, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6640), "Scorching", 17, 62 },
                    { new Guid("516d524f-af2f-4901-9ca2-8a3f157aaccb"), new DateTime(2023, 4, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5984), "Chilly", 2, 35 },
                    { new Guid("51bd8c50-bcf2-4604-bf27-e51da796e21d"), new DateTime(2024, 4, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7973), "Scorching", -5, 24 },
                    { new Guid("51f4c329-db31-496a-82ad-6f4ee167d66c"), new DateTime(2022, 10, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4934), "Warm", 2, 35 },
                    { new Guid("5211ec16-dd18-450d-98ff-4febf9a05f52"), new DateTime(2022, 10, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4940), "Mild", 30, 85 },
                    { new Guid("52279c6f-184b-4f7a-adcf-6651954cbad0"), new DateTime(2023, 1, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5540), "Freezing", 8, 46 },
                    { new Guid("52a0655e-3a03-44a7-996e-18883e5b3d5a"), new DateTime(2024, 3, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7874), "Chilly", 29, 84 },
                    { new Guid("52b99b0f-79d7-4d2d-b5a2-8e0115c8137a"), new DateTime(2023, 7, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6584), "Sweltering", -15, 6 },
                    { new Guid("52f8f8e6-7b13-40ab-a11c-aac5295b2615"), new DateTime(2023, 11, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7462), "Mild", 1, 33 },
                    { new Guid("538fe654-171d-4007-91e4-9a1a945880b6"), new DateTime(2023, 5, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6050), "Cool", 5, 40 },
                    { new Guid("53cb325e-3943-4aa9-be1f-6a39c67eabca"), new DateTime(2023, 11, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7477), "Scorching", 2, 35 },
                    { new Guid("546de9b9-25b6-439a-93bd-9ead1c4c1093"), new DateTime(2024, 2, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7729), "Scorching", 20, 67 },
                    { new Guid("54a66529-1c35-4fb7-ae95-c3d044a29560"), new DateTime(2023, 10, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6949), "Chilly", 43, 109 },
                    { new Guid("56764328-a6c7-45a4-a22c-3447b4f626a1"), new DateTime(2022, 6, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4158), "Sweltering", 52, 125 },
                    { new Guid("56990843-0199-4dff-93ec-e633fee969ee"), new DateTime(2024, 10, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8464), "Mild", -9, 16 },
                    { new Guid("569adcda-4faa-4bed-9215-83a3df77d9ee"), new DateTime(2023, 10, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7256), "Freezing", -14, 7 },
                    { new Guid("5845d71a-56b6-41c6-8174-615540407282"), new DateTime(2024, 4, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7906), "Bracing", 37, 98 },
                    { new Guid("587f94cb-9b56-4ddf-b5b2-7f753cf9e224"), new DateTime(2024, 2, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7759), "Chilly", 8, 46 },
                    { new Guid("58d5b219-8ac7-4949-8bdc-1a6874141d9a"), new DateTime(2023, 10, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6955), "Chilly", -3, 27 },
                    { new Guid("58f41cb3-f2e5-49a9-b5eb-55f5086fd671"), new DateTime(2024, 5, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8044), "Cool", 37, 98 },
                    { new Guid("592e0e14-a13f-459b-83dc-80b5e701072f"), new DateTime(2024, 1, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7605), "Hot", 10, 49 },
                    { new Guid("593fca8b-cddd-4cff-992d-1dd16c080600"), new DateTime(2022, 7, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4244), "Hot", 50, 121 },
                    { new Guid("5961124a-cb17-4576-a8e6-a4dea8d38fd5"), new DateTime(2024, 7, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8253), "Warm", 29, 84 },
                    { new Guid("5a2dacfb-5329-4763-ab54-9374a3f91f8c"), new DateTime(2022, 7, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4443), "Hot", 33, 91 },
                    { new Guid("5ab3ef48-6e0e-4f63-9efd-3d7a526311d8"), new DateTime(2023, 1, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5580), "Bracing", 46, 114 },
                    { new Guid("5acb161c-be62-4442-a5ff-28edc8c302cf"), new DateTime(2022, 12, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5417), "Hot", 43, 109 },
                    { new Guid("5b0f83e7-b9a1-4dc8-b021-a1280d6b8977"), new DateTime(2023, 9, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6921), "Mild", 37, 98 },
                    { new Guid("5b5c1ee6-2939-4f2d-af34-36d7a8370b94"), new DateTime(2023, 4, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6015), "Sweltering", 0, 32 },
                    { new Guid("5b889dad-d2b7-432c-8d45-34171aa242f2"), new DateTime(2025, 1, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8827), "Cool", 43, 109 },
                    { new Guid("5c1e893a-2b1a-4b13-b37c-69120068fbe8"), new DateTime(2024, 6, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8115), "Chilly", 32, 89 },
                    { new Guid("5ca01240-08c7-4884-a338-81c84a5a0d1d"), new DateTime(2024, 11, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8637), "Cool", 53, 127 },
                    { new Guid("5cc7a6d2-57b5-4381-8de0-7622fee34d64"), new DateTime(2022, 10, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4899), "Bracing", -20, -3 },
                    { new Guid("5ced9d50-3cf0-4ba6-82b2-99342cc88a2b"), new DateTime(2022, 12, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5463), "Mild", -20, -3 },
                    { new Guid("5d0bc765-44a2-4709-b97c-ecb9ac440cdd"), new DateTime(2024, 10, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8461), "Warm", -11, 13 },
                    { new Guid("5d12ec5d-3ee1-48f4-a2e8-1ab9201a9343"), new DateTime(2023, 2, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5651), "Balmy", -18, 0 },
                    { new Guid("5d2cb68f-7033-487a-a421-3c71c14ab820"), new DateTime(2024, 7, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8235), "Hot", 20, 67 },
                    { new Guid("5d4f2cda-f06f-47ce-9992-c4bda4c8a8d7"), new DateTime(2024, 7, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8171), "Mild", -17, 2 },
                    { new Guid("5d75ef3f-d827-416b-8893-cf0135c71c92"), new DateTime(2023, 12, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7548), "Bracing", -2, 29 },
                    { new Guid("5db0832c-1091-433d-bcb1-9b0759d2b5ee"), new DateTime(2024, 9, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8436), "Chilly", 34, 93 },
                    { new Guid("5dfd1c71-889c-417b-aad4-bc2624445540"), new DateTime(2024, 10, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8570), "Chilly", 22, 71 },
                    { new Guid("5e11a5d6-d416-43b2-9548-b2274ea939ca"), new DateTime(2023, 2, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5661), "Warm", 50, 121 },
                    { new Guid("5e88cb9e-df4d-4b9d-9e00-0aeebd5fc137"), new DateTime(2024, 2, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7723), "Chilly", 16, 60 },
                    { new Guid("5e93a6e3-7ab9-4834-90d4-16e662d324dc"), new DateTime(2024, 9, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8444), "Mild", 35, 94 },
                    { new Guid("5ec13334-b507-4754-9e46-71102726bf55"), new DateTime(2022, 7, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4432), "Cool", 16, 60 },
                    { new Guid("5ece13de-96a7-41c6-97e4-081fae2e42df"), new DateTime(2023, 4, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6043), "Bracing", 4, 39 },
                    { new Guid("5f421645-bd5b-4316-b69f-7a84ecfd048d"), new DateTime(2022, 11, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5108), "Hot", 23, 73 },
                    { new Guid("5f4c8bbb-04cd-4768-bce7-77fc90755f5e"), new DateTime(2022, 10, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4888), "Warm", 32, 89 },
                    { new Guid("5f690d60-36b5-4d64-aa7f-a42c3e15626b"), new DateTime(2024, 9, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8374), "Scorching", 41, 105 },
                    { new Guid("5f8611fc-0550-4ef0-9a3d-2e339d7221d6"), new DateTime(2024, 12, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8715), "Freezing", 16, 60 },
                    { new Guid("5ff0483b-8bba-4f67-b5f1-035297f2b9fb"), new DateTime(2023, 4, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5979), "Cool", 7, 44 },
                    { new Guid("601899ad-ddb9-482e-b63f-b47fa4c23a88"), new DateTime(2023, 12, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7516), "Mild", 27, 80 },
                    { new Guid("6043b7ee-f414-40f8-b1b3-7b902683d922"), new DateTime(2024, 1, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7600), "Mild", 19, 66 },
                    { new Guid("60536472-d4f6-4fc3-aa74-92611fcd1ed0"), new DateTime(2024, 9, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8402), "Freezing", 29, 84 },
                    { new Guid("6065a625-ee20-4142-8eb0-5d90340a43d8"), new DateTime(2023, 6, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6468), "Bracing", 27, 80 },
                    { new Guid("60a64484-bff1-4c0f-b32f-8549f0f829b3"), new DateTime(2024, 3, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7854), "Balmy", 51, 123 },
                    { new Guid("60ff413a-2ead-4e5a-b96b-a59b9c1f89e6"), new DateTime(2022, 8, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4484), "Mild", 32, 89 },
                    { new Guid("613cf35d-b944-4e56-98a6-1cea41e6f335"), new DateTime(2024, 12, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8748), "Bracing", 44, 111 },
                    { new Guid("61f2eb7d-6e12-4cff-ab96-beda2fb46beb"), new DateTime(2024, 7, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8271), "Balmy", 41, 105 },
                    { new Guid("61f9ff6a-a4f8-4258-a162-88a01d0390ea"), new DateTime(2024, 7, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8238), "Bracing", 4, 39 },
                    { new Guid("6277398a-e86d-4e54-90c8-83ede672d3bd"), new DateTime(2022, 9, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4808), "Chilly", -20, -3 },
                    { new Guid("627f38c3-f132-4ec0-a208-0682c1235686"), new DateTime(2022, 7, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4234), "Sweltering", -4, 25 },
                    { new Guid("62e10a4d-c4fb-450b-b1c0-0bf65e1e4128"), new DateTime(2024, 11, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8654), "Bracing", -6, 22 },
                    { new Guid("6357518b-1bc5-4bde-abf1-a59dd46b7451"), new DateTime(2023, 12, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7511), "Balmy", 9, 48 },
                    { new Guid("637c63d6-a377-4c68-a9e2-b6c5b0439771"), new DateTime(2024, 11, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8616), "Bracing", 8, 46 },
                    { new Guid("641f0f60-01d4-4f86-9040-3d2dcb2c96e9"), new DateTime(2024, 4, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7966), "Warm", -17, 2 },
                    { new Guid("64a71201-0e34-46dd-a7f0-4bd396cb0b1c"), new DateTime(2022, 9, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4832), "Cool", -5, 24 },
                    { new Guid("6591f603-e488-460e-8e86-b68d2adc1535"), new DateTime(2023, 2, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5619), "Cool", 39, 102 },
                    { new Guid("65de7aa4-bda9-4716-a263-7ae6f7a0e149"), new DateTime(2023, 8, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6627), "Freezing", -10, 15 },
                    { new Guid("667a0de5-e2c2-4c49-8751-19b86910f4c3"), new DateTime(2024, 11, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8590), "Chilly", 34, 93 },
                    { new Guid("668d7693-7712-4754-a8d8-041c8664b13a"), new DateTime(2023, 12, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7576), "Mild", 50, 121 },
                    { new Guid("6755615e-2a64-4e34-85d4-e437edd59e1c"), new DateTime(2023, 10, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7251), "Cool", 48, 118 },
                    { new Guid("676c63d8-3762-45a9-a0bc-ebe87555657f"), new DateTime(2024, 1, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7691), "Scorching", 1, 33 },
                    { new Guid("67de61e7-31e2-44bf-98da-3dfe5192075c"), new DateTime(2023, 9, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6730), "Hot", -20, -3 },
                    { new Guid("6839f5b5-b340-4b04-984d-e830fa7c1a10"), new DateTime(2024, 2, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7792), "Cool", -1, 31 },
                    { new Guid("68c34646-e200-43fc-8862-5830484b7604"), new DateTime(2024, 1, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7714), "Cool", 3, 37 },
                    { new Guid("69184700-e792-45f0-98a6-5c406b718382"), new DateTime(2024, 5, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8004), "Hot", -19, -2 },
                    { new Guid("691a6e99-4224-4842-9e34-1eaea787c986"), new DateTime(2024, 8, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8312), "Sweltering", -4, 25 },
                    { new Guid("692b3306-d351-4943-b8ce-eb4c01dd03d5"), new DateTime(2023, 12, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7572), "Warm", 9, 48 },
                    { new Guid("69bc1b73-323f-490c-a6c3-5c5267d332d1"), new DateTime(2023, 8, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6684), "Cool", 17, 62 },
                    { new Guid("6a0e2650-5d7a-4759-8db3-e7b99b9eaf07"), new DateTime(2024, 11, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8659), "Freezing", 33, 91 },
                    { new Guid("6a16d55d-6803-4e32-98ca-1bff56e14bb3"), new DateTime(2023, 7, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6574), "Mild", 3, 37 },
                    { new Guid("6a1740ac-e7fc-482f-bb74-ad150891657e"), new DateTime(2022, 6, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4104), "Warm", 46, 114 },
                    { new Guid("6a2e4ca8-925c-49b0-9625-2d6b9fdf2c74"), new DateTime(2023, 11, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7457), "Chilly", -11, 13 },
                    { new Guid("6a6e408e-c51c-439c-9cc1-d2d344ca329f"), new DateTime(2023, 1, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5596), "Freezing", 5, 40 },
                    { new Guid("6a9eb2db-0053-4383-a0fe-f68a22127465"), new DateTime(2023, 2, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5655), "Mild", 35, 94 },
                    { new Guid("6ac18d14-ffad-4a96-a353-c1436a13b492"), new DateTime(2022, 12, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5428), "Chilly", -4, 25 },
                    { new Guid("6bbbde82-4450-4b5f-b8fc-d4920802eb48"), new DateTime(2024, 2, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7749), "Sweltering", 1, 33 },
                    { new Guid("6be7cf2f-13a9-407e-8d22-7fd2e284ac22"), new DateTime(2023, 11, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7424), "Scorching", -4, 25 },
                    { new Guid("6bf8d84e-021f-48c5-9209-e3e951b1b34f"), new DateTime(2024, 12, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8733), "Balmy", 4, 39 },
                    { new Guid("6c06e92d-9fe8-4a75-8bf6-332570891af9"), new DateTime(2023, 6, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6465), "Chilly", 36, 96 },
                    { new Guid("6c0848fc-a2d2-4c79-b46a-100169b408c7"), new DateTime(2025, 1, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8822), "Mild", -10, 15 },
                    { new Guid("6cbf9bb7-a717-4b19-8446-2ad82d97a4ee"), new DateTime(2023, 12, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7559), "Sweltering", 11, 51 },
                    { new Guid("6cdc517e-887b-43ed-b7b2-fba018394e77"), new DateTime(2022, 8, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4464), "Freezing", 49, 120 },
                    { new Guid("6cfbe981-29d5-41cd-8cb5-12b0ea5250ec"), new DateTime(2024, 7, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8264), "Freezing", 32, 89 },
                    { new Guid("6d2c4ae9-ab7f-4728-8b18-ca49d60b4083"), new DateTime(2022, 10, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4874), "Scorching", 11, 51 },
                    { new Guid("6d646970-1b6a-4dd4-83b3-6720aedfa4d7"), new DateTime(2023, 10, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7227), "Cool", 34, 93 },
                    { new Guid("6d8ccb46-7287-45fc-9ed0-4653caf56f47"), new DateTime(2024, 9, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8434), "Balmy", 50, 121 },
                    { new Guid("6dac479f-346f-4198-a4bb-362c97963904"), new DateTime(2023, 8, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6653), "Freezing", 13, 55 },
                    { new Guid("6df83b64-2030-4a81-afe3-1e737f1153f0"), new DateTime(2024, 5, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8066), "Sweltering", -2, 29 },
                    { new Guid("6e41611b-7326-487d-94a3-715124891f4d"), new DateTime(2023, 4, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5987), "Warm", 23, 73 },
                    { new Guid("6e5cfebe-4ffc-49ec-a707-c513cc238174"), new DateTime(2023, 6, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6151), "Sweltering", 19, 66 },
                    { new Guid("6e680fce-b949-4432-81a5-81951364f9dd"), new DateTime(2022, 8, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4499), "Sweltering", 22, 71 },
                    { new Guid("6ef34109-cffc-4691-a657-3500c90d7f4d"), new DateTime(2024, 11, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8640), "Sweltering", 12, 53 },
                    { new Guid("6f0ef99d-3a4f-4d47-b3a4-a13898a89e8d"), new DateTime(2023, 9, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6903), "Mild", 19, 66 },
                    { new Guid("6f5f2799-7233-45fd-97d3-fb7bd1515af3"), new DateTime(2024, 2, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7784), "Freezing", 29, 84 },
                    { new Guid("6f61bcc1-c2e2-4734-ae55-c940728babf1"), new DateTime(2022, 11, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5185), "Cool", -15, 6 },
                    { new Guid("6f7fd933-4dce-4c9c-87a5-9ddecfad80aa"), new DateTime(2022, 9, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4829), "Sweltering", 45, 112 },
                    { new Guid("6ff05e30-f912-419c-a9bc-93052c6c0f75"), new DateTime(2024, 4, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7936), "Freezing", -6, 22 },
                    { new Guid("70750de4-eeed-4b9f-921b-f63bdfa359a4"), new DateTime(2023, 11, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7480), "Scorching", 12, 53 },
                    { new Guid("7095a179-d38b-4a94-8fd0-21ee835e0b30"), new DateTime(2023, 8, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6681), "Warm", 16, 60 },
                    { new Guid("70d8b59c-2f2e-458e-89fe-4c9929b29b1a"), new DateTime(2024, 6, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8166), "Balmy", -15, 6 },
                    { new Guid("717585ac-3bc9-4429-9dbb-9cc2f4c8da51"), new DateTime(2024, 10, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8573), "Freezing", 11, 51 },
                    { new Guid("71791bc6-7278-42f2-908f-51def56e4d05"), new DateTime(2024, 1, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7660), "Hot", 36, 96 },
                    { new Guid("71c24239-085f-4745-bb0f-ed263897e09b"), new DateTime(2022, 10, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4926), "Balmy", 14, 57 },
                    { new Guid("71dc0815-5ec7-4016-a77e-f609cf3c9848"), new DateTime(2023, 7, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6571), "Mild", 23, 73 },
                    { new Guid("72109adb-ebbf-4004-b3ee-5c44ee71235e"), new DateTime(2024, 4, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7908), "Bracing", 47, 116 },
                    { new Guid("722101f2-ba22-4313-aa46-f8626555ce14"), new DateTime(2024, 9, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8429), "Chilly", 44, 111 },
                    { new Guid("725664a2-5023-4850-9b73-f949662e0e58"), new DateTime(2023, 10, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7240), "Cool", 1, 33 },
                    { new Guid("727758f4-6c2a-4f8c-b033-8c57fad02bd9"), new DateTime(2024, 3, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7840), "Chilly", 42, 107 },
                    { new Guid("728d8a8e-b250-4128-92cd-e296a8833f89"), new DateTime(2022, 6, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4160), "Scorching", 39, 102 },
                    { new Guid("732fd6c8-a9d0-4296-91f9-19b83e5a30ab"), new DateTime(2022, 10, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4870), "Chilly", 22, 71 },
                    { new Guid("73496c30-fc7b-4027-96da-7ffe96614f71"), new DateTime(2023, 8, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6673), "Freezing", 13, 55 },
                    { new Guid("73c45e83-85ce-4a07-a101-d2648821e4ef"), new DateTime(2024, 11, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8645), "Hot", -7, 20 },
                    { new Guid("73feccfd-4628-4c86-b8d7-fca2f340d8db"), new DateTime(2022, 9, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4819), "Mild", 51, 123 },
                    { new Guid("741225a4-9b85-4c2a-b764-603cc78e272c"), new DateTime(2023, 2, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5690), "Balmy", 22, 71 },
                    { new Guid("745028e5-ea84-4183-8d21-468b24ac217d"), new DateTime(2023, 12, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7525), "Cool", -11, 13 },
                    { new Guid("7460d7f5-0188-4d27-86c8-2eebc13c584c"), new DateTime(2022, 5, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4040), "Chilly", -1, 31 },
                    { new Guid("746d7f03-88db-45d5-a5a8-9f8cc03f34c9"), new DateTime(2023, 6, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6146), "Cool", -4, 25 },
                    { new Guid("7472a248-31a9-4a5f-93fe-1ec2343fb926"), new DateTime(2022, 12, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5458), "Warm", 37, 98 },
                    { new Guid("7479a918-c675-46bc-b2c4-c39aa611a6fc"), new DateTime(2024, 6, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8082), "Cool", -14, 7 },
                    { new Guid("74c19658-16d8-44f4-acb6-e578ec3e90da"), new DateTime(2023, 3, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5714), "Freezing", 47, 116 },
                    { new Guid("7504eadc-8ac8-40e0-ae83-21c6377daf80"), new DateTime(2023, 4, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6020), "Freezing", -7, 20 },
                    { new Guid("75f1c675-85d7-419c-90e5-88c96ed73777"), new DateTime(2022, 8, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4742), "Bracing", 23, 73 },
                    { new Guid("762d327e-ac68-4c99-8366-fa6e96c66b09"), new DateTime(2022, 6, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4136), "Sweltering", 2, 35 },
                    { new Guid("767d36f8-e063-420d-801a-4c6acadacec1"), new DateTime(2024, 4, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7991), "Freezing", 18, 64 },
                    { new Guid("76a526f3-498d-499a-8b41-fbf9bd1dbbd5"), new DateTime(2024, 6, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8100), "Warm", 53, 127 },
                    { new Guid("76de02c8-3357-44bf-beee-a90209daf6e8"), new DateTime(2022, 6, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4139), "Warm", -12, 11 },
                    { new Guid("76e6ff0a-a221-42e5-979b-0d1d7eb5f990"), new DateTime(2022, 8, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4725), "Cool", 28, 82 },
                    { new Guid("773848af-b12b-4696-a825-f6fce044f310"), new DateTime(2023, 10, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7254), "Sweltering", -9, 16 },
                    { new Guid("77532f4f-fff2-4007-bf6c-2cd4e47b379b"), new DateTime(2023, 1, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5548), "Scorching", 43, 109 },
                    { new Guid("7766e89f-6dfd-432e-845e-e956b56b7cca"), new DateTime(2023, 2, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5666), "Balmy", -14, 7 },
                    { new Guid("778e39b6-5bfb-4944-b427-3a482d998657"), new DateTime(2023, 9, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6934), "Sweltering", 54, 129 },
                    { new Guid("785c99c8-c768-4de3-9db6-d943eaf61c79"), new DateTime(2023, 9, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6897), "Scorching", 12, 53 },
                    { new Guid("78a9d203-8088-48b8-b895-127698179a60"), new DateTime(2023, 7, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6599), "Sweltering", 35, 94 },
                    { new Guid("78e2c99d-cd93-4972-9a6a-f87aa6247ece"), new DateTime(2024, 1, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7701), "Warm", -10, 15 },
                    { new Guid("78eea2f6-84f7-4015-8079-5bdabda49705"), new DateTime(2024, 10, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8481), "Mild", 1, 33 },
                    { new Guid("79b5aa80-7d1e-450f-bca9-f0ca59e64f4b"), new DateTime(2024, 12, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8710), "Chilly", 36, 96 },
                    { new Guid("7a141405-a525-426f-b208-dfc0f682a9fd"), new DateTime(2022, 7, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4258), "Chilly", 2, 35 },
                    { new Guid("7a158044-6c80-43a8-a2be-b1f632a4f1a0"), new DateTime(2022, 10, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4904), "Bracing", 31, 87 },
                    { new Guid("7a45aa8e-5d78-44ab-b111-0e2d4ae0ffbf"), new DateTime(2022, 7, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4225), "Hot", 42, 107 },
                    { new Guid("7a7f4f4f-34a0-48c8-9137-2f18410c6afb"), new DateTime(2024, 3, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7799), "Warm", 45, 112 },
                    { new Guid("7abf06f6-f7d8-4683-93a6-edab4b8d7a88"), new DateTime(2024, 7, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8189), "Sweltering", -10, 15 },
                    { new Guid("7ad71347-8a89-49f7-a1b8-61186ccde763"), new DateTime(2023, 9, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6932), "Hot", 52, 125 },
                    { new Guid("7aefae62-95dc-4bbe-8b2f-9f2096921a93"), new DateTime(2022, 8, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4492), "Chilly", -12, 11 },
                    { new Guid("7b99909d-fdba-4a0e-94f3-d79d6d3548ed"), new DateTime(2023, 6, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6135), "Scorching", 29, 84 },
                    { new Guid("7baa5f4c-d0ca-48c1-81c9-09d799aaaf0f"), new DateTime(2024, 9, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8447), "Sweltering", 48, 118 },
                    { new Guid("7bb9cbcd-1af5-4562-b742-41d1dbe3d4a0"), new DateTime(2024, 3, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7820), "Scorching", 22, 71 },
                    { new Guid("7c72c56f-0cf7-4528-a0ae-9b29b89c3e2d"), new DateTime(2023, 5, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6096), "Chilly", 28, 82 },
                    { new Guid("7ca1ff40-ca55-4859-a710-564894b6b180"), new DateTime(2022, 11, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5131), "Mild", 38, 100 },
                    { new Guid("7cf677ae-7c80-4f73-afbe-0c7c50e710d6"), new DateTime(2024, 5, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8071), "Chilly", 9, 48 },
                    { new Guid("7d5e7afb-208b-490f-ae17-28c0c07e5ec0"), new DateTime(2024, 4, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7894), "Mild", 45, 112 },
                    { new Guid("7d7479b4-a1f6-4bbb-879a-6e6dd41c2c38"), new DateTime(2023, 8, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6716), "Freezing", 10, 49 },
                    { new Guid("7d99f7bf-4bf6-4788-8932-02036d5f0d28"), new DateTime(2024, 4, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7951), "Chilly", -1, 31 },
                    { new Guid("7e0f3261-cde3-4731-a3be-bf7167531507"), new DateTime(2024, 8, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8322), "Hot", 52, 125 },
                    { new Guid("7e79887e-3877-448e-b5cb-e3e74151889b"), new DateTime(2023, 3, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5758), "Balmy", -20, -3 },
                    { new Guid("7e7dcbf6-62e3-43c7-9973-a1cacee00faf"), new DateTime(2022, 7, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4249), "Warm", 45, 112 },
                    { new Guid("7eb0f634-7a22-4699-b265-f012fa37f56a"), new DateTime(2024, 5, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8051), "Mild", 13, 55 },
                    { new Guid("7f0c9183-e66f-47f0-801a-1e118e9d7cd0"), new DateTime(2024, 8, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8286), "Cool", 28, 82 },
                    { new Guid("7f0dd91e-00ef-4dda-bfe5-9b5ccbda71b7"), new DateTime(2023, 6, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6443), "Cool", 15, 58 },
                    { new Guid("7f553f93-a687-4038-aa7f-cadb446ee656"), new DateTime(2023, 4, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6038), "Warm", 9, 48 },
                    { new Guid("7f65b717-aae0-4797-82a7-efaab92991aa"), new DateTime(2023, 12, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7508), "Chilly", -18, 0 },
                    { new Guid("8028b148-8b7b-4a48-b823-c2aa009d9101"), new DateTime(2024, 4, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7989), "Bracing", 44, 111 },
                    { new Guid("802d2300-874e-4200-a3d5-a2485ddaf61d"), new DateTime(2022, 5, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4034), "Balmy", 23, 73 },
                    { new Guid("8031f37f-484d-4ddb-9eca-69fb87d6a092"), new DateTime(2022, 8, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4487), "Freezing", 12, 53 },
                    { new Guid("80982da9-d64c-4a75-bed1-56950d6ce835"), new DateTime(2024, 11, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8603), "Sweltering", 13, 55 },
                    { new Guid("80df76cd-b917-45ab-9976-5172e4ef22c3"), new DateTime(2024, 11, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8608), "Mild", 39, 102 },
                    { new Guid("80f624cd-bbd6-4e68-bb74-e4761f963f93"), new DateTime(2023, 5, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6110), "Sweltering", 16, 60 },
                    { new Guid("8156cc8e-974d-4a08-a0fd-15c3d35e3af1"), new DateTime(2023, 5, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6065), "Warm", 23, 73 },
                    { new Guid("8191dd9a-ce5e-40b2-b651-d45905801fe3"), new DateTime(2022, 6, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4098), "Bracing", 29, 84 },
                    { new Guid("81d347fc-b85a-4158-911a-0e18d786f330"), new DateTime(2024, 2, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7739), "Scorching", 32, 89 },
                    { new Guid("823c1475-058a-4322-b7db-4794298d36cb"), new DateTime(2024, 11, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8595), "Sweltering", -6, 22 },
                    { new Guid("8246e50d-2eb4-4e00-860e-2629782e2e8d"), new DateTime(2023, 9, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6929), "Bracing", 36, 96 },
                    { new Guid("8273db50-68a4-4415-87c0-7f4832eeb8f8"), new DateTime(2023, 9, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6924), "Mild", 24, 75 },
                    { new Guid("82976034-af29-4bc5-b593-84c21f1b7fed"), new DateTime(2024, 9, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8377), "Bracing", 28, 82 },
                    { new Guid("829a833a-ad53-444f-aba1-a4d7c27ba948"), new DateTime(2024, 7, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8258), "Cool", 13, 55 },
                    { new Guid("830b859d-2cee-44fc-9b88-81f7ca1a9498"), new DateTime(2023, 6, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6446), "Balmy", -19, -2 },
                    { new Guid("831e04a5-5fbb-4da7-9830-ede3b78f1646"), new DateTime(2023, 5, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6058), "Scorching", 16, 60 },
                    { new Guid("83e3fc51-7454-4c45-a81b-b68631e4a48a"), new DateTime(2024, 11, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8610), "Cool", 23, 73 },
                    { new Guid("8414817f-73d4-4206-8a46-18bc7dc68787"), new DateTime(2024, 8, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8332), "Hot", 13, 55 },
                    { new Guid("843129df-c087-4b78-a311-f2e1705e6c42"), new DateTime(2024, 12, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8738), "Chilly", 6, 42 },
                    { new Guid("84f1d61d-2b51-4f27-86ec-d1660a49829e"), new DateTime(2023, 10, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7224), "Cool", -8, 18 },
                    { new Guid("851b61f5-490c-4219-99de-c32f229ac327"), new DateTime(2024, 10, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8543), "Bracing", 16, 60 },
                    { new Guid("85a1dfc6-bec8-4266-ae6d-a92d5e6580f9"), new DateTime(2023, 10, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7264), "Sweltering", 27, 80 },
                    { new Guid("86499c93-37b1-4414-9d5e-ab15a070a4fc"), new DateTime(2023, 7, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6518), "Hot", -18, 0 },
                    { new Guid("864eefba-cb4e-4c65-a8b9-37a762548f3c"), new DateTime(2024, 2, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7762), "Chilly", -13, 9 },
                    { new Guid("867aa622-7182-47aa-8364-0d01d25d6cc8"), new DateTime(2023, 3, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5774), "Balmy", -3, 27 },
                    { new Guid("86cdcb86-deb3-4870-9faa-c3da69afffd1"), new DateTime(2022, 6, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4090), "Mild", -7, 20 },
                    { new Guid("86e89a61-8d32-4bb9-ab6d-e84e56236ae6"), new DateTime(2022, 8, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4722), "Chilly", 14, 57 },
                    { new Guid("871a7a57-c04b-465f-87c2-514f83f2302f"), new DateTime(2024, 5, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8019), "Cool", -1, 31 },
                    { new Guid("874fbfa1-a381-45d1-96a0-cd3bf39608ea"), new DateTime(2024, 7, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8174), "Warm", -16, 4 },
                    { new Guid("87f5477f-f425-48da-815c-74ae0ff6b2da"), new DateTime(2022, 5, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4056), "Mild", -11, 13 },
                    { new Guid("87fbb6fa-3d90-4e31-810d-b49de5083afd"), new DateTime(2024, 6, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8164), "Balmy", 49, 120 },
                    { new Guid("88799418-67a3-4ed4-b580-6f5a75bfdf77"), new DateTime(2023, 3, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5698), "Scorching", -10, 15 },
                    { new Guid("888e8f1e-de6b-476e-b897-fe8f986649d0"), new DateTime(2023, 9, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6725), "Hot", -20, -3 },
                    { new Guid("88d5f39a-a639-424d-a4b4-34e948a80253"), new DateTime(2024, 10, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8568), "Cool", 41, 105 },
                    { new Guid("88ec3cd3-8a5b-498b-8a91-6538ffef88b6"), new DateTime(2023, 10, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7248), "Freezing", 6, 42 },
                    { new Guid("8951ee51-c2cb-4747-8b3b-88fbcd1dc377"), new DateTime(2022, 5, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4012), "Hot", 33, 91 },
                    { new Guid("899078ed-cea3-4884-8b1f-ec8ed120062a"), new DateTime(2023, 8, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6711), "Bracing", -11, 13 },
                    { new Guid("8a45aac9-554e-4726-8a43-0d47d17a98f7"), new DateTime(2024, 3, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7817), "Mild", 48, 118 },
                    { new Guid("8a53d677-8652-49db-b8e6-1f7335ddf066"), new DateTime(2024, 6, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8118), "Bracing", 29, 84 },
                    { new Guid("8b6c1379-df30-450b-a137-2bb96e305ba9"), new DateTime(2024, 4, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7946), "Chilly", 48, 118 },
                    { new Guid("8b8fd564-1424-42cf-b99e-46e693fa0423"), new DateTime(2023, 7, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6587), "Bracing", -6, 22 },
                    { new Guid("8bd42934-a85f-470c-b6fd-3ab837fd549d"), new DateTime(2022, 6, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4088), "Cool", -19, -2 },
                    { new Guid("8c53c88f-b625-44db-9659-1548657c9a2f"), new DateTime(2024, 8, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8309), "Scorching", 3, 37 },
                    { new Guid("8c5cdf48-90cd-4e60-b183-7e7f45b79b26"), new DateTime(2024, 7, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8276), "Sweltering", -17, 2 },
                    { new Guid("8ccf09bb-1905-4d72-b50e-a225e297233f"), new DateTime(2024, 12, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8713), "Sweltering", 34, 93 },
                    { new Guid("8d099a77-79d7-4e06-bf41-a68f7a69dfa8"), new DateTime(2023, 5, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6106), "Chilly", 44, 111 },
                    { new Guid("8d101eea-b23c-4396-bec6-c4219aed70a6"), new DateTime(2022, 12, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5439), "Warm", 42, 107 },
                    { new Guid("8d38b98b-0b0a-42dc-b4c1-f2212e81740f"), new DateTime(2022, 11, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5134), "Mild", 26, 78 },
                    { new Guid("8dc829f6-c7d8-4f85-9273-c3d75f109503"), new DateTime(2024, 10, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8479), "Scorching", -15, 6 },
                    { new Guid("8dc9484d-469e-4a44-82d5-4f7c182c18f7"), new DateTime(2023, 3, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5745), "Balmy", 37, 98 },
                    { new Guid("8e02e456-902d-4bb7-80b0-530cca1a6dac"), new DateTime(2023, 1, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5569), "Cool", 48, 118 },
                    { new Guid("8f0c84ee-113e-4061-91d3-c29377448ea1"), new DateTime(2022, 10, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4909), "Chilly", -1, 31 },
                    { new Guid("8f6f3bf4-7eff-47ac-8044-71a41a5c30ac"), new DateTime(2022, 10, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4947), "Balmy", 15, 58 },
                    { new Guid("8fe0d7e7-6206-4919-a7f7-74884df4bfb9"), new DateTime(2023, 7, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6550), "Sweltering", 19, 66 },
                    { new Guid("8ff4436e-522b-4309-9f0e-2fd453673036"), new DateTime(2023, 7, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6516), "Chilly", 38, 100 },
                    { new Guid("90e1d8ae-5022-40b1-8c1c-88ae535c83ce"), new DateTime(2023, 2, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5613), "Mild", -11, 13 },
                    { new Guid("91231813-3cb7-45a5-ae33-3a9329f252f1"), new DateTime(2024, 5, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8064), "Sweltering", 50, 121 },
                    { new Guid("9123cb63-4450-4870-9d45-4cdd07364807"), new DateTime(2022, 6, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4197), "Mild", -3, 27 },
                    { new Guid("9126f6be-fa5a-4265-9a4e-659ec0634250"), new DateTime(2023, 6, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6454), "Mild", 36, 96 },
                    { new Guid("91aa6b17-c8b7-47f1-96a4-dec5cf241b78"), new DateTime(2024, 4, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7899), "Mild", 9, 48 },
                    { new Guid("91c5a3c2-9f21-459d-83c3-91b1a7a3341a"), new DateTime(2023, 7, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6604), "Mild", 28, 82 },
                    { new Guid("91d33a75-5b5f-4f27-befa-dec53e0b16f2"), new DateTime(2023, 5, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6073), "Bracing", 18, 64 },
                    { new Guid("920763ed-5749-41d4-99ea-4748413771c7"), new DateTime(2024, 12, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8695), "Freezing", 41, 105 },
                    { new Guid("925daede-2262-4b15-a8d0-e0ffd380490a"), new DateTime(2022, 11, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5126), "Hot", -4, 25 },
                    { new Guid("92617e8d-d1dc-41f6-9ab9-681b6134dfc3"), new DateTime(2024, 6, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8143), "Scorching", -8, 18 },
                    { new Guid("9261f1b9-df79-4874-98c6-208e803799cb"), new DateTime(2024, 5, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7999), "Balmy", 5, 40 },
                    { new Guid("92d2d2f1-3365-4035-b70f-1acc7a3778e7"), new DateTime(2023, 5, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6083), "Mild", 24, 75 },
                    { new Guid("9307f94a-1ee5-46c7-83df-2098caee9437"), new DateTime(2022, 10, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4885), "Chilly", 37, 98 },
                    { new Guid("9325d8c4-1f26-4742-996b-550b4ef42af3"), new DateTime(2022, 8, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4481), "Cool", 15, 58 },
                    { new Guid("93c6e4d9-3e03-4874-9451-e6e67716a8ec"), new DateTime(2022, 5, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4023), "Scorching", -13, 9 },
                    { new Guid("93e8cfa9-e9f7-4497-9248-221569653c27"), new DateTime(2023, 3, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5735), "Cool", 23, 73 },
                    { new Guid("93f0c21e-0384-4891-97d0-94dfb7d18749"), new DateTime(2023, 5, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6055), "Warm", 14, 57 },
                    { new Guid("93fc63f5-6c6c-4fca-9f6b-5ed869495c63"), new DateTime(2024, 4, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7983), "Bracing", 13, 55 },
                    { new Guid("9447be93-3b0f-4b26-b188-3f2e1648b9fc"), new DateTime(2024, 9, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8369), "Balmy", 16, 60 },
                    { new Guid("9455a5b0-7976-45e3-aec5-7838a4214821"), new DateTime(2023, 5, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6068), "Mild", 3, 37 },
                    { new Guid("94e5e9f3-da6d-4815-a288-7385e05879de"), new DateTime(2023, 10, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7203), "Hot", 53, 127 },
                    { new Guid("951f65b1-ae42-4664-a42b-d54f896aa8e7"), new DateTime(2024, 12, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8669), "Balmy", 20, 67 },
                    { new Guid("9574341a-bbb1-4d12-a859-85f356de538e"), new DateTime(2022, 7, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4268), "Balmy", -1, 31 },
                    { new Guid("9580cc91-798b-4c94-b547-933d8be6990a"), new DateTime(2022, 6, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4147), "Warm", 49, 120 },
                    { new Guid("95d408a7-93dc-471b-acb7-014fb7649416"), new DateTime(2022, 11, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5178), "Hot", 21, 69 },
                    { new Guid("95d96fac-4db7-4bf7-b97a-2f44ac2456c5"), new DateTime(2022, 7, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4222), "Mild", -17, 2 },
                    { new Guid("95ff5c74-ab85-42c3-bba5-d27fcb8d6aa2"), new DateTime(2022, 7, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4435), "Bracing", -2, 29 },
                    { new Guid("9626db20-4e84-4826-9f58-7b4438f6534d"), new DateTime(2024, 1, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7663), "Warm", 27, 80 },
                    { new Guid("96378a19-8000-4a7a-bd5e-d54b7b410488"), new DateTime(2022, 11, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5143), "Cool", 30, 85 },
                    { new Guid("96fbbcf5-9b5a-4c90-b3f3-2716001d10d7"), new DateTime(2022, 5, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4003), "Freezing", 0, 32 },
                    { new Guid("97049450-c60a-4751-816c-e1836ab23b52"), new DateTime(2024, 7, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8256), "Warm", 1, 33 },
                    { new Guid("972947cd-db8e-4f8f-bcb6-00a814a3777c"), new DateTime(2024, 7, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8181), "Scorching", 52, 125 },
                    { new Guid("9757380b-0013-4dbe-8ffd-73770b942d93"), new DateTime(2022, 8, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4456), "Hot", 9, 48 },
                    { new Guid("97d14b9c-a48b-4d91-af3e-628e3842e77e"), new DateTime(2023, 9, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6944), "Bracing", 41, 105 },
                    { new Guid("97f3d5a4-9278-403a-803e-307fc27dafe4"), new DateTime(2023, 3, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5726), "Chilly", 4, 39 },
                    { new Guid("98571ba4-a8bd-42c4-9e2b-afef4051d1f2"), new DateTime(2024, 12, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8723), "Cool", 29, 84 },
                    { new Guid("9860c3d6-3f91-4c90-b2fc-854deb75aba9"), new DateTime(2022, 10, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4891), "Hot", 10, 49 },
                    { new Guid("987d16aa-8e55-48b4-89de-d3a8ad2ba3da"), new DateTime(2023, 9, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6738), "Scorching", 47, 116 },
                    { new Guid("98bf4bf1-78cf-4d64-be42-8defa41f41de"), new DateTime(2023, 4, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5977), "Warm", -17, 2 },
                    { new Guid("98c78580-d537-4f4c-82ad-b342f3687021"), new DateTime(2024, 10, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8456), "Bracing", 23, 73 },
                    { new Guid("98e93dd7-d285-4bd1-aaf8-35005bb83d2e"), new DateTime(2024, 4, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7889), "Sweltering", 10, 49 },
                    { new Guid("98f6fb14-595e-4f09-aabe-a0b1da122e82"), new DateTime(2023, 2, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5658), "Mild", 22, 71 },
                    { new Guid("98fe7378-3bca-47ba-b598-01416c9cbefb"), new DateTime(2022, 11, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5138), "Freezing", 26, 78 },
                    { new Guid("99443ffc-691f-48b1-b1cc-d6f3a974f05e"), new DateTime(2024, 10, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8459), "Warm", 24, 75 },
                    { new Guid("996c99f2-1d05-4580-a693-e7e432bf9f71"), new DateTime(2022, 8, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4469), "Balmy", 52, 125 },
                    { new Guid("998c0ae1-95b6-4349-8349-60029242983c"), new DateTime(2024, 9, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8424), "Cool", 3, 37 },
                    { new Guid("99ac363f-40fb-4228-871a-1f9010fc2798"), new DateTime(2022, 6, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4095), "Sweltering", 0, 32 },
                    { new Guid("99faeceb-34ea-420d-9999-a914a9b91864"), new DateTime(2024, 7, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8187), "Mild", -15, 6 },
                    { new Guid("99fd4593-8013-47b0-bf05-4c25998ebde3"), new DateTime(2023, 5, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6115), "Scorching", 36, 96 },
                    { new Guid("9a42cfe7-e3b3-4cbb-a2e0-f3854644ea24"), new DateTime(2022, 6, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4083), "Warm", 0, 32 },
                    { new Guid("9a50ebda-0068-4d55-bb3e-1d40efdc6404"), new DateTime(2022, 12, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5425), "Sweltering", -2, 29 },
                    { new Guid("9ad8027d-aa51-4d7b-bcf5-eb3e2f96aabe"), new DateTime(2024, 3, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7877), "Cool", -19, -2 },
                    { new Guid("9afaf547-f171-4093-995f-5d5b220ef725"), new DateTime(2022, 9, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4755), "Bracing", -16, 4 },
                    { new Guid("9b28cd22-b0ca-49a6-814a-08e0e7bce470"), new DateTime(2022, 12, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5477), "Mild", 33, 91 },
                    { new Guid("9b80811d-dd7c-489a-8a73-30e959c05515"), new DateTime(2023, 8, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6650), "Balmy", 16, 60 },
                    { new Guid("9b982592-2ded-4fc5-9381-ab497092eb54"), new DateTime(2024, 6, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8126), "Sweltering", 33, 91 },
                    { new Guid("9bc372e1-c543-4daf-989b-5b5ccb06978b"), new DateTime(2023, 1, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5585), "Sweltering", -12, 11 },
                    { new Guid("9bd54716-d8f8-49f7-b2e1-579d0b00fcb8"), new DateTime(2022, 9, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4811), "Bracing", 29, 84 },
                    { new Guid("9be8b154-ef34-43d4-aa55-0ae4373253c3"), new DateTime(2023, 4, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6030), "Warm", 30, 85 },
                    { new Guid("9d150113-dbec-49d9-8530-1dd795272312"), new DateTime(2024, 5, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8012), "Chilly", 30, 85 },
                    { new Guid("9d1f11c6-fab2-4386-8a0f-dffdc5c811c6"), new DateTime(2023, 5, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6081), "Sweltering", 42, 107 },
                    { new Guid("9db34d31-bc34-4a89-83d4-3e569e6ddf99"), new DateTime(2023, 4, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5999), "Chilly", -13, 9 },
                    { new Guid("9dc277e8-722c-45da-be21-4212b8b5c4a4"), new DateTime(2024, 6, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8148), "Bracing", -19, -2 },
                    { new Guid("9dd50110-2612-4c52-96da-8e9ad2dee903"), new DateTime(2024, 6, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8161), "Cool", 12, 53 },
                    { new Guid("9deeeb9a-7a45-4411-a989-79cf35148293"), new DateTime(2024, 11, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8592), "Warm", 19, 66 },
                    { new Guid("9e49fa8a-238f-435c-8bce-dc8e4cdd179a"), new DateTime(2024, 4, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7896), "Balmy", 6, 42 },
                    { new Guid("9ea5e627-1ab9-4e76-ab94-c9cb2fb99169"), new DateTime(2023, 2, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5635), "Hot", 5, 40 },
                    { new Guid("9ed3314e-afa7-4704-974c-8835b674589a"), new DateTime(2023, 5, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6132), "Cool", 25, 76 },
                    { new Guid("9f183b03-4b13-4219-aa7a-133b001b47c1"), new DateTime(2024, 4, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7975), "Freezing", -15, 6 },
                    { new Guid("9f25f7dc-d1ef-4697-928a-ae174969524d"), new DateTime(2023, 9, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6732), "Cool", 48, 118 },
                    { new Guid("a0128c90-a196-444a-b206-92005e6e2284"), new DateTime(2023, 2, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5648), "Mild", 10, 49 },
                    { new Guid("a0a22505-ff4e-4781-a492-e970cdf0323f"), new DateTime(2024, 6, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8089), "Scorching", 51, 123 },
                    { new Guid("a0c19c74-d819-4b7c-9aa3-c4e12a8c9dfe"), new DateTime(2024, 8, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8319), "Mild", 28, 82 },
                    { new Guid("a0f1b0ca-a7b9-4edd-a27a-39b31611209d"), new DateTime(2023, 11, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7421), "Mild", -6, 22 },
                    { new Guid("a101371d-a37a-4661-83b8-1a7a9965f4d2"), new DateTime(2022, 9, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4766), "Mild", -20, -3 },
                    { new Guid("a16d3bff-66d7-46c3-8042-88a4ef750519"), new DateTime(2023, 4, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6025), "Hot", 12, 53 },
                    { new Guid("a18df3eb-d67a-4122-b2e6-a84b477ecc17"), new DateTime(2023, 7, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6615), "Freezing", 14, 57 },
                    { new Guid("a1befa76-18d3-433b-8af7-0bf307805005"), new DateTime(2023, 1, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5545), "Freezing", 40, 103 },
                    { new Guid("a1ea57c3-d756-4694-af25-f5507e4032c0"), new DateTime(2024, 2, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7751), "Hot", 1, 33 },
                    { new Guid("a22cbecd-5793-4d4c-a582-7a60cc523e6c"), new DateTime(2022, 7, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4212), "Freezing", 8, 46 },
                    { new Guid("a22d621e-73de-476c-b0d9-4b892538926b"), new DateTime(2022, 9, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4784), "Cool", -20, -3 },
                    { new Guid("a251ab65-8719-4875-8b27-d2af428bc935"), new DateTime(2023, 8, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6645), "Freezing", 10, 49 },
                    { new Guid("a2914aff-2552-4f8c-9af8-8d8a4d273188"), new DateTime(2024, 1, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7595), "Bracing", -1, 31 },
                    { new Guid("a2a4a3fc-c280-40ea-9123-ca33afd0a943"), new DateTime(2024, 2, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7794), "Balmy", 23, 73 },
                    { new Guid("a2cb2d31-f2d4-4ff3-9ebb-f4796067952d"), new DateTime(2023, 7, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6590), "Scorching", 0, 32 },
                    { new Guid("a2e94f46-8557-4ce2-9046-855471921310"), new DateTime(2023, 12, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7553), "Bracing", 12, 53 },
                    { new Guid("a2f7c9eb-f8fc-4489-b76b-aa5f2813e781"), new DateTime(2022, 9, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4796), "Balmy", 43, 109 },
                    { new Guid("a360ac22-f60a-4b02-8109-e6ffa166392f"), new DateTime(2024, 5, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8074), "Mild", 11, 51 },
                    { new Guid("a3aa9a31-3e22-496e-979d-687fa6b68ed1"), new DateTime(2023, 1, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5532), "Cool", 13, 55 },
                    { new Guid("a3ee363a-4835-4d05-a4ee-7fdfe4279a9e"), new DateTime(2024, 12, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8755), "Bracing", 20, 67 },
                    { new Guid("a4ccc927-05ae-44d8-8d37-d0c298c15a01"), new DateTime(2023, 8, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6692), "Chilly", -1, 31 },
                    { new Guid("a51c8351-2779-464b-ad01-8cff1c757aa4"), new DateTime(2022, 10, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4929), "Sweltering", 49, 120 },
                    { new Guid("a5751549-da08-4379-9f78-ef6227a8c6f4"), new DateTime(2025, 1, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8816), "Warm", -4, 25 },
                    { new Guid("a57fbfbf-7804-4d87-9ec4-2167e3891f27"), new DateTime(2024, 12, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8708), "Hot", 49, 120 },
                    { new Guid("a5dc39b9-37e0-4fdf-a268-c8062c73e3fa"), new DateTime(2023, 10, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7205), "Mild", 54, 129 },
                    { new Guid("a5e0bceb-264a-448e-9bef-4ab5d75254bc"), new DateTime(2023, 6, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6141), "Sweltering", 43, 109 },
                    { new Guid("a5e513f8-b8d3-4d19-9662-7c035c8ef803"), new DateTime(2023, 4, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5784), "Scorching", 22, 71 },
                    { new Guid("a6340bff-e258-45fc-a8b3-8b0e8ef120c2"), new DateTime(2023, 6, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6158), "Mild", 18, 64 },
                    { new Guid("a648065b-b029-4a29-ae4b-3aa6ef5d1db1"), new DateTime(2023, 7, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6568), "Sweltering", 33, 91 },
                    { new Guid("a67cc8b3-80aa-4526-aa5c-32bc42c7498e"), new DateTime(2023, 5, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6120), "Cool", 0, 32 },
                    { new Guid("a69bf183-b1e8-4c9f-81ed-ea36527add60"), new DateTime(2022, 7, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4437), "Mild", -7, 20 },
                    { new Guid("a6c9f47f-fa27-4462-a63c-31a0d17ed577"), new DateTime(2022, 10, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4931), "Freezing", 35, 94 },
                    { new Guid("a7098edb-c0cf-49fa-9090-f36686ba4062"), new DateTime(2023, 9, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6900), "Hot", 19, 66 },
                    { new Guid("a70ce960-5ed6-4ea6-aa15-99eaa6fdc4f2"), new DateTime(2024, 1, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7683), "Scorching", -16, 4 },
                    { new Guid("a72c5994-37eb-4611-a98e-09e35d81ddb0"), new DateTime(2024, 1, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7694), "Sweltering", 35, 94 },
                    { new Guid("a75aef28-1936-4e2c-9a09-21866f58c661"), new DateTime(2022, 4, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3981), "Cool", 16, 60 },
                    { new Guid("a79cc9e1-4785-45a2-a5e6-563824a34dd6"), new DateTime(2023, 2, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5637), "Balmy", 16, 60 },
                    { new Guid("a83a86bb-9cd2-420b-a7a2-18dcb989fb64"), new DateTime(2024, 1, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7704), "Cool", -7, 20 },
                    { new Guid("a85dd8c7-472d-4043-913f-0e29f7cf52c7"), new DateTime(2024, 3, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7886), "Scorching", -5, 24 },
                    { new Guid("a8cc1b7e-e9af-49f7-9b0a-c6a8ced645cd"), new DateTime(2023, 12, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7564), "Scorching", 41, 105 },
                    { new Guid("a95f634f-e5ba-442d-862a-fa531d00bf0c"), new DateTime(2023, 9, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6905), "Sweltering", -20, -3 },
                    { new Guid("a989aa8c-360c-46bc-960b-dceaabff2a25"), new DateTime(2023, 5, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6118), "Freezing", -7, 20 },
                    { new Guid("a9aeb340-8807-4001-a714-60dcc047f06b"), new DateTime(2023, 2, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5646), "Balmy", 24, 75 },
                    { new Guid("aa990b91-209a-48ab-8fa4-baa6dc082248"), new DateTime(2024, 8, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8341), "Mild", -4, 25 },
                    { new Guid("aae6df1e-dd62-42fe-9e24-ba13d89c6c59"), new DateTime(2022, 10, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4915), "Freezing", 25, 76 },
                    { new Guid("aaef18ec-bdb0-4c6a-be27-1847a01c3a98"), new DateTime(2022, 9, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4790), "Scorching", 45, 112 },
                    { new Guid("ab3cc0a8-528e-4e19-8e6b-0aa812f13a63"), new DateTime(2022, 10, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4867), "Hot", 13, 55 },
                    { new Guid("ab6a7d8c-1aab-4843-863c-453362bedc0d"), new DateTime(2023, 9, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6918), "Bracing", 42, 107 },
                    { new Guid("abd309f3-3253-4c3e-8a86-1821cea0c4fb"), new DateTime(2024, 5, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8014), "Warm", -12, 11 },
                    { new Guid("ac31ec22-a574-42c1-9bfd-032d8c6ff2a1"), new DateTime(2022, 9, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4813), "Freezing", 4, 39 },
                    { new Guid("ac4838d8-5e5a-413b-b60d-05a37f6cb6a1"), new DateTime(2022, 10, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4937), "Sweltering", 46, 114 },
                    { new Guid("accbb0c1-2d30-4738-a598-b1c023326827"), new DateTime(2022, 12, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5487), "Scorching", 16, 60 },
                    { new Guid("ace8b2f5-ddf9-4287-a44a-fd3810d9817f"), new DateTime(2023, 12, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7503), "Freezing", 33, 91 },
                    { new Guid("ad146621-0170-4982-8b88-35326a7e339d"), new DateTime(2023, 1, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5553), "Sweltering", -15, 6 },
                    { new Guid("adba4b00-afa5-4209-a9ab-b8b15e28988e"), new DateTime(2023, 10, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7193), "Hot", 48, 118 },
                    { new Guid("adbe3ccd-e7d0-4be8-b810-bd1a495b817a"), new DateTime(2022, 5, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3987), "Hot", -12, 11 },
                    { new Guid("adc94bf9-4464-4655-8549-a2e1b4d8dedc"), new DateTime(2024, 4, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7901), "Freezing", -4, 25 },
                    { new Guid("ade9bb7b-14bc-4825-9fea-51eb369a2791"), new DateTime(2025, 1, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8768), "Sweltering", 11, 51 },
                    { new Guid("ae98855d-2912-4a8c-a3fb-0245a2e9ed8e"), new DateTime(2023, 8, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6695), "Bracing", 19, 66 },
                    { new Guid("af194834-a549-4390-985d-f7a8eda7958a"), new DateTime(2023, 10, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7232), "Freezing", 47, 116 },
                    { new Guid("af37ea14-a600-4d42-adbd-02addc1a029d"), new DateTime(2024, 12, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8750), "Bracing", 17, 62 },
                    { new Guid("af7c90b4-dada-473b-9b42-cc69883b80ec"), new DateTime(2024, 9, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8439), "Balmy", -16, 4 },
                    { new Guid("af833ae2-d887-4c2c-ae09-81d8acd6b620"), new DateTime(2024, 8, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8304), "Chilly", 52, 125 },
                    { new Guid("b069d1e7-c849-48b0-8559-54d9061aa563"), new DateTime(2023, 2, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5640), "Freezing", 41, 105 },
                    { new Guid("b0f9e067-6933-4616-a072-0cb8a1952107"), new DateTime(2023, 11, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7459), "Warm", 28, 82 },
                    { new Guid("b1068812-54b6-477d-92c7-19bc362edabb"), new DateTime(2022, 11, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5141), "Hot", 15, 58 },
                    { new Guid("b12ad111-d205-4347-8196-00aba785f758"), new DateTime(2023, 8, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6663), "Hot", 5, 40 },
                    { new Guid("b12d32aa-38e1-4dd8-b3a8-3c8a695b2541"), new DateTime(2023, 1, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5551), "Mild", 44, 111 },
                    { new Guid("b18c7d57-e61e-409a-803a-8ad90a4d8768"), new DateTime(2023, 2, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5682), "Mild", 47, 116 },
                    { new Guid("b36a5b97-6712-4be8-b36c-5cd5896ba814"), new DateTime(2023, 6, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6155), "Chilly", -16, 4 },
                    { new Guid("b391feaa-6309-4d90-a60f-6a6704116567"), new DateTime(2024, 5, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8046), "Bracing", 32, 89 },
                    { new Guid("b438a2c4-e29c-4c75-af6b-25e2db804d4b"), new DateTime(2023, 5, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6113), "Mild", 1, 33 },
                    { new Guid("b4f8b579-6038-4556-b3ec-6d31df649fb9"), new DateTime(2023, 11, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7450), "Sweltering", -1, 31 },
                    { new Guid("b5296d3f-7890-4e11-860b-00d414fc8db4"), new DateTime(2025, 1, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8824), "Freezing", 4, 39 },
                    { new Guid("b5494b1f-7e01-4750-b7ea-a1b713646cc3"), new DateTime(2023, 3, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5695), "Bracing", -4, 25 },
                    { new Guid("b56837b9-9bb2-4043-af6c-6b46035f91fd"), new DateTime(2024, 2, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7754), "Scorching", 5, 40 },
                    { new Guid("b5822230-b1b9-40de-861b-326391aafbbc"), new DateTime(2022, 7, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4440), "Scorching", 48, 118 },
                    { new Guid("b5b25cdf-5edb-4321-8cc7-0b8eef0baf3f"), new DateTime(2023, 5, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6123), "Warm", -14, 7 },
                    { new Guid("b5cc8b77-6269-4bcb-b95d-f72dd9150504"), new DateTime(2024, 12, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8728), "Sweltering", 21, 69 },
                    { new Guid("b62d85c4-3b04-4630-8d54-10119c99225d"), new DateTime(2022, 11, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5118), "Warm", 13, 55 },
                    { new Guid("b673ba28-2795-4992-b419-4ebcc5754b76"), new DateTime(2023, 7, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6596), "Warm", 2, 35 },
                    { new Guid("b69c6c2e-f85c-4498-a972-266962d7f26c"), new DateTime(2023, 5, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6048), "Scorching", 40, 103 },
                    { new Guid("b6e9f438-646b-42f2-96c3-4e1de67092c5"), new DateTime(2024, 12, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8679), "Mild", 32, 89 },
                    { new Guid("b6ed8fe7-c27b-46d5-abd2-b7a5979b790e"), new DateTime(2023, 1, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5590), "Freezing", 14, 57 },
                    { new Guid("b6f48915-de4f-460d-a355-49a263cddb61"), new DateTime(2023, 2, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5611), "Chilly", -14, 7 },
                    { new Guid("b74411c1-8ed8-4574-966b-b1671d6c3794"), new DateTime(2022, 5, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4009), "Bracing", -18, 0 },
                    { new Guid("b75b779f-fda4-41d4-ba42-666e9c5b9548"), new DateTime(2022, 12, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5420), "Sweltering", -15, 6 },
                    { new Guid("b7c42420-2b3a-4e41-a6bf-3cbc6179a03e"), new DateTime(2022, 8, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4739), "Cool", -20, -3 },
                    { new Guid("b7dcb227-c118-4c40-8dc4-a0a72cce6d6a"), new DateTime(2023, 6, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6148), "Scorching", -5, 24 },
                    { new Guid("b7ee86ce-2671-45c6-aaf5-d1e4b5b913c5"), new DateTime(2024, 6, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8128), "Mild", 53, 127 },
                    { new Guid("b8b7e6dd-80c0-4af5-9226-4c569130dacc"), new DateTime(2024, 11, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8619), "Cool", -8, 18 },
                    { new Guid("b8e9fbca-13a1-4621-be9c-5b34248ddd30"), new DateTime(2022, 9, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4822), "Chilly", 7, 44 },
                    { new Guid("b901b1df-2d8d-40ed-8f31-447ea2aa9609"), new DateTime(2024, 2, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7726), "Bracing", 8, 46 },
                    { new Guid("b90ae923-5ec4-4c91-be78-ba67c24f5a86"), new DateTime(2024, 2, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7764), "Chilly", -6, 22 },
                    { new Guid("b97bf412-d46e-40c5-a274-5a33358c4f03"), new DateTime(2023, 10, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7200), "Balmy", -1, 31 },
                    { new Guid("b98ce7c2-81cd-45c9-a3fd-8589c01caa06"), new DateTime(2024, 7, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8278), "Hot", 16, 60 },
                    { new Guid("ba07b769-3d7a-4305-b885-ce17cf9d89ba"), new DateTime(2024, 1, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7658), "Warm", 2, 35 },
                    { new Guid("ba91bf3d-b6f3-4372-bb41-3289149ab8b6"), new DateTime(2024, 9, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8397), "Hot", 17, 62 },
                    { new Guid("bbbbcb6e-7d54-4bad-857a-d7aa75a891c3"), new DateTime(2022, 7, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4236), "Scorching", 33, 91 },
                    { new Guid("bbfcb211-9ce2-42a1-8351-c0371931c222"), new DateTime(2022, 9, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4816), "Mild", 15, 58 },
                    { new Guid("bc5b8a87-bcdc-4637-b349-085e7d94ad41"), new DateTime(2022, 5, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4026), "Sweltering", 52, 125 },
                    { new Guid("bc9517a3-5a69-4492-9d70-ce71567423c1"), new DateTime(2024, 10, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8528), "Balmy", 16, 60 },
                    { new Guid("bcb76124-8836-4750-bca0-247455e427c0"), new DateTime(2022, 10, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4912), "Hot", 35, 94 },
                    { new Guid("bd421c3c-c78a-42ba-a19d-349fd3274bd3"), new DateTime(2023, 5, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6070), "Warm", 54, 129 },
                    { new Guid("bd5fa9ca-a998-429b-94a0-06991fd5464c"), new DateTime(2022, 7, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4239), "Balmy", -11, 13 },
                    { new Guid("bd6552f1-f750-4456-907e-8d49fc64740f"), new DateTime(2024, 2, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7772), "Sweltering", 43, 109 },
                    { new Guid("bdaf9d85-c68e-4cc4-b109-6fec6b3e25ba"), new DateTime(2024, 3, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7807), "Mild", 42, 107 },
                    { new Guid("be097ea5-84a9-4644-b82d-48fea251edc1"), new DateTime(2023, 4, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6002), "Mild", 5, 40 },
                    { new Guid("beb474bc-96b7-4043-b5d5-40917c1d516a"), new DateTime(2024, 7, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8192), "Scorching", 4, 39 },
                    { new Guid("bebc80a0-1d87-48c7-ac44-551dc12c74b2"), new DateTime(2023, 5, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6125), "Freezing", 26, 78 },
                    { new Guid("bedce7ca-3ff8-424e-80f7-a5b58b9c37a7"), new DateTime(2024, 7, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8248), "Warm", -16, 4 },
                    { new Guid("bf1b1220-e191-4c66-8658-4b2ab0c69587"), new DateTime(2024, 1, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7648), "Scorching", 11, 51 },
                    { new Guid("bf1f60bf-6691-4890-92e3-c0e8a72384f2"), new DateTime(2023, 1, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5564), "Sweltering", -1, 31 },
                    { new Guid("bfab65bb-e7d5-4101-bcc4-bd75efb176e7"), new DateTime(2024, 9, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8409), "Freezing", -10, 15 },
                    { new Guid("c02918e7-55cd-4cd8-bccf-7954769de94d"), new DateTime(2022, 6, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4144), "Sweltering", 27, 80 },
                    { new Guid("c0579512-2bb4-4140-8219-1c6e04776a61"), new DateTime(2022, 7, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4231), "Freezing", 25, 76 },
                    { new Guid("c05ba57a-a39e-4b9b-be67-abe54c8bb341"), new DateTime(2022, 12, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5455), "Sweltering", 53, 127 },
                    { new Guid("c05f30d4-63e1-43a7-9d67-efb8689d7922"), new DateTime(2023, 8, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6629), "Bracing", 8, 46 },
                    { new Guid("c0b8c4db-0881-42e5-843d-806358705ee3"), new DateTime(2023, 7, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6609), "Chilly", -14, 7 },
                    { new Guid("c1687a6c-c01b-4645-a4d9-69066fa89457"), new DateTime(2024, 6, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8113), "Warm", 4, 39 },
                    { new Guid("c16a42de-872d-4d27-aab8-725a88b90673"), new DateTime(2024, 3, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7825), "Hot", -15, 6 },
                    { new Guid("c16be980-3908-46ec-93ab-55fd2943a527"), new DateTime(2023, 3, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5743), "Freezing", 41, 105 },
                    { new Guid("c1adad63-c2cd-4d16-9447-cdf00e4d90af"), new DateTime(2023, 12, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7584), "Balmy", 8, 46 },
                    { new Guid("c1fd448a-0808-41cf-a8d3-c1d0d4cb0aca"), new DateTime(2022, 7, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4252), "Hot", 2, 35 },
                    { new Guid("c25b25e6-14cf-4cf9-9300-2a864a873b67"), new DateTime(2022, 11, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5188), "Balmy", 38, 100 },
                    { new Guid("c2ea058c-c47d-4fc8-9cdf-e65da15e147f"), new DateTime(2022, 12, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5450), "Sweltering", 19, 66 },
                    { new Guid("c330d1b6-89f0-42c4-8985-3251296479b8"), new DateTime(2023, 11, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7467), "Freezing", 24, 75 },
                    { new Guid("c3556498-29c5-4d90-8f3f-a637a36ee317"), new DateTime(2022, 8, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4474), "Chilly", 10, 49 },
                    { new Guid("c3929021-0870-4d20-bfc7-c22cdcd5f41a"), new DateTime(2022, 10, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4959), "Warm", -1, 31 },
                    { new Guid("c3bc99dd-95c9-4ddb-a58f-dd7e3b278ffa"), new DateTime(2023, 2, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5674), "Bracing", 48, 118 },
                    { new Guid("c4248c2c-5448-46c2-9f1d-c6db8d1118dd"), new DateTime(2023, 3, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5732), "Mild", 54, 129 },
                    { new Guid("c44ce81b-099a-47fc-b2c1-9742414969bb"), new DateTime(2023, 7, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6563), "Chilly", 21, 69 },
                    { new Guid("c45d5476-a65e-4521-b13b-51ff158f2990"), new DateTime(2024, 5, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8024), "Bracing", 6, 42 },
                    { new Guid("c4639ad4-ab42-4de0-91bc-0358dad956bc"), new DateTime(2023, 5, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6098), "Chilly", 17, 62 },
                    { new Guid("c46c22e5-1631-4a1e-addc-f7738db138e9"), new DateTime(2023, 11, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7445), "Chilly", -12, 11 },
                    { new Guid("c49a7784-05c7-46f3-8e59-d0beb4c78248"), new DateTime(2023, 11, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7419), "Scorching", -1, 31 },
                    { new Guid("c4a2869e-34fc-4e83-98d9-a6daf13b072d"), new DateTime(2022, 11, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5157), "Mild", 24, 75 },
                    { new Guid("c4ba2c3e-c3e9-457f-a6f7-5cecc6d29670"), new DateTime(2022, 6, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4155), "Sweltering", 33, 91 },
                    { new Guid("c564f158-ba4e-4cd7-ae85-9c6dc1e67292"), new DateTime(2024, 1, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7597), "Freezing", 45, 112 },
                    { new Guid("c56c247b-b604-495e-b932-2083ea83cba8"), new DateTime(2023, 9, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6926), "Mild", -6, 22 },
                    { new Guid("c5754dd3-23c5-4220-9482-542c4e4aee3d"), new DateTime(2023, 1, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5526), "Chilly", 28, 82 },
                    { new Guid("c587bd65-5abd-4e3b-b7a4-160e6dca6f6d"), new DateTime(2024, 3, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7833), "Hot", 12, 53 },
                    { new Guid("c588dc89-08aa-4583-992a-98778f2e2c18"), new DateTime(2022, 4, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3978), "Warm", 3, 37 },
                    { new Guid("c593c4cc-6806-4ee8-8423-fe5d0519ce14"), new DateTime(2024, 5, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8001), "Bracing", 3, 37 },
                    { new Guid("c5b69f23-abb7-43a7-b8ce-5e57cf8d4959"), new DateTime(2023, 1, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5575), "Scorching", 13, 55 },
                    { new Guid("c5f246ca-0f02-4b2c-9d4a-689a535c2d9c"), new DateTime(2024, 10, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8556), "Hot", -3, 27 },
                    { new Guid("c60a3b22-2b5d-4494-af5c-77fc20b955e7"), new DateTime(2024, 11, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8632), "Balmy", 15, 58 },
                    { new Guid("c616c6dc-e7cb-404f-bd1c-ee7de1a64e11"), new DateTime(2023, 2, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5616), "Hot", 42, 107 },
                    { new Guid("c68cb502-3951-447a-85e4-7e4ce90a9862"), new DateTime(2024, 7, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8178), "Freezing", 5, 40 },
                    { new Guid("c6b9bd03-bda1-40e1-b1c3-50da5c74486b"), new DateTime(2022, 10, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4918), "Chilly", -2, 29 },
                    { new Guid("c76e68e2-d29f-43e3-ae11-9745b07364ac"), new DateTime(2022, 12, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5414), "Chilly", 32, 89 },
                    { new Guid("c7f361e0-775e-4637-8d1a-03f06e72b203"), new DateTime(2024, 9, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8412), "Chilly", 26, 78 },
                    { new Guid("c80fbbbb-5897-40c5-9585-55f2f8de43a2"), new DateTime(2022, 11, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5154), "Bracing", 9, 48 },
                    { new Guid("c846723b-0b6e-41a4-97d7-9fb9a3390d2a"), new DateTime(2023, 3, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5766), "Hot", 7, 44 },
                    { new Guid("c873b687-aac4-412b-8fe7-63a8cc00d1d9"), new DateTime(2024, 5, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8041), "Balmy", 22, 71 },
                    { new Guid("c8bbdbf6-7017-4270-a18d-7abd5a961607"), new DateTime(2023, 12, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7531), "Warm", -17, 2 },
                    { new Guid("c8e6462b-bcbd-49b9-b3d5-70475d37d306"), new DateTime(2023, 12, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7579), "Cool", -3, 27 },
                    { new Guid("c9647bc6-13f9-45ec-8698-a62ee52bc738"), new DateTime(2025, 1, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8782), "Cool", 5, 40 },
                    { new Guid("c995002d-098e-4a0f-984c-810ca7ec63df"), new DateTime(2024, 8, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8326), "Scorching", 32, 89 },
                    { new Guid("c9a81948-ae98-452f-b3d9-0c800146ba18"), new DateTime(2023, 8, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6668), "Balmy", 54, 129 },
                    { new Guid("c9b6edf2-db3c-4b0e-894d-b8949f4d9853"), new DateTime(2022, 12, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5490), "Chilly", 10, 49 },
                    { new Guid("c9d247ef-a826-4ed9-8aa2-bd1f25e490f5"), new DateTime(2022, 8, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4479), "Cool", 1, 33 },
                    { new Guid("cacdf68f-4f6c-4229-8b0c-c587f8fc18ab"), new DateTime(2024, 1, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7686), "Freezing", 29, 84 },
                    { new Guid("cadef5ec-e62e-48af-b53e-3104c3bb2ef9"), new DateTime(2023, 12, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7500), "Mild", 8, 46 },
                    { new Guid("cb1f3791-8163-4678-95a5-4d2b21bcbabf"), new DateTime(2024, 5, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8009), "Mild", 54, 129 },
                    { new Guid("cbc08f71-517c-428c-853b-19f4e2e474d1"), new DateTime(2024, 9, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8394), "Cool", -14, 7 },
                    { new Guid("cc378b94-51a8-4448-bcb8-df2bd301ff5a"), new DateTime(2023, 11, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7434), "Scorching", 19, 66 },
                    { new Guid("cc408ce9-c875-4740-903b-dbc7cc3db11b"), new DateTime(2024, 12, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8700), "Mild", 31, 87 },
                    { new Guid("cc60a81c-d121-49f2-87e4-8f5aa94320dc"), new DateTime(2022, 5, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4015), "Freezing", -1, 31 },
                    { new Guid("cc7fd20f-3fc1-4ea0-8660-e6676669ee52"), new DateTime(2023, 12, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7551), "Warm", 37, 98 },
                    { new Guid("cc84b1e3-af25-46eb-8dca-bc0f25cc4e84"), new DateTime(2023, 6, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6503), "Bracing", -12, 11 },
                    { new Guid("cd980255-c643-4875-bb6f-f238de7a9655"), new DateTime(2024, 8, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8346), "Cool", -9, 16 },
                    { new Guid("cdb8dbb2-520d-476e-8b8b-787feac040e4"), new DateTime(2024, 4, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7938), "Hot", -17, 2 },
                    { new Guid("ce1de89e-76e1-4f87-a8b8-4751ba1b4dcb"), new DateTime(2023, 5, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6061), "Hot", -4, 25 },
                    { new Guid("ce3867be-4e63-4551-bf19-1eca890ed2c1"), new DateTime(2023, 7, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6612), "Warm", 6, 42 },
                    { new Guid("ce63420a-1907-4f38-bfb7-36f596c683ca"), new DateTime(2025, 1, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8758), "Sweltering", 30, 85 },
                    { new Guid("ce696f3f-3c0a-4a6a-8c1d-8b104b541328"), new DateTime(2023, 5, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6088), "Scorching", 19, 66 },
                    { new Guid("ce6ea5d8-5fae-43f4-8185-ebb4258e8f4d"), new DateTime(2024, 9, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8392), "Mild", 0, 32 },
                    { new Guid("ce8f41e5-8ce2-4b9f-8501-382a6b2f339d"), new DateTime(2023, 7, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6601), "Sweltering", 2, 35 },
                    { new Guid("ceaa29a4-c60c-4ff9-8d28-0f0e2b50adb9"), new DateTime(2024, 11, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8585), "Bracing", 6, 42 },
                    { new Guid("cec64fba-4cf7-4f6a-bf9a-71871e3822fa"), new DateTime(2024, 8, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8354), "Cool", 20, 67 },
                    { new Guid("cee0289c-d161-48d4-9394-12413ce036bb"), new DateTime(2024, 8, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8361), "Cool", -4, 25 },
                    { new Guid("cef4e288-e789-472b-88a0-2c70e292c3c1"), new DateTime(2024, 1, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7592), "Chilly", 20, 67 },
                    { new Guid("cf3521cd-bafc-4c18-9487-39070c2c7d39"), new DateTime(2024, 12, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8705), "Chilly", 1, 33 },
                    { new Guid("cf4b33e8-7a81-4ccf-81f6-5afbcf7bcbdd"), new DateTime(2023, 10, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6957), "Warm", -17, 2 },
                    { new Guid("cff0c7cc-6ec4-4548-9efe-dafc01abe1b7"), new DateTime(2023, 6, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6482), "Balmy", 13, 55 },
                    { new Guid("d0b7cc6e-f601-45d0-95ac-2c6425b1b0f6"), new DateTime(2022, 5, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4006), "Cool", -19, -2 },
                    { new Guid("d16b6444-899b-43cf-8b68-4b5886a834ec"), new DateTime(2024, 11, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8600), "Sweltering", 39, 102 },
                    { new Guid("d1b3f12e-5280-4b98-99e1-90e044983a0a"), new DateTime(2022, 8, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4730), "Chilly", 17, 62 },
                    { new Guid("d1cff043-e91b-4d45-a150-4c129a54fe1d"), new DateTime(2024, 7, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8266), "Hot", -8, 18 },
                    { new Guid("d241c769-32a1-48d2-bd04-fad28ee20713"), new DateTime(2022, 7, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4203), "Chilly", 54, 129 },
                    { new Guid("d248fab8-2415-4b21-a014-9f8ed8df149d"), new DateTime(2024, 3, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7861), "Chilly", 38, 100 },
                    { new Guid("d25a0579-9ff0-4cce-b412-d0e9aba4dce2"), new DateTime(2024, 3, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7815), "Hot", 45, 112 },
                    { new Guid("d28d7df3-69df-4f78-b9d9-0b7b71cbc69f"), new DateTime(2023, 3, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5708), "Bracing", 22, 71 },
                    { new Guid("d28fabbf-1d3b-483d-b792-857e09fb9c82"), new DateTime(2024, 7, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8273), "Warm", -10, 15 },
                    { new Guid("d298205d-edae-4db3-b515-8541d634fe51"), new DateTime(2023, 11, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7473), "Sweltering", 42, 107 },
                    { new Guid("d361ddbb-6dbb-4c4c-a525-84a54b87032d"), new DateTime(2023, 8, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6670), "Freezing", 8, 46 },
                    { new Guid("d39012ae-9949-4bfe-882d-8efe897bfbbe"), new DateTime(2024, 1, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7668), "Mild", 37, 98 },
                    { new Guid("d3cea1ef-dda3-4ebb-b339-389cc7f1b112"), new DateTime(2024, 6, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8146), "Bracing", 8, 46 },
                    { new Guid("d3d211a4-103e-42bb-8c0b-b10eb08370fd"), new DateTime(2024, 10, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8476), "Mild", 25, 76 },
                    { new Guid("d3d8f9e4-34e9-4e3b-9b1e-77b81fa194b6"), new DateTime(2022, 9, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4837), "Scorching", 33, 91 },
                    { new Guid("d3da602a-240c-4da7-9a42-29286479eaf8"), new DateTime(2024, 11, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8624), "Sweltering", 24, 75 },
                    { new Guid("d44c024d-ce2b-4ae9-81bf-5bb9349cf9ba"), new DateTime(2022, 5, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4018), "Cool", -12, 11 },
                    { new Guid("d4b08694-3547-4a10-81df-2dcb83cdd24f"), new DateTime(2024, 9, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8414), "Chilly", 39, 102 },
                    { new Guid("d4b192c4-7e66-4e88-b0d7-8ac87b0f82ca"), new DateTime(2023, 10, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7197), "Balmy", 4, 39 },
                    { new Guid("d4bcab98-be5a-46c0-aee6-6fc7e82927c7"), new DateTime(2023, 12, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7536), "Chilly", 10, 49 },
                    { new Guid("d4c42f1c-be9c-41bf-935a-2858e8c51737"), new DateTime(2023, 7, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6513), "Sweltering", 33, 91 },
                    { new Guid("d52e0273-09dd-4abe-9057-21a32b3f680c"), new DateTime(2023, 6, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6487), "Mild", 15, 58 },
                    { new Guid("d54e4dc3-9620-4c8e-a6de-3f2e59862a0a"), new DateTime(2023, 11, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7483), "Bracing", 35, 94 },
                    { new Guid("d5c02fb5-1c5d-4ccd-b74b-9f6251af57c7"), new DateTime(2022, 9, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4771), "Warm", 50, 121 },
                    { new Guid("d5ef4d45-feee-4def-9a22-7adee4c2237e"), new DateTime(2023, 5, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6093), "Balmy", 2, 35 },
                    { new Guid("d68dfbb2-7afb-4b8a-b719-5b714c521a61"), new DateTime(2024, 9, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8441), "Bracing", 20, 67 },
                    { new Guid("d6ca6286-2535-41b0-88f0-6f54cbbf65b9"), new DateTime(2022, 9, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4757), "Mild", -11, 13 },
                    { new Guid("d742d971-7fa0-4350-a885-4baaaec89da3"), new DateTime(2024, 11, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8649), "Freezing", -6, 22 },
                    { new Guid("d7ef4a8b-7e3b-4c75-b2c2-848800018cc7"), new DateTime(2023, 4, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5992), "Chilly", 24, 75 },
                    { new Guid("d830017f-4409-4486-8a10-e3c0a7568eba"), new DateTime(2024, 11, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8613), "Freezing", 7, 44 },
                    { new Guid("d9367483-62e7-47ea-ad80-3ea9b91373ec"), new DateTime(2024, 5, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8049), "Cool", -5, 24 },
                    { new Guid("d9461d94-1a85-465a-a3aa-dcc9f883f035"), new DateTime(2023, 10, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7259), "Mild", 51, 123 },
                    { new Guid("d974d487-21cd-40e7-af8c-513ced34aaf3"), new DateTime(2022, 8, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4750), "Cool", 48, 118 },
                    { new Guid("d9e0acf1-40ab-4ce0-8ee4-b85292220e41"), new DateTime(2023, 6, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6457), "Balmy", 18, 64 },
                    { new Guid("d9e2bf98-0bf1-4ddd-9cb3-760fdfdc5aa9"), new DateTime(2023, 2, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5627), "Freezing", -13, 9 },
                    { new Guid("da3a724d-1f05-4cfb-8f53-671281b9daa8"), new DateTime(2023, 4, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6022), "Balmy", 9, 48 },
                    { new Guid("da4d32aa-dbef-41ae-a730-358c882802c0"), new DateTime(2024, 4, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7956), "Scorching", 14, 57 },
                    { new Guid("da85b56b-6189-4d11-aedc-9cd0d4ba3ff1"), new DateTime(2024, 11, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8647), "Freezing", 46, 114 },
                    { new Guid("daa35c7d-060e-4ed8-a407-bed62a6587cf"), new DateTime(2023, 7, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6618), "Mild", 30, 85 },
                    { new Guid("daebae27-6f73-4e3f-ae1f-6a757b096384"), new DateTime(2022, 9, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4826), "Hot", 49, 120 },
                    { new Guid("db398995-a881-4ffc-889c-370f38335b7c"), new DateTime(2022, 5, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4032), "Scorching", -12, 11 },
                    { new Guid("db70caf0-c417-4efe-a2b7-febd3b5dcb0f"), new DateTime(2023, 10, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7221), "Freezing", 11, 51 },
                    { new Guid("dc003c8a-5f79-435a-8ed9-d118215c62c7"), new DateTime(2023, 10, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7208), "Scorching", 50, 121 },
                    { new Guid("dc48726b-20df-4149-82bf-ee05777b424a"), new DateTime(2022, 6, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4168), "Cool", 42, 107 },
                    { new Guid("dc68cd3d-123e-49db-9249-280ab71e3328"), new DateTime(2024, 5, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8069), "Scorching", 54, 129 },
                    { new Guid("dcae8f1a-fdfa-4519-b9fb-94922cee2e93"), new DateTime(2024, 2, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7737), "Cool", 5, 40 },
                    { new Guid("dd344708-ff93-4963-b879-1c233244ee92"), new DateTime(2024, 6, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8105), "Chilly", 40, 103 },
                    { new Guid("dd34b0be-7401-47eb-8904-9675b0e14f77"), new DateTime(2023, 7, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6555), "Freezing", 36, 96 },
                    { new Guid("dd500498-ba4f-4f45-ae78-2c62bc18fc93"), new DateTime(2024, 4, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7981), "Chilly", 2, 35 },
                    { new Guid("dd753da9-4e92-492b-94e6-7b4bdb6ee39a"), new DateTime(2023, 3, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5769), "Mild", -15, 6 },
                    { new Guid("dd7d7223-58b1-4bf3-bf47-c2cc987531f6"), new DateTime(2024, 2, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7719), "Warm", 17, 62 },
                    { new Guid("dd9819a7-5586-4284-b78a-d14ed324e27a"), new DateTime(2024, 5, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8036), "Hot", 31, 87 },
                    { new Guid("dda402cd-20d4-4141-9fa3-77d89af5c5c3"), new DateTime(2022, 8, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4502), "Cool", -7, 20 },
                    { new Guid("ddca1e52-2fc0-40ae-bf46-a7cc3e95606d"), new DateTime(2024, 5, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8059), "Balmy", 37, 98 },
                    { new Guid("de60411a-92ae-4cf8-91d4-9e5c20946a0d"), new DateTime(2025, 1, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8763), "Scorching", 22, 71 },
                    { new Guid("decb470e-3846-4935-ad6d-5d50f744d6c7"), new DateTime(2025, 1, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8780), "Freezing", -20, -3 },
                    { new Guid("deedcadd-a7a2-468e-80c8-be2a35b9fd06"), new DateTime(2023, 12, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7545), "Chilly", -8, 18 },
                    { new Guid("df411867-9f2f-4dcf-8774-5ca017e492ec"), new DateTime(2023, 8, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6701), "Cool", 20, 67 },
                    { new Guid("df6a49ef-f51e-406f-b5b7-442258cf853f"), new DateTime(2022, 8, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4453), "Cool", 24, 75 },
                    { new Guid("df7ee2c7-d749-41d2-8cd9-36d26bffcda4"), new DateTime(2022, 12, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5453), "Hot", -13, 9 },
                    { new Guid("dfd352cc-2797-4b52-84a4-133602b38f30"), new DateTime(2022, 10, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4894), "Hot", 5, 40 },
                    { new Guid("e04eaabc-43b7-4b6c-928e-772d62cc4b6a"), new DateTime(2022, 12, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5474), "Cool", 32, 89 },
                    { new Guid("e0b37e6c-61a5-418e-bc9c-e15555aba0ef"), new DateTime(2024, 8, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8294), "Mild", -13, 9 },
                    { new Guid("e0c923d9-5a16-42a7-9b82-8544fafb4482"), new DateTime(2024, 9, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8380), "Hot", 34, 93 },
                    { new Guid("e11085d5-3d07-41d4-b26b-0386f2e417f7"), new DateTime(2023, 8, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6642), "Freezing", -20, -3 },
                    { new Guid("e15f58d5-0159-4104-9304-eb5eb2fb660c"), new DateTime(2023, 10, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7245), "Mild", -15, 6 },
                    { new Guid("e18df96b-7d4b-408a-83a2-bdde54be2efa"), new DateTime(2022, 6, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4134), "Warm", 20, 67 },
                    { new Guid("e19fa219-89e1-471f-8655-f096612d4a6c"), new DateTime(2023, 3, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5737), "Chilly", 8, 46 },
                    { new Guid("e1a67bf3-54ae-4d72-ac73-91c2a7cbabfc"), new DateTime(2024, 1, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7671), "Sweltering", 33, 91 },
                    { new Guid("e1c704d6-7246-4bf7-b7a9-d7dcc8bdb8a2"), new DateTime(2023, 10, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6965), "Sweltering", 10, 49 },
                    { new Guid("e1d1cb16-3858-449a-990f-4aec97abf1ef"), new DateTime(2024, 8, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8324), "Balmy", -15, 6 },
                    { new Guid("e2071be4-d12b-4ae0-9c04-6edd416780ea"), new DateTime(2023, 12, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7541), "Cool", 27, 80 },
                    { new Guid("e2a04738-4180-451e-b097-7bca1a03517b"), new DateTime(2023, 4, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5981), "Warm", 45, 112 },
                    { new Guid("e2c2d5c6-df21-46da-aeba-8b4bd170a371"), new DateTime(2024, 1, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7696), "Mild", 43, 109 },
                    { new Guid("e352a86a-ac7d-4f6c-afff-6962600d16aa"), new DateTime(2024, 6, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8141), "Bracing", 20, 67 },
                    { new Guid("e3d41961-94ca-480d-a44d-be0d421d1e82"), new DateTime(2024, 4, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7943), "Cool", -16, 4 },
                    { new Guid("e42139bf-9c30-42c9-a9e6-e8e8b029c590"), new DateTime(2022, 11, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5191), "Chilly", 3, 37 },
                    { new Guid("e43b9d24-00b5-4430-ad4c-82d0c5dd6c4b"), new DateTime(2023, 12, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7538), "Cool", 6, 42 },
                    { new Guid("e469a27a-9957-45d5-85f2-b4bf19c1c8fd"), new DateTime(2024, 8, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8329), "Bracing", 35, 94 },
                    { new Guid("e46a0160-110d-4779-a763-d274390aaea3"), new DateTime(2024, 1, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7688), "Sweltering", 17, 62 },
                    { new Guid("e500ee76-eaf4-49ef-b3b8-90b2ea90e1ea"), new DateTime(2024, 11, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8627), "Balmy", 16, 60 },
                    { new Guid("e51bd776-3f1a-4c56-96d2-9db881576d00"), new DateTime(2022, 8, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4733), "Cool", 15, 58 },
                    { new Guid("e5eee87d-d4bc-495c-8e76-55e294d288ee"), new DateTime(2024, 5, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8032), "Freezing", 19, 66 },
                    { new Guid("e65b9c32-b19e-49c6-8622-8a39882ba612"), new DateTime(2024, 2, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7746), "Sweltering", 47, 116 },
                    { new Guid("e6b97d1e-a527-455b-8b17-c94841c46655"), new DateTime(2022, 12, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5401), "Warm", 7, 44 },
                    { new Guid("e6bc19f7-0c12-4706-8179-8c6a6aa0f6bb"), new DateTime(2024, 3, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7879), "Freezing", 17, 62 },
                    { new Guid("e706c78f-1ffb-4c2d-ab43-2ec5e080184a"), new DateTime(2023, 4, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5968), "Warm", 53, 127 },
                    { new Guid("e75bb1ab-dbab-4b16-b065-3e1a55e16878"), new DateTime(2023, 4, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6004), "Cool", 33, 91 },
                    { new Guid("e77c12d9-c369-4693-ace8-2a5609b8fa59"), new DateTime(2024, 6, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8133), "Mild", 34, 93 },
                    { new Guid("e7b7cc77-f701-4062-9e53-0bfca6cf8279"), new DateTime(2024, 11, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8657), "Balmy", 4, 39 },
                    { new Guid("e7c49d45-6bda-4c83-bdf2-1953d2e3e2ed"), new DateTime(2023, 8, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6665), "Mild", 18, 64 },
                    { new Guid("e7cd48c2-27b7-40dc-aef2-8d1b3c7a50c6"), new DateTime(2023, 6, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6500), "Warm", 11, 51 },
                    { new Guid("e84127cb-8716-476c-b853-bcd69255bf44"), new DateTime(2024, 5, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8077), "Sweltering", 6, 42 },
                    { new Guid("e841ef1e-9ce5-49cb-80eb-905a1f88d4e7"), new DateTime(2023, 8, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6689), "Hot", 19, 66 },
                    { new Guid("e875c754-f76d-46a0-92fe-b5eeeb2459f7"), new DateTime(2024, 8, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8307), "Chilly", 28, 82 },
                    { new Guid("e88934e1-c507-4f7c-af12-cd15445f4cc8"), new DateTime(2024, 11, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8665), "Hot", 18, 64 },
                    { new Guid("e910c19a-e089-46e8-a5f9-afd91d26f667"), new DateTime(2024, 7, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8241), "Cool", -11, 13 },
                    { new Guid("e91233a1-45d0-493b-bcd1-900e8c1e0095"), new DateTime(2023, 3, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5782), "Freezing", 11, 51 },
                    { new Guid("e91e4005-2d80-40fc-8456-fd073ad2338b"), new DateTime(2022, 11, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5152), "Mild", -5, 24 },
                    { new Guid("e92adad7-4e6a-456c-8f4d-0ba6e86a943f"), new DateTime(2024, 2, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7756), "Chilly", 27, 80 },
                    { new Guid("e936c178-3dd8-46a9-8d91-eab7d8a1ce3f"), new DateTime(2022, 5, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3997), "Freezing", 32, 89 },
                    { new Guid("e97215bb-9631-45aa-970f-c0ce34b2036f"), new DateTime(2022, 10, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4950), "Hot", 29, 84 },
                    { new Guid("e9f05a6f-1dcc-44c3-8702-2736e3956b43"), new DateTime(2024, 9, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8432), "Bracing", 11, 51 },
                    { new Guid("ea3d482b-238c-4db1-b9ca-44d7b7cd4ddd"), new DateTime(2024, 1, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7678), "Balmy", -17, 2 },
                    { new Guid("eaa491a3-0e28-4b88-b499-a1dc3ef767c4"), new DateTime(2022, 5, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4029), "Scorching", 22, 71 },
                    { new Guid("eb120b3b-33ca-461f-afff-828efd2a5662"), new DateTime(2023, 9, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6746), "Chilly", 51, 123 },
                    { new Guid("eb72a3ec-0bd9-411e-8b26-a737f842642c"), new DateTime(2023, 6, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6474), "Cool", 32, 89 },
                    { new Guid("eb821e9e-2df0-4574-a3ee-36b91692a93c"), new DateTime(2023, 4, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5989), "Mild", 38, 100 },
                    { new Guid("eb8cf569-e46e-45e2-b887-f7da1488689e"), new DateTime(2023, 4, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5974), "Hot", 11, 51 },
                    { new Guid("eb8db586-0049-4b9f-a9a9-4d5e5904c4c5"), new DateTime(2022, 8, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4717), "Sweltering", 4, 39 },
                    { new Guid("ebbecac1-96f4-40b2-96bb-b85f5a56304a"), new DateTime(2022, 7, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4255), "Scorching", -4, 25 },
                    { new Guid("ec96cc0e-ecd9-42ad-9d2f-b206e720b5c6"), new DateTime(2023, 9, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6719), "Hot", -19, -2 },
                    { new Guid("eca7369e-00b6-4b56-9567-1d538b5c87ef"), new DateTime(2022, 12, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5431), "Hot", 51, 123 },
                    { new Guid("ecd5f23b-7158-46c7-ba79-84ad94e93170"), new DateTime(2024, 10, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8565), "Bracing", 42, 107 },
                    { new Guid("ed145b09-8489-4748-8fbe-9c25494879bf"), new DateTime(2023, 12, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7528), "Cool", 18, 64 },
                    { new Guid("ed230858-4ea3-4b0e-a43d-b4688fff5611"), new DateTime(2024, 4, 28, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7986), "Scorching", -2, 29 },
                    { new Guid("ed415301-f369-4a3e-8c68-6a56d791629f"), new DateTime(2024, 6, 4, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8092), "Mild", 24, 75 },
                    { new Guid("ed5f0404-176c-48f1-8002-7769e0ccf915"), new DateTime(2024, 4, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7961), "Balmy", 39, 102 },
                    { new Guid("ed7790f7-d789-4660-b995-70842666bef6"), new DateTime(2024, 6, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8110), "Freezing", -7, 20 },
                    { new Guid("edb65405-0841-4008-bd91-a29ba8bd0be4"), new DateTime(2022, 10, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4956), "Freezing", 19, 66 },
                    { new Guid("edff0a24-d6b1-4830-842b-6df995b6623d"), new DateTime(2023, 4, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6010), "Chilly", 46, 114 },
                    { new Guid("ee925289-6728-4792-9c05-8ce8b5df7a8f"), new DateTime(2023, 6, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6492), "Scorching", 50, 121 },
                    { new Guid("eed8c1fa-e126-4f25-bb96-cd1cb1101fc8"), new DateTime(2023, 1, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5561), "Sweltering", -10, 15 },
                    { new Guid("ef3baf25-739f-48b2-a103-d4de23a17057"), new DateTime(2024, 3, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7828), "Bracing", 3, 37 },
                    { new Guid("ef4f5a79-0461-4112-af3d-057e20786c0e"), new DateTime(2024, 7, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8243), "Cool", 14, 57 },
                    { new Guid("ef698826-1841-42fe-8a92-4233c76388ec"), new DateTime(2024, 1, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7711), "Hot", 43, 109 },
                    { new Guid("ef99c294-f8c6-451f-980e-40148392d389"), new DateTime(2024, 3, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7848), "Chilly", 29, 84 },
                    { new Guid("efbe2da6-8f2e-4cd2-9db9-110fa4ff848a"), new DateTime(2023, 6, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6490), "Sweltering", -19, -2 },
                    { new Guid("f001a890-2bad-49ab-afff-426c176681ec"), new DateTime(2023, 5, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6078), "Cool", 20, 67 },
                    { new Guid("f01c85d0-74dd-47c9-8eae-42b8f112c83e"), new DateTime(2022, 12, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5466), "Balmy", 17, 62 },
                    { new Guid("f04bee0d-519f-446c-b0c1-ddeb5ecff9e9"), new DateTime(2022, 7, 3, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4206), "Mild", -16, 4 },
                    { new Guid("f055f33a-0611-434d-bb8a-ba305e9e2c2e"), new DateTime(2024, 12, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8725), "Balmy", 46, 114 },
                    { new Guid("f0e45ef8-e992-4b7d-81a1-6dd4ef3e9b3c"), new DateTime(2024, 10, 15, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8536), "Hot", 53, 127 },
                    { new Guid("f1050a8b-d2e4-4adb-a69d-fd3d10882050"), new DateTime(2023, 9, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6911), "Balmy", 35, 94 },
                    { new Guid("f18c5b97-b3a4-4435-86dd-c784ecef4acc"), new DateTime(2022, 9, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4798), "Freezing", 7, 44 },
                    { new Guid("f1c1e510-8b94-4179-a3bc-fdbf8a1ab532"), new DateTime(2024, 12, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8687), "Balmy", 49, 120 },
                    { new Guid("f1d1955b-97ba-461a-9497-d54893f545cc"), new DateTime(2023, 5, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6076), "Balmy", 18, 64 },
                    { new Guid("f20d4f2f-581c-441f-ad86-94d832e5b699"), new DateTime(2022, 8, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4496), "Hot", 0, 32 },
                    { new Guid("f2108d61-249b-406b-8505-968bf6c9016f"), new DateTime(2022, 12, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5445), "Hot", -1, 31 },
                    { new Guid("f21f137b-cd9e-439b-b9d1-57e03093d453"), new DateTime(2022, 5, 20, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4048), "Scorching", -5, 24 },
                    { new Guid("f2d78a6d-ee7c-4cd8-9fbf-21cd7f9c9472"), new DateTime(2024, 1, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7673), "Warm", 52, 125 },
                    { new Guid("f3281f97-5537-47a0-8ebc-556d329e68c1"), new DateTime(2024, 12, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8741), "Hot", -12, 11 },
                    { new Guid("f3857fec-f6f9-4518-9781-e1263df0ac32"), new DateTime(2024, 5, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8029), "Scorching", 9, 48 },
                    { new Guid("f45c40b8-14fd-45d9-a96b-3dafb3a15a8d"), new DateTime(2024, 11, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8587), "Sweltering", -13, 9 },
                    { new Guid("f46f085f-cf66-48da-920d-2ee5fa46e097"), new DateTime(2024, 1, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7602), "Freezing", 28, 82 },
                    { new Guid("f494eb21-fcd3-4b1b-a0fe-800186515e06"), new DateTime(2023, 11, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7493), "Chilly", 6, 42 },
                    { new Guid("f4a6b90d-d07d-4574-8376-d5f92e520a9e"), new DateTime(2022, 9, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4793), "Warm", 18, 64 },
                    { new Guid("f4ab3906-93e3-4c98-8bcf-cabbe46cd29f"), new DateTime(2022, 5, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4053), "Scorching", -13, 9 },
                    { new Guid("f4afa2f6-c244-4659-a153-41cf57d486fb"), new DateTime(2022, 6, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4085), "Sweltering", 48, 118 },
                    { new Guid("f4e8885b-92d7-42b2-85f4-dd2d4930a890"), new DateTime(2024, 3, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7843), "Bracing", 43, 109 },
                    { new Guid("f4fc9325-54a0-4aa1-8bb1-573015f0b81c"), new DateTime(2023, 10, 31, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7411), "Freezing", 1, 33 },
                    { new Guid("f51e5979-866b-46ff-81e1-36131e2a87e4"), new DateTime(2023, 1, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5517), "Mild", -12, 11 },
                    { new Guid("f5412991-00c8-42ea-85d8-2a4ed26f5a8e"), new DateTime(2023, 11, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7426), "Sweltering", 14, 57 },
                    { new Guid("f545b357-408e-4633-97a7-ceaab73d9571"), new DateTime(2023, 11, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7488), "Scorching", 30, 85 },
                    { new Guid("f557e748-af6a-45c3-a057-38a7f632671e"), new DateTime(2023, 7, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6565), "Scorching", 31, 87 },
                    { new Guid("f58aaff5-6a00-4782-9382-6052db23ee38"), new DateTime(2024, 9, 18, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8417), "Mild", -5, 24 },
                    { new Guid("f6819bee-f3b6-47b8-8a85-64a220d3850d"), new DateTime(2024, 3, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7837), "Scorching", 44, 111 },
                    { new Guid("f6b57a27-ea65-45ff-a28f-2de20de6cf59"), new DateTime(2024, 12, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8753), "Hot", 1, 33 },
                    { new Guid("f6ee7070-7952-4e05-bacb-e8d5e1c908b5"), new DateTime(2022, 6, 9, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4107), "Cool", 42, 107 },
                    { new Guid("f70ac607-7388-4641-9c74-863a36e1d5d1"), new DateTime(2022, 9, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4839), "Mild", -15, 6 },
                    { new Guid("f75ce725-f9c0-4781-b50b-9e6a6226a3ba"), new DateTime(2023, 5, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6103), "Cool", 0, 32 },
                    { new Guid("f77fee06-3c29-4699-8693-62ecfd1578cc"), new DateTime(2023, 10, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7216), "Sweltering", 32, 89 },
                    { new Guid("f7b28681-b09a-4eae-b4b0-c29f7c6bc303"), new DateTime(2022, 9, 8, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4774), "Mild", 6, 42 },
                    { new Guid("f7bf508d-b209-42ac-942d-5bee299f25b5"), new DateTime(2024, 9, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8406), "Bracing", -7, 20 },
                    { new Guid("f81e2a61-625f-4729-97aa-8b94d5327fc9"), new DateTime(2022, 11, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4961), "Cool", -11, 13 },
                    { new Guid("f8979c20-a38d-44ce-986c-f4a3d6018880"), new DateTime(2023, 3, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5721), "Warm", 41, 105 },
                    { new Guid("f8b058ed-3d52-4d47-8f39-689cd5cf0c6b"), new DateTime(2023, 1, 14, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5556), "Bracing", 20, 67 },
                    { new Guid("f90dfa0c-feaf-4d11-8a30-8b44977344fb"), new DateTime(2022, 9, 10, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4781), "Mild", 21, 69 },
                    { new Guid("f94f3011-19aa-44f3-886b-621fa3a57033"), new DateTime(2024, 10, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8553), "Freezing", 3, 37 },
                    { new Guid("fa05027a-d545-4d13-b81a-43050d5a118d"), new DateTime(2022, 5, 17, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4037), "Chilly", 20, 67 },
                    { new Guid("fa5d4ecc-b13e-4b04-87ff-f23a2a33feaa"), new DateTime(2024, 3, 12, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7830), "Hot", 51, 123 },
                    { new Guid("fa74efff-fc8d-4dee-9db9-e3cf9fd12c44"), new DateTime(2023, 12, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7562), "Hot", -20, -3 },
                    { new Guid("fa7c7e98-20e1-4008-9cc1-e54cc6dbd4b4"), new DateTime(2023, 3, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5756), "Bracing", -20, -3 },
                    { new Guid("faedfb20-7a7c-4452-97d3-331bb2f82601"), new DateTime(2022, 12, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5483), "Hot", -11, 13 },
                    { new Guid("fafa8cd0-ba7e-431f-854d-e64f795c5db5"), new DateTime(2024, 8, 1, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8281), "Scorching", 28, 82 },
                    { new Guid("fb55b0b0-fcc3-4b19-843e-d161b4ed45fc"), new DateTime(2024, 5, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8056), "Freezing", 25, 76 },
                    { new Guid("fbb4e2fe-4d80-4cf9-bc00-dba30d03d1ec"), new DateTime(2022, 11, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5172), "Freezing", 31, 87 },
                    { new Guid("fbc1d291-1777-4ab3-b7f0-8f45dc212018"), new DateTime(2024, 8, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8351), "Hot", 25, 76 },
                    { new Guid("fbeef6bd-41f3-4a1c-b40b-a687d1de6dd1"), new DateTime(2024, 7, 11, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8220), "Bracing", -12, 11 },
                    { new Guid("fc49beaa-e65d-4ffd-9f96-079dd4587244"), new DateTime(2022, 4, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(3971), "Hot", 42, 107 },
                    { new Guid("fc910c3f-db71-4fb7-b956-fd545cf5e2a8"), new DateTime(2024, 12, 22, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8730), "Mild", 21, 69 },
                    { new Guid("fca1e0f6-26ba-42b2-bd1d-4239927cf617"), new DateTime(2022, 11, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5148), "Freezing", 49, 120 },
                    { new Guid("fcfab158-2d1b-4603-800c-a74bdcf2e7e2"), new DateTime(2022, 7, 16, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4246), "Mild", 3, 37 },
                    { new Guid("fd0490e6-5f50-45a5-8c00-cab750691267"), new DateTime(2024, 7, 13, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8227), "Freezing", 50, 121 },
                    { new Guid("fd16a9df-3ae7-48af-bf50-e4443559ff82"), new DateTime(2023, 6, 19, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6470), "Cool", 20, 67 },
                    { new Guid("fd196e7a-1ddd-443e-b254-4b67c6050ce7"), new DateTime(2022, 10, 29, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4953), "Freezing", -13, 9 },
                    { new Guid("fd1f0a11-8daa-4517-aaf0-03de7ff097fa"), new DateTime(2024, 9, 2, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8372), "Sweltering", 16, 60 },
                    { new Guid("fd4bfc4c-85ed-46ef-9852-c04c09298930"), new DateTime(2023, 6, 21, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6476), "Bracing", 54, 129 },
                    { new Guid("fd519c78-59d0-4f38-932e-c07b49269a2e"), new DateTime(2024, 3, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7864), "Hot", -5, 24 },
                    { new Guid("fd64cd26-3995-45c2-acb5-d71a3c3b7720"), new DateTime(2022, 5, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4000), "Hot", 34, 93 },
                    { new Guid("fd69e1b4-ba98-47b6-89f9-701984ded536"), new DateTime(2023, 3, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5705), "Freezing", 21, 69 },
                    { new Guid("fd6eb1e8-331f-4d68-bb2f-daa5386fa0d1"), new DateTime(2022, 5, 26, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(4064), "Balmy", 50, 121 },
                    { new Guid("fdb5a152-5525-4dc4-bfc1-95c0e7311503"), new DateTime(2023, 12, 27, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7574), "Hot", 52, 125 },
                    { new Guid("fde38475-074d-4f74-a8c0-026ae99bd78a"), new DateTime(2024, 10, 23, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8558), "Hot", -19, -2 },
                    { new Guid("fde86d68-9e9b-4472-bfe8-8d01cb5e98f9"), new DateTime(2023, 9, 6, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6735), "Chilly", 38, 100 },
                    { new Guid("fe06f331-53be-4158-bcda-a8a7591f8025"), new DateTime(2023, 11, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7431), "Balmy", 0, 32 },
                    { new Guid("fe444d64-be3b-41fe-8619-899f0793d8ad"), new DateTime(2025, 1, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8770), "Sweltering", 7, 44 },
                    { new Guid("fe7c2313-3d2c-4a5d-936b-b83f72486222"), new DateTime(2023, 3, 24, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5761), "Cool", 46, 114 },
                    { new Guid("fea2e0bf-7619-447f-9fb9-11bab3c2509d"), new DateTime(2022, 11, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(5123), "Hot", -19, -2 },
                    { new Guid("fead7e5e-8b34-4781-9805-7bab95b76696"), new DateTime(2024, 12, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(8682), "Bracing", 51, 123 },
                    { new Guid("fec3f7e8-69ac-454f-aff5-8e618d729554"), new DateTime(2023, 4, 30, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(6045), "Chilly", 11, 51 },
                    { new Guid("fed5c1d3-c84e-49f4-85ae-a668bb9424f9"), new DateTime(2024, 4, 25, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7978), "Freezing", 53, 127 },
                    { new Guid("ff6d4299-634f-4f3c-bcbf-4b3b09cac750"), new DateTime(2024, 3, 5, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7810), "Chilly", 35, 94 },
                    { new Guid("ff77b73a-a84e-4c25-866f-2d7c5aa7cc3f"), new DateTime(2024, 2, 7, 20, 14, 11, 915, DateTimeKind.Local).AddTicks(7734), "Hot", 35, 94 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0039eed2-d22c-42a3-8c3f-d3254be77f58"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("003a1a57-d04f-4022-82ff-1c9c704ea19d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("008a4074-47c4-47ba-8d3b-7a37c2e217be"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("00d5a98d-bbf1-4a26-b0a8-2aec9f29ada8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("00e3040c-5a6e-4e70-82ae-66c93110ce6c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("01396b64-5389-4edb-aa23-9f98a543f96e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0149fe11-24fb-455f-b309-7d0ada27cc5a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0191d7db-e727-48ca-a491-687fe25f9bbc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("01d691e5-3e57-44eb-9893-18002cac189e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0214b2ab-675f-4a22-9d02-85f1db3c637f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("024aa2a4-892d-45d3-b82c-26b621937284"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0282d59c-0977-4693-b6c0-6d30bb88f637"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0330cf6b-0595-4345-855e-5858567ef2b0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("034e3506-ef0a-4caa-a5f0-0c844053a04c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0372e42d-4957-49f4-8e0f-845cd3ade758"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0428c9c0-05ca-4935-b441-e7bc69b4f5d3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0443bb02-24e8-4d51-929a-7338b0a7bdc1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("04ad6e60-b7e1-4136-b4db-f0a8d4d70df1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("050ebb5d-01fc-433f-aaa7-97bef660e68f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("058a4043-94da-40ca-b51d-80ee7ca1b64b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("05a8f276-ddda-449a-8a2d-df9e93aa45fd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("06660027-38b7-4d3c-b8be-5e039b8e72ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("066c3832-cd73-453f-9775-14604ae965ed"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("068c957c-2602-4ac3-9d39-8526dd08d4f6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("06a0be64-deea-4666-a1f6-b8b149d7d7cb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("06d1b9fb-b1ba-4f2b-9bfb-ad4f91ef966f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("076b3bf1-27b9-4834-80c1-62bb93fb9368"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("07db197f-c544-4a07-b20a-bc49c5afa25a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("07e872cb-ecb4-4bc4-bb51-dc029374333c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("07f2f9de-9441-4f42-aca6-29184ec60a9e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("07f6da5d-31da-4866-a83f-bb7b22d98fb5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0839fc46-b393-42b2-9d83-d9fffcd34fc4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0848a22d-55f6-4757-8dd9-aeaa458273da"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("08aa3654-242a-412b-a7f1-ad2e5a611cbe"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("091bbbf4-93af-4289-8820-ccd85aad9d48"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0a00d39e-c101-4cf2-9796-0b67f574e08b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0a638589-6378-4529-bc84-55a537d49662"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0a9652ca-a2b0-40bb-b451-342b14f7342a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0aa4d846-5b88-4db7-97ff-c84560d56b2e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0aaf3148-ceef-4813-b930-018686a08ce3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0acec600-d213-4e76-91f1-601e0471d03c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0b6f865e-4d2a-42db-b815-4f3fd73d9738"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0b94ab7b-4b69-427c-a12f-29e2a0eabf2f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0bac577d-38ef-49ac-b8cd-4449598a67b8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0bc188c5-f393-4257-bc06-4d16e1aeadd3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0bd4ea9b-81f7-4b40-90f9-72da75b86541"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0be8c9df-0a5a-4e96-8cf5-cba765a3f34e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0bf9188c-24b0-474f-b307-5256ed88230a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0c17ddbd-86aa-4bee-a119-29c826458cd9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0c25ee30-5a33-4394-963e-f8f9a5747226"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0c3a70cf-6069-479e-8fd0-e57cfd1d669f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0c69e352-db2a-4dcc-9a7c-2ce0a5ed87cb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0c8135a0-ff26-40fa-8384-dd69ed077453"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0d04b3b8-9c28-41cf-a7c7-2594a75cead9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0d262b52-199d-4447-bd01-db33777da1e2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0d524d4e-f7e1-4838-b9a2-b2311f9a06b1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0d6addee-6cb8-48a3-947a-7eaeb9c9606b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0e1e2027-15e2-45ad-a272-65beeb5d4a8b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0e5bfe7f-ba87-4983-85ef-dad7ee9f4963"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0e8debb3-027d-4743-87c9-fff57dd21133"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0f209ec4-1e13-4eef-9895-39ee958dc9b3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0fa4ba2a-cd76-496c-be26-d2c6543dfee1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("0faf3c0a-c1e1-435d-bb80-8d713eabd56f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("10733b52-0575-4e38-8440-10452b4af05f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("113de170-571b-45ca-b06b-2e52d36878f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("116f1d9a-a619-4e64-8505-38e5a0279194"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("11a6dfbe-27d1-477d-b427-b652001c57d1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("11c19965-516a-4aa2-8d5a-e2580c75f189"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("121e285d-bfaa-45f8-8a94-ade8b56e0fb1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("123ebfba-1586-461c-88dd-cec6c2701123"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("12d81dd5-b228-47cd-9194-32005ac34d31"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("12d9e769-582a-47b8-86a6-514544ddeee3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("135fd134-e232-4876-b058-5adb53ae8670"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1390190e-80be-481d-a287-d159dcd5a95c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("13b9914c-7a6e-469f-b918-6ca87c2c7b73"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("13bf8380-81d7-41fb-be45-59721bbd496d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("13fb7f33-dc90-4e0b-b5f5-da20ddab5df1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("142dcb99-1672-4fc9-9b6e-01775a132224"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("142f8f36-4317-4b31-be77-81c9627f7e9d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1438f103-3cdf-4cda-a22b-17bb54846347"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("144ba891-d472-4605-9306-28497e20788e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1466a7be-a258-41db-b001-47009323008a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("147be06c-75a5-4d6e-82d5-bb1810cdc907"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("14ecdf16-3a96-4c92-875a-cfa7de05fdb4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1520ab40-e2c7-466a-bd49-b1340403cb9a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1557adc1-c08c-4e15-a1a4-2870bf7444ab"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1576a8af-d2f3-4c50-87e3-b6cc4f91f6c0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("161db75a-74a0-40e0-b368-2a8a08b746e7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1636fa47-495b-4ad9-8f32-88025dada2da"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1645e5ac-eb58-4312-a6d7-0f99d5f5dd98"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1652b76a-7d0d-4a86-8d4f-a2738649b292"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("169e4908-14d2-4835-9923-825ef862d135"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("170c2b9c-2dd9-4a93-b867-ac1583c7f048"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1713beec-757b-480b-b06a-d1723f69525b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1750ca3e-f5c6-45be-be46-37942ee0a2af"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("178600db-7326-49cb-b7a8-3ad5a31859b7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("17cce5c1-1080-4b30-bffe-bc3cd3d5b576"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1817fb00-921a-40c2-85ec-965b8439fdbf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("184ccb39-8e88-4f2c-9943-666116066be9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1890e112-47a0-4b92-abb7-1e77b37b4380"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("18c5f613-e8e5-412a-8d0f-c1fef6adb649"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1978c1f9-5238-4e6c-bd8b-a1810604de1a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("19ba5f45-f2ca-4d21-b672-88ab01ba84e2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1a042f41-ae1c-4cd1-86ee-5e8d2540a3fa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1a0fb31d-d061-4a21-9d98-d5678b32060a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1a670186-850b-443b-9565-d9ceaefcc077"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1a958014-f629-4ec7-a2dd-7246faca7272"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1b859959-a032-47d8-a66c-0489c20a0ec0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1bb638e5-f8a2-4a42-a7d5-659e3dee706e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1c70b9f3-f7d4-40af-9897-668be353d4ef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1cb0eb20-6fc9-4e37-abe4-cc983c437046"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1d7f3dc3-dc3e-46f8-81de-b52c948c93c2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1e0fbfe4-572d-4dee-953e-3d5ca4e611cc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1e2b3737-6468-4388-8a61-545e982bee65"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1e39d2af-58cd-4530-b353-695c99906fa6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1e81e6aa-ed31-4081-976c-7216a1569de9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1e8ce454-f035-46cd-a0d8-b8014c2bcaef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1ef4d58c-ad5f-4208-9208-45ac4fdfbb66"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1f120b9d-0e60-4dd8-b417-f8b80d73b705"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1f1a755a-25ab-49e9-9ca2-273953d135be"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1f5fd86c-1918-4ba0-b485-56bc25c66631"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1fa4a02a-f6be-4f3c-9149-d143def5f091"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1fa750fa-ae62-463f-978d-f19ccdf77b2e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("1ffa7366-9b11-49f7-8654-6ef42c00fd73"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2002f187-cb9a-4f57-9e62-b123298077c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("201d3df1-cc73-445b-9eee-02365fb98c9c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("208f673f-eb3a-4df2-97f2-e3fc5bf56606"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("20f9bbac-b847-4365-aff1-226d983ba7f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2107aae5-9384-4c6b-999a-01cb0a76b354"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2126e968-49fd-48e8-b6aa-45cda360eb10"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("212fb1df-b460-49e6-b4cc-1dd1d8c0ee81"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("21a0788d-7ccb-467e-8292-96815256a439"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("21e73fa2-aef9-45a2-b36e-625f2cca778d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("21eb3dc9-7e7e-4462-a8a8-c099c9a15a65"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("221d83bd-18e5-474f-8720-905709b4322d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("229b1cf7-9ec4-45b6-b418-84b371a3f217"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("22ee2076-cbbc-4417-9ce0-72af1e131525"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("23421a94-3fc6-493a-8523-77a7c9960a76"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("23dba211-71b9-4c46-96b7-3eba74eff208"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("23f95739-9bbc-4484-aa3d-e4b1707bcb22"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("241f1a61-05df-4567-a67f-ad56997085d3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("24455f03-d823-4634-ba5d-b324fa40104f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("255f1f83-abe2-4442-b140-2139276431ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("256814f8-fe3d-4fa6-a05d-a60b2e4f65a0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2590ad9b-7821-4364-b7b1-3810f6d718ea"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("260c011c-63fb-4f51-8dd3-b9259ab7635a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2645e16e-c528-476a-a6a8-2a6a61b20f87"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("26873973-6385-40ae-a003-ee6715bc9d91"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("269fbf57-881e-4476-a028-97cf756da985"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("26a5fb0c-2529-4689-89a7-a4972e612010"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("26d50d90-aa9e-4a07-83b1-3adc2da4fc66"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("26fc776f-a89a-47e0-968b-566d45620bb1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("27098fd7-a90b-48df-8513-fb9cd588549f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("27324b14-e5ba-4d00-befc-686b4637ff39"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("274ab388-f67b-4277-a82f-249941446c63"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("27529f1c-1941-4813-a8ff-8ecb6dd23330"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("278d9f5c-9908-4540-8b61-90b25094a06d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("28099df1-31b3-49c8-a060-c3e330b127c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("287bdffb-057d-4e02-8df5-7347e408cd32"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("297395d1-c072-4fc1-878c-509026f56a38"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("298196f9-0800-4dc9-a2fa-23f4779c6e48"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2a0ffdd4-31d6-4bfa-a836-8355a6651584"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2a269e4a-a839-45f8-93d3-9364db544023"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2a7c877b-39ac-4f29-be5b-e9a00f9788d1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2aaab1c5-997a-4ade-80f0-615f45a85e19"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2c2f3995-cc8e-4f26-b949-c8849705e541"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2c336723-b573-402e-8805-c8bfbc5ac6c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2c4a27b1-7727-448d-9ea8-bd517d268c91"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2d15457d-e2bb-4c03-b8df-3bd32ccba2c4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2d8dd7ef-8691-49d8-87e0-079f3a9aca6e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2dd15ffb-b583-4893-a579-65189a337f5c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2df35f57-09da-4971-af26-041f3ea49eaa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2dfc3dfa-a9c7-45bd-b772-e0eaca499d66"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2e569237-7ddc-4607-ba8e-7c7bf741d246"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2f719f20-550a-4129-a46a-cb5e069b4878"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2f74851e-ec9b-47df-bcca-ee6d33803cf2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2fb2fb37-19ad-461f-bdf8-42aea5752c5c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("2fc16ec9-4e6d-4181-a617-1f40085cbaae"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3051cd8a-8699-4af3-a4f9-a7296e5b10e2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("308c9f3d-2500-4cc8-b4d9-fded363a09cc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("30f014c6-38d4-47ab-bfc9-9ea4b3af0997"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("31677f42-9457-4349-b64e-c313a6c41c05"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("31eca9a4-e5fa-4181-aeac-24e912d08cb3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("32097233-e9a4-4fa4-b8a9-cf9a9ea72022"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("323eb473-bcae-44a1-80d7-f5248084abd1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("325b00fa-896a-454e-bdd0-953940fa5d05"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("327f0630-f0b6-4a77-b3dd-c04ff9744997"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("32a6716e-b9ae-4404-bd8c-89389ca013f1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("32ba6c18-3418-44c8-abd6-ed8260d5e572"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("32c4386e-4754-4279-9d46-9a0cc6f1ae3d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("32ebb246-da62-4889-89ed-f7f6b204d181"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("33017606-99a5-47c5-8378-b37ee4ab85b2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3310eb6c-d4be-4640-b77d-5e7d3286b858"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("33433021-7f08-4799-a3c1-cca4f26f9aa3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("334db2c8-7cbe-4be9-962e-f137a572d963"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("33bf6251-30df-4995-9786-f82a90ad7e5e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("33c2bc45-533e-45f0-98ef-31881364744d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("33c768a6-01e4-40ef-961a-b53078f93d63"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("34048f4a-e61b-42e8-b30e-a5286da2c572"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("341b72a5-e9e6-424b-bfd2-2dfbc7f9cdb3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("34811a86-034e-4e5f-8571-d1cc40f4f383"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("34a89caf-7851-4a1f-b72b-c561828958de"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("34fd11d7-8f44-40fc-8790-462827804652"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("360795ea-93c9-4dc6-b2ff-352619c4cd3a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("361f049b-19fc-451e-a77b-4178eb647eff"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("363a26a8-33d6-4ba0-8d4d-de2b07680d4b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("364f149f-1f69-4b55-803b-2e438a6a3c28"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("36c970b6-f765-4c0b-ae3f-464dc3264e18"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("36f9c6ac-75c1-4796-bb0a-1bcf4db4ffbf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3783dc68-9608-41b7-bee4-010e129c9aa8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("37a623ed-3b20-42a2-87c2-739c2efa76c5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("37acf2e5-9343-4add-bcb7-b36e855c7c5c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("37d7392e-aa60-4e4a-8476-ab918599880f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("37e954bc-eea8-4bf5-a578-9f1cd04c5f9f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3811722f-54e6-4582-85a8-3933de352f65"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("382c9993-275d-4321-93aa-d117e25342b4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("384ecad5-0a55-457a-9800-af9e0d8718c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3860454a-a8bc-433d-a2c3-f7ffe529fba1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("38e3aef1-4399-4e76-b470-0b5fdbe20e48"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("390fe896-7cb3-4b6f-adf2-21398a3c3d88"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("394a218b-53cb-4b17-a16e-2ca9de3009d4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("39659acb-3016-41f8-842e-3e8f2e525313"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("39b85689-a40e-4253-bd4e-dc0d61eed665"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3a046be6-8649-4c85-b591-c6f6e9df5edd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3a266813-b493-4196-8b0c-83bb0d8787f1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3a2f1e85-0dfb-4a29-bd74-4e2f28201366"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3a55afb3-4816-43a5-922a-3858d50c8e51"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3abca9dd-12a1-4be5-b225-80ec066d2180"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3b24bdab-36c9-4bc2-8400-b6ec5fb40b31"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3b2e2f85-bf0c-4df5-a01b-21c53cd365cd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3b489561-0fb3-41ba-8f51-d95f85790596"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3b58e402-17a4-406b-9017-2980a292a19b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3b8024bb-c8a2-4e15-81b4-340f7033a77e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3b833c11-fadb-4bb5-98c8-4f480327c9e0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3bd14a5d-90b4-444e-ba1b-16d761bdef5b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3be017fc-ee3c-4ece-9a55-bf72df42ace2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3c16d2d0-d508-4286-a298-9bd6a2cd4791"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3c28080e-ccbc-47e4-89e3-de7bb6481f53"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3c2abdd9-4c4f-47d0-b512-242d0e6f3eeb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3c4ad31e-5beb-4f5c-a8b6-b4c16f6fab78"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3c60f2ed-7f6b-4fd1-93c7-5bad13b35834"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3cf1b473-d89f-4bfe-ae18-bec2db8ac356"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3d18c7d5-844c-4eb7-a453-b95a6a0d72f9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3d237296-9335-4b36-842f-188b1408856b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3d2ce1b3-b382-4f25-a5f5-360eb815f52a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3d34cc79-229e-4260-8de1-c618f43284b8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3d3e727d-3559-4c78-b74d-03b260eef0b8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3daa6473-f316-41f9-8bc3-55b87499b355"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3e0f7968-dc88-484c-bef5-e8c2741de429"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3e48c685-59ed-4534-bdaf-a8f40cecf8e3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3eec0189-e482-453d-a71f-27602d74a6d4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3f527512-0e57-4a54-a9eb-d933499e165f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3fc8609d-ee46-4d88-9e48-5acfd934d275"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("3ffe5676-f810-4ab5-b8d7-036df0bd7751"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("400d7871-3f98-40cb-bd1e-769a73854b5b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("402027ba-2617-4769-aa27-a10ded44e9a3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("404e0021-a8d2-413b-b67b-0496221a236c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4059be01-910f-4db4-850f-8664a11e9a7f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("40f328c4-34e6-4244-bdf0-9936beb098df"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("40f906f7-52af-42fa-b135-0d19cec41320"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("412c3d32-25c5-4d06-af85-312d4a47f413"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("418681b4-5f90-4481-bbcd-a3c4ae47ed46"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("419fd37c-19d5-413f-aeee-dd0b4e6b77c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("41b286c9-b817-4811-8443-743d9136f35d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("41ebe996-e2de-4032-b247-a3b09bd15847"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("421ab9a8-69af-4875-b377-8aa5055b6483"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("422baf86-f389-4bad-8f0c-a9a8dc81dc68"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("42cc8cc3-fdab-4757-bbb4-d56bd78e56ba"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("42da01f8-68a8-412c-98ff-d782411d9acd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("43136578-fac3-44b7-a59c-fba668f833cf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4397db9d-5e23-41df-bb91-d4bc0a1a0c4b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("43e86f47-939b-4afa-baad-c0351cb91e12"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("43fc235d-bd86-4b4a-81dd-ca016f13997c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("44088817-055c-4cd7-9ae3-0d56cb6a666a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4449d00a-735c-4344-9e72-ca6e1df085bb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("44648c7d-ac59-498c-9950-77c00dba2432"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4469216e-fd18-4d12-8fdf-99b8ddcffc69"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("446b964d-0cbf-447d-9492-6da71b60fda2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("44c6f7d6-0d0f-4f5f-915b-32107c97ab6b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("44f79c8e-d1ea-4609-a0a1-6974194bb475"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("453cd0a3-ec1f-428a-afb8-1d226d82a866"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("454b0afc-6fd3-4164-bc85-d8e625b56fcb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("45d35fae-1ed6-4977-9f22-0be2101a31a7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("46b2763b-f304-4b5a-a992-92a4184e33a1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("476fd57a-49df-48df-9f03-672d57fe2774"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("48364687-ed23-4f5e-80f1-92414f9e04de"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("483f8e50-49ad-4c11-826a-975be03c0a72"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("48846cfd-c406-4a5b-ae93-97c0f36684eb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("48bd67d0-7ad0-40da-aef5-7ac57c885c0d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("49026d65-4659-42af-accf-d701be2798c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("49975658-6412-4f0c-abf0-e433adc8361a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("499eb5d1-57d4-4253-a8df-d50632759790"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("49a07d81-44ea-4bbc-8176-6f10a48c306a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4a1d0810-1e95-4447-a90b-d25f4bf1c162"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4a917607-3457-4058-9bc8-ab1341414006"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4bd95cea-f9d0-4e0f-b4ec-a7e93e850c49"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4c11cdbb-674c-4bcb-b6df-5f5ec63b9ad3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4c78fec9-2d5b-4b6b-b9dd-be2fda443c77"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4cc755cc-cb93-4982-a6e3-bf98a5c6c797"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4cf8cacd-4447-4d5d-8c02-21b360c2e5c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4d05461b-ed96-460e-ac72-5970b89454f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4d0b057e-d9a9-49e7-af1f-b8ce74c6dea1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4d2d71ae-d368-4016-9bef-28b372a2f175"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4dee4729-e308-4c03-8ff4-be404e5a703e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4ebf8b0a-c8af-4025-a43a-1fd6294ac099"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4f0fd730-f232-4394-b1de-7957fc65db5e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4f3731ac-fa4d-4698-8484-69dded65f650"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("4f96c1a6-c68a-4a61-9304-6b3a98f7baec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5002c004-5c4d-4623-a365-f666f9b06855"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("500a98c9-b556-4d7e-a7ab-2d6dc4a13f00"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("500e9508-a37e-4d7d-b12e-56dc876b08d5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("501ac3ae-6d7f-41fc-86e2-e983bb62d9f8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("504338d6-06df-416f-a333-e0df74bfde24"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("509339d0-2dab-4928-842d-10e6d44fe60f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("513ad520-8815-4c7c-9e30-f614e495638d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("516d524f-af2f-4901-9ca2-8a3f157aaccb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("51bd8c50-bcf2-4604-bf27-e51da796e21d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("51f4c329-db31-496a-82ad-6f4ee167d66c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5211ec16-dd18-450d-98ff-4febf9a05f52"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("52279c6f-184b-4f7a-adcf-6651954cbad0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("52a0655e-3a03-44a7-996e-18883e5b3d5a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("52b99b0f-79d7-4d2d-b5a2-8e0115c8137a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("52f8f8e6-7b13-40ab-a11c-aac5295b2615"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("538fe654-171d-4007-91e4-9a1a945880b6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("53cb325e-3943-4aa9-be1f-6a39c67eabca"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("546de9b9-25b6-439a-93bd-9ead1c4c1093"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("54a66529-1c35-4fb7-ae95-c3d044a29560"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("56764328-a6c7-45a4-a22c-3447b4f626a1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("56990843-0199-4dff-93ec-e633fee969ee"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("569adcda-4faa-4bed-9215-83a3df77d9ee"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5845d71a-56b6-41c6-8174-615540407282"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("587f94cb-9b56-4ddf-b5b2-7f753cf9e224"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("58d5b219-8ac7-4949-8bdc-1a6874141d9a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("58f41cb3-f2e5-49a9-b5eb-55f5086fd671"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("592e0e14-a13f-459b-83dc-80b5e701072f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("593fca8b-cddd-4cff-992d-1dd16c080600"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5961124a-cb17-4576-a8e6-a4dea8d38fd5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5a2dacfb-5329-4763-ab54-9374a3f91f8c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5ab3ef48-6e0e-4f63-9efd-3d7a526311d8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5acb161c-be62-4442-a5ff-28edc8c302cf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5b0f83e7-b9a1-4dc8-b021-a1280d6b8977"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5b5c1ee6-2939-4f2d-af34-36d7a8370b94"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5b889dad-d2b7-432c-8d45-34171aa242f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5c1e893a-2b1a-4b13-b37c-69120068fbe8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5ca01240-08c7-4884-a338-81c84a5a0d1d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5cc7a6d2-57b5-4381-8de0-7622fee34d64"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5ced9d50-3cf0-4ba6-82b2-99342cc88a2b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5d0bc765-44a2-4709-b97c-ecb9ac440cdd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5d12ec5d-3ee1-48f4-a2e8-1ab9201a9343"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5d2cb68f-7033-487a-a421-3c71c14ab820"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5d4f2cda-f06f-47ce-9992-c4bda4c8a8d7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5d75ef3f-d827-416b-8893-cf0135c71c92"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5db0832c-1091-433d-bcb1-9b0759d2b5ee"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5dfd1c71-889c-417b-aad4-bc2624445540"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5e11a5d6-d416-43b2-9548-b2274ea939ca"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5e88cb9e-df4d-4b9d-9e00-0aeebd5fc137"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5e93a6e3-7ab9-4834-90d4-16e662d324dc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5ec13334-b507-4754-9e46-71102726bf55"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5ece13de-96a7-41c6-97e4-081fae2e42df"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5f421645-bd5b-4316-b69f-7a84ecfd048d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5f4c8bbb-04cd-4768-bce7-77fc90755f5e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5f690d60-36b5-4d64-aa7f-a42c3e15626b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5f8611fc-0550-4ef0-9a3d-2e339d7221d6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("5ff0483b-8bba-4f67-b5f1-035297f2b9fb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("601899ad-ddb9-482e-b63f-b47fa4c23a88"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6043b7ee-f414-40f8-b1b3-7b902683d922"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("60536472-d4f6-4fc3-aa74-92611fcd1ed0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6065a625-ee20-4142-8eb0-5d90340a43d8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("60a64484-bff1-4c0f-b32f-8549f0f829b3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("60ff413a-2ead-4e5a-b96b-a59b9c1f89e6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("613cf35d-b944-4e56-98a6-1cea41e6f335"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("61f2eb7d-6e12-4cff-ab96-beda2fb46beb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("61f9ff6a-a4f8-4258-a162-88a01d0390ea"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6277398a-e86d-4e54-90c8-83ede672d3bd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("627f38c3-f132-4ec0-a208-0682c1235686"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("62e10a4d-c4fb-450b-b1c0-0bf65e1e4128"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6357518b-1bc5-4bde-abf1-a59dd46b7451"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("637c63d6-a377-4c68-a9e2-b6c5b0439771"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("641f0f60-01d4-4f86-9040-3d2dcb2c96e9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("64a71201-0e34-46dd-a7f0-4bd396cb0b1c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6591f603-e488-460e-8e86-b68d2adc1535"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("65de7aa4-bda9-4716-a263-7ae6f7a0e149"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("667a0de5-e2c2-4c49-8751-19b86910f4c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("668d7693-7712-4754-a8d8-041c8664b13a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6755615e-2a64-4e34-85d4-e437edd59e1c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("676c63d8-3762-45a9-a0bc-ebe87555657f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("67de61e7-31e2-44bf-98da-3dfe5192075c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6839f5b5-b340-4b04-984d-e830fa7c1a10"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("68c34646-e200-43fc-8862-5830484b7604"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("69184700-e792-45f0-98a6-5c406b718382"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("691a6e99-4224-4842-9e34-1eaea787c986"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("692b3306-d351-4943-b8ce-eb4c01dd03d5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("69bc1b73-323f-490c-a6c3-5c5267d332d1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a0e2650-5d7a-4759-8db3-e7b99b9eaf07"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a16d55d-6803-4e32-98ca-1bff56e14bb3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a1740ac-e7fc-482f-bb74-ad150891657e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a2e4ca8-925c-49b0-9625-2d6b9fdf2c74"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a6e408e-c51c-439c-9cc1-d2d344ca329f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6a9eb2db-0053-4383-a0fe-f68a22127465"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6ac18d14-ffad-4a96-a353-c1436a13b492"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6bbbde82-4450-4b5f-b8fc-d4920802eb48"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6be7cf2f-13a9-407e-8d22-7fd2e284ac22"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6bf8d84e-021f-48c5-9209-e3e951b1b34f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6c06e92d-9fe8-4a75-8bf6-332570891af9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6c0848fc-a2d2-4c79-b46a-100169b408c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6cbf9bb7-a717-4b19-8446-2ad82d97a4ee"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6cdc517e-887b-43ed-b7b2-fba018394e77"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6cfbe981-29d5-41cd-8cb5-12b0ea5250ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6d2c4ae9-ab7f-4728-8b18-ca49d60b4083"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6d646970-1b6a-4dd4-83b3-6720aedfa4d7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6d8ccb46-7287-45fc-9ed0-4653caf56f47"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6dac479f-346f-4198-a4bb-362c97963904"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6df83b64-2030-4a81-afe3-1e737f1153f0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6e41611b-7326-487d-94a3-715124891f4d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6e5cfebe-4ffc-49ec-a707-c513cc238174"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6e680fce-b949-4432-81a5-81951364f9dd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6ef34109-cffc-4691-a657-3500c90d7f4d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6f0ef99d-3a4f-4d47-b3a4-a13898a89e8d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6f5f2799-7233-45fd-97d3-fb7bd1515af3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6f61bcc1-c2e2-4734-ae55-c940728babf1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6f7fd933-4dce-4c9c-87a5-9ddecfad80aa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("6ff05e30-f912-419c-a9bc-93052c6c0f75"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("70750de4-eeed-4b9f-921b-f63bdfa359a4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7095a179-d38b-4a94-8fd0-21ee835e0b30"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("70d8b59c-2f2e-458e-89fe-4c9929b29b1a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("717585ac-3bc9-4429-9dbb-9cc2f4c8da51"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("71791bc6-7278-42f2-908f-51def56e4d05"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("71c24239-085f-4745-bb0f-ed263897e09b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("71dc0815-5ec7-4016-a77e-f609cf3c9848"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("72109adb-ebbf-4004-b3ee-5c44ee71235e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("722101f2-ba22-4313-aa46-f8626555ce14"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("725664a2-5023-4850-9b73-f949662e0e58"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("727758f4-6c2a-4f8c-b033-8c57fad02bd9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("728d8a8e-b250-4128-92cd-e296a8833f89"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("732fd6c8-a9d0-4296-91f9-19b83e5a30ab"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("73496c30-fc7b-4027-96da-7ffe96614f71"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("73c45e83-85ce-4a07-a101-d2648821e4ef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("73feccfd-4628-4c86-b8d7-fca2f340d8db"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("741225a4-9b85-4c2a-b764-603cc78e272c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("745028e5-ea84-4183-8d21-468b24ac217d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7460d7f5-0188-4d27-86c8-2eebc13c584c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("746d7f03-88db-45d5-a5a8-9f8cc03f34c9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7472a248-31a9-4a5f-93fe-1ec2343fb926"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7479a918-c675-46bc-b2c4-c39aa611a6fc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("74c19658-16d8-44f4-acb6-e578ec3e90da"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7504eadc-8ac8-40e0-ae83-21c6377daf80"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("75f1c675-85d7-419c-90e5-88c96ed73777"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("762d327e-ac68-4c99-8366-fa6e96c66b09"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("767d36f8-e063-420d-801a-4c6acadacec1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("76a526f3-498d-499a-8b41-fbf9bd1dbbd5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("76de02c8-3357-44bf-beee-a90209daf6e8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("76e6ff0a-a221-42e5-979b-0d1d7eb5f990"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("773848af-b12b-4696-a825-f6fce044f310"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("77532f4f-fff2-4007-bf6c-2cd4e47b379b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7766e89f-6dfd-432e-845e-e956b56b7cca"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("778e39b6-5bfb-4944-b427-3a482d998657"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("785c99c8-c768-4de3-9db6-d943eaf61c79"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("78a9d203-8088-48b8-b895-127698179a60"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("78e2c99d-cd93-4972-9a6a-f87aa6247ece"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("78eea2f6-84f7-4015-8079-5bdabda49705"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("79b5aa80-7d1e-450f-bca9-f0ca59e64f4b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7a141405-a525-426f-b208-dfc0f682a9fd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7a158044-6c80-43a8-a2be-b1f632a4f1a0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7a45aa8e-5d78-44ab-b111-0e2d4ae0ffbf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7a7f4f4f-34a0-48c8-9137-2f18410c6afb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7abf06f6-f7d8-4683-93a6-edab4b8d7a88"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7ad71347-8a89-49f7-a1b8-61186ccde763"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7aefae62-95dc-4bbe-8b2f-9f2096921a93"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7b99909d-fdba-4a0e-94f3-d79d6d3548ed"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7baa5f4c-d0ca-48c1-81c9-09d799aaaf0f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7bb9cbcd-1af5-4562-b742-41d1dbe3d4a0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7c72c56f-0cf7-4528-a0ae-9b29b89c3e2d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7ca1ff40-ca55-4859-a710-564894b6b180"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7cf677ae-7c80-4f73-afbe-0c7c50e710d6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7d5e7afb-208b-490f-ae17-28c0c07e5ec0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7d7479b4-a1f6-4bbb-879a-6e6dd41c2c38"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7d99f7bf-4bf6-4788-8932-02036d5f0d28"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7e0f3261-cde3-4731-a3be-bf7167531507"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7e79887e-3877-448e-b5cb-e3e74151889b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7e7dcbf6-62e3-43c7-9973-a1cacee00faf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7eb0f634-7a22-4699-b265-f012fa37f56a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7f0c9183-e66f-47f0-801a-1e118e9d7cd0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7f0dd91e-00ef-4dda-bfe5-9b5ccbda71b7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7f553f93-a687-4038-aa7f-cadb446ee656"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("7f65b717-aae0-4797-82a7-efaab92991aa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8028b148-8b7b-4a48-b823-c2aa009d9101"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("802d2300-874e-4200-a3d5-a2485ddaf61d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8031f37f-484d-4ddb-9eca-69fb87d6a092"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("80982da9-d64c-4a75-bed1-56950d6ce835"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("80df76cd-b917-45ab-9976-5172e4ef22c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("80f624cd-bbd6-4e68-bb74-e4761f963f93"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8156cc8e-974d-4a08-a0fd-15c3d35e3af1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8191dd9a-ce5e-40b2-b651-d45905801fe3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("81d347fc-b85a-4158-911a-0e18d786f330"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("823c1475-058a-4322-b7db-4794298d36cb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8246e50d-2eb4-4e00-860e-2629782e2e8d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8273db50-68a4-4415-87c0-7f4832eeb8f8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("82976034-af29-4bc5-b593-84c21f1b7fed"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("829a833a-ad53-444f-aba1-a4d7c27ba948"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("830b859d-2cee-44fc-9b88-81f7ca1a9498"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("831e04a5-5fbb-4da7-9830-ede3b78f1646"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("83e3fc51-7454-4c45-a81b-b68631e4a48a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8414817f-73d4-4206-8a46-18bc7dc68787"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("843129df-c087-4b78-a311-f2e1705e6c42"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("84f1d61d-2b51-4f27-86ec-d1660a49829e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("851b61f5-490c-4219-99de-c32f229ac327"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("85a1dfc6-bec8-4266-ae6d-a92d5e6580f9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("86499c93-37b1-4414-9d5e-ab15a070a4fc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("864eefba-cb4e-4c65-a8b9-37a762548f3c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("867aa622-7182-47aa-8364-0d01d25d6cc8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("86cdcb86-deb3-4870-9faa-c3da69afffd1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("86e89a61-8d32-4bb9-ab6d-e84e56236ae6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("871a7a57-c04b-465f-87c2-514f83f2302f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("874fbfa1-a381-45d1-96a0-cd3bf39608ea"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("87f5477f-f425-48da-815c-74ae0ff6b2da"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("87fbb6fa-3d90-4e31-810d-b49de5083afd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("88799418-67a3-4ed4-b580-6f5a75bfdf77"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("888e8f1e-de6b-476e-b897-fe8f986649d0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("88d5f39a-a639-424d-a4b4-34e948a80253"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("88ec3cd3-8a5b-498b-8a91-6538ffef88b6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8951ee51-c2cb-4747-8b3b-88fbcd1dc377"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("899078ed-cea3-4884-8b1f-ec8ed120062a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8a45aac9-554e-4726-8a43-0d47d17a98f7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8a53d677-8652-49db-b8e6-1f7335ddf066"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8b6c1379-df30-450b-a137-2bb96e305ba9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8b8fd564-1424-42cf-b99e-46e693fa0423"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8bd42934-a85f-470c-b6fd-3ab837fd549d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8c53c88f-b625-44db-9659-1548657c9a2f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8c5cdf48-90cd-4e60-b183-7e7f45b79b26"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8ccf09bb-1905-4d72-b50e-a225e297233f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8d099a77-79d7-4e06-bf41-a68f7a69dfa8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8d101eea-b23c-4396-bec6-c4219aed70a6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8d38b98b-0b0a-42dc-b4c1-f2212e81740f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8dc829f6-c7d8-4f85-9273-c3d75f109503"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8dc9484d-469e-4a44-82d5-4f7c182c18f7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8e02e456-902d-4bb7-80b0-530cca1a6dac"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8f0c84ee-113e-4061-91d3-c29377448ea1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8f6f3bf4-7eff-47ac-8044-71a41a5c30ac"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8fe0d7e7-6206-4919-a7f7-74884df4bfb9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("8ff4436e-522b-4309-9f0e-2fd453673036"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("90e1d8ae-5022-40b1-8c1c-88ae535c83ce"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("91231813-3cb7-45a5-ae33-3a9329f252f1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9123cb63-4450-4870-9d45-4cdd07364807"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9126f6be-fa5a-4265-9a4e-659ec0634250"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("91aa6b17-c8b7-47f1-96a4-dec5cf241b78"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("91c5a3c2-9f21-459d-83c3-91b1a7a3341a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("91d33a75-5b5f-4f27-befa-dec53e0b16f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("920763ed-5749-41d4-99ea-4748413771c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("925daede-2262-4b15-a8d0-e0ffd380490a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("92617e8d-d1dc-41f6-9ab9-681b6134dfc3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9261f1b9-df79-4874-98c6-208e803799cb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("92d2d2f1-3365-4035-b70f-1acc7a3778e7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9307f94a-1ee5-46c7-83df-2098caee9437"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9325d8c4-1f26-4742-996b-550b4ef42af3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("93c6e4d9-3e03-4874-9451-e6e67716a8ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("93e8cfa9-e9f7-4497-9248-221569653c27"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("93f0c21e-0384-4891-97d0-94dfb7d18749"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("93fc63f5-6c6c-4fca-9f6b-5ed869495c63"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9447be93-3b0f-4b26-b188-3f2e1648b9fc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9455a5b0-7976-45e3-aec5-7838a4214821"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("94e5e9f3-da6d-4815-a288-7385e05879de"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("951f65b1-ae42-4664-a42b-d54f896aa8e7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9574341a-bbb1-4d12-a859-85f356de538e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9580cc91-798b-4c94-b547-933d8be6990a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("95d408a7-93dc-471b-acb7-014fb7649416"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("95d96fac-4db7-4bf7-b97a-2f44ac2456c5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("95ff5c74-ab85-42c3-bba5-d27fcb8d6aa2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9626db20-4e84-4826-9f58-7b4438f6534d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("96378a19-8000-4a7a-bd5e-d54b7b410488"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("96fbbcf5-9b5a-4c90-b3f3-2716001d10d7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("97049450-c60a-4751-816c-e1836ab23b52"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("972947cd-db8e-4f8f-bcb6-00a814a3777c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9757380b-0013-4dbe-8ffd-73770b942d93"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("97d14b9c-a48b-4d91-af3e-628e3842e77e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("97f3d5a4-9278-403a-803e-307fc27dafe4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("98571ba4-a8bd-42c4-9e2b-afef4051d1f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9860c3d6-3f91-4c90-b2fc-854deb75aba9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("987d16aa-8e55-48b4-89de-d3a8ad2ba3da"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("98bf4bf1-78cf-4d64-be42-8defa41f41de"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("98c78580-d537-4f4c-82ad-b342f3687021"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("98e93dd7-d285-4bd1-aaf8-35005bb83d2e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("98f6fb14-595e-4f09-aabe-a0b1da122e82"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("98fe7378-3bca-47ba-b598-01416c9cbefb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("99443ffc-691f-48b1-b1cc-d6f3a974f05e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("996c99f2-1d05-4580-a693-e7e432bf9f71"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("998c0ae1-95b6-4349-8349-60029242983c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("99ac363f-40fb-4228-871a-1f9010fc2798"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("99faeceb-34ea-420d-9999-a914a9b91864"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("99fd4593-8013-47b0-bf05-4c25998ebde3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9a42cfe7-e3b3-4cbb-a2e0-f3854644ea24"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9a50ebda-0068-4d55-bb3e-1d40efdc6404"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9ad8027d-aa51-4d7b-bcf5-eb3e2f96aabe"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9afaf547-f171-4093-995f-5d5b220ef725"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9b28cd22-b0ca-49a6-814a-08e0e7bce470"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9b80811d-dd7c-489a-8a73-30e959c05515"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9b982592-2ded-4fc5-9381-ab497092eb54"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9bc372e1-c543-4daf-989b-5b5ccb06978b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9bd54716-d8f8-49f7-b2e1-579d0b00fcb8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9be8b154-ef34-43d4-aa55-0ae4373253c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9d150113-dbec-49d9-8530-1dd795272312"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9d1f11c6-fab2-4386-8a0f-dffdc5c811c6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9db34d31-bc34-4a89-83d4-3e569e6ddf99"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9dc277e8-722c-45da-be21-4212b8b5c4a4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9dd50110-2612-4c52-96da-8e9ad2dee903"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9deeeb9a-7a45-4411-a989-79cf35148293"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9e49fa8a-238f-435c-8bce-dc8e4cdd179a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9ea5e627-1ab9-4e76-ab94-c9cb2fb99169"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9ed3314e-afa7-4704-974c-8835b674589a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9f183b03-4b13-4219-aa7a-133b001b47c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("9f25f7dc-d1ef-4697-928a-ae174969524d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a0128c90-a196-444a-b206-92005e6e2284"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a0a22505-ff4e-4781-a492-e970cdf0323f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a0c19c74-d819-4b7c-9aa3-c4e12a8c9dfe"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a0f1b0ca-a7b9-4edd-a27a-39b31611209d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a101371d-a37a-4661-83b8-1a7a9965f4d2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a16d3bff-66d7-46c3-8042-88a4ef750519"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a18df3eb-d67a-4122-b2e6-a84b477ecc17"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a1befa76-18d3-433b-8af7-0bf307805005"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a1ea57c3-d756-4694-af25-f5507e4032c0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a22cbecd-5793-4d4c-a582-7a60cc523e6c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a22d621e-73de-476c-b0d9-4b892538926b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a251ab65-8719-4875-8b27-d2af428bc935"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a2914aff-2552-4f8c-9af8-8d8a4d273188"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a2a4a3fc-c280-40ea-9123-ca33afd0a943"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a2cb2d31-f2d4-4ff3-9ebb-f4796067952d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a2e94f46-8557-4ce2-9046-855471921310"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a2f7c9eb-f8fc-4489-b76b-aa5f2813e781"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a360ac22-f60a-4b02-8109-e6ffa166392f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a3aa9a31-3e22-496e-979d-687fa6b68ed1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a3ee363a-4835-4d05-a4ee-7fdfe4279a9e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a4ccc927-05ae-44d8-8d37-d0c298c15a01"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a51c8351-2779-464b-ad01-8cff1c757aa4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a5751549-da08-4379-9f78-ef6227a8c6f4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a57fbfbf-7804-4d87-9ec4-2167e3891f27"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a5dc39b9-37e0-4fdf-a268-c8062c73e3fa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a5e0bceb-264a-448e-9bef-4ab5d75254bc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a5e513f8-b8d3-4d19-9662-7c035c8ef803"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a6340bff-e258-45fc-a8b3-8b0e8ef120c2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a648065b-b029-4a29-ae4b-3aa6ef5d1db1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a67cc8b3-80aa-4526-aa5c-32bc42c7498e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a69bf183-b1e8-4c9f-81ed-ea36527add60"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a6c9f47f-fa27-4462-a63c-31a0d17ed577"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a7098edb-c0cf-49fa-9090-f36686ba4062"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a70ce960-5ed6-4ea6-aa15-99eaa6fdc4f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a72c5994-37eb-4611-a98e-09e35d81ddb0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a75aef28-1936-4e2c-9a09-21866f58c661"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a79cc9e1-4785-45a2-a5e6-563824a34dd6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a83a86bb-9cd2-420b-a7a2-18dcb989fb64"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a85dd8c7-472d-4043-913f-0e29f7cf52c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a8cc1b7e-e9af-49f7-9b0a-c6a8ced645cd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a95f634f-e5ba-442d-862a-fa531d00bf0c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a989aa8c-360c-46bc-960b-dceaabff2a25"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("a9aeb340-8807-4001-a714-60dcc047f06b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("aa990b91-209a-48ab-8fa4-baa6dc082248"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("aae6df1e-dd62-42fe-9e24-ba13d89c6c59"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("aaef18ec-bdb0-4c6a-be27-1847a01c3a98"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ab3cc0a8-528e-4e19-8e6b-0aa812f13a63"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ab6a7d8c-1aab-4843-863c-453362bedc0d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("abd309f3-3253-4c3e-8a86-1821cea0c4fb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ac31ec22-a574-42c1-9bfd-032d8c6ff2a1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ac4838d8-5e5a-413b-b60d-05a37f6cb6a1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("accbb0c1-2d30-4738-a598-b1c023326827"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ace8b2f5-ddf9-4287-a44a-fd3810d9817f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ad146621-0170-4982-8b88-35326a7e339d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("adba4b00-afa5-4209-a9ab-b8b15e28988e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("adbe3ccd-e7d0-4be8-b810-bd1a495b817a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("adc94bf9-4464-4655-8549-a2e1b4d8dedc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ade9bb7b-14bc-4825-9fea-51eb369a2791"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ae98855d-2912-4a8c-a3fb-0245a2e9ed8e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("af194834-a549-4390-985d-f7a8eda7958a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("af37ea14-a600-4d42-adbd-02addc1a029d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("af7c90b4-dada-473b-9b42-cc69883b80ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("af833ae2-d887-4c2c-ae09-81d8acd6b620"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b069d1e7-c849-48b0-8559-54d9061aa563"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b0f9e067-6933-4616-a072-0cb8a1952107"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b1068812-54b6-477d-92c7-19bc362edabb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b12ad111-d205-4347-8196-00aba785f758"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b12d32aa-38e1-4dd8-b3a8-3c8a695b2541"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b18c7d57-e61e-409a-803a-8ad90a4d8768"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b36a5b97-6712-4be8-b36c-5cd5896ba814"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b391feaa-6309-4d90-a60f-6a6704116567"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b438a2c4-e29c-4c75-af6b-25e2db804d4b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b4f8b579-6038-4556-b3ec-6d31df649fb9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b5296d3f-7890-4e11-860b-00d414fc8db4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b5494b1f-7e01-4750-b7ea-a1b713646cc3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b56837b9-9bb2-4043-af6c-6b46035f91fd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b5822230-b1b9-40de-861b-326391aafbbc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b5b25cdf-5edb-4321-8cc7-0b8eef0baf3f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b5cc8b77-6269-4bcb-b95d-f72dd9150504"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b62d85c4-3b04-4630-8d54-10119c99225d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b673ba28-2795-4992-b419-4ebcc5754b76"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b69c6c2e-f85c-4498-a972-266962d7f26c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b6e9f438-646b-42f2-96c3-4e1de67092c5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b6ed8fe7-c27b-46d5-abd2-b7a5979b790e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b6f48915-de4f-460d-a355-49a263cddb61"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b74411c1-8ed8-4574-966b-b1671d6c3794"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b75b779f-fda4-41d4-ba42-666e9c5b9548"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b7c42420-2b3a-4e41-a6bf-3cbc6179a03e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b7dcb227-c118-4c40-8dc4-a0a72cce6d6a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b7ee86ce-2671-45c6-aaf5-d1e4b5b913c5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b8b7e6dd-80c0-4af5-9226-4c569130dacc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b8e9fbca-13a1-4621-be9c-5b34248ddd30"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b901b1df-2d8d-40ed-8f31-447ea2aa9609"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b90ae923-5ec4-4c91-be78-ba67c24f5a86"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b97bf412-d46e-40c5-a274-5a33358c4f03"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("b98ce7c2-81cd-45c9-a3fd-8589c01caa06"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ba07b769-3d7a-4305-b885-ce17cf9d89ba"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ba91bf3d-b6f3-4372-bb41-3289149ab8b6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bbbbcb6e-7d54-4bad-857a-d7aa75a891c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bbfcb211-9ce2-42a1-8351-c0371931c222"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bc5b8a87-bcdc-4637-b349-085e7d94ad41"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bc9517a3-5a69-4492-9d70-ce71567423c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bcb76124-8836-4750-bca0-247455e427c0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bd421c3c-c78a-42ba-a19d-349fd3274bd3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bd5fa9ca-a998-429b-94a0-06991fd5464c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bd6552f1-f750-4456-907e-8d49fc64740f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bdaf9d85-c68e-4cc4-b109-6fec6b3e25ba"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("be097ea5-84a9-4644-b82d-48fea251edc1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("beb474bc-96b7-4043-b5d5-40917c1d516a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bebc80a0-1d87-48c7-ac44-551dc12c74b2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bedce7ca-3ff8-424e-80f7-a5b58b9c37a7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bf1b1220-e191-4c66-8658-4b2ab0c69587"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bf1f60bf-6691-4890-92e3-c0e8a72384f2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("bfab65bb-e7d5-4101-bcc4-bd75efb176e7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c02918e7-55cd-4cd8-bccf-7954769de94d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c0579512-2bb4-4140-8219-1c6e04776a61"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c05ba57a-a39e-4b9b-be67-abe54c8bb341"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c05f30d4-63e1-43a7-9d67-efb8689d7922"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c0b8c4db-0881-42e5-843d-806358705ee3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c1687a6c-c01b-4645-a4d9-69066fa89457"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c16a42de-872d-4d27-aab8-725a88b90673"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c16be980-3908-46ec-93ab-55fd2943a527"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c1adad63-c2cd-4d16-9447-cdf00e4d90af"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c1fd448a-0808-41cf-a8d3-c1d0d4cb0aca"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c25b25e6-14cf-4cf9-9300-2a864a873b67"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c2ea058c-c47d-4fc8-9cdf-e65da15e147f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c330d1b6-89f0-42c4-8985-3251296479b8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c3556498-29c5-4d90-8f3f-a637a36ee317"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c3929021-0870-4d20-bfc7-c22cdcd5f41a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c3bc99dd-95c9-4ddb-a58f-dd7e3b278ffa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c4248c2c-5448-46c2-9f1d-c6db8d1118dd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c44ce81b-099a-47fc-b2c1-9742414969bb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c45d5476-a65e-4521-b13b-51ff158f2990"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c4639ad4-ab42-4de0-91bc-0358dad956bc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c46c22e5-1631-4a1e-addc-f7738db138e9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c49a7784-05c7-46f3-8e59-d0beb4c78248"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c4a2869e-34fc-4e83-98d9-a6daf13b072d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c4ba2c3e-c3e9-457f-a6f7-5cecc6d29670"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c564f158-ba4e-4cd7-ae85-9c6dc1e67292"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c56c247b-b604-495e-b932-2083ea83cba8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c5754dd3-23c5-4220-9482-542c4e4aee3d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c587bd65-5abd-4e3b-b7a4-160e6dca6f6d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c588dc89-08aa-4583-992a-98778f2e2c18"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c593c4cc-6806-4ee8-8423-fe5d0519ce14"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c5b69f23-abb7-43a7-b8ce-5e57cf8d4959"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c5f246ca-0f02-4b2c-9d4a-689a535c2d9c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c60a3b22-2b5d-4494-af5c-77fc20b955e7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c616c6dc-e7cb-404f-bd1c-ee7de1a64e11"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c68cb502-3951-447a-85e4-7e4ce90a9862"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c6b9bd03-bda1-40e1-b1c3-50da5c74486b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c76e68e2-d29f-43e3-ae11-9745b07364ac"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c7f361e0-775e-4637-8d1a-03f06e72b203"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c80fbbbb-5897-40c5-9585-55f2f8de43a2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c846723b-0b6e-41a4-97d7-9fb9a3390d2a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c873b687-aac4-412b-8fe7-63a8cc00d1d9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c8bbdbf6-7017-4270-a18d-7abd5a961607"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c8e6462b-bcbd-49b9-b3d5-70475d37d306"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c9647bc6-13f9-45ec-8698-a62ee52bc738"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c995002d-098e-4a0f-984c-810ca7ec63df"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c9a81948-ae98-452f-b3d9-0c800146ba18"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c9b6edf2-db3c-4b0e-894d-b8949f4d9853"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("c9d247ef-a826-4ed9-8aa2-bd1f25e490f5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cacdf68f-4f6c-4229-8b0c-c587f8fc18ab"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cadef5ec-e62e-48af-b53e-3104c3bb2ef9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cb1f3791-8163-4678-95a5-4d2b21bcbabf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cbc08f71-517c-428c-853b-19f4e2e474d1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cc378b94-51a8-4448-bcb8-df2bd301ff5a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cc408ce9-c875-4740-903b-dbc7cc3db11b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cc60a81c-d121-49f2-87e4-8f5aa94320dc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cc7fd20f-3fc1-4ea0-8660-e6676669ee52"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cc84b1e3-af25-46eb-8dca-bc0f25cc4e84"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cd980255-c643-4875-bb6f-f238de7a9655"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cdb8dbb2-520d-476e-8b8b-787feac040e4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ce1de89e-76e1-4f87-a8b8-4751ba1b4dcb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ce3867be-4e63-4551-bf19-1eca890ed2c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ce63420a-1907-4f38-bfb7-36f596c683ca"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ce696f3f-3c0a-4a6a-8c1d-8b104b541328"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ce6ea5d8-5fae-43f4-8185-ebb4258e8f4d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ce8f41e5-8ce2-4b9f-8501-382a6b2f339d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ceaa29a4-c60c-4ff9-8d28-0f0e2b50adb9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cec64fba-4cf7-4f6a-bf9a-71871e3822fa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cee0289c-d161-48d4-9394-12413ce036bb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cef4e288-e789-472b-88a0-2c70e292c3c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cf3521cd-bafc-4c18-9487-39070c2c7d39"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cf4b33e8-7a81-4ccf-81f6-5afbcf7bcbdd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("cff0c7cc-6ec4-4548-9efe-dafc01abe1b7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d0b7cc6e-f601-45d0-95ac-2c6425b1b0f6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d16b6444-899b-43cf-8b68-4b5886a834ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d1b3f12e-5280-4b98-99e1-90e044983a0a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d1cff043-e91b-4d45-a150-4c129a54fe1d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d241c769-32a1-48d2-bd04-fad28ee20713"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d248fab8-2415-4b21-a014-9f8ed8df149d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d25a0579-9ff0-4cce-b412-d0e9aba4dce2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d28d7df3-69df-4f78-b9d9-0b7b71cbc69f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d28fabbf-1d3b-483d-b792-857e09fb9c82"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d298205d-edae-4db3-b515-8541d634fe51"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d361ddbb-6dbb-4c4c-a525-84a54b87032d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d39012ae-9949-4bfe-882d-8efe897bfbbe"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d3cea1ef-dda3-4ebb-b339-389cc7f1b112"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d3d211a4-103e-42bb-8c0b-b10eb08370fd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d3d8f9e4-34e9-4e3b-9b1e-77b81fa194b6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d3da602a-240c-4da7-9a42-29286479eaf8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d44c024d-ce2b-4ae9-81bf-5bb9349cf9ba"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d4b08694-3547-4a10-81df-2dcb83cdd24f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d4b192c4-7e66-4e88-b0d7-8ac87b0f82ca"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d4bcab98-be5a-46c0-aee6-6fc7e82927c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d4c42f1c-be9c-41bf-935a-2858e8c51737"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d52e0273-09dd-4abe-9057-21a32b3f680c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d54e4dc3-9620-4c8e-a6de-3f2e59862a0a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d5c02fb5-1c5d-4ccd-b74b-9f6251af57c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d5ef4d45-feee-4def-9a22-7adee4c2237e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d68dfbb2-7afb-4b8a-b719-5b714c521a61"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d6ca6286-2535-41b0-88f0-6f54cbbf65b9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d742d971-7fa0-4350-a885-4baaaec89da3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d7ef4a8b-7e3b-4c75-b2c2-848800018cc7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d830017f-4409-4486-8a10-e3c0a7568eba"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d9367483-62e7-47ea-ad80-3ea9b91373ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d9461d94-1a85-465a-a3aa-dcc9f883f035"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d974d487-21cd-40e7-af8c-513ced34aaf3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d9e0acf1-40ab-4ce0-8ee4-b85292220e41"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("d9e2bf98-0bf1-4ddd-9cb3-760fdfdc5aa9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("da3a724d-1f05-4cfb-8f53-671281b9daa8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("da4d32aa-dbef-41ae-a730-358c882802c0"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("da85b56b-6189-4d11-aedc-9cd0d4ba3ff1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("daa35c7d-060e-4ed8-a407-bed62a6587cf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("daebae27-6f73-4e3f-ae1f-6a757b096384"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("db398995-a881-4ffc-889c-370f38335b7c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("db70caf0-c417-4efe-a2b7-febd3b5dcb0f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dc003c8a-5f79-435a-8ed9-d118215c62c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dc48726b-20df-4149-82bf-ee05777b424a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dc68cd3d-123e-49db-9249-280ab71e3328"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dcae8f1a-fdfa-4519-b9fb-94922cee2e93"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dd344708-ff93-4963-b879-1c233244ee92"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dd34b0be-7401-47eb-8904-9675b0e14f77"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dd500498-ba4f-4f45-ae78-2c62bc18fc93"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dd753da9-4e92-492b-94e6-7b4bdb6ee39a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dd7d7223-58b1-4bf3-bf47-c2cc987531f6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dd9819a7-5586-4284-b78a-d14ed324e27a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dda402cd-20d4-4141-9fa3-77d89af5c5c3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ddca1e52-2fc0-40ae-bf46-a7cc3e95606d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("de60411a-92ae-4cf8-91d4-9e5c20946a0d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("decb470e-3846-4935-ad6d-5d50f744d6c7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("deedcadd-a7a2-468e-80c8-be2a35b9fd06"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("df411867-9f2f-4dcf-8774-5ca017e492ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("df6a49ef-f51e-406f-b5b7-442258cf853f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("df7ee2c7-d749-41d2-8cd9-36d26bffcda4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("dfd352cc-2797-4b52-84a4-133602b38f30"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e04eaabc-43b7-4b6c-928e-772d62cc4b6a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e0b37e6c-61a5-418e-bc9c-e15555aba0ef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e0c923d9-5a16-42a7-9b82-8544fafb4482"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e11085d5-3d07-41d4-b26b-0386f2e417f7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e15f58d5-0159-4104-9304-eb5eb2fb660c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e18df96b-7d4b-408a-83a2-bdde54be2efa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e19fa219-89e1-471f-8655-f096612d4a6c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e1a67bf3-54ae-4d72-ac73-91c2a7cbabfc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e1c704d6-7246-4bf7-b7a9-d7dcc8bdb8a2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e1d1cb16-3858-449a-990f-4aec97abf1ef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e2071be4-d12b-4ae0-9c04-6edd416780ea"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e2a04738-4180-451e-b097-7bca1a03517b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e2c2d5c6-df21-46da-aeba-8b4bd170a371"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e352a86a-ac7d-4f6c-afff-6962600d16aa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e3d41961-94ca-480d-a44d-be0d421d1e82"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e42139bf-9c30-42c9-a9e6-e8e8b029c590"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e43b9d24-00b5-4430-ad4c-82d0c5dd6c4b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e469a27a-9957-45d5-85f2-b4bf19c1c8fd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e46a0160-110d-4779-a763-d274390aaea3"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e500ee76-eaf4-49ef-b3b8-90b2ea90e1ea"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e51bd776-3f1a-4c56-96d2-9db881576d00"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e5eee87d-d4bc-495c-8e76-55e294d288ee"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e65b9c32-b19e-49c6-8622-8a39882ba612"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e6b97d1e-a527-455b-8b17-c94841c46655"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e6bc19f7-0c12-4706-8179-8c6a6aa0f6bb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e706c78f-1ffb-4c2d-ab43-2ec5e080184a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e75bb1ab-dbab-4b16-b065-3e1a55e16878"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e77c12d9-c369-4693-ace8-2a5609b8fa59"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e7b7cc77-f701-4062-9e53-0bfca6cf8279"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e7c49d45-6bda-4c83-bdf2-1953d2e3e2ed"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e7cd48c2-27b7-40dc-aef2-8d1b3c7a50c6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e84127cb-8716-476c-b853-bcd69255bf44"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e841ef1e-9ce5-49cb-80eb-905a1f88d4e7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e875c754-f76d-46a0-92fe-b5eeeb2459f7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e88934e1-c507-4f7c-af12-cd15445f4cc8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e910c19a-e089-46e8-a5f9-afd91d26f667"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e91233a1-45d0-493b-bcd1-900e8c1e0095"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e91e4005-2d80-40fc-8456-fd073ad2338b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e92adad7-4e6a-456c-8f4d-0ba6e86a943f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e936c178-3dd8-46a9-8d91-eab7d8a1ce3f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e97215bb-9631-45aa-970f-c0ce34b2036f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("e9f05a6f-1dcc-44c3-8702-2736e3956b43"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ea3d482b-238c-4db1-b9ca-44d7b7cd4ddd"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eaa491a3-0e28-4b88-b499-a1dc3ef767c4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eb120b3b-33ca-461f-afff-828efd2a5662"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eb72a3ec-0bd9-411e-8b26-a737f842642c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eb821e9e-2df0-4574-a3ee-36b91692a93c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eb8cf569-e46e-45e2-b887-f7da1488689e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eb8db586-0049-4b9f-a9a9-4d5e5904c4c5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ebbecac1-96f4-40b2-96bb-b85f5a56304a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ec96cc0e-ecd9-42ad-9d2f-b206e720b5c6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eca7369e-00b6-4b56-9567-1d538b5c87ef"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ecd5f23b-7158-46c7-ba79-84ad94e93170"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ed145b09-8489-4748-8fbe-9c25494879bf"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ed230858-4ea3-4b0e-a43d-b4688fff5611"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ed415301-f369-4a3e-8c68-6a56d791629f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ed5f0404-176c-48f1-8002-7769e0ccf915"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ed7790f7-d789-4660-b995-70842666bef6"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("edb65405-0841-4008-bd91-a29ba8bd0be4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("edff0a24-d6b1-4830-842b-6df995b6623d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ee925289-6728-4792-9c05-8ce8b5df7a8f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("eed8c1fa-e126-4f25-bb96-cd1cb1101fc8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ef3baf25-739f-48b2-a103-d4de23a17057"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ef4f5a79-0461-4112-af3d-057e20786c0e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ef698826-1841-42fe-8a92-4233c76388ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ef99c294-f8c6-451f-980e-40148392d389"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("efbe2da6-8f2e-4cd2-9db9-110fa4ff848a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f001a890-2bad-49ab-afff-426c176681ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f01c85d0-74dd-47c9-8eae-42b8f112c83e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f04bee0d-519f-446c-b0c1-ddeb5ecff9e9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f055f33a-0611-434d-bb8a-ba305e9e2c2e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f0e45ef8-e992-4b7d-81a1-6dd4ef3e9b3c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f1050a8b-d2e4-4adb-a69d-fd3d10882050"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f18c5b97-b3a4-4435-86dd-c784ecef4acc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f1c1e510-8b94-4179-a3bc-fdbf8a1ab532"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f1d1955b-97ba-461a-9497-d54893f545cc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f20d4f2f-581c-441f-ad86-94d832e5b699"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f2108d61-249b-406b-8505-968bf6c9016f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f21f137b-cd9e-439b-b9d1-57e03093d453"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f2d78a6d-ee7c-4cd8-9fbf-21cd7f9c9472"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f3281f97-5537-47a0-8ebc-556d329e68c1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f3857fec-f6f9-4518-9781-e1263df0ac32"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f45c40b8-14fd-45d9-a96b-3dafb3a15a8d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f46f085f-cf66-48da-920d-2ee5fa46e097"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f494eb21-fcd3-4b1b-a0fe-800186515e06"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f4a6b90d-d07d-4574-8376-d5f92e520a9e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f4ab3906-93e3-4c98-8bcf-cabbe46cd29f"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f4afa2f6-c244-4659-a153-41cf57d486fb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f4e8885b-92d7-42b2-85f4-dd2d4930a890"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f4fc9325-54a0-4aa1-8bb1-573015f0b81c"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f51e5979-866b-46ff-81e1-36131e2a87e4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f5412991-00c8-42ea-85d8-2a4ed26f5a8e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f545b357-408e-4633-97a7-ceaab73d9571"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f557e748-af6a-45c3-a057-38a7f632671e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f58aaff5-6a00-4782-9382-6052db23ee38"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f6819bee-f3b6-47b8-8a85-64a220d3850d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f6b57a27-ea65-45ff-a28f-2de20de6cf59"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f6ee7070-7952-4e05-bacb-e8d5e1c908b5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f70ac607-7388-4641-9c74-863a36e1d5d1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f75ce725-f9c0-4781-b50b-9e6a6226a3ba"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f77fee06-3c29-4699-8693-62ecfd1578cc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f7b28681-b09a-4eae-b4b0-c29f7c6bc303"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f7bf508d-b209-42ac-942d-5bee299f25b5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f81e2a61-625f-4729-97aa-8b94d5327fc9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f8979c20-a38d-44ce-986c-f4a3d6018880"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f8b058ed-3d52-4d47-8f39-689cd5cf0c6b"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f90dfa0c-feaf-4d11-8a30-8b44977344fb"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("f94f3011-19aa-44f3-886b-621fa3a57033"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fa05027a-d545-4d13-b81a-43050d5a118d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fa5d4ecc-b13e-4b04-87ff-f23a2a33feaa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fa74efff-fc8d-4dee-9db9-e3cf9fd12c44"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fa7c7e98-20e1-4008-9cc1-e54cc6dbd4b4"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("faedfb20-7a7c-4452-97d3-331bb2f82601"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fafa8cd0-ba7e-431f-854d-e64f795c5db5"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fb55b0b0-fcc3-4b19-843e-d161b4ed45fc"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fbb4e2fe-4d80-4cf9-bc00-dba30d03d1ec"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fbc1d291-1777-4ab3-b7f0-8f45dc212018"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fbeef6bd-41f3-4a1c-b40b-a687d1de6dd1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fc49beaa-e65d-4ffd-9f96-079dd4587244"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fc910c3f-db71-4fb7-b956-fd545cf5e2a8"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fca1e0f6-26ba-42b2-bd1d-4239927cf617"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fcfab158-2d1b-4603-800c-a74bdcf2e7e2"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd0490e6-5f50-45a5-8c00-cab750691267"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd16a9df-3ae7-48af-bf50-e4443559ff82"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd196e7a-1ddd-443e-b254-4b67c6050ce7"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd1f0a11-8daa-4517-aaf0-03de7ff097fa"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd4bfc4c-85ed-46ef-9852-c04c09298930"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd519c78-59d0-4f38-932e-c07b49269a2e"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd64cd26-3995-45c2-acb5-d71a3c3b7720"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd69e1b4-ba98-47b6-89f9-701984ded536"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fd6eb1e8-331f-4d68-bb2f-daa5386fa0d1"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fdb5a152-5525-4dc4-bfc1-95c0e7311503"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fde38475-074d-4f74-a8c0-026ae99bd78a"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fde86d68-9e9b-4472-bfe8-8d01cb5e98f9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fe06f331-53be-4158-bcda-a8a7591f8025"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fe444d64-be3b-41fe-8619-899f0793d8ad"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fe7c2313-3d2c-4a5d-936b-b83f72486222"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fea2e0bf-7619-447f-9fb9-11bab3c2509d"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fead7e5e-8b34-4781-9805-7bab95b76696"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fec3f7e8-69ac-454f-aff5-8e618d729554"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("fed5c1d3-c84e-49f4-85ae-a668bb9424f9"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ff6d4299-634f-4f3c-bcbf-4b3b09cac750"));

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: new Guid("ff77b73a-a84e-4c25-866f-2d7c5aa7cc3f"));

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
    }
}
