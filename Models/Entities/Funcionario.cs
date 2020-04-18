using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVSC.Models.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        [Required]
        public string Cpf { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Salario { get; set; }
    }
}