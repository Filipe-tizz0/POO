public class Carro
{
    private string modelo;

    private int velocidade;
    public int Velocidade {
        get { return velocidade;}
        set {
            if (value >= 0) {
                velocidade = value;
            }
        }
    }

    public Carro(string Modelo) {
        this.modelo = Modelo;
    }

    public void Acelerar(int vel) {
        velocidade += vel;
    }

    public void Frear(int vel) {
        if (this.velocidade - vel > 0) {
            this.velocidade -= vel;
        } else {
            velocidade = 0;
            Console.WriteLine("Velocidade não pode ser menor que 0");
        }
    }
}