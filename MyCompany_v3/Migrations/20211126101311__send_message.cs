using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany_v3.Migrations
{
    public partial class _send_message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "289cafc2-6345-4640-8a82-37b1fc1cd46a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "4092b425-75ea-41d2-bc71-6dfd5e8d4a07");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2418c4b8-0c48-4f36-a565-20790efba176", "AQAAAAEAACcQAAAAEGRIC2ctSeQ3N5gBELJWzM1w6AFpvRQsPgv44X3VTPY9C9RXnRGvjrFTf3sl3JE3wQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf4fd1ff-eec1-48fe-b951-21b31021bbe7", "AQAAAAEAACcQAAAAEEGm2tayOpSn62btJJXAif5HIev1I3bUn39u+uFL0xDGxC7px5btKyTqixnoHjLpVw==" });

            migrationBuilder.InsertData(
                table: "MessageItems",
                columns: new[] { "Id", "CreationDate", "Text", "Title", "UserId" },
                values: new object[] { new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"), new DateTime(2021, 11, 26, 10, 13, 10, 212, DateTimeKind.Utc).AddTicks(5390), "Text Text Text Text", "Tiiitle", "48a58e3e-7de3-40d3-9d74-97927cbd2c36" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 10, 13, 10, 212, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 10, 13, 10, 212, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 10, 13, 10, 212, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 10, 13, 10, 211, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.CreateIndex(
                name: "IX_MessageItems_UserId",
                table: "MessageItems",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageItems");

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

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 20, 15, 31, 516, DateTimeKind.Utc).AddTicks(4224));

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
    }
}
