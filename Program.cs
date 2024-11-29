Console.WriteLine("-----------------------------");
Console.WriteLine("---- Carrinho de Compras ----");
Console.WriteLine("-----------------------------");

var produtosDisponiveis = new List<Produto>()
{
    new Produto() { Codigo = 1, Descricao = "Camisa P", Preco = 40},
    new Produto() { Codigo = 2, Descricao = "Camisa M", Preco = 45},
    new Produto() { Codigo = 3, Descricao = "Camisa G", Preco = 50},
    new Produto() { Codigo = 4, Descricao = "Camisa GG", Preco = 55}
};

ExibirListaDeProdutos(produtosDisponiveis);

void ExibirListaDeProdutos(List<Produto> produtos)
{
    Console.WriteLine($"| Código | Descrição   | Valor unitário |");
    Console.WriteLine($"| ------ | ----------- | -------------- |");

    produtos.ForEach(produto => {
        Console.WriteLine($"| {produto.Codigo}      | {produto.Descricao}    | {produto.Preco:C2}       |");    
    });

    // for (int i = 0; i < produtosDisponiveis.Count; i++)
    // {
    //     Produto produto = produtosDisponiveis[i];
    //     Console.WriteLine($"| {produto.Codigo}   | {produto.Descricao}  | {produto.Preco:C2} |");    
    // }

    // foreach(var produto in produtos)
    // {
    //     Console.WriteLine($"| {produto.Codigo}   | {produto.Descricao}  | {produto.Preco:C2} |");    
    // } 
}
