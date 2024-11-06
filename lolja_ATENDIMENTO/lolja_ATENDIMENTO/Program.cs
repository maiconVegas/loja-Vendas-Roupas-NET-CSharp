using lolja_MODELOS.lolja.Modelos.Models.Produtos;



// Teste 1 //

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


//Produto camisaAnime = new Produto("Camisa Demon Slayer", 39.90, "G", new Categoria("Roupas Animes", "Roupas para ilustrar animes"));
// Geração de 25 produtos utilizando os construtores
List<Produto> produtos = new List<Produto>();

// 25 produtos, distribuídos entre as categorias
produtos.Add(new Produto("Camiseta Anime", "Camiseta com estampa do anime Demon Slayer", 39.90, "G", "Azul", camisetas));
produtos.Add(new Produto("Camiseta Batman", "Camiseta com estampa do Batman", 49.90, "M", "Preto", camisetas));
produtos.Add(new Produto("Camiseta Star Wars", "Camiseta com estampa do Star Wars", 59.90, "P", "Branco", camisetas));
produtos.Add(new Produto("Jeans Slim", "Calça jeans modelo slim fit", 129.90, "M", "Azul", calcas));
produtos.Add(new Produto("Legging Fitness", "Legging preta para academia", 89.90, "G", "Preto", calcas));
produtos.Add(new Produto("Calça Moletom", "Calça de moletom confortável", 79.90, "M", "Cinza", calcas));
produtos.Add(new Produto("Vestido Floral", "Vestido com estampa floral, ideal para o verão", 149.90, "P", "Rosa", vestidos));
produtos.Add(new Produto("Vestido Longo", "Vestido longo com detalhes em renda", 199.90, "G", "Branco", vestidos));
produtos.Add(new Produto("Vestido Midi", "Vestido midi com detalhes em botões", 179.90, "M", "Preto", vestidos));
produtos.Add(new Produto("Blusa Cropped", "Blusa cropped de manga curta", 69.90, "M", "Azul", blusas));
produtos.Add(new Produto("Blusa de Frio", "Blusa de frio para o inverno", 119.90, "G", "Preto", blusas));
produtos.Add(new Produto("Blusa de Tricot", "Blusa de tricot para o inverno", 89.90, "M", "Bege", blusas));
produtos.Add(new Produto("Jaqueta Jeans", "Jaqueta jeans estilo oversized", 159.90, "G", "Azul", jaquetas));
produtos.Add(new Produto("Jaqueta de Couro", "Jaqueta de couro preta", 249.90, "M", "Preto", jaquetas));
produtos.Add(new Produto("Jaqueta Parka", "Jaqueta parka de inverno", 199.90, "P", "Verde", jaquetas));
produtos.Add(new Produto("Saia Jeans", "Saia jeans com lavagem escura", 89.90, "M", "Azul", saia));
produtos.Add(new Produto("Saia Midi", "Saia midi com cinto", 129.90, "G", "Bege", saia));
produtos.Add(new Produto("Saia Curta", "Saia curta de algodão", 69.90, "P", "Preto", saia));
produtos.Add(new Produto("Shorts Jeans", "Shorts jeans estilo destroyed", 79.90, "M", "Azul", shorts));
produtos.Add(new Produto("Shorts de Algodão", "Shorts de algodão para o verão", 59.90, "G", "Branco", shorts));
produtos.Add(new Produto("Shorts Esportivo", "Shorts esportivo para academia", 49.90, "P", "Preto", shorts));
produtos.Add(new Produto("Macacão Jeans", "Macacão jeans estilo urbano", 189.90, "M", "Azul", macacoes));
produtos.Add(new Produto("Macacão Floral", "Macacão floral feminino", 159.90, "G", "Rosa", macacoes));
produtos.Add(new Produto("Macacão Preto", "Macacão preto elegante", 249.90, "M", "Preto", macacoes));
produtos.Add(new Produto("Top de Esporte", "Top esportivo para academia", 39.90, "P", "Azul", roupaEsporte));
produtos.Add(new Produto("Legging Esportiva", "Legging esportiva com detalhe em neon", 79.90, "M", "Preto", roupaEsporte));
produtos.Add(new Produto("Shorts de Corrida", "Shorts de corrida com tecnologia de compressão", 89.90, "G", "Preto", roupaEsporte));
produtos.Add(new Produto("Sutiã Lingerie", "Sutiã de renda para lingerie", 49.90, "M", "Bege", intimos));
produtos.Add(new Produto("Calcinha Lingerie", "Calcinha de renda para lingerie", 29.90, "P", "Preto", intimos));

#region Testando Produtos

// Exibe os produtos criados
//foreach (var produto in produtos)
//{
//    Console.WriteLine($"Produto: {produto.Nome}");
//    Console.WriteLine($"Categoria: {produto.categoriaRoupa.Nome}");
//    Console.WriteLine($"Descrição: {produto.Descricao}");
//    Console.WriteLine($"Preço: {produto.Preco:C}");
//    Console.WriteLine($"Tamanho: {produto.Tamanho}");
//    Console.WriteLine($"Cor: {produto.Cor}");
//    Console.WriteLine();
//}

//Console.WriteLine(camisaAnime.ID_Produto);
//Console.WriteLine(camisaAnime.Nome);
//Console.WriteLine(camisaAnime.Preco);
//Console.WriteLine(camisaAnime.Tamanho);
//Console.WriteLine(camisaAnime.categoriaRoupa.ID_Categoria);
//Console.WriteLine(camisaAnime.categoriaRoupa.Nome);
//Console.WriteLine(camisaAnime.categoriaRoupa.Descricao);

/*
// Teste 2

Dictionary<string, int> dicionario;
dicionario = new Dictionary<string, int>();

dicionario.Add("AAA", 3);
Console.WriteLine(dicionario["AAA"]);
dicionario["AAA"] = dicionario["AAA"] - 1;
Console.WriteLine(dicionario["AAA"]);
foreach (var item in dicionario)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}
*/

/*
// teste 3
Produto blusaFrio = new Produto("Blusa de Frio", "Blusa de frio para o inverno", 119.90, "G", "Preto", blusas);
Produto legginfit = new Produto("Legging Fitness", "Legging preta para academia", 89.90, "G", "Preto", calcas);
Dictionary<Produto, int> estoquezin = new Dictionary<Produto, int>();
estoquezin.Add(blusaFrio, 99);
estoquezin.Add(legginfit, 10);
foreach (var item in estoquezin)
{
    Console.WriteLine(item.Key.Nome);
    Console.WriteLine(item.Key.Descricao);
    Console.WriteLine(item.Key.Preco);
    Console.WriteLine(item.Key.categoriaRoupa.Nome);
    Console.WriteLine(item.Value);

}
Console.WriteLine(estoquezin.ContainsKey(blusaFrio));
*/


//teste 4


Produto camisetaBatman = new Produto("Camiseta Batman", "Camiseta com estampa do Batman", 49.90, "M", "Preto", camisetas);
Produto camisetaAnime = new Produto("Camiseta Anime", "Camiseta com estampa do anime Demon Slayer", 39.90, "G", "Azul", camisetas);
Produto camisetaStarWars = new Produto("Camiseta Star Wars", "Camiseta com estampa do Star Wars", 59.90, "P", "Branco", camisetas);
Estoque estoque =  new Estoque();
estoque.AdicionarProduto(camisetaAnime, 12);
estoque.AdicionarProduto(camisetaBatman, 9);
estoque.AdicionarProduto(camisetaStarWars, 5);
estoque.AdicionarProduto(camisetaBatman, 1);
Console.WriteLine(estoque.ObterQuantidade(camisetaAnime));
Console.WriteLine(estoque.ObterQuantidade(camisetaBatman));
Console.WriteLine(estoque.ObterQuantidade(camisetaStarWars));
estoque.RemoverProduto(camisetaAnime, 2);
Console.WriteLine(estoque.ObterQuantidade(camisetaAnime));
Console.WriteLine(estoque.ObterQuantidade(camisetaBatman));
Console.WriteLine(estoque.ObterQuantidade(camisetaStarWars));

foreach (var item in estoque.Itens)
{
    Console.WriteLine(item.Key.Nome);
    Console.WriteLine(item.Key.Preco);
    Console.WriteLine(item.Value);
    Console.WriteLine();
}

#endregion

Console.WriteLine();