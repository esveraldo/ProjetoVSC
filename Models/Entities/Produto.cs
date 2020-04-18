using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVSC.Models.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public Produto()
        {
            
        }

        public Produto(int id, string nome, int categoriaId)
        {
            Id = Id;
            Nome = nome;
            CategoriaId = categoriaId;
        }

        public override string ToString(){
            return "Id: " + Id + " Nome: " + Nome + " Categoria: " + Categoria.ToString(); 
        }
    }
}