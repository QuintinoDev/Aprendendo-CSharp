namespace ScreenSound.Model;

internal class Avaliacao//Inrernal, quando queremos que somente nosso projeto tenha acesso a nossa classe
{
    public int Nota { get;}

    public Avaliacao(int nota) 
    { 
        Nota = nota; 
    }

    public static Avaliacao Parse(string texto) 
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
