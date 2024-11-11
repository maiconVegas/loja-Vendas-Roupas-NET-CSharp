using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using lolja_MODELOS.lolja.Modelos.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lolja_MODELOS.lolja.Modelos.Models.Enderecos.Estado;

namespace lolja_MODELOS.lolja.Modelos.Services
{
    public class VendedorService
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

        public Cliente CadastrarCliente()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("-------------------CADASTRAR CLIENTE-------------------");

                Endereco endereco = CadastrarEndereco();

                Console.Write("Insira Nome do CLiente: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                Thread.Sleep(1000);
                for (int i = 0; i < 3; i++)
                {
                    Console.Clear();
                    foreach (var item in "..cadastrando..")
                    {
                        Console.Write(item);
                        Thread.Sleep(50);
                    }
                }
                var novoCliente = new Cliente(nome, idade, cpf, endereco, senha);
                novoCliente.Email = email;
                return novoCliente;
                

            }
            catch (Exception excecao)
            {
                Console.WriteLine("Não foi possível realizar o cadastro");
                return null;
            }
        }

        private Endereco CadastrarEndereco()
        {
            try
            {
                Console.WriteLine(" - Estado - ");
                Console.WriteLine("AC - Acre | AL - Alagoas | AM - Amazonas | AP - Amapá |");
                Console.WriteLine("BA - Bahia | CE - Ceará | DF - Distrito Federal | ES - Espírito Santo |");
                Console.WriteLine("GO - Goiás | MA - Maranhão | MT - Mato Grosso | MS - Mato Grosso do Sul |");
                Console.WriteLine("MG - Minas Gerais | PA - Pará | PB - Paraíba | PE - Pernambuco |");
                Console.WriteLine("PI - Piauí | PR - Paraná | RJ - Rio de Janeiro | RN - Rio Grande do Norte |");
                Console.WriteLine("RS - Rio Grande do Sul | RO - Rondônia | RR - Roraima | SC - Santa Catarina |");
                Console.WriteLine("SE - Sergipe | SP - São Paulo | TO - Tocantins");

                Console.Write("Digite seu Estado: ");
                string estadoDigitado = Console.ReadLine();
                Estado estado = null;
                try
                {
                    switch (estadoDigitado)
                    {
                        case "Acre":
                            estado = new Estado(Estado.SiglaEstado.AC);
                            break;
                        case "Alagoas":
                            estado = new Estado(Estado.SiglaEstado.AL);
                            break;
                        case "Amazonas":
                            estado = new Estado(Estado.SiglaEstado.AM);
                            break;
                        case "Amapá":
                            estado = new Estado(Estado.SiglaEstado.AP);
                            break;
                        case "Bahia":
                            estado = new Estado(Estado.SiglaEstado.BA);
                            break;
                        case "Ceará":
                            estado = new Estado(Estado.SiglaEstado.CE);
                            break;
                        case "Distrito Federal":
                            estado = new Estado(Estado.SiglaEstado.DF);
                            break;
                        case "Espírito Santo":
                            estado = new Estado(Estado.SiglaEstado.ES);
                            break;
                        case "Goiás":
                            estado = new Estado(Estado.SiglaEstado.GO);
                            break;
                        case "Maranhão":
                            estado = new Estado(Estado.SiglaEstado.MA);
                            break;
                        case "Mato Grosso":
                            estado = new Estado(Estado.SiglaEstado.MT);
                            break;
                        case "Mato Grosso do Sul":
                            estado = new Estado(Estado.SiglaEstado.MS);
                            break;
                        case "Minas Gerais":
                            estado = new Estado(Estado.SiglaEstado.MG);
                            break;
                        case "Pará":
                            estado = new Estado(Estado.SiglaEstado.PA);
                            break;
                        case "Paraíba":
                            estado = new Estado(Estado.SiglaEstado.PB);
                            break;
                        case "Pernambuco":
                            estado = new Estado(Estado.SiglaEstado.PE);
                            break;
                        case "Piauí":
                            estado = new Estado(Estado.SiglaEstado.PI);
                            break;
                        case "Paraná":
                            estado = new Estado(Estado.SiglaEstado.PR);
                            break;
                        case "Rio de Janeiro":
                            estado = new Estado(Estado.SiglaEstado.RJ);
                            break;
                        case "Rio Grande do Norte":
                            estado = new Estado(Estado.SiglaEstado.RN);
                            break;
                        case "Rio Grande do Sul":
                            estado = new Estado(Estado.SiglaEstado.RS);
                            break;
                        case "Rondônia":
                            estado = new Estado(Estado.SiglaEstado.RO);
                            break;
                        case "Roraima":
                            estado = new Estado(Estado.SiglaEstado.RR);
                            break;
                        case "Santa Catarina":
                            estado = new Estado(Estado.SiglaEstado.SC);
                            break;
                        case "Sergipe":
                            estado = new Estado(Estado.SiglaEstado.SE);
                            break;
                        case "São Paulo":
                            estado = new Estado(Estado.SiglaEstado.SP);
                            break;
                        case "Tocantins":
                            estado = new Estado(Estado.SiglaEstado.TO);
                            break;
                        default:
                            Console.WriteLine("Estado não encontrado.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Estado Inexistente! Tente novamente!");
                    Thread.Sleep(1500);
                    CadastrarCliente();
                }
                Console.Write("Digite sua Cidade: ");
                string nomeCidade = Console.ReadLine();
                if (!(string.IsNullOrEmpty(nomeCidade)))
                {
                    Cidade cidade = new Cidade(nomeCidade, estado);
                    Console.Write("Nome da Rua: ");
                    string rua = Console.ReadLine();
                    Console.Write("Número: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Write("Bairro: ");
                    string bairro = Console.ReadLine();
                    Console.Write("CEP: ");
                    string cep = Console.ReadLine();
                    if (!(string.IsNullOrEmpty(rua) || numero < 0 || string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(cep)))
                    {
                        Console.WriteLine("\n");
                        return new Endereco(rua, numero, bairro, cep, cidade);
                    }
                    else
                    {
                        Console.WriteLine("Não insira campos vazios!");
                        Thread.Sleep(1000);
                        CadastrarCliente();
                    }
                }
                else
                {
                    Console.WriteLine("Digite o nome da cidade novamente!");
                    Thread.Sleep(1000);
                    CadastrarCliente();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tente Informar o endereço novamente...");
                Thread.Sleep(1500);
                CadastrarCliente();
            }
            return null;
        }
    }
}
