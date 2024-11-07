using lolja_MODELOS.lolja.Modelos.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Vendas
{
    public class ItemVenda
    {
        public Produto Item { get; private set; }
        public int Quantidade { get; private set; }

        public ItemVenda(Produto produto, int quantidade)
        {
            this.Item = produto;
            this.Quantidade = quantidade > 0 ? quantidade : 0;
            
        }
    }
}
