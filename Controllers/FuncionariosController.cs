using System;
using Microsoft.AspNetCore.Mvc;
using ProjetoVSC.Models.Entities;
using ProjetoVSC.Database;
using System.Linq;

namespace ProjetoVSC.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuncionariosController(ApplicationDbContext context){
            _context = context;
        }

        public IActionResult Index(){
            var funcionarios = _context.Funcionario.ToList();
            return View(funcionarios);
        }

        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(Funcionario funcioanario){
            _context.Funcionario.Add(funcioanario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int? id){

            if (id == null)
            {
                return NotFound();
            }

            var funcionarios = _context.Funcionario.First(f => f.Id == id);
            return View(funcionarios);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Alterar(int id, Funcionario funcionario){

            if (id != funcionario.Id)
            {
                return NotFound();
            }

            _context.Funcionario.Update(funcionario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int? id){

            if (id == null)
            {
                return NotFound();
            }

            var funcionario = _context.Funcionario.First(f => f.Id == id);
            return View(funcionario);
        }

        public IActionResult Excluir(int id){

            var funcionario = _context.Funcionario.Find(id);

            if (id != funcionario.Id)
            {
                return NotFound();
            }

            _context.Funcionario.Remove(funcionario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}