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
        public void ExportarVendedores()
        {

        }
        public void ExportarClientes()
        {

        }
        public void Estoque()
        {

        }
    }
}
