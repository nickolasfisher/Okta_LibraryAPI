using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CheckoutDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CheckinDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkout_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "J. R. R. Tolkien", "The Fellowship of the Ring, the first volume in the trilogy, tells of the fateful power of the One Ring. It begins a magnificent tale of adventure that will plunge the members of the Fellowship of the Ring into a perilous quest and set the stage for the ultimate clash between the powers of good and evil.", "The Fellowship of the Ring" },
                    { 2, "J. R. R. Tolkien", "The Fellowship has been forced to split up. Frodo and Sam must continue alone towards Mount Doom, where the One Ring must be destroyed. Meanwhile, at Helm’s Deep and Isengard, the first great battles of the War of the Ring take shape.", "The Two Towers" },
                    { 3, "J. R. R. Tolkien", "The Return of the King is the towering climax to J. R. R. Tolkien’s trilogy that tells the saga of the hobbits of Middle-earth and the great War of the Rings. In this concluding volume, Frodo and Sam make a terrible journey to the heart of the Land of the Shadow in a final reckoning with the power of Sauron.", "The Return of the King" },
                    { 4, "J. R. R. Tolkien", "Like every other hobbit, Bilbo Baggins likes nothing better than a quiet evening in his snug hole in the ground, dining on a sumptuous dinner in front of a fire. But when a wandering wizard captivates him with tales of the unknown, Bilbo becomes restless. Soon he joins the wizard’s band of homeless dwarves in search of giant spiders, savage wolves, and other dangers. Bilbo quickly tires of the quest for adventure and longs for the security of his familiar home. But before he can return to his life of comfort, he must face the greatest threat of all - a treasure-troving dragon named Smaug.", "The Hobbit" },
                    { 5, "Philip K Dick", "It's America in 1962. Slavery is legal once again. The few Jews who still survive hide under assumed names. In San Francisco, the I Ching is as common as the Yellow Pages. All because some twenty years earlier the United States lost a war - and is now occupied by Nazi Germany and Japan.", "The Man In The High Castle" },
                    { 6, "Jim Butcher", "With rent past due and a decent meal becoming an issue of some importance, Harry needs work, and soon. A call from a distraught wife, and another from Lt. Murphy of the Chicago PD Special Investigation Unit makes Harry believe things are looking up, but they are about to get worse, much worse. Someone is harnessing immense supernatural forces to commit a series of grisly murders. Someone has violated the first law of magic: Thou Shalt Not Kill. Tracking that someone takes Harry into the dangerous underbelly of Chicago, from mobsters to vampires, while he himself is under suspicion of the crimes.", "Storm Front" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_BookId",
                table: "Checkout",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_UserId",
                table: "Checkout",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
