using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany_v3.Migrations
{
    public partial class _review_feedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageItems_AspNetUsers_UserId",
                table: "MessageItems");

            migrationBuilder.DropIndex(
                name: "IX_MessageItems_UserId",
                table: "MessageItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "MessageItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeedback",
                table: "MessageItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "cd05e386-962a-43b7-8d4e-db776b290af6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "2f83b5d0-eaf9-45b4-b8ef-9867c916fc5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ea2921e-93e7-4593-9810-6ec5d029bacf", "AQAAAAEAACcQAAAAEHn0TZTKCw78MmpvLtIkK30tX8lD8QDaUyr0TRwCmKRyPtQcoyXsAAVEc13RdZrBAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7c7dc43-c2a4-4ac1-b58a-6410244b4b95", "AQAAAAEAACcQAAAAEHs0LkFSvAWJKJMgyepDVoz1YhMvahxj3u0BzswDlT/yIxQJ/7Z1N4XWHg3xEz/Vyw==" });

            migrationBuilder.UpdateData(
                table: "MessageItems",
                keyColumn: "Id",
                keyValue: new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 26, 19, 42, 53, 422, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.InsertData(
                table: "MessageItems",
                columns: new[] { "Id", "CreationDate", "IsFeedback", "Text", "Title", "UserId" },
                values: new object[] { new Guid("d938d3a3-cd89-469b-a5b9-d83671f22c20"), new DateTime(2021, 11, 26, 19, 42, 53, 423, DateTimeKind.Utc).AddTicks(7854), true, "Your news is amazing", "Feedback for your news", "48a58e3e-7de3-40d3-9d74-97927cbd2c36" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 19, 42, 53, 422, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "ReviewItems",
                keyColumn: "Id",
                keyValue: new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 19, 42, 53, 423, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 19, 42, 53, 422, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 19, 42, 53, 422, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 11, 26, 19, 42, 53, 421, DateTimeKind.Utc).AddTicks(9958));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MessageItems",
                keyColumn: "Id",
                keyValue: new Guid("d938d3a3-cd89-469b-a5b9-d83671f22c20"));

            migrationBuilder.DropColumn(
                name: "IsFeedback",
                table: "MessageItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "MessageItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_MessageItems_UserId",
                table: "MessageItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageItems_AspNetUsers_UserId",
                table: "MessageItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
