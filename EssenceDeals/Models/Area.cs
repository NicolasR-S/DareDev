using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EssenceDeals.Models
{
    [Table("TB_AREAS")]
    public class Area
    {
        [Column("CodArea")]
        [Display(Name = "CodArea")]
        [Key]
        public int CodArea { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
