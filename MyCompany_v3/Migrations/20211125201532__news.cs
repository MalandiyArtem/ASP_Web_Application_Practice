using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany_v3.Migrations
{
    public partial class _news : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    CodeWord = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "a778be85-dcb7-4977-b0f0-280ada122e76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "c398a54c-c6b6-4559-96a2-9641d1b8b054");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a8c4d63-e94a-4d3b-92e5-ac23054136c0", "AQAAAAEAACcQAAAAEL2bCVINVGKbPKnG2xI9Oy110UTadSVRZCgfTX+zlJNvOujm31j4BXUrh2LDwjHzpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b5179c8-90b7-4317-a51a-45666bf719c6", "AQAAAAEAACcQAAAAEBWA9KU5Aouwk4qhgLYtkuqQWz6iULox2hpJC2Ks0PZqina8YN+qR1HlbD83iRf3Ow==" });

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"), "PageNews", new DateTime(2021, 11, 25, 20, 15, 31, 516, DateTimeKind.Utc).AddTicks(4224), null, null, null, null, "Join us, we are here!", "We opened", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 15, 31, 516, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 15, 31, 516, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 15, 31, 516, DateTimeKind.Utc).AddTicks(1047));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "31897c19-a0a6-4c29-9e3a-27a458e10ab4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "7819fa32-95d8-4e31-8941-60122dca763a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c7cb318-fb5e-4936-b06b-fd7f75b3e285", "AQAAAAEAACcQAAAAEJXpEGJZGe/fPArSaqhyjGmU9Yh/aIp7o0pJIwf4M6fAJzcZ5+7dkPyy+b7N2OJgyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e0c7b88-d5b2-431d-93b9-bdc32a9e2c2c", "AQAAAAEAACcQAAAAEDCwcZXoEp3W2DeY7YTXC9rtoPk8zgcroMBjrctxOiLd6AXvtv1nh9QZOBwcf1I7Kg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 8, 32, 780, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 8, 32, 780, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 8, 32, 780, DateTimeKind.Utc).AddTicks(6475));
        }
    }
}
