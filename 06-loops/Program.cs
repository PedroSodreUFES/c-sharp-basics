using System.ComponentModel;

namespace HelloWorld;

public class Program
{
    public static void Main()
    {
        // for loops
        Console.WriteLine("For loop:");
        var lista = new List<string> { "Sodré", "Vicente", "Francis", "Fábio", "Letícia" };

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        // for each
        Console.WriteLine("\nFor each em lista:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nFor each em dicionário:");
        var dicionario = new Dictionary<string, string>();
        dicionario.Add("nome1", "Sodré");
        dicionario.Add("nome2", "Letícia");
        dicionario.Add("nome3", "Vicente");
        foreach (var item in dicionario)
        {
            Console.WriteLine($"Chave:{item.Key} Valor:{item.Value}");
        }

        // while - checagem no inicio. - pode não executar: ex numero = 11
        Console.WriteLine("\nWhile:");
        var numero = 1;
        while (numero <= 10)
        {
            Console.WriteLine($"Teste {numero}");
            numero++;
        }

        // Do-While - checagem ao final
        Console.WriteLine("\nDo-While:");
        numero = 1;
        // sempre vai executar no mínimo 1 vez
        do
        {
            Console.WriteLine($"Teste {numero}");
            numero++;
        } while (numero < 1); // vai executar 1 vez, pois a checagem e só ao fim.
    }
}