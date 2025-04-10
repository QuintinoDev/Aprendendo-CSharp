using ScreenSound.Model;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda
{
    public void Exibir(Dictionary<string, Model.Banda> bandasRegistradas)
    {
        //Com esse comando consigo limpar meu console
        Console.Clear();
        Console.Write("Digite o nome da banda que deseja registra: ");
        string nomeBanda = Console.ReadLine()!;
        //Dentro do Dictionary tambem temos o comando de add, mas como nesse metodo estamos adicionando somente o nome, estamos passando uma lista vazia de avalizações
        Banda banda = new Banda(nomeBanda);
        bandasRegistradas.Add(banda.Nome, banda);
        Console.WriteLine($"Voce registrou a banda {nomeBanda}");
        //Com esse comando consigo fazer com que meu codigo demore um pouco no console antes de ser executado
        Thread.Sleep(2000);
        Console.Clear();
    }
}
