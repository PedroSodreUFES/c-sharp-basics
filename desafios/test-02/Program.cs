namespace Sodre;
public class Program
{
    public static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine("Seu nome completo: " + nome + " " + sobrenome);
    }
}