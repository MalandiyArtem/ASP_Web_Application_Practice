using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany_v3.Migrations
{
    public partial class _divide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "31897c19-a0a6-4c29-9e3a-27a458e10ab4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ca94fb5-67e7-4e5b-a814-7212f19d2530", "7819fa32-95d8-4e31-8941-60122dca763a", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e0c7b88-d5b2-431d-93b9-bdc32a9e2c2c", "AQAAAAEAACcQAAAAEDCwcZXoEp3W2DeY7YTXC9rtoPk8zgcroMBjrctxOiLd6AXvtv1nh9QZOBwcf1I7Kg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "48a58e3e-7de3-40d3-9d74-97927cbd2c36", 0, "7c7cb318-fb5e-4936-b06b-fd7f75b3e285", "user1@gmail.com", true, false, null, "USER1@GMAIL.COM", "USER1", "AQAAAAEAACcQAAAAEJXpEGJZGe/fPArSaqhyjGmU9Yh/aIp7o0pJIwf4M6fAJzcZ5+7dkPyy+b7N2OJgyg==", null, false, "", false, "user1" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7ff2d40a-5884-4d27-ba2d-9854b0d29581", "4ca94fb5-67e7-4e5b-a814-7212f19d2530" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "48a58e3e-7de3-40d3-9d74-97927cbd2c36", "4ca94fb5-67e7-4e5b-a814-7212f19d2530" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48a58e3e-7de3-40d3-9d74-97927cbd2c36", "4ca94fb5-67e7-4e5b-a814-7212f19d2530" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7ff2d40a-5884-4d27-ba2d-9854b0d29581", "4ca94fb5-67e7-4e5b-a814-7212f19d2530" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "ee3d63c5-20b5-4c94-b7a6-360b5a889467");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a0536c1-40db-4a57-bdb8-efd390bac65b", "AQAAAAEAACcQAAAAEG4OQkIKp7IWQg8NYge0ZaaIxva6Xj2ZQEyvy5kzFXlUHrWKchjzZS4DsojVoTaZfA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 19, 51, 52, 371, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 19, 51, 52, 371, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 25, 19, 51, 52, 371, DateTimeKind.Utc).AddTicks(3533));
        }
    }
}
