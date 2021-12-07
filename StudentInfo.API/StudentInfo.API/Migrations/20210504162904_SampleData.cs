using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentInfo.API.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "City", "First_Name", "Last_Name", "Phone" },
                values: new object[] { 1, "Pune", "Parth", "Darekar", 9876543210L });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "City", "First_Name", "Last_Name", "Phone" },
                values: new object[] { 2, "Satara", "Nupur", "Darekar", 76543234567L });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "City", "First_Name", "Last_Name", "Phone" },
                values: new object[] { 3, "Kolhapur", "Nachiket", "Joshi", 1234567890L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
