using Microsoft.EntityFrameworkCore;
using EssenceDeals.Models;

namespace EssenceDeals.Models
{
    public class Contexto : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public Contexto(DbContextOptions<Contexto> options) : base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Area> Area { get; set; }

    }
}
