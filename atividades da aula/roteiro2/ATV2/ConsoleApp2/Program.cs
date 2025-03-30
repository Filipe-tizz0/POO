// See https://aka.ms/new-console-template for more information
Carro c = new Carro("Ferrari");
c.Acelerar(50);
Console.WriteLine(c.Velocidade); // Deve exibir 50
c.Frear(30);
Console.WriteLine(c.Velocidade); // Deve exibir 20
c.Frear(50);
Console.WriteLine(c.Velocidade);
