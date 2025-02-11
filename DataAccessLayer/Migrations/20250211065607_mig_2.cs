using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Heading_HeadingID",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "WriterID",
                table: "Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Heading_HeadingID",
                table: "Contents",
                column: "HeadingID",
                principalTable: "Heading",
                principalColumn: "HeadingID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Heading_HeadingID",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "WriterID",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Heading_HeadingID",
                table: "Contents",
                column: "HeadingID",
                principalTable: "Heading",
                principalColumn: "HeadingID");
        }
    }
}
