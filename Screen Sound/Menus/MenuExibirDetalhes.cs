using ScreenSound.Model;
namespace ScreenSound.Menus;

internal class MenuExibirDetalhes
{
    public void exibir(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Digite o nome da banda que deseja exibir os detalhes");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.WriteLine($"A media de avaliações da banda {nomeBanda} é de {banda.Media}");
            Console.WriteLine("\nDiscografia:");
            foreach (Album album in banda.albums)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("Aperte uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else 
        { 
            Console.WriteLine("Banda nao encontrada!!");
            Console.WriteLine("Voltando ao menu principal");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
