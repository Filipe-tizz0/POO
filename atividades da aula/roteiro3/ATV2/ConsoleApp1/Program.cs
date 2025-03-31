// See https://aka.ms/new-console-template for more information
Pedido p = new Pedido();

p.item.nome = "Queijo";
p.item.origem = "Nacional";
p.item.preco = 15.60m;
p.quantComprada = 6;

Console.WriteLine(p.item.apresentarItem());
Console.WriteLine($"O valor total da compra foi: {p.GetValorTotal()}");
