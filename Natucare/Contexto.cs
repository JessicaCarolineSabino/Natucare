using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Natucare.Entidades;
namespace Natucare
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option){ }

        public DbSet<Cliente> CLIENTES { get; set; }
    }
}
