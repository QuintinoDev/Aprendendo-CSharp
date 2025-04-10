using ScreenSound.Model;

namespace ScreenSound.Menus;

internal class MenuListaDeBandas
{
    public void Exibir(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Lista de bandas: \n");
        //Comando para percorrer uma lista imprimindo ela, coloco uma varivel na frente e associar a cada coisa dentro da lista
        foreach (string bandas in bandasRegistradas.Keys)//Como estamos usando Dictionary, conseguimos percorrer so por dentro das chaves(Nome das bandas) dele.
        {
            Console.WriteLine($"Banda:{bandas}");
        }
        Console.WriteLine("\nAperte qualquer tecla para voltar para o menu.");
        //Comando para deixar o codigo parado ate uma tecla ser acionada e o codigo proceguir
        Console.ReadKey();
        Console.Clear();
    }
}
