public class Produto
{
    private string nome;
    private double preco;

    public Produto(string Nome, double Preco) {
        this.nome = Nome;
        if (Preco > 0) {
            this.preco = Preco;
        } else {
            Console.WriteLine("Valor menor ou igual a 0");
        }
    }

    public void ExibirDetalhes() {
        Console.WriteLine($"Nome: {nome}, Preço: {preco}");
    }
}