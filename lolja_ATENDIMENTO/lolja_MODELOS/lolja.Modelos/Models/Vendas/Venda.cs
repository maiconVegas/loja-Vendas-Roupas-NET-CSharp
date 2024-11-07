using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Vendas
{
    public class Venda
    {
        public string ID_Venda { get; private set; }
        public DateTime Data_Venda { get; private set; }
        public Cliente Comprador { get; private set; }
        public List<ItemVenda> ItensVenda { get; private set; }
        public double Preco_Total { get; private set; }



    }
}
