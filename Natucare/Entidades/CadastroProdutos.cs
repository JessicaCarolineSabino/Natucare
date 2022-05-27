using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Entidades
{
    public class CadastroProdutos
    {
        public int Id { get; set; }
        public string Linha { get; set; }
        public int Codigo { get; set; }
        public string Produto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
