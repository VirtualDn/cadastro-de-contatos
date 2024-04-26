using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastro_de_contatos.Migrations
{
    /// <inheritdoc />
    public partial class alteretNameAttribut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contact",
                table: "contact");

            migrationBuilder.RenameTable(
                name: "contact",
                newName: "Contact");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Contact",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "contact");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "contact",
                newName: "Nome");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contact",
                table: "contact",
                column: "Id");
        }
    }
}
