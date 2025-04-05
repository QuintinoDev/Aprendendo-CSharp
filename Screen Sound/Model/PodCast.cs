class PodCast
{
    public string Host { get;}
    public string Nome { get;}
    public int TotalEpisodios => episodios.Count;

    private List<Episodio> episodios = new List<Episodio> ();

    public void AdicionarEpisodi(Episodio episodio)
    {
        episodios.Add(episodio);  
    }

    public PodCast(string host, string nome) 
    { 
        this.Host = host;
        this.Nome = nome;
    }

    public void ExibirDetalhes() 
    {
        Console.WriteLine($"Pod Cast: {Nome}, Host:{Host}");
        foreach (var episode in episodios)
        { 
            Console.WriteLine($"Episodio: {episode}");
        }
        Console.WriteLine($"Esse PodCast tem um total de: {TotalEpisodios}");
    }

}