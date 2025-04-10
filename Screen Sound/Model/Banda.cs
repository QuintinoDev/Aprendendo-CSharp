namespace ScreenSound.Model;
internal class Banda : IAvaliavel
{ 
    public List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new ();
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);//Fizemos um metodo get com paramentros mesmo nem precisar declarar um metodo completo
        }
    }
    public string Nome { get; set; }

    public Banda(string Nome) 
    {
        this.Nome = Nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia() 
    {
        Console.WriteLine($"Exibindo Discografia da banda {Nome}");
        foreach (Album album in albums) 
        {
            Console.WriteLine($"Álbum: {album.Nome}, com duração de {album.DuracaoTotal}");
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}