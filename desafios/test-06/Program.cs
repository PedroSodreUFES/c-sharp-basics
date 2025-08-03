using System.Globalization;

namespace Sodre;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite 1 para ver a data completa\nDigite 2 para ver a data no formato 01/03/2024\nDigite 3 para ver a hora no formato de 24 horas.\nDigite 4 para ver a data com o mês por extenso\n");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                {
                    DateTime hoje = DateTime.Now;
                    Console.WriteLine($"A data é: {hoje}");
                }
                break;
            case 2:
                {
                    string hoje = DateTime.Now.ToString("dd/MM/yyyy");
                    Console.WriteLine($"A data é: {hoje}");
                }
                break;
            case 3:
                {
                    string hora = DateTime.Now.ToString("hh");
                    Console.WriteLine($"A hora é: {hora}");
                }
                break;
            case 4:
                {
                    string hoje = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-br"));
                    Console.WriteLine($"A data é: {hoje}");
                }
                break;
            default:
                {
                    Console.WriteLine("Opção inválida.");
                }
                break;
        }

    }
}