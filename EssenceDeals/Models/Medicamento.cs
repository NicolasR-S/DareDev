using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EssenceDeals.Models
{
    [Table("Medicamento")]
    public class Medicamento
    {
        [Column("CodMedicamento")]
        [Display(Name="CodigoMedicamento")]
        [Key]
        public int CodMedicamento { get; set; }


        [Column("NomeMedicamento")]
        [Display(Name="NomeMedicamento")]
        public string NomeMedicamento { get; set; }


        [Column("destino")]
        [Display(Name ="destino")]
        public string destino { get; set; }

        [Column("TipoMedicamento")]
        [Display(Name = "TipoMedicamento")]
        public string TipoMedicamento { get; set; }



    }
}
