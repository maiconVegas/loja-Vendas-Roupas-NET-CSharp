using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using lolja_MODELOS.lolja.Modelos.Models.Produtos;
using lolja_MODELOS.lolja.Modelos.Models.Vendas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lolja_MODELOS.lolja.Modelos.Services
{
    public class ClienteService
    {
        public void ConsultarProdutos(Estoque estoque)
        {
            Console.Clear();
            if (estoque != null)
            {
                foreach (var item in estoque.Itens)
                {
                    Console.WriteLine($"================ Produto ================");
                    Console.WriteLine($"Nome: {item.Key.Nome}");
                    Console.WriteLine($"Descrição: {item.Key.Descricao}");
                    Console.WriteLine($"Preço: {item.Key.Preco.ToString("C")}");
                    Console.WriteLine($"Tamanho: {item.Key.Tamanho}");
                    Console.WriteLine($"Cor: {item.Key.Cor}");
                    Console.WriteLine($"Categoria: {item.Key.categoriaRoupa.Nome}");
                    Console.WriteLine($"Descri Categoria: {item.Key.categoriaRoupa.Descricao}");
                    Console.WriteLine($"Quantidade: {item.Value}");
                    Console.WriteLine("===========================================\n\n");     
                }
            }
            else
            {
                Console.WriteLine("Produtos Indisponiveis!");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public Produto RetornarProduto(Estoque estoque, string nome)
        {
            foreach (var item in estoque.Itens)
            {

                if (item.Key.Nome.Equals(nome))
                {
                    return item.Key;
                }

            }
            return null;
        }

        public void ConsultarProdutoPorNome(Estoque estoque, string nome)
        {
            foreach (var item in estoque.Itens)
            {
                
                if (item.Key.Nome.Equals(nome))
                {
                    Console.WriteLine($"================ Produto ================");
                    Console.WriteLine($"Nome: {item.Key.Nome}");
                    Console.WriteLine($"Descrição: {item.Key.Descricao}");
                    Console.WriteLine($"Preço: {item.Key.Preco.ToString("C")}");
                    Console.WriteLine($"Tamanho: {item.Key.Tamanho}");
                    Console.WriteLine($"Cor: {item.Key.Cor}");
                    Console.WriteLine($"Categoria: {item.Key.categoriaRoupa.Nome}");
                    Console.WriteLine($"Descri Categoria: {item.Key.categoriaRoupa.Descricao}");
                    Console.WriteLine($"Quantidade: {item.Value}");
                    Console.WriteLine("===========================================\n\n");
                }
                
            }
            //Console.WriteLine($"Pressione Enter para sair...");
            //Console.ReadKey();
        }

        public ItemVenda AdicionarProdutoNoCarrinho(Estoque estoque, string nomeProduto, int quantidadeProduto)
        {
            if (estoque == null || estoque.Itens == null || string.IsNullOrEmpty(nomeProduto))
            {
                throw new ArgumentException("Parâmetros inválidos");
            }
            foreach (var produto in estoque.Itens)
            {
                try
                {
                    if (produto.Key.Nome.Equals(nomeProduto) && produto.Value >= quantidadeProduto)
                    {
                        return new ItemVenda(produto.Key, estoque.RemoverProduto(produto.Key, quantidadeProduto)); ;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Erro ao adicionar produto no carrinho");
                }
                
            }
            return null;
        }

        public void ListarCarrinho(List<ItemVenda> carrinho)
        {
            Console.Clear();
            if (carrinho != null && carrinho.Count != 0)
            {
                foreach (var item in carrinho)
                {
                    Console.WriteLine($"===========================================");
                    Console.WriteLine($"Nome: {item.Item.Nome}");
                    Console.WriteLine($"Descrição: {item.Item.Descricao}");
                    Console.WriteLine($"Preço: {item.Item.Preco.ToString("C")}");
                    Console.WriteLine($"Tamanho: {item.Item.Tamanho}");
                    Console.WriteLine($"Cor: {item.Item.Cor}");
                    Console.WriteLine($"Categoria: {item.Item.categoriaRoupa.Nome}");
                    Console.WriteLine($"Descri Categoria: {item.Item.categoriaRoupa.Descricao}");
                    Console.WriteLine($"Quantidade: {item.Quantidade}");
                    Console.WriteLine("===========================================\n\n");
                }
                Console.WriteLine($"Preço Total: {CalcularPrecoTotal(carrinho).ToString("C")}");
            }
            else
            {
                Console.WriteLine("CARRINHO VÁZIO!\n\n");
            }
            Console.WriteLine($"Pressione Enter...");
            Console.ReadKey();
            Console.Clear();
        }

        private double CalcularPrecoTotal(List<ItemVenda> carrinho)
        {
            double total = 0;
            foreach (var item in carrinho)
            {
                total += item.Item.Preco * item.Quantidade;
            }
            return total;
        }

        public Venda FinalizarCompra(Cliente comprador, List<ItemVenda> itensVenda)
        {
            Console.Clear();
            if (itensVenda != null && itensVenda.Count != 0)
            {
                foreach (char letter in "......Listando seus produtos.......")
                {
                    Console.Write(letter);
                    Thread.Sleep(50);
                }
                ListarCarrinho(itensVenda);
                Console.WriteLine($"Total do valor para o pagamento: {CalcularPrecoTotal(itensVenda).ToString("C")}");
                Console.WriteLine($"Pressione Enter para Confirmar...");
                Console.ReadKey();
                Console.WriteLine("Pressione (S) - PAGAR");
                Console.WriteLine("Pressione (N) - NÃO PAGAR");
                Console.Write("Tecla: ");
                string entrada = Console.ReadLine();
                if (!string.IsNullOrEmpty(entrada))
                {
                    char tecla = entrada[0];
                    switch (tecla)
                    {
                        case 'S':
                        case 's':
                            Console.WriteLine("Compra Sucedida!\n\n");
                            Console.WriteLine($"Pressione Enter para sair...");
                            Console.ReadKey();
                            Console.Clear();
                            return new Venda(comprador, itensVenda);
                        case 'N':
                        case 'n':
                            Console.WriteLine("Compra Cancelada!");
                            Console.WriteLine($"Pressione Enter para sair...");
                            Console.ReadKey();
                            Console.Clear();
                            return null;
                        default:
                            Console.WriteLine("Tecla Inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro");
                }
                
            }
            else
            {
                Console.WriteLine("Não é possível finalizar a compra sem os produtos!\n\n");
            }
            Console.WriteLine($"Pressione Enter para sair...");
            Console.ReadKey();
            Console.Clear();
            return null;
        }

        public bool VerificarProduto(Estoque estoque, string nome)
        {
            foreach (var item in estoque.Itens)
            {
                if (item.Key.Nome.Equals(nome))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
