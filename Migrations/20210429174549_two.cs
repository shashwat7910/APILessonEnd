using Microsoft.EntityFrameworkCore.Migrations;

namespace APILessonEnd.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marksinphysics = table.Column<int>(type: "int", nullable: false),
                    marksinchem = table.Column<int>(type: "int", nullable: false),
                    marksineng = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
