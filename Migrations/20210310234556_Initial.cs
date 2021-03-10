using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_8_Joisah_Sarles.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    authorFirst = table.Column<string>(type: "TEXT", nullable: false),
                    authorMiddle = table.Column<string>(type: "TEXT", nullable: true),
                    authorLast = table.Column<string>(type: "TEXT", nullable: false),
                    publisher = table.Column<string>(type: "TEXT", nullable: false),
                    isbn = table.Column<string>(type: "TEXT", nullable: false),
                    classification = table.Column<string>(type: "TEXT", nullable: false),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                    pages = table.Column<int>(type: "INTEGER", nullable: false),
                    price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.bookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
