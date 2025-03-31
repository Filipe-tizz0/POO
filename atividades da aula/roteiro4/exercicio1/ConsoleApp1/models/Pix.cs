public class Pix : IPagamento
{
    public override string ProcessarPagamento()
    {
        return "Pagamento em pix";
    }
}