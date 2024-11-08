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

        public Venda(Cliente comprador, List<ItemVenda> itensVenda)
        {
            ID_Venda = Guid.NewGuid().ToString();
            Data_Venda = DateTime.Now;
            Comprador = comprador;
            ItensVenda = itensVenda;
            Preco_Total = CalcularPrecoTotal();
        }

        private double CalcularPrecoTotal()
        {
            double total = 0;
            foreach (var item in ItensVenda)
            {
                total += item.Item.Preco * item.Quantidade;
            }
            return total;
        }
    }
}
