namespace Sodre;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        if (placa.Length != 7)
        {
            Console.WriteLine("Inválida: A placa precisa ter 7 caracteres.");
            return;
        }

        for (int i = 0; i < 3; i++)
        {
            if (!Char.IsLetter(placa[i]))
            {
                Console.WriteLine("Inválida: Um dos três primeiros caracteres não é uma letra.");
                return;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!Char.IsNumber(placa[i]))
            {
                Console.WriteLine("Inválida: Um dos quatro últimos caracteres não é um número.");
                return;
            }
        }

        Console.WriteLine($"A placa {placa} é válida!");
    }
}