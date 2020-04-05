using Microsoft.EntityFrameworkCore;
using ProjetoVSC.Models.Entities;

namespace ProjetoVSC.Database
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options){

        }

    }
}