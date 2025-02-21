using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_headings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Heading_HeadingID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Heading_Categories_CategoryID",
                table: "Heading");

            migrationBuilder.DropForeignKey(
                name: "FK_Heading_Writers_WriterID",
                table: "Heading");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Heading",
                table: "Heading");

            migrationBuilder.RenameTable(
                name: "Heading",
                newName: "Headings");

            migrationBuilder.RenameIndex(
                name: "IX_Heading_WriterID",
                table: "Headings",
                newName: "IX_Headings_WriterID");

            migrationBuilder.RenameIndex(
                name: "IX_Heading_CategoryID",
                table: "Headings",
                newName: "IX_Headings_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Headings",
                table: "Headings",
                column: "HeadingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Headings_HeadingID",
                table: "Contents",
                column: "HeadingID",
                principalTable: "Headings",
                principalColumn: "HeadingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Categories_CategoryID",
                table: "Headings",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterID",
                table: "Headings",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Headings_HeadingID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Categories_CategoryID",
                table: "Headings");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterID",
                table: "Headings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Headings",
                table: "Headings");

            migrationBuilder.RenameTable(
                name: "Headings",
                newName: "Heading");

            migrationBuilder.RenameIndex(
                name: "IX_Headings_WriterID",
                table: "Heading",
                newName: "IX_Heading_WriterID");

            migrationBuilder.RenameIndex(
                name: "IX_Headings_CategoryID",
                table: "Heading",
                newName: "IX_Heading_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Heading",
                table: "Heading",
                column: "HeadingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Heading_HeadingID",
                table: "Contents",
                column: "HeadingID",
                principalTable: "Heading",
                principalColumn: "HeadingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Heading_Categories_CategoryID",
                table: "Heading",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Heading_Writers_WriterID",
                table: "Heading",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID");
        }
    }
}
