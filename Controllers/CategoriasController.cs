using System;
using ProjetoVSC.Database;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProjetoVSC.Models.Entities;

namespace ProjetoVSC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Teste(){

            var categorias = _context.Categorias.Where(c => c.Nome.Equals("Vendedor")).ToList();

            Console.WriteLine("=========== Categorias ===========");

            categorias.ForEach(cat => {Console.WriteLine(cat.ToString());});

            Console.WriteLine("==================================");

            return Content("Ok");
        }
    }
}