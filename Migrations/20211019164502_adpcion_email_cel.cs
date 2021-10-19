using Microsoft.EntityFrameworkCore.Migrations;

namespace S3_Repaso_Formulario.Migrations
{
    public partial class adpcion_email_cel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "SolicitudesAdopcion",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "SolicitudesAdopcion",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "SolicitudesAdopcion");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "SolicitudesAdopcion");
        }
    }
}
