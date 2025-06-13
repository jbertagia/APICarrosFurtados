using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCadastrarVeiculo.Migrations
{
    /// <inheritdoc />
    public partial class AddValorEDiasRoubado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiasRoubado",
                table: "Veiculos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 15, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 5, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 12, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 7, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 8, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 6, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 4, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 6, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 10, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 2, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 92, 50000m });

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DiasRoubado", "Valor" },
                values: new object[] { 0, 90000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasRoubado",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Veiculos");
        }
    }
}
