using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageSender_MVC.Migrations
{
    public partial class CreateMessageSenderSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MobileContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoblieNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoblieMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(nullable: true),
                    MobileContactId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoblieMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoblieMessages_MobileContacts_MobileContactId",
                        column: x => x.MobileContactId,
                        principalTable: "MobileContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoblieMessages_MobileContactId",
                table: "MoblieMessages",
                column: "MobileContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoblieMessages");

            migrationBuilder.DropTable(
                name: "MobileContacts");
        }
    }
}
