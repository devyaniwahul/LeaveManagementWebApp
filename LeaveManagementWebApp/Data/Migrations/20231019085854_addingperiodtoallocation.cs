using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingperiodtoallocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d98860-25fe-4d9f-8dce-c1ea33df91ee", "AQAAAAIAAYagAAAAEAq0g6nQY2x47WvPVi1IfGc9feP7KzPaYLTMt+OuOTB0ihg2GZ1umeboI2OpmJpNPQ==", "1ab465c5-2f2b-4386-8040-c420451d5ad2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6a9fd2-77e8-41d4-94a5-2f3a9eba5715", "AQAAAAIAAYagAAAAEAdBJsPDPM2ZyUC7skT2ffj/zJ+1bnF1F4vkdX0cXD72xABJeKOZ2MIryG7vOBxerA==", "dc17fc35-5403-4a43-9ad5-076a132d4899" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2e86fea-92ac-4591-b0d6-fd4e8714df8c", "AQAAAAIAAYagAAAAECphr8RITSkH2T0DTJJO6uALsNbvgjrQGbBGfW/AxCBBGx4fkpen6SiDFvMIyPcRrw==", "23b2d512-9146-4eb1-9a97-58018d2bec04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db77bbbf-aa3b-417c-b1d9-24276766c8ba", "AQAAAAIAAYagAAAAELfQgOOGL7OVHrABMV+hp/hpd5bJiLLZGaU/jgYB6DOGV+px6SEXFuhy4/NvehXORw==", "41674eca-0dda-43a5-ae84-bd96fbaba03b" });
        }
    }
}
