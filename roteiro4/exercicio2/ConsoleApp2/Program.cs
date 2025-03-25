// See https://aka.ms/new-console-template for more information
Gerente g = new Gerente {salario = 15129.79};
Programador p = new Programador {salario = 1880.25};

Console.WriteLine($"Salário do gerente é R$ {g.CalcularSalario()}");
Console.WriteLine($"Salário do progrmador é R$ {p.CalcularSalario()}");