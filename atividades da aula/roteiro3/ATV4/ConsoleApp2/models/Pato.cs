public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato pode Voar,");
    }
    public void Nadar()
    {
        Console.WriteLine("Também pode voar   :O");
    }

    public void VoareNadar(){
        this.Voar();
        this.Nadar();
    }
}