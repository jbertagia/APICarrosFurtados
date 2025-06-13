using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiCadastrarVeiculo.Migrations
{
    /// <inheritdoc />
    public partial class SeedMaisVeiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Chassis", "Cor", "Marca", "Modelo", "Placa", "Status" },
                values: new object[,]
                {
                    { 11, "CHS011", "Prata", "Ford", "EcoSport", "EFG1122", "Roubado" },
                    { 12, "CHS012", "Cinza", "Fiat", "Toro", "HIJ3344", "Recuperado" },
                    { 13, "CHS013", "Vermelho", "Fiat", "Strada", "KLM5566", "Roubado" },
                    { 14, "CHS014", "Azul", "Chevrolet", "Celta", "NOP7788", "Recuperado" },
                    { 15, "CHS015", "Amarelo", "Volkswagen", "Fusca", "QRS9900", "Roubado" },
                    { 16, "CHS016", "Branco", "Renault", "Logan", "TUV1133", "Recuperado" },
                    { 17, "CHS017", "Preto", "Renault", "Duster", "WXY4455", "Roubado" },
                    { 18, "CHS018", "Cinza", "Toyota", "Etios", "ZAB6677", "Recuperado" },
                    { 19, "CHS019", "Prata", "Nissan", "March", "CDE8899", "Roubado" },
                    { 20, "CHS020", "Azul", "Nissan", "Versa", "FGH0001", "Recuperado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Chassis", "Cor", "Marca", "Modelo", "Placa", "Status" },
                values: new object[] { 10, "CHS010", "Verde", "Fiat", "Uno", "BCD7890", "Recuperado" });
        }
    }
}
