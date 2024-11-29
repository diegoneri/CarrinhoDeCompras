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

string opcao = "";

while (opcao != "FINALIZAR")
{
    Console.Write("\n[P]rodutos, [A]dicionar, [C]arrinho, [L]impar, [F]inalizar: ");
    opcao = Console.ReadLine()!.ToUpper().Trim().Substring(0, 1);

    switch(opcao)
    {
        case "P":
            ExibirListaDeProdutos(produtosDisponiveis);
            break;
        case "A":
        case "C":
        case "L":
        case "F":
            Console.WriteLine("Funcionalidade em construção...");
            break;        
        default:
            Console.WriteLine("Opcão inválida!");
            break;
    }
}

void ExibirListaDeProdutos(List<Produto> produtos)
{
    Console.WriteLine($"| Código | Descrição   | Valor unitário |");
    Console.WriteLine($"| ------ | ----------- | -------------- |");

    produtos.ForEach(produto => {
        Console.WriteLine($"| {produto.Codigo}      | {produto.Descricao}    | {produto.Preco:C2}       |");    
    });
}
