using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorBooks.Web.Migrations
{
    /// <inheritdoc />
    public partial class RenameDisplayOrderToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Categories",
                newName: "Order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Categories",
                newName: "DisplayOrder");
        }
    }
}
