public class Item
{
    public string nome;
    public string origem;

    public decimal preco;
    public string apresentarItem()
    {
        return $"{nome} e {origem}";
    }
}