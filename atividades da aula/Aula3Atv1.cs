using System;

class Produto {
    private string nome;
    public string Nome {
        get {
            return nome; 
        }
    }
    
    private decimal preco;
    public decimal Preco {
        get {
            return preco;
        }
    }
    
    public void set_preco (decimal p) {
            if (p >= 0) {
                this.preco = p;
            } else {
                Console.WriteLine("Erro, preço menor que 0");
            }
    }
    
    public Produto (string n, decimal p) {
        this.nome = n;
        if (p>=0) {
            this.preco = p;
        } else {
            Console.WriteLine("Erro, preço menor que 0");
        }
    }
    
    public void apresentar () {
        Console.WriteLine($"{nome} , {preco}");
    }
}

class HelloWorld {
  static void Main() {
    Produto p1 = new Produto("Celular", 1500);
    p1.apresentar();
    p1.set_preco(-200);
  }
}