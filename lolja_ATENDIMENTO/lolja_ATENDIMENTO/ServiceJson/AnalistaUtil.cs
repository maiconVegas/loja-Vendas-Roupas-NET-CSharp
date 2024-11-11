using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using lolja_MODELOS.lolja.Modelos.Models.Produtos;
using lolja_MODELOS.lolja.Modelos.Models.Vendas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolja_ATENDIMENTO.ServiceJson
{
    internal class AnalistaUtil
    {
        public void ExportarVendas(List<Venda> vendas)
        {
            Console.Clear();
            string json = JsonConvert.SerializeObject(vendas,
                    Formatting.Indented);
            try
            {
                FileStream fs = new FileStream(@"C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils\vendas.json",
                    FileMode.Create);
                using (StreamWriter streamwriter = new StreamWriter(fs))
                {
                    streamwriter.WriteLine(json);
                }
                foreach (var letra in "...Exportando...")
                {
                    Console.Write(letra);
                    Thread.Sleep(100);
                }
                Console.WriteLine(@"Arquivo salvo em C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils");
                Console.ReadKey();
            }
            catch (Exception excecao)
            {
                Console.WriteLine("deu erro");
            }
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExportarVendedores(List<Vendedor> vendedores)
        {
            Console.Clear();
            string json = JsonConvert.SerializeObject(vendedores,
                    Formatting.Indented);
            try
            {
                FileStream fs = new FileStream(@"C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils\vendedores.json",
                    FileMode.Create);
                using (StreamWriter streamwriter = new StreamWriter(fs))
                {
                    streamwriter.WriteLine(json);
                }
                foreach (var letra in "...Exportando...")
                {
                    Console.Write(letra);
                    Thread.Sleep(100);
                }
                Console.WriteLine(@"Arquivo salvo em C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils");
                Console.ReadKey();
            }
            catch (Exception excecao)
            {
                Console.WriteLine("deu erro");
            }
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExportarClientes(List<Cliente> clientes)
        {
            Console.Clear();
            string json = JsonConvert.SerializeObject(clientes,
                    Formatting.Indented);
            try
            {
                FileStream fs = new FileStream(@"C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils\clientes.json",
                    FileMode.Create);
                using (StreamWriter streamwriter = new StreamWriter(fs))
                {
                    streamwriter.WriteLine(json);
                }
                foreach (var letra in "...Exportando...")
                {
                    Console.Write(letra);
                    Thread.Sleep(100);
                }
                Console.WriteLine(@"Arquivo salvo em C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils");
                Console.ReadKey();
            }
            catch (Exception excecao)
            {
                Console.WriteLine("deu erro");
            }
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExportarEstoque(Estoque estoque)
        {
            var estoqueSerializavel = estoque.Itens.ToDictionary(
                item => item.Key.ID_Produto,
                item => new
                {
                    Nome = item.Key.Nome,
                    Descrição = item.Key.Descricao,
                    Preço = item.Key.Preco,
                    Tamanho = item.Key.Tamanho,
                    Cor = item.Key.Cor,
                    Categoria = new
                    {
                        ID_Categoria = item.Key.categoriaRoupa.ID_Categoria,
                        Nome = item.Key.categoriaRoupa.Nome,
                        Descrição = item.Key.categoriaRoupa.Descricao
                    },
                    Quantidade = item.Value
                }
            );

            Console.Clear();
            string json = JsonConvert.SerializeObject(estoqueSerializavel,
                    Formatting.Indented);
            try
            {
                FileStream fs = new FileStream(@"C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils\estoque.json",
                    FileMode.Create);
                using (StreamWriter streamwriter = new StreamWriter(fs))
                {
                    streamwriter.WriteLine(json);
                }
                foreach (var letra in "...Exportando...")
                {
                    Console.Write(letra);
                    Thread.Sleep(100);
                }
                Console.WriteLine(@"Arquivo salvo em C:\Users\maico\OneDrive\Área de Trabalho\loja-Vendas-Roupas-NET-CSharp\lolja_ATENDIMENTO\lolja_MODELOS\lolja.Modelos\Utils");
                Console.ReadKey();
            }
            catch (Exception excecao)
            {
                Console.WriteLine("deu erro");
            }
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
