public class Fantasmas {
    public string habilidade;
    public string cor;
    public string nick;
    
    public string mover (string direcao) {
        return $"O fantasma {nick} está indo para {direcao}";
    }
    
    public void gerar_fantasma () {
        Console.WriteLine($"fantasma: {nick}, Cor: {cor}, Habilidade: {habilidade}");
    }
}