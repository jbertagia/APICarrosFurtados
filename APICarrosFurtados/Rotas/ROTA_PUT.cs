using ApiCadastrarVeiculo.Data;
using ApiCadastrarVeiculo.Models;

namespace ApiCadastrarVeiculo.Rotas
{
    public static class ROTA_PUT
    {
        public static void MapPutRoutes(this WebApplication app)
        {
            app.MapPut("/api/veiculos/{id}", async (int id, Veiculo dadosAtualizados, VeiculoContext db) =>
            {
                var veiculo = await db.Veiculos.FindAsync(id);
                if (veiculo == null) return Results.NotFound();

                veiculo.Modelo = dadosAtualizados.Modelo;
                veiculo.Marca = dadosAtualizados.Marca;
                veiculo.Cor = dadosAtualizados.Cor;
                veiculo.Placa = dadosAtualizados.Placa;
                veiculo.Chassis = dadosAtualizados.Chassis;
                veiculo.Valor = dadosAtualizados.Valor;
                veiculo.DiasRoubado = dadosAtualizados.DiasRoubado;
                veiculo.Status = dadosAtualizados.Status;

                await db.SaveChangesAsync();
                return Results.Ok(veiculo);
            });
        }
    }
}
