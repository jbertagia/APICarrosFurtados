using Microsoft.EntityFrameworkCore;
using ApiCadastrarVeiculo.Models;

namespace ApiCadastrarVeiculo.Data
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().HasKey(v => v.Id);

            modelBuilder.Entity<Veiculo>().HasData(
                new Veiculo { Id = 1, Modelo = "Onix", Marca = "Chevrolet", Cor = "Prata", Placa = "ABC1234", Chassis = "9BWZZZ377VT004251", Status = "Roubado", Valor = 50000, DiasRoubado = 15 },
                new Veiculo { Id = 2, Modelo = "Civic", Marca = "Honda", Cor = "Preto", Placa = "DEF5678", Chassis = "1HGCM82633A123456", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 3, Modelo = "Gol", Marca = "Volkswagen", Cor = "Branco", Placa = "GHI9012", Chassis = "3FAFP31394R128765", Status = "Roubado", Valor = 50000, DiasRoubado = 5 },
                new Veiculo { Id = 4, Modelo = "Fiesta", Marca = "Ford", Cor = "Azul", Placa = "JKL3456", Chassis = "JH4DA9350MS012345", Status = "Roubado", Valor = 50000, DiasRoubado = 12 },
                new Veiculo { Id = 5, Modelo = "HB20", Marca = "Hyundai", Cor = "Vermelho", Placa = "MNO7890", Chassis = "2C4RC1BG2HR567890", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 6, Modelo = "Ka", Marca = "Ford", Cor = "Cinza", Placa = "PQR1234", Chassis = "3N1AB7APXGY345678", Status = "Roubado", Valor = 50000, DiasRoubado = 7 },
                new Veiculo { Id = 7, Modelo = "Palio", Marca = "Fiat", Cor = "Preto", Placa = "STU5678", Chassis = "KL1TD56607B765432", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 8, Modelo = "Corolla", Marca = "Toyota", Cor = "Branco", Placa = "VWX9012", Chassis = "1FTRX17W1XKA98765", Status = "Roubado", Valor = 50000, DiasRoubado = 8 },
                new Veiculo { Id = 9, Modelo = "Cruze", Marca = "Chevrolet", Cor = "Azul", Placa = "YZA3456", Chassis = "JN8AS5MT2DW123456", Status = "Roubado", Valor = 50000, DiasRoubado = 6 },
                new Veiculo { Id = 11, Modelo = "EcoSport", Marca = "Ford", Cor = "Prata", Placa = "EFG1122", Chassis = "WVWZZZ1KZAW056789", Status = "Roubado", Valor = 50000, DiasRoubado = 4 },
                new Veiculo { Id = 12, Modelo = "Toro", Marca = "Fiat", Cor = "Cinza", Placa = "HIJ3344", Chassis = "ZFAAXX00A0P012345", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 13, Modelo = "Strada", Marca = "Fiat", Cor = "Vermelho", Placa = "KLM5566", Chassis = "MAJ6S3GL8LC987654", Status = "Roubado", Valor = 50000, DiasRoubado = 6 },
                new Veiculo { Id = 14, Modelo = "Celta", Marca = "Chevrolet", Cor = "Azul", Placa = "NOP7788", Chassis = "5NPE24AF8FH456321", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 15, Modelo = "Fusca", Marca = "Volkswagen", Cor = "Amarelo", Placa = "QRS9900", Chassis = "1FAFP55U61A432109", Status = "Roubado", Valor = 50000, DiasRoubado = 10 },
                new Veiculo { Id = 16, Modelo = "Logan", Marca = "Renault", Cor = "Branco", Placa = "TUV1133", Chassis = "VF1RFA00458012345", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 17, Modelo = "Duster", Marca = "Renault", Cor = "Preto", Placa = "WXY4455", Chassis = "9C2JC41104R000123", Status = "Roubado", Valor = 50000, DiasRoubado = 2 },
                new Veiculo { Id = 18, Modelo = "Etios", Marca = "Toyota", Cor = "Cinza", Placa = "ZAB6677", Chassis = "4T1BF1FK2GU789321", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 },
                new Veiculo { Id = 19, Modelo = "March", Marca = "Nissan", Cor = "Prata", Placa = "CDE8899", Chassis = "KMHD84LF6JU007700", Status = "Roubado", Valor = 50000, DiasRoubado = 92 },
                new Veiculo { Id = 20, Modelo = "Versa", Marca = "Nissan", Cor = "Azul", Placa = "FGH0001", Chassis = "KNADM4A38F6021345", Status = "Recuperado", Valor = 90000, DiasRoubado = 0 }
            );
        }
    }
}
