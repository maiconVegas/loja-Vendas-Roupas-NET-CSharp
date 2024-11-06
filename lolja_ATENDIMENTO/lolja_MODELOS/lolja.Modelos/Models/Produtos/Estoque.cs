using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Produtos
{
    public class Estoque
    {
        public Dictionary<Produto, int> Itens { get; private set; }

        public Estoque()
        {
            Itens = new Dictionary<Produto, int>();
        }

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            if (Itens.ContainsKey(produto))
            {
                Itens[produto] += quantidade;
            }
            else if (produto != null && quantidade > 0)
            {
                Itens.Add(produto, quantidade);
            }
        }

        public void RemoverProduto(Produto produto, int quantidade)
        {
            if (Itens.ContainsKey(produto) && Itens[produto] >= quantidade)
            {
                Itens[produto] -= quantidade;
            }
        }

        public int ObterQuantidade(Produto produto)
        {
            return Itens.ContainsKey(produto) ? Itens[produto] : 0;
        }


    }
}
