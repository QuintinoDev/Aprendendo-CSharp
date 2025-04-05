class Banda 
{ 
    private List<Album> albums = new List<Album>();
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

}