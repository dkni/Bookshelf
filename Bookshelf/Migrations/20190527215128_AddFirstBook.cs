using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf.Migrations
{
    public partial class AddFirstBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Isbn", "Description", "Title" },
                values: new object[] { "978-0684801223", "The Old Man and the Sea is one of Hemingway's most enduring works. Told in language of great simplicity and power, it is the story of an old Cuban fisherman, down on his luck, and his supreme ordeal -- a relentless, agonizing battle with a giant marlin far out in the Gulf Stream. Here Hemingway recasts, in strikingly contemporary style, the classic theme of courage in the face of defeat, of personal triumph won from loss.Written in 1952, this hugely successful novella confirmed his power and presence in the literary world and played a large part in his winning the 1954 Nobel Prize for Literature.", "The Old Man and the Sea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Isbn",
                keyValue: "978-0684801223");
        }
    }
}
