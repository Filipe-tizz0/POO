public class Cartao : Pagamento
{
    public override string ProcessarPagamento()
    {
        return "Pagamento em cartão de crédito";
    }
}