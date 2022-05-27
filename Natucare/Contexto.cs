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
        public DbSet<Usuarios> USUARIOS { get; set; }
        public DbSet<CadastroProdutos> CADASTROPRODUTOS { get; set; }
        public DbSet<CadastroCliente> CADASTROCLIENTE { get; set; }
    }
}
