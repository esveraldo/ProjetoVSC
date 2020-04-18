using System.IO;
using ProjetoVSC.Models.Entities;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoVSC.Database
{
    public class SeedingService
    {
        private readonly ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed(){
            if(_context.Categorias.Any() || _context.Produtos.Any()){
                return;
            }

            Categoria c1 = new Categoria(1, "Eletrônicos");
            Categoria c2 = new Categoria(2, "Cama e mesa");
            Categoria c3 = new Categoria(3, "Brinquedos");
            Categoria c4 = new Categoria(4, "Vestuário");
            Categoria c5 = new Categoria(5, "Alimentos");
            Categoria c6 = new Categoria(6, "Bijuterias");
            Categoria c7 = new Categoria(7, "Linha branca");
            
            _context.Categorias.AddRange(c1, c2, c3, c4, c5, c6, c7);
            _context.SaveChanges();

            Produto p1 = new Produto(1, "Computador", 1);
            Produto p2 = new Produto(2, "Camiseta", 4);
            Produto p3 = new Produto(3, "Calça Jeans", 4);
            Produto p4 = new Produto(4, "Geladeira", 7);

            _context.Produtos.AddRange(p1, p2, p3, p4);
            _context.SaveChanges();

        }
    }
}