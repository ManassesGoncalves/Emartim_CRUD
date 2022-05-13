using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emartim_CRUD.Models
{

    [Table("Cargo")]
    public class Cargo
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Cargo")]
        [Column("Carg")]
        public string Carg { get; set; }


        [Display(Name = "Situação")]
        [Column("Situacao")]
        public bool Situacao { get; set; }

    }
}
