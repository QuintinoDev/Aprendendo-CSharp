  class Musica 
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    //Boleano no C#
    public bool Disponivel { get; set;}//Jeito de escrever metodos Get e Set, seu atributo precisa ser publico, e agr ele vira PascalCase
    public string Descricao =>//Quando querermos ter somento um get para uma propiedade usamos o Lambida, que ai colocamos na frente somente oque queremos mostrar
        $"O nome da musica é {Nome}, e o artista é {Artista}";


    public Musica (string nome, string artista, int duracao)
    {
        this.Nome = nome;
        this.Artista = artista;
        this.Duracao = duracao;
    }
    public void ExibirFichaMusica() 
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duração:{Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Musica disponivel");
        }
        else
        {
            Console.WriteLine("Compre o plano plus+");
        }
    }  
}

