using ScreenSound.Model;

namespace ScreenSound.Menus
{
    internal class MenuRegitrarAlbum
    {
        public void exibir(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            Console.Write("Digite a banda cujo o álbum deseja registrar: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Console.Write("Digite o nome do album que deseja registrar: ");
                string nomeAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeBanda];
                banda.AdicionarAlbum(new Album(nomeAlbum));
                Console.WriteLine("Album cadastrado com Sucesso");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Banda nao encontrada!!!");
            }
        }
    }
}
