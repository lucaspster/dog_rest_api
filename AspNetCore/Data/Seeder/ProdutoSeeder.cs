using Microsoft.EntityFrameworkCore;
using Entrevista.Models;
using Bogus;
namespace Entrevista.Data.Seeder
{
    public class ProdutoSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Verificar se já existem produtos no banco de dados.
                if (context.Produtos.Any())
                {
                    return;   // DB has been seeded
                }

                // Gerar dados falsos para produtos.
                
                var faker = new Faker<Produtos>()
                    .RuleFor(p => p.ProdutoId, f => f.Random.Int(1000, 9999))
                    .RuleFor(p => p.Nome, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Descricao, f => f.Commerce.ProductDescription())
                    .RuleFor(p => p.Preco, f => f.Random.Decimal(0.01m, 10000m))
                    .RuleFor(p => p.DataCriacao, f => f.Date.Past(1))
                    .RuleFor(p => p.QuantidadeEstoque, f => f.Random.Int(0, 100))
                    .RuleFor(p => p.CategoriaId, f => f.Random.Int(1, 10));

                var produtos = faker.Generate(50);

                // Adicionar produtos gerados ao contexto.
                context.Produtos.AddRange(produtos);

                // Salvar as mudanças no banco de dados.
                context.SaveChanges();
            }
        }
    }
}

