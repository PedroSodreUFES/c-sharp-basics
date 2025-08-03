namespace Sodre;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        int cont = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if (Char.IsLetter(frase[i])) {
                cont++;
            }
        }
        Console.WriteLine($"O número de caracteres é: {cont}");
    }
}