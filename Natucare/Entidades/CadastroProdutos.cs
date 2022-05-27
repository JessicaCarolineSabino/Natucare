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
        public int Código { get; set; }
        public string Produto { get; set; }
        public int PreçoVenda { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
