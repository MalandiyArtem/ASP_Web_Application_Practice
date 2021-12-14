using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany_v3.Migrations
{
    public partial class _change_answer_to_review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "69a70022-1aaa-4c6d-bda7-4b287dbddc92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "af1206e6-0325-4ebf-9270-7f84807c3211");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b63a971c-c60b-45b3-a7bf-6bed31699ec6", "AQAAAAEAACcQAAAAEMl4SXtwQUnso8sf5sCjQCuBCQRrS1lRh9GE6IexE6SRJ2dsWn6PbAQjT3Nn/MAKFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da5f5cda-75e2-4799-b74d-275fa0952740", "AQAAAAEAACcQAAAAEBZgG88gPwLT+U+NL6wOR+qomVvEvnH50XAqrWj4YB9ppF+jXcaYk69CfXcyNFIQ/Q==" });

            migrationBuilder.UpdateData(
                table: "FeedbackItems",
                keyColumn: "Id",
                keyValue: new Guid("ebb21448-243e-49fb-8fc4-c711b15a6dca"),
                column: "CreationDate",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 756, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "MessageItems",
                keyColumn: "Id",
                keyValue: new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"),
                column: "CreationDate",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 755, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 754, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "ReviewItems",
                keyColumn: "Id",
                keyValue: new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 756, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 752, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 752, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 16, 20, 5, 752, DateTimeKind.Utc).AddTicks(6017));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391403d9-ba6d-4213-bebe-ad44d7994199",
                column: "ConcurrencyStamp",
                value: "6f65cfdf-f494-4cea-9b62-aae5d5896711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                column: "ConcurrencyStamp",
                value: "98c14ebc-3979-40f7-b94c-d5df79cdba23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d158ef3-1943-4ddd-be83-cb9bf779beff", "AQAAAAEAACcQAAAAECUPJu46WovpTBkvZ4RRxf7z0kadg7mocoxdDQOMzzsJ07pL+/h/hiRtax99gwe8bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95cb1b33-d8fe-440c-84d0-ee89bf12c8b6", "AQAAAAEAACcQAAAAEOTxErNVoEvS9Zf9SQNvZYkV5FRkj1vDAOIgkrr0oHzPEurDlD+tfLQxwah/RNY8Mg==" });

            migrationBuilder.UpdateData(
                table: "FeedbackItems",
                keyColumn: "Id",
                keyValue: new Guid("ebb21448-243e-49fb-8fc4-c711b15a6dca"),
                column: "CreationDate",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 109, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "MessageItems",
                keyColumn: "Id",
                keyValue: new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"),
                column: "CreationDate",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 108, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 107, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "ReviewItems",
                keyColumn: "Id",
                keyValue: new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 108, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 107, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 107, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 14, 14, 45, 36, 107, DateTimeKind.Utc).AddTicks(4700));
        }
    }
}
