using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EssenceDeals.Models
{
    [Table("Medicamento")]
    public class Medicamento
    {
        [Column("CodCliente")]
        [Display(Name="CodigoCliente")]
        [Key]
        public int CodMedicamento { get; set; }


        [Column("Nome")]
        [Display(Name="Nome")]
        public string NomeMedicamento { get; set; }


        [Column("Telefone")]
        [Display(Name ="Telefone")]
        public string destino { get; set; }

        [Column("Email")]
        [Display(Name = "E-mail")]
        public string TipoMedicamento { get; set; }



    }
}
