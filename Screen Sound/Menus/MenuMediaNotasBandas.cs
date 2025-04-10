
using ScreenSound.Model;

namespace ScreenSound.Menus;

internal class MenuMediaNotasBandas
{
    internal void exibir(Dictionary<string, Model.Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.Write("Digite o nome da banda para exibir a media: ");
        var nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            //Salvando o nome da banda com suas notas em uma variavel
            Banda banda = bandasRegistradas[nomeBanda];
            //Exibindo a media de notas ja calculada, com a função Average().
            Console.WriteLine($"\nA media de nota da sua banda é de: {banda.Media}");
            Console.WriteLine("\nPrecione alguma tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Banda não encontrada!");
            Console.WriteLine("Vontando para menu principal...");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
