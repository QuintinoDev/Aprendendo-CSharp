class Episodio
{
    private List<string> convidados = new();
    public int Duracao { get;}
    public int Ordem { get;}
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: {string.Join(", ", convidados)}";
    public string Titulo { get;}

    public Episodio(int ordem, string titulo, int duracao)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }
    public void AdicionarConvidados(string convidado) 
    {
        convidados.Add(convidado);
    }


}