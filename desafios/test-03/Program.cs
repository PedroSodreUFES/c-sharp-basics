using System.Numerics;

namespace Sodre;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite um número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A soma dos dois é: " + (n1 + n2));
        Console.WriteLine("A subtração do primeiro pelo segundo é: " + (n1 - n2));
        Console.WriteLine("A multiplicação dos dois é: " + (n1 * n2));
        if (n2 == 0)
        {
            Console.WriteLine("Segundo número é 0, logo a divisão não é possível.");
        }
        else
            Console.WriteLine("A divisão do primeiro pelo segundo é: " + (n1 / n2));
        Console.WriteLine("A média dos dois é: " + ((n1 + n2) / 2));
    }
}