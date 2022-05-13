using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emartim_CRUD.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {

        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cargo")]
        [Column("Cargo")]
        public string Cargo { get; set; }

        [Display(Name = "Situação")]
        [Column("Situacao")]
        public bool Situacao { get; set; }

        [Display(Name = "Data da Admissão")]
        [Column("Data_Admissao")]
        public DateTime Data_Admissao { get; set; }

        [Display(Name = "Sálario")]
        [Column("Salario")]
        public decimal Salario { get; set; }


    }
}
