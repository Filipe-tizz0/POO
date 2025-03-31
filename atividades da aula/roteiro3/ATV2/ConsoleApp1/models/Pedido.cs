public class Pedido
{
    public Item item = new Item();
    public int quantComprada;
    private decimal valorTotal => item.preco * quantComprada;
    public decimal GetValorTotal() {
        return valorTotal;
    }

}