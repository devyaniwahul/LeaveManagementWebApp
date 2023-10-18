using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e", null, "User", "USER" },
                    { "ca57afe6-4182-4d62-8d86-f9f0a9eebe6e", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e", 0, "f2e86fea-92ac-4591-b0d6-fd4e8714df8c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECphr8RITSkH2T0DTJJO6uALsNbvgjrQGbBGfW/AxCBBGx4fkpen6SiDFvMIyPcRrw==", null, false, "23b2d512-9146-4eb1-9a97-58018d2bec04", null, false, "Admin@localhost.com" },
                    { "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e", 0, "db77bbbf-aa3b-417c-b1d9-24276766c8ba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAELfQgOOGL7OVHrABMV+hp/hpd5bJiLLZGaU/jgYB6DOGV+px6SEXFuhy4/NvehXORw==", null, false, "41674eca-0dda-43a5-ae84-bd96fbaba03b", null, false, "User@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ca57afe6-4182-4d62-8d86-f9f0a9eebe6e", "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e" },
                    { "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e", "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca57afe6-4182-4d62-8d86-f9f0a9eebe6e", "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e", "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca57afe6-4182-4d62-8d86-f9f0a9eebe6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e");
        }
    }
}
