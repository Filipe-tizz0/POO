using System;

class Retangulo {
  public int area;
}

class Pessoa {
  public string nome;
}

class Program {
  public static void Main () {

    //1° - Tipos de variável primitivas 
    int a = 1;
    int b = a;

    Console.WriteLine($" a = {a}\n b = {b}\n");
    b = 2;
    Console.WriteLine($"Pós mudança:\n a = {a}\n b = {b}\n");

    //1° - Tipos de variáveis de referência

    Retangulo r1 = new Retangulo();
    r1.area = 12;

    Retangulo r2 = r1;

    Console.WriteLine($" r1.area = {r1.area}\n r2.area = {r2.area}\n");
    r1.area = 24;
    Console.WriteLine($"Pós mudança:\n r1.area = {r1.area}\n r2.area = {r2.area}\n");


    //2° - Correção
    object obj = "123";
    string str = (string)obj;
    int x = int.Parse(str);
    Console.WriteLine($" = {x}");

    //Dupla 1°
    int z = 1;
    int y = z;

    Console.WriteLine($" a = {z}\n b = {y}\n");
    y = 2;
    Console.WriteLine($"Pós mudança:\n a = {z}\n b = {y}\n");

    //Dupla 2°
    Pessoa p1 = new Pessoa();
    p1.nome = "Wyndersson";
    Pessoa p2 = p1;
    Console.WriteLine($" p1.nome = {p1.nome}\n p2.nome = {p2.nome}\n");
    p2.nome = "Uylian";
    Console.WriteLine($" p1.nome = {p1.nome}\n p2.nome = {p2.nome}\n");

    //Dupla 3°
    double n = 6.9;
    int m = (int)n;
    Console.WriteLine(m);
    
    //Dupla 4° 
    Console.WriteLine("Digite um número:");
    string str_num = Console.ReadLine();
    
    if (int.TryParse(str_num, out int numero)) {
      Console.WriteLine($"Sucesso. Número digitado: {numero}");
    }else{
      Console.WriteLine("Valor digitado inválido");
    }

  }
}