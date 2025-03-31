public class Animal
{
    public string Som;

    public void EmitirSomGenerico()
    {
        Console.WriteLine($"Som genérico de um animal");
    }

    public void EmitirSom()
    {
        Console.WriteLine($"{this.Som}");
    }
}