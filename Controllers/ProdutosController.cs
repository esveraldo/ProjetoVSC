using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProjetoVSC.Database;
using ProjetoVSC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProjetoVSC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }
         public IActionResult Teste(){

            Console.WriteLine("=========== Categorias ===========");
            //1 -1
            //var produto = _context.Produtos.Include(p => p.Categoria).ToList();
            //1 - *
            var produto = _context.Produtos.Include(p => p.Categoria).Where(c => c.Categoria.Id == 4).ToList();

            produto.ForEach(prod => {System.Console.WriteLine(prod.ToString());});

            Console.WriteLine("==================================");

            return Content("Ok");
        }
    }
}