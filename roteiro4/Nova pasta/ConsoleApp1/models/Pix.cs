public class Pix : Pagamento
{
    public override string ProcessarPagamento()
    {
        return "Pagamento em pix";
    }
}