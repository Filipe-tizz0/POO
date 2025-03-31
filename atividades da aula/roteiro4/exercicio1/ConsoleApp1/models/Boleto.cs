public class Boleto : IPagamento
{
    public override string ProcessarPagamento()
    {
        return "Pagamento em boleto";
    }
}