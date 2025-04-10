namespace ScreenSound.Model;
internal class Album : IAvaliavel
{
    private List<Musica> musicas = new();
    private List<Avaliacao> notas = new(); 

    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);//Lambida para resumir metodo de soma de duração de musica
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public Album(string nome) 
    { 
        this.Nome = nome;
    }
    public void AdicionarMusica(Musica musica) 
    { 
        musicas.Add(musica);
    }
    public void ExibirMusicasAlbum() 
    {
        Console.WriteLine($"Lista de Musicas do Album {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musicas: {musica.Nome}");
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}