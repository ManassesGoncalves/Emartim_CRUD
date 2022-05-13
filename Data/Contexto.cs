using Emartim_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Emartim_CRUD.Data
{
    public class Contexto :DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Cargo> Cargo { get; set; }

    }
}
