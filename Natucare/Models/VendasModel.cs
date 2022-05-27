using Natucare.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Models
{
    public class VendasModel
    {
        public List<CadastroProdutos> ListaTodosProdutos    { get; set; }
        public List<CadastroCliente> ListaTodosClientes     { get; set; }

        public CadastroProdutos Produto { get; set; }
        public int CadastroClienteId { get; set; }
       
        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }
       
     
        public int Ciclo { get; set; }

    }
}
