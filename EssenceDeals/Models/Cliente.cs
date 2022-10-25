using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EssenceDeals.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("CodCliente")]
        [Display(Name="CodigoCliente")]
        [Key]
        public int CodCliente { get; set; }


        [Column("Nome")]
        [Display(Name="Nome")]
        public string Nome { get; set; }


        [Column("Telefone")]
        [Display(Name ="Telefone")]
        public int Telefone { get; set; }

        [Column("Email")]
        [Display(Name = "E-mail")]
        public string email { get; set; }



    }
}
