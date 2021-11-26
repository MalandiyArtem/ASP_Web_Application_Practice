using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany_v3.Migrations
{
    public partial class _review_news_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "42654a35-ab13-4ada-9b3e-d227bf31c703");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "a5c3c1a3-9a2e-42a4-9c18-0c76efb34b9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b121ddbb-0221-4534-8e70-83e0d3367f09", "AQAAAAEAACcQAAAAEJ5No6Xu6y0Ru2C1J0tb76DqX4tyCQSgXmVxq6jUmQGA3eBplp2m8/IIoBPprdB71Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6f1e105-4d2a-433e-a39a-9474fce16e0e", "AQAAAAEAACcQAAAAEJcgG2r5lo1FSltfZNWilJXEEbkJQuF3b7Padh0vmbcWi8UMXlC7JPPLZmUArzRHxQ==" });

            migrationBuilder.UpdateData(
                table: "MessageItems",
                keyColumn: "Id",
                keyValue: new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 26, 17, 42, 39, 51, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 42, 39, 50, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "ReviewItems",
                keyColumn: "Id",
                keyValue: new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 42, 39, 51, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 42, 39, 50, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 42, 39, 50, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 42, 39, 50, DateTimeKind.Utc).AddTicks(4247));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "628ce1c8-1a63-42ac-91e1-6590bc5892e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "bf8060ba-fd99-439a-ab20-88f92a870b6b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb935a0a-e04f-42b3-a986-4f76cf7a1402", "AQAAAAEAACcQAAAAEB/TZCp5YYDcKYPDETVOVGSMaNuhIy0iQ77P3ojX1PwnOz2KpqxMJ3dqEOXUYI6zIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a258d5ef-3ef9-4ea9-81cc-902f3e63083f", "AQAAAAEAACcQAAAAEAMgzn82+AkGR+xSiVBnaL3q2c41HfXQur6+6t1cxjZHabUfVOgmssQ5iqQOIpMzCw==" });

            migrationBuilder.UpdateData(
                table: "MessageItems",
                keyColumn: "Id",
                keyValue: new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 26, 17, 41, 41, 492, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 41, 41, 492, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ReviewItems",
                keyColumn: "Id",
                keyValue: new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 41, 41, 493, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 41, 41, 491, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 41, 41, 491, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 17, 41, 41, 491, DateTimeKind.Utc).AddTicks(6194));
        }
    }
}
