abstract class Funcionario
{
    public decimal salario
    {
        get; set;
    }
    public decimal CalcularSalario()
    {
        return salario *= 10;
    }
}