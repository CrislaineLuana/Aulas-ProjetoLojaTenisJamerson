using Aulas_ProjetoLojaTenis3.Models;
using Microsoft.EntityFrameworkCore;

namespace Aulas_ProjetoLojaTenis3.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {        
        }

        public DbSet<ProdutoModel> Produtos { get; set; }

    }
}
