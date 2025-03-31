public class Cartao : IPagamento
{
    public override string ProcessarPagamento()
    {
        return "Pagamento em cartão de crédito";
    }
}