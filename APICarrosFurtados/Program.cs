// dotnet ef database drop -f
// dotnet ef database update
// dotnet ef migrations add CriarTabelaVeiculos
// dotnet run

using ApiCadastrarVeiculo.Data;
using ApiCadastrarVeiculo.Rotas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<VeiculoContext>(opt =>
    opt.UseSqlite("Data Source=veiculos.db"));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/veiculos", () =>
    Results.Redirect("/index.html"));
app.MapGetRoutes();
app.MapPostRoutes();
app.MapDeleteRoutes(); 
app.MapPutRoutes();

app.Run();
