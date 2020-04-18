using Microsoft.EntityFrameworkCore;
using ProjetoVSC.Models.Entities;
using System.Linq;

namespace ProjetoVSC.Database
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options){

        }

    }
}