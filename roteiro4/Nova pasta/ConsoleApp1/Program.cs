// See https://aka.ms/new-console-template for more information

Pix p = new Pix();
Cartao c = new Cartao();
Boleto b = new Boleto();

Console.WriteLine(p.ProcessarPagamento());
Console.WriteLine(c.ProcessarPagamento());
Console.WriteLine(b.ProcessarPagamento());