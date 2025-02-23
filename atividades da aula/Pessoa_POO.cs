using System;

class pessoa {
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

class HelloWorld {
  static void Main() {
    
    pessoa p1 = new pessoa();
    p1.nome = "Filipe";
    p1.idade = 20;
    p1.cargo = "Estagiário";
    p1.apresentar();
    Console.WriteLine($"O salário de {p1.nome} é {p1.salario()}\n");
    
    pessoa p2 = new pessoa();
    p2.nome = "Caio";
    p2.idade = 24;
    p2.cargo = "Desenvolvedor";
    p2.apresentar();
    Console.WriteLine($"O salário de {p2.nome} é {p2.salario()}\n");
    
    pessoa p3 = new pessoa();
    p3.nome = "Uilian";
    p3.idade = 32;
    p3.cargo = "Gerente";
    p3.apresentar();
    Console.WriteLine($"O salário de {p3.nome} é {p3.salario()}\n");
  }
}