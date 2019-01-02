using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalizeWord.API.Migrations
{
    public partial class AddEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    ListKey = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    UserName = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    ListId = table.Column<int>(nullable: false),
                    ItemKey = table.Column<string>(nullable: false),
                    Oridinal = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListItems_Lists_ListId",
                        column: x => x.ListId,
                        principalTable: "Lists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListItemCaptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    ListItemId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: false),
                    Caption = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItemCaptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListItemCaptions_ListItems_ListItemId",
                        column: x => x.ListItemId,
                        principalTable: "ListItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    LoanWordId = table.Column<int>(nullable: true),
                    Context = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_ListItems_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ListItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Words_ListItems_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "ListItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Words_Words_LoanWordId",
                        column: x => x.LoanWordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListItemCaptions_ListItemId",
                table: "ListItemCaptions",
                column: "ListItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ListItems_ListId",
                table: "ListItems",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_CategoryId",
                table: "Words",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_LanguageId",
                table: "Words",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_LoanWordId",
                table: "Words",
                column: "LoanWordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListItemCaptions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "ListItems");

            migrationBuilder.DropTable(
                name: "Lists");
        }
    }
}
