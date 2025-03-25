public class Boleto : Pagamento
{
    public override string ProcessarPagamento()
    {
        return "Pagamento em boleto";
    }
}