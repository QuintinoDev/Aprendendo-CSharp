class Album
{
    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);//Lambida para resumir metodo de soma de duração de musica

    private List<Musica> musicas = new List<Musica>();

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

    //Metodo inteiro resumido em uma Lambida
    //public int DuracaoAlbum()
    //{
       // foreach (var musica in musicas)
        //{
            //DuracaoTotal += musica.Duracao;
            
        //}
        //return DuracaoTotal;
    //}
}