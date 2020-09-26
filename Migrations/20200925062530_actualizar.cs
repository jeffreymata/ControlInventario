using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiInventario.Migrations
{
    public partial class actualizar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ Details_ Equipments_idEquipo",
                schema: "dbo",
                table: " Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ Equipments",
                schema: "dbo",
                table: " Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ Details",
                schema: "dbo",
                table: " Details");

            migrationBuilder.DropIndex(
                name: "IX_ Details_idEquipo",
                schema: "dbo",
                table: " Details");

            migrationBuilder.RenameTable(
                name: " Equipments",
                schema: "dbo",
                newName: "Equipments");

            migrationBuilder.RenameTable(
                name: " Details",
                schema: "dbo",
                newName: "Details");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Equipments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentsId",
                table: "Details",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Details_EquipmentsId",
                table: "Details",
                column: "EquipmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Equipments_EquipmentsId",
                table: "Details",
                column: "EquipmentsId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Equipments_EquipmentsId",
                table: "Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropIndex(
                name: "IX_Details_EquipmentsId",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "EquipmentsId",
                table: "Details");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: " Equipments",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: " Details",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                schema: "dbo",
                table: " Equipments",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ Equipments",
                schema: "dbo",
                table: " Equipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ Details",
                schema: "dbo",
                table: " Details",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ Details_idEquipo",
                schema: "dbo",
                table: " Details",
                column: "idEquipo");

            migrationBuilder.AddForeignKey(
                name: "FK_ Details_ Equipments_idEquipo",
                schema: "dbo",
                table: " Details",
                column: "idEquipo",
                principalSchema: "dbo",
                principalTable: " Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
