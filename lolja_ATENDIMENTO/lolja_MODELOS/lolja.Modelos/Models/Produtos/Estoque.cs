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

        public int RemoverProduto(Produto produto, int quantidade)
        {
            if (Itens.ContainsKey(produto) && Itens[produto] >= quantidade)
            {
                Itens[produto] -= quantidade;
                return quantidade;
            }
            return 0;
        }

        public int ObterQuantidade(Produto produto)
        {
            return Itens.ContainsKey(produto) ? Itens[produto] : 0;
        }

        //public override string ToString()
        //{
            
        //    return $" === Produto ===\n" +
        //               $"Nome: {this.Itens.ElementAt().Key.Nome}\n" +
        //               $"Descrição: {this.Itens.Key.Descricao}\n" +
        //               $"Preço: {this.Itens.Key.Preco}\n" +
        //               $"Tamanho: {this.Itens.Key.Tamanho}\n" +
        //               $"Cor: {this.Itens.Key.Cor}\n" +
        //               $"Categoria: {this.Itens.Key.categoriaRoupa.Nome}\n" +
        //               $": {this.Itens.Key.categoriaRoupa.Descricao}\n" +
        //               $"Quantidade: {this.Itens.Value}\n\n\n"; ;
        //}

    }
}
