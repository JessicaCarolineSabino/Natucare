using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Entidades
{
    public class Vendas
    {
        public int Id { get; set; }
        public int CadastroClienteId { get; set; }
        public CadastroCliente cadastroCliente { get; set; }


        public CadastroProdutos Produto { get; set; }
        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }
        public decimal precoProduto { get; set; }
        public decimal ValorTotal { get; set; }
        public int Ciclo { get; set; }
    }
}
