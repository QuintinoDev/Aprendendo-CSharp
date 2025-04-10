using ScreenSound.Model;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum
{
    public void exibir(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.Write("Digite o nome da banda que deseja avaliar o album: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            //Com esse [] estou associando no meu dicionario o nome da banda, e com isso incluindo a ela uma nota 
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write("Digite o nome do album que deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;
            if (banda.albums.Any(a => a.Nome.Equals(nomeAlbum)))
            {
                Album album = banda.albums.First(a => a.Nome.Equals(nomeAlbum));
                Console.WriteLine($"De uma nota para o album {nomeAlbum}");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine("Nota adicionada com sucesso!");
                Console.WriteLine("\nAperte alguma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Album não encontrado!");
                Console.WriteLine("Vontando para menu principal...");
                Thread.Sleep(1000);
                Console.Clear();
            }
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
