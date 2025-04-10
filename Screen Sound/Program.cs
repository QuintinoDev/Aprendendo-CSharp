using ScreenSound.Menus;
using ScreenSound.Model;
//Quando usamos a classe program zerada ela vem com esse metodo oculto
internal class Program
{
    private static void Main(string[] args)
    {
        Banda banda1 = new("Bonde da Stronda");
        banda1.AdicionarNota(new Avaliacao(10));
        banda1.AdicionarNota(new Avaliacao(8));
        banda1.AdicionarNota(new Avaliacao(6));
        Banda banda2 = new("Tribo da Periferia");

        //Dicionario, consigo salvar as chaves no caso nome das bansdas, e colocar o valor das notas delas, de acordo com que são valiadas
        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(banda1.Nome, banda1);
        bandasRegistradas.Add(banda2.Nome, banda2);

        //Forma de fazer um metodo(Função) em C#, so declara o retorno dele e o nome
        void DarBoasVindas()
        {
            Console.WriteLine("BEM VINDO AO SPOTFY");
        }
        void Menu()
        {

            int opcaoInteira = 0;
            while (opcaoInteira != 8)
            {
                DarBoasVindas();
                Console.WriteLine("\n1 - Registrar um banda.");
                Console.WriteLine("2 - Lista de Bandas.");
                Console.WriteLine("3 - Mostra media de avaliações de uma banda.");
                Console.WriteLine("4 - Para avaliar uma banda.");
                Console.WriteLine("5 - Registrar um Album.");
                Console.WriteLine("6 - Exibir detalhes de uma banda.");
                Console.WriteLine("7 - Para avaiar um album");
                Console.WriteLine("8 - Sair.");
                //Quando se coloca so Write ele nao pula linha e continua aparecendo a string
                Console.Write("\nDigitite a opção escolhida: ");
                //O ReadLine() so consegue ler string mas, passamos ele para int assim que colocamos dele dentro de int.Parse() 
                opcaoInteira = int.Parse(Console.ReadLine()!);//Esse ! é para não recebermos valore nulos
                switch (opcaoInteira)
                {
                    case 1:
                        MenuRegistrarBanda registrarBanda = new();
                        registrarBanda.Exibir(bandasRegistradas);
                        break;
                    case 2:
                        MenuListaDeBandas listaDeBandas = new();
                        listaDeBandas.Exibir(bandasRegistradas);
                        break;
                    case 3:
                        MenuMediaNotasBandas mediaNotasBandas = new();
                        mediaNotasBandas.exibir(bandasRegistradas);
                        break;
                    case 4:
                        MenuAvaliarBanda avaliarBanda = new();
                        avaliarBanda.exibir(bandasRegistradas);
                        break;
                    case 5:
                        MenuRegitrarAlbum registrarAlbum = new();
                        registrarAlbum.exibir(bandasRegistradas);
                        break;
                    case 6:
                        MenuExibirDetalhes exibirDetalhes = new();
                        exibirDetalhes.exibir();
                        break;
                    case 7:
                        MenuAvaliarAlbum avaliarAlbum = new();
                        avaliarAlbum.exibir(bandasRegistradas);
                        break;
                    case 8:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção digita invalida");
                        break;
                }
            }
        }
        Menu();
    }
}