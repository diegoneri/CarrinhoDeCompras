public class Carrinho
{
    public List<ItemDoCarrinho> Itens = new();

    public void AdicionarItemAoCarrinho(Produto produto, int quantidade)
    {
        var produtoNoCarrinho = Itens.Find(item => item.Produto == produto);

        if (produtoNoCarrinho != null)
        {
            produtoNoCarrinho.Quantidade += quantidade;
        }
        else
        {
            Itens.Add(new ItemDoCarrinho() {Produto = produto, Quantidade = quantidade});
        }
    }

    public void LimparCarrinho()
    {
        Itens.Clear();
    }
}