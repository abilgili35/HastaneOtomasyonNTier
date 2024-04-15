using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnalysisResults",
                columns: new[] { "ID", "AnalysisDate", "CreatedDate", "FileLink", "IsActive", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(6735), "Link1", true, 2 },
                    { 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(6773), "Link2", true, 1 },
                    { 3, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(6777), "Link3", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "ID", "CreatedDate", "DegreeDate", "FirstName", "IsActive", "LastName", "Profession" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 15, 15, 22, 6, 750, DateTimeKind.Local).AddTicks(5644), new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmet", true, "Yilmaz", "Dahiliye" },
                    { 2, new DateTime(2024, 4, 15, 15, 22, 6, 750, DateTimeKind.Local).AddTicks(5702), new DateTime(1967, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enver", true, "Akturk", "Cerrahi" },
                    { 3, new DateTime(2024, 4, 15, 15, 22, 6, 750, DateTimeKind.Local).AddTicks(5706), new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rukiye", true, "Bilgili", "Kulak Burun Bogaz" },
                    { 4, new DateTime(2024, 4, 15, 15, 22, 6, 750, DateTimeKind.Local).AddTicks(5710), new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ufuk", true, "Gunalp", "Goz" }
                });

            migrationBuilder.UpdateData(
                table: "PatientInfos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 749, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "PatientInfos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 749, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "PatientInfos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 749, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 741, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 743, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 743, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 22, 6, 743, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Amount", "CreatedDate", "IsActive", "PatientId", "PaymentDate" },
                values: new object[,]
                {
                    { 1, 2000.50m, new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(8), true, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4000m, new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(44), true, 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 6000.70m, new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(49), true, 1, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 8500.50m, new DateTime(2024, 4, 15, 15, 22, 6, 765, DateTimeKind.Local).AddTicks(52), true, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "DoctorId", "PatientId", "AppointmentDate", "CreatedDate", "IsActive" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 15, 22, 6, 762, DateTimeKind.Local).AddTicks(6688), true },
                    { 2, 1, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 15, 22, 6, 762, DateTimeKind.Local).AddTicks(6722), true },
                    { 3, 3, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 15, 22, 6, 762, DateTimeKind.Local).AddTicks(6726), true }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "BuildingNumber", "CreatedDate", "FloorNumber", "IsActive", "RoomNumber" },
                values: new object[,]
                {
                    { 1, 11, new DateTime(2024, 4, 15, 15, 22, 6, 771, DateTimeKind.Local).AddTicks(1683), 2, true, 101 },
                    { 2, 21, new DateTime(2024, 4, 15, 15, 22, 6, 771, DateTimeKind.Local).AddTicks(1712), 3, true, 203 },
                    { 4, 31, new DateTime(2024, 4, 15, 15, 22, 6, 771, DateTimeKind.Local).AddTicks(1716), 1, true, 207 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnalysisResults",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnalysisResults",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnalysisResults",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "PatientInfos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 638, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "PatientInfos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 638, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "PatientInfos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 638, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 622, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 632, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 632, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 45, 632, DateTimeKind.Local).AddTicks(5209));
        }
    }
}
