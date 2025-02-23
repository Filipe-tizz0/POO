using System;

class fantasma {
    public string habilidade;
    public string cor;
    public string nick;
    
    public string mover (string direcao) {
        return $"O fantasma {nick} está indo para {direcao}";
    }
    
    public void gerar_fantasma () {
        Console.WriteLine($"fantasma: {nick}, Cor: [cor], Habilidade: {habilidade}");
    }
}

class HelloWorld {
  static void Main() {
    
    fantasma f1 = new fantasma();
    f1.nick = "Incky";
    f1.cor = "azul";
    f1.habilidade = "inteligencia";
    f1.gerar_fantasma();
    Console.WriteLine(f1.mover("direita"));
  }
}