namespace HelloWorld;

public class Program
{
    public static void Main()
    {
        var numero = 0;

        // break
        Console.WriteLine("break:");
        while (numero < 10)
        {
            numero++;
            if (numero == 5)
            {
                break;
            }
            Console.WriteLine(numero);
        }
        Console.WriteLine("Aqui!");

        numero = 0;
        // continue
        Console.WriteLine("\ncontinue:");
        while (numero < 10)
        {
            numero++;
            if (numero == 5)
            {
                continue;
            }
            Console.WriteLine(numero);
        }
        Console.WriteLine("Aqui!");


        numero = 0;
        // return => quebra a função
        Console.WriteLine("\nreturn:");
        while (numero < 10)
        {
            numero++;
            if (numero == 5)
            {
                return; // saiu da função
            }
            Console.WriteLine(numero);
        }
        Console.WriteLine("Aqui!"); // não será printado
    }
}