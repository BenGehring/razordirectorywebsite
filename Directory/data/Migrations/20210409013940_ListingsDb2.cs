using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class ListingsDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BusinessTypeId",
                table: "Businesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Businesses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Businesses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BusinessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_BusinessTypeId",
                table: "Businesses",
                column: "BusinessTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_BusinessTypes_BusinessTypeId",
                table: "Businesses",
                column: "BusinessTypeId",
                principalTable: "BusinessTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_BusinessTypes_BusinessTypeId",
                table: "Businesses");

            migrationBuilder.DropTable(
                name: "BusinessTypes");

            migrationBuilder.DropIndex(
                name: "IX_Businesses_BusinessTypeId",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "BusinessTypeId",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Businesses");
        }
    }
}
