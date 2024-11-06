using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Models.Produtos
{
    public class Produto
    {
        public string ID_Produto { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public Categoria categoriaRoupa { get; set; }

        public Produto(string nome, double preco, string tamanho, Categoria categoria)
        {
            ID_Produto = Guid.NewGuid().ToString();
            Nome = nome;
            Preco = preco;
            Tamanho = tamanho;
            categoriaRoupa = categoria;
        }
        public Produto(string nome, string descricao, double preco, string tamanho, Categoria categoria)
        {
            ID_Produto = Guid.NewGuid().ToString();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Tamanho = tamanho;
            categoriaRoupa = categoria;
        }
        public Produto(string nome, string descricao, double preco, string tamanho, string cor, Categoria categoria)
        {
            ID_Produto = Guid.NewGuid().ToString();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Tamanho = tamanho;
            Cor = cor;
            categoriaRoupa = categoria;
        }

        public void AlterarPreco(double preco)
        {
            if (preco > 0)
            {
                Preco = preco;
            }
        }

        public void AlterarDescricao(string descricao)
        {
            if (descricao != null || descricao != " ")
            {
                Descricao = descricao;
            }
            else
            {
                Console.WriteLine("Descrição da Categoria vázio!");
            }
        }
    }
}
