ExibirCabecalho();

var produtosDisponiveis = new List<Produto>()
{
    new Produto() { Codigo = 1, Descricao = "Camisa P", Preco = 40},
    new Produto() { Codigo = 2, Descricao = "Camisa M", Preco = 45},
    new Produto() { Codigo = 3, Descricao = "Camisa G", Preco = 50},
    new Produto() { Codigo = 4, Descricao = "Camisa GG", Preco = 55}
};

var carrinho = new Carrinho();

string opcao = "";

while (opcao != "F")
{
    Console.Write("\n[P]rodutos, [A]dicionar, [C]arrinho, [L]impar, [F]inalizar: ");
    opcao = Console.ReadLine()!.ToUpper().Trim().Substring(0, 1);

    switch(opcao)
    {
        case "P":
            ExibirListaDeProdutos(produtosDisponiveis);
            break;
        case "A":
            AdicionarItemAoCarrinho(carrinho, produtosDisponiveis);
            break;
        case "L":
            carrinho.LimparCarrinho();
            break;
        case "F":
        case "C":
            ExibirCarrinho(carrinho);
            break;
        default:
            Console.WriteLine("Opcão inválida!");
            break;
    }
}

void ExibirListaDeProdutos(List<Produto> produtos)
{
    Console.WriteLine($"| Código | Descrição    | Valor unitário |");
    Console.WriteLine($"| ------ | ------------ | -------------- |");

    produtos.ForEach(produto => {
        Console.WriteLine($"| {produto.Codigo}      | {produto.Descricao}    | {produto.Preco:C2}       |");    
    });
}

void AdicionarItemAoCarrinho(Carrinho carrinho, List<Produto> produtos)
{
    Console.Write("Código......:");
    int codigo = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Quantidade..:");
    int quantidade = Convert.ToInt32(Console.ReadLine()!);

    var produto = produtos.Find(produto => produto.Codigo == codigo);

    if (produto == null)
    {
        Console.WriteLine("Produto não encontrado");
        return;
    }

    if (quantidade <=0)
    {
        Console.WriteLine("Quantidade inválida");
        return;
    }

    carrinho.AdicionarItemAoCarrinho(produto, quantidade);

    Console.WriteLine("Item adicionado com sucesso!\n\n");
}

void ExibirCarrinho(Carrinho carrinho)
{
    ExibirCabecalho();
    decimal total = 0;
    carrinho.Itens.ForEach(item => {
        var totalItem = item.Produto.Preco * item.Quantidade;
        total += totalItem;
        Console.WriteLine($"{item.Quantidade} x {item.Produto.Descricao} = {totalItem:C2}");
    });
    
    Console.WriteLine($"\nTotal = {total:C2}");
}

void ExibirCabecalho()
{
    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("---- Carrinho de Compras ----");
    Console.WriteLine("-----------------------------");
}