using ScreenSound.Model;

namespace ScreenSound.Menus
{
    public class MenuAvaliarBanda
    {
        internal void exibir(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                //Com esse [] estou associando no meu dicionario o nome da banda, e com isso incluindo a ela uma nota 
                Banda banda = bandasRegistradas[nomeBanda];
                Console.WriteLine($"De uma nota para a banda {nomeBanda}");
                Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                banda.AdicionarNota(avaliacao);
                Console.WriteLine($"A nota {avaliacao.Nota} foi atribuida a banda {nomeBanda}");
                Console.WriteLine("\nAperte alguma tecla para voltar ao menu principal");
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
}
