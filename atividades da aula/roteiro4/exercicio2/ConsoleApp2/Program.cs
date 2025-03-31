// See https://aka.ms/new-console-template for more information
Gerente g = new Gerente {salario = 1500.79m};
Programador p = new Programador {salario = 188.25m};

Console.WriteLine($"Salário do gerente é R$ {g.CalcularSalario()}");
Console.WriteLine($"Salário do progrmador é R$ {p.CalcularSalario()}");