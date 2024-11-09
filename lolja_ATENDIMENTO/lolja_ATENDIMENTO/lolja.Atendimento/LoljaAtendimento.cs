using lolja_MODELOS.lolja.Modelos.Models.Enderecos;
using lolja_MODELOS.lolja.Modelos.Models.Pessoas;
using lolja_MODELOS.lolja.Modelos.Models.Produtos;
using lolja_MODELOS.lolja.Modelos.Models.Vendas;
using lolja_MODELOS.lolja.Modelos.Services;
using lolja_MODELOS.lolja.Modelos.Views;

namespace lolja_ATENDIMENTO.lolja.Atendimento
{
    public class LoljaAtendimento
    {

        public void AtendimentoMain()
        {
            #region DADOS INICIAIS
            // ------------------------------------ INICIANDO DADOS ------------------------------------

            Categoria camisetas = new Categoria("Camisetas", "Roupas de manga curta para diversas ocasiões.");
            Categoria calcas = new Categoria("Calças", "Diversos tipos de calças, incluindo jeans, leggings e outros.");
            Categoria vestidos = new Categoria("Vestidos", "Vestidos de diferentes estilos, ideais para várias ocasiões.");
            Categoria blusas = new Categoria("Blusas", "Blusas de diferentes modelos e tecidos.");
            Categoria jaquetas = new Categoria("Jaquetas", "Jaquetas e casacos para o inverno e moda urbana.");
            Categoria saia = new Categoria("Saia", "Saia para diferentes estilos, como curtas, longas e midi.");
            Categoria shorts = new Categoria("Shorts", "Shorts para o verão e ocasiões informais.");
            Categoria macacoes = new Categoria("Macacões", "Macacões femininos e masculinos para diversas ocasiões.");
            Categoria roupaEsporte = new Categoria("Roupas de Esporte", "Roupa de esporte como leggings, tops e shorts.");
            Categoria intimos = new Categoria("Roupas Íntimas", "Roupas íntimas e acessórios, como lingerie e pijamas.");

            Produto camisetaAnime = new Produto("Camiseta Anime", "Camiseta com estampa do anime Demon Slayer", 39.90, "G", "Azul", camisetas);
            Produto camisetaBatman = new Produto("Camiseta Batman", "Camiseta com estampa do Batman", 49.90, "M", "Preto", camisetas);
            Produto camisetaStarWars = new Produto("Camiseta Star Wars", "Camiseta com estampa do Star Wars", 59.90, "P", "Branco", camisetas);
            Produto jeansSlim = new Produto("Jeans Slim", "Calça jeans modelo slim fit", 129.90, "M", "Azul", calcas);
            Produto leggingFitness = new Produto("Legging Fitness", "Legging preta para academia", 89.90, "G", "Preto", calcas);
            Produto calcaMoletom = new Produto("Calça Moletom", "Calça de moletom confortável", 79.90, "M", "Cinza", calcas);
            Produto vestidoFloral = new Produto("Vestido Floral", "Vestido com estampa floral, ideal para o verão", 149.90, "P", "Rosa", vestidos);
            Produto vestidoLongo = new Produto("Vestido Longo", "Vestido longo com detalhes em renda", 199.90, "G", "Branco", vestidos);
            Produto vestidoMidi = new Produto("Vestido Midi", "Vestido midi com detalhes em botões", 179.90, "M", "Preto", vestidos);
            Produto blusaCropped = new Produto("Blusa Cropped", "Blusa cropped de manga curta", 69.90, "M", "Azul", blusas);
            Produto blusaFrio = new Produto("Blusa de Frio", "Blusa de frio para o inverno", 119.90, "G", "Preto", blusas);
            Produto blusaTricot = new Produto("Blusa de Tricot", "Blusa de tricot para o inverno", 89.90, "M", "Bege", blusas);
            Produto jaquetaJeans = new Produto("Jaqueta Jeans", "Jaqueta jeans estilo oversized", 159.90, "G", "Azul", jaquetas);
            Produto jaquetaCouro = new Produto("Jaqueta de Couro", "Jaqueta de couro preta", 249.90, "M", "Preto", jaquetas);
            Produto jaquetaParka = new Produto("Jaqueta Parka", "Jaqueta parka de inverno", 199.90, "P", "Verde", jaquetas);
            Produto saiaJeans = new Produto("Saia Jeans", "Saia jeans com lavagem escura", 89.90, "M", "Azul", saia);
            Produto saiaMidi = new Produto("Saia Midi", "Saia midi com cinto", 129.90, "G", "Bege", saia);
            Produto saiaCurta = new Produto("Saia Curta", "Saia curta de algodão", 69.90, "P", "Preto", saia);
            Produto shortsJeans = new Produto("Shorts Jeans", "Shorts jeans estilo destroyed", 79.90, "M", "Azul", shorts);
            Produto shortsAlgodao = new Produto("Shorts de Algodão", "Shorts de algodão para o verão", 59.90, "G", "Branco", shorts);
            Produto shortsEsportivo = new Produto("Shorts Esportivo", "Shorts esportivo para academia", 49.90, "P", "Preto", shorts);
            Produto macacaoJeans = new Produto("Macacão Jeans", "Macacão jeans estilo urbano", 189.90, "M", "Azul", macacoes);
            Produto macacaoFloral = new Produto("Macacão Floral", "Macacão floral feminino", 159.90, "G", "Rosa", macacoes);
            Produto macacaoPreto = new Produto("Macacão Preto", "Macacão preto elegante", 249.90, "M", "Preto", macacoes);
            Produto topEsporte = new Produto("Top de Esporte", "Top esportivo para academia", 39.90, "P", "Azul", roupaEsporte);
            Produto leggingEsportiva = new Produto("Legging Esportiva", "Legging esportiva com detalhe em neon", 79.90, "M", "Preto", roupaEsporte);
            Produto shortsCorrida = new Produto("Shorts de Corrida", "Shorts de corrida com tecnologia de compressão", 89.90, "G", "Preto", roupaEsporte);
            Produto sutiaLingerie = new Produto("Sutiã Lingerie", "Sutiã de renda para lingerie", 49.90, "M", "Bege", intimos);
            Produto calcinhaLingerie = new Produto("Calcinha Lingerie", "Calcinha de renda para lingerie", 29.90, "P", "Preto", intimos);

            Estoque estoque = new Estoque();
            estoque.AdicionarProduto(camisetaAnime, 30);
            estoque.AdicionarProduto(camisetaBatman, 50);
            estoque.AdicionarProduto(camisetaStarWars, 40);
            estoque.AdicionarProduto(jeansSlim, 25);
            estoque.AdicionarProduto(leggingFitness, 35);
            estoque.AdicionarProduto(calcaMoletom, 20);
            estoque.AdicionarProduto(vestidoFloral, 15);
            estoque.AdicionarProduto(vestidoLongo, 10);
            estoque.AdicionarProduto(vestidoMidi, 18);
            estoque.AdicionarProduto(blusaCropped, 30);
            estoque.AdicionarProduto(blusaFrio, 20);
            estoque.AdicionarProduto(blusaTricot, 25);
            estoque.AdicionarProduto(jaquetaJeans, 12);
            estoque.AdicionarProduto(jaquetaCouro, 8);
            estoque.AdicionarProduto(jaquetaParka, 10);
            estoque.AdicionarProduto(saiaJeans, 20);
            estoque.AdicionarProduto(saiaMidi, 15);
            estoque.AdicionarProduto(saiaCurta, 25);
            estoque.AdicionarProduto(shortsJeans, 30);
            estoque.AdicionarProduto(shortsAlgodao, 35);
            estoque.AdicionarProduto(shortsEsportivo, 40);
            estoque.AdicionarProduto(macacaoJeans, 12);
            estoque.AdicionarProduto(macacaoFloral, 10);
            estoque.AdicionarProduto(macacaoPreto, 8);
            estoque.AdicionarProduto(topEsporte, 50);
            estoque.AdicionarProduto(leggingEsportiva, 45);
            estoque.AdicionarProduto(shortsCorrida, 35);
            estoque.AdicionarProduto(sutiaLingerie, 40);
            estoque.AdicionarProduto(calcinhaLingerie, 60);

            Estado estadoSP = new Estado(Estado.SiglaEstado.SP);
            Estado estadoRJ = new Estado(Estado.SiglaEstado.RJ);
            Estado estadoMG = new Estado(Estado.SiglaEstado.MG);
            Estado estadoBA = new Estado(Estado.SiglaEstado.BA);
            Estado estadoRS = new Estado(Estado.SiglaEstado.RS);

            Cidade cidadeSP = new Cidade("São Paulo", estadoSP);
            Cidade cidadeRJ = new Cidade("Rio de Janeiro", estadoRJ);
            Cidade cidadeBH = new Cidade("Belo Horizonte", estadoMG);
            Cidade cidadeSalvador = new Cidade("Salvador", estadoBA);
            Cidade cidadePortoAlegre = new Cidade("Porto Alegre", estadoRS);

            Endereco endereco1 = new Endereco("Rua das Flores", 101, "Jardim Paulista", "01001-000", cidadeSP);
            Endereco endereco2 = new Endereco("Avenida Paulista", 500, "Bela Vista", "01310-000", cidadeSP);
            Endereco endereco3 = new Endereco("Rua da Consolação", 900, "Centro", "01302-001", cidadeSP);
            Endereco endereco4 = new Endereco("Avenida Faria Lima", 1000, "Itaim Bibi", "01451-001", cidadeSP);
            Endereco endereco5 = new Endereco("Rua Augusta", 200, "Cerqueira César", "01412-002", cidadeSP);
            Endereco endereco6 = new Endereco("Rua do Passeio", 250, "Centro", "20021-290", cidadeRJ);
            Endereco endereco7 = new Endereco("Avenida Atlântica", 1300, "Copacabana", "22021-001", cidadeRJ);
            Endereco endereco8 = new Endereco("Rua das Acácias", 400, "Santa Teresa", "20241-001", cidadeRJ);
            Endereco endereco9 = new Endereco("Avenida Rio Branco", 500, "Centro", "20040-001", cidadeRJ);
            Endereco endereco10 = new Endereco("Rua Visconde de Pirajá", 300, "Ipanema", "22410-000", cidadeRJ);
            Endereco endereco11 = new Endereco("Rua da Liberdade", 105, "Liberdade", "30110-000", cidadeBH);
            Endereco endereco12 = new Endereco("Avenida Afonso Pena", 550, "Centro", "30130-002", cidadeBH);
            Endereco endereco13 = new Endereco("Rua Tupinambás", 700, "Centro", "30120-050", cidadeBH);
            Endereco endereco14 = new Endereco("Rua Bahia", 800, "Lourdes", "30160-011", cidadeBH);
            Endereco endereco15 = new Endereco("Avenida do Contorno", 450, "Funcionários", "30110-002", cidadeBH);
            Endereco endereco16 = new Endereco("Rua das Pedras", 300, "Pelourinho", "40020-001", cidadeSalvador);
            Endereco endereco17 = new Endereco("Avenida Sete de Setembro", 700, "Campo Grande", "40080-002", cidadeSalvador);
            Endereco endereco18 = new Endereco("Rua da Paciência", 102, "Rio Vermelho", "41940-010", cidadeSalvador);
            Endereco endereco19 = new Endereco("Rua Miguel Burnier", 300, "Graça", "40150-001", cidadeSalvador);
            Endereco endereco20 = new Endereco("Avenida Oceânica", 900, "Ondina", "40140-130", cidadeSalvador);

            Cliente cliente1 = new Cliente("João Silva", 40, "123.456.789-01", endereco16, "senha123");
            cliente1.Email = "joaosilva@email.com";
            Cliente cliente2 = new Cliente("Maria Oliveira", 30, "234.567.890-12", endereco11, "senha456");
            cliente2.Email = "mariaoliveira@email.com";
            Cliente cliente3 = new Cliente("Carlos Souza", 25, "345.678.901-23", endereco1, "senha789");
            cliente3.Email = "carlossouza@email.com";
            Cliente cliente4 = new Cliente("Ana Costa", 28, "456.789.012-34", endereco2, "senha101");
            cliente4.Email = "anacosta@email.com";
            Cliente cliente5 = new Cliente("Felipe Almeida", 35, "567.890.123-45", endereco3, "senha112");
            cliente5.Email = "felipealmeida@email.com";

            List<Cliente> clientes = new List<Cliente>() { cliente1, cliente2, cliente3, cliente4, cliente5 };


            Analista analista1 = new Analista(5000, "Lucas Pereira", 30, "123.456.789-01", endereco19, "senha123");
            analista1.Email = "lucaspereira.analista@email.com";
            Analista analista2 = new Analista(5500, "Cláudia Santos", 28, "234.567.890-12", endereco20, "senha456");
            analista2.Email = "claudiasantos.analista@email.com";

            Vendedor vendedor1 = new Vendedor(3000, "Roberto Lima", 25, "345.678.901-23", endereco12, "senha789");
            vendedor1.Email = "robertolima.vendedor@email.com";
            Vendedor vendedor2 = new Vendedor(3500, "Tatiane Souza", 28, "456.789.012-34", endereco7, "senha101");
            vendedor2.Email = "tatianesouza.vendedor@email.com";
            Vendedor vendedor3 = new Vendedor(4000, "Gustavo Costa", 35, "567.890.123-45", endereco5, "senha112");
            vendedor3.Email = "gustavocosta.vendedor@email.com";

            List<ItemVenda> listaDeItensVendas = new List<ItemVenda>();
            List<Venda> listaDeVendas = new List<Venda>();

            Cliente clienteLogado = null;

            #endregion
            Inicio();

            void Inicio()
            {
                new InterfaceInicio().IniciarInterface();

                try
                {
                    int tecla = -1;
                    bool entradaValida = false;

                    while (!entradaValida)
                    {
                        tecla = int.Parse(Console.ReadLine());
                        if ((tecla == 1) || (tecla == 2) || (tecla == 3) || (tecla == 4))
                        {
                            entradaValida = true;
                            switch (tecla)
                            {
                                case 1:
                                    ExibirTelaAnalista();
                                    break;
                                case 2:
                                    ExibirTelaVendedor();
                                    break;
                                case 3:
                                    ExibirTelaCliente();
                                    break;
                                case 4:
                                    Console.Clear();
                                    foreach (char letter in "......Saindo.......")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(50);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida, por favor escolha um número entre 1 a 4");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nPor favor, digite apenas os números entre 1 a 4");
                        }
                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("\nPor favor, digite apenas os números 1, 2, 3 ou 4.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Inicio();
                }


                void ExibirTelaCliente()
                {
                    Console.Clear();
                    new InterfaceCliente().Imprimir();
                    try
                    {
                        string email = "";
                        string senha = "";
                        bool permitido = false;
                        Console.WriteLine("\n\n");
                        Console.Write("Email: ");
                        email = Console.ReadLine();
                        Console.Write($"Senha: ");
                        senha = Console.ReadLine();
                        foreach (var cliente in clientes)
                        {
                            if (cliente.Autenticar(email, senha))
                            {
                                clienteLogado = cliente;
                                permitido = true;
                                break;
                            }
                        }

                        if (permitido)
                        {
                            Console.Clear();
                            ClienteMenu();
                        }
                        else
                        {
                            Console.WriteLine("Email e/ou Senha Incorreta!");
                            Thread.Sleep(1000);
                            ExibirTelaCliente();
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("ERROOOOO");
                    }
                }

                static void ExibirTelaVendedor()
                {
                    Console.Clear();
                    new InterfaceVendedor().Imprimir();
                    Console.WriteLine("Vendedor");
                }

                static void ExibirTelaAnalista()
                {
                    Console.Clear();
                    new InterfaceAnalista().Imprimir();
                    Console.WriteLine("Analista");
                }

                void ClienteMenu()
                {
                    new InterfaceCliente().Menu();
                    try
                    {
                        int tecla = -1;
                        tecla = int.Parse(Console.ReadLine());
                        if ((tecla == 1) || (tecla == 2) || (tecla == 3) || (tecla == 4) || (tecla == 5) || (tecla == 6))
                        {
                            switch (tecla)
                            {
                                case 1:
                                    new ClienteService().ConsultarProdutos(estoque);
                                    ClienteMenu();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.Write("Digite o nome do produto: ");
                                    string nome = Console.ReadLine();
                                    new ClienteService().ConsultarProdutoPorNome(estoque, nome);
                                    Console.WriteLine($"Pressione Enter para sair...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    ClienteMenu();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Digite o nome do produto: ");
                                    string nomep = Console.ReadLine();
                                    new ClienteService().ConsultarProdutoPorNome(estoque, nomep);
                                    Console.Write("Quantidade: ");
                                    int qtd = int.Parse(Console.ReadLine());
                                    listaDeItensVendas.Add(new ClienteService().AdicionarProdutoNoCarrinho(estoque, nomep, qtd));
                                    Console.Clear();
                                    foreach (char letter in "......Item Adicionado com Sucesso!.......")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(50);
                                    }
                                    Console.Clear();
                                    ClienteMenu();
                                    break;
                                case 4:
                                    Console.Clear();
                                    new ClienteService().ListarCarrinho(listaDeItensVendas);
                                    ClienteMenu();
                                    break;
                                case 5:
                                    Console.Clear();
                                    listaDeVendas.Add(new ClienteService().FinalizarCompra(clienteLogado, listaDeItensVendas));
                                    listaDeItensVendas.Clear();
                                    ClienteMenu();
                                    break;
                                case 6:
                                    Console.Clear();
                                    foreach (char letter in "......Saindo.......")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(50);
                                    }
                                    Inicio();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida, por favor escolha um número entre 1 a 6");
                                    Inicio();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nPor favor, digite apenas os números 1, 2, 3 ou 4.");
                        }



                    }
                    catch (Exception)
                    {

                        Console.WriteLine("\nPor favor, digite apenas os números 1, 2, 3 ou 4."); ;
                    }
                }
            }

        }

    }
}
