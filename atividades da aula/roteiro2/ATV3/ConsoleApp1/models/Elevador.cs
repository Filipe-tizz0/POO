public class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int total)
    {
        this.totalAndares = total;
    }

    public int AndarAtual
    {
        get { return andarAtual; }
        set
        {
            this.andarAtual = value;
        }
    }

    public void Subir() {
        if (andarAtual + 1 > totalAndares) {
            Console.WriteLine("Você já está no último andar");
        } else {
            andarAtual += 1;
        }
    }
    public void Descer() {
        if (andarAtual - 1 < 0) {
            Console.WriteLine("Você já está no primeiro andar");
        } else {
            andarAtual -= 1;
        }
    }
}