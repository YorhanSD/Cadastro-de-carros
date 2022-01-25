using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeCarros.Models
{
    [Table("Carros")]
    public class Carros
    {
        [Display(Name = "Id")]
        [Column("Id")]

        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Nome { get; set; }

        [Display(Name = "Marca")]
        [Column("Marca")]

        public string Marca { get; set; }

        [Display(Name = "Ano")]
        [Column("Ano")]

        public int Ano { get; set; }

        [Display(Name = "Motor")]
        [Column("Motor")]

        public string Motor { get; set; }

        [Display(Name = "Turbo")]
        [Column("Turbo")]

        public bool Turbo { get; set; }
    }
}
