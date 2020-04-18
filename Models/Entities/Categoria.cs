using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVSC.Models.Entities
{
    public class Categoria 
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {
            
        }
        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString(){
            return "Id: " + Id + " Nome: " + Nome; 
        }
    }
}