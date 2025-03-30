// See https://aka.ms/new-console-template for more information
 Pessoa p1 = new Pessoa();
    p1.nome = "Filipe";
    p1.idade = 20;
    p1.cargo = "Estagiário";
    p1.apresentar();
    Console.WriteLine($"O salário de {p1.nome} é {p1.salario()}\n");
    
    Pessoa p2 = new Pessoa();
    p2.nome = "Caio";
    p2.idade = 24;
    p2.cargo = "Desenvolvedor";
    p2.apresentar();
    Console.WriteLine($"O salário de {p2.nome} é {p2.salario()}\n");
    
    Pessoa p3 = new Pessoa();
    p3.nome = "Uilian";
    p3.idade = 32;
    p3.cargo = "Gerente";
    p3.apresentar();
    Console.WriteLine($"O salário de {p3.nome} é {p3.salario()}\n");