using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnimalDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnimalType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaleFemale = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnimalAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalAge", "AnimalDescription", "AnimalName", "AnimalType", "MaleFemale" },
                values: new object[,]
                {
                    { 1, 3, "They were found dumpster diving.", "Trash", "Dog", "Female" },
                    { 2, 5, "Likes to do your taxes.", "Nerd", "Dog", "Male" },
                    { 3, 20, "They are the Illuminati. Don't cross them or you'll be swimming with the fishes.", "Illuminati", "Dog", "Unknown" },
                    { 4, 18, "Big Gwyneth Paltrow fan.", "Womb", "Dog", "Female" },
                    { 5, 2, "While he may be new to the fashion scene, he's known what he's wanted to do his whole life. Style you in the best outfits he can.", "Jimmy Chew", "Dog", "Male" },
                    { 6, 5, "They think their a lot tougher than they are. Spicy outside, soft inside", "Wasabi", "Cat", "Male" },
                    { 7, 1, "Was seen fraternizing with racoons. Bullied by other cats now.", "Racoon", "Cat", "Male" },
                    { 8, 314, "Can rattle off over 300 variables from the Pi sequence and very proud of it.", "Pi", "Cat", "Female" },
                    { 9, 6, "Hacked into the CIA. We can't talk about it.", "Linux", "Cat", "Female" },
                    { 10, 1, "They are a tuxedo cat and believes that makes them better than everyone else, since they are always best dressed.", "Richard", "Cat", "Male" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
