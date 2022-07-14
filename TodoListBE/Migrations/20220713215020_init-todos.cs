using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListBE.Migrations
{
    public partial class inittodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Nhiệm vụ 1" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Nhiệm vụ 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
