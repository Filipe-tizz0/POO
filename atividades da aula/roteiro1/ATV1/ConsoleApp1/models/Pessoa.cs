public class Pessoa {
    public string nome;
    public int idade;
    public string cargo;
    
    public int salario () {
        if (cargo == "Gerente"){
            return 10000;
        }
        
        if (cargo == "Desenvolvedor"){
            return 5000;
        }
        
        if (cargo == "Estagiário"){
            return 100;
        }
        
        return 0;
    }
    
    public void apresentar () {
        Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
    }
}