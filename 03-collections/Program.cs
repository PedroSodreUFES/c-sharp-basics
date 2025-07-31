namespace HelloWorld;

class Program
{
    static void Main()
    {
        // vetor cd inteiros
        Console.WriteLine("Vetores:");
        int[] inteiros = new int[10];
        Console.WriteLine(inteiros.Length);
        inteiros[0] = 1;
        Console.WriteLine(inteiros[0]);

        // matriz
        int[,] matriz = new int[10, 10];
        matriz[0, 0] = 1;
        Console.WriteLine(matriz[0, 0]);

        // listas
        Console.WriteLine("\n\nLista:");
        List<int> inteiros2 = new List<int>();
        Console.WriteLine(inteiros2.Count); // tamanho da lista
        inteiros2.Add(0);
        inteiros2.Add(1);
        inteiros2.Add(2);

        Console.WriteLine(inteiros2[0]);
        Console.WriteLine(inteiros2[1]);

        int primeiroElemento = inteiros2.First();
        Console.WriteLine(primeiroElemento);
        int ultimoElemento = inteiros2.Last();
        Console.WriteLine(ultimoElemento);


        inteiros2.Remove(0); // Remove o elemento 1
        inteiros2.RemoveAt(0); // Remove o elemento no index 0;
        Console.WriteLine("Tamanho da Lista: " + inteiros2.Count());
        inteiros2.Clear(); // Remove tudo

        // Lista mista
        List<object> objetos = new List<object>();

        objetos.Add("Hello");
        objetos.Add(7);
        objetos.Add(true);
        Console.WriteLine("\n\nLista Mista:");
        Console.WriteLine(objetos[0]);
        Console.WriteLine(objetos[1]);
        Console.WriteLine(objetos[2]);

        // Lista String
        List<string> strings = new List<string>();

        strings.Add("Hello");
        strings.Add("Mundo");

        string resultado = string.Join(" ", strings);
        Console.WriteLine(resultado);

        // Dicionários
        // key, value   
        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        dicionario.Add(241, "Sodras");
        dicionario.Add(270, "Vicente");
        dicionario.Add(2223, "Letícia");

        string value = dicionario[2223];
        Console.WriteLine("\n\nDicionário:");
        Console.WriteLine(value);

        bool existe = dicionario.ContainsKey(0);
        Console.WriteLine(existe);
        existe = dicionario.ContainsKey(270);
        Console.WriteLine(existe);

        // HashSet - Lista que não aceita repetidos.
        Console.WriteLine("\nHashSet:");
        HashSet<int> set = new HashSet<int>();
        set.Add(0);
        set.Add(1);
        set.Add(1);
        set.Add(1);
        Console.WriteLine(set.Count()); // vai ser de tamanho 2

    }
}