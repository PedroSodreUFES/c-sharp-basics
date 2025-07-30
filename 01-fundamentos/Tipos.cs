using System;
using System.Globalization;
using System.Text;
using HelloWorld;
using HelloWorld.Teste;

class Program
{
    static void Main(string[] args)
    {
        // classes
        Carro carrin = new Carro();

        carrin.Ligar();
        carrin.Desligar();

        Biscoito biscoitebass = new Biscoito();

        biscoitebass.Temperatura();

        // numeros
        int inteiro = 7;
        long longo = 1000000000;
        uint sodras = 2345678903;

        double numero1 = 3.14;
        float numero2 = 0.14f;
        decimal numero3 = 0.14m;

        // booleano
        bool verdadeiro = true;
        bool falso = false;

        // string e caracteres
        char letra = 'a'; // aspas simples
        string texto = "sodrezada"; // aspas duplas
        char primeira_letra_do_texto = texto[0];

        Console.WriteLine(texto);
        Console.WriteLine(primeira_letra_do_texto);

        string meuNome = "    Sodré      ";
        string nome_sem_espaco = meuNome.Trim();
        Console.WriteLine(nome_sem_espaco);

        bool comeca_com_S = nome_sem_espaco.StartsWith("S");
        bool termina_com_e = nome_sem_espaco.EndsWith("é");
        bool tem_odr = nome_sem_espaco.Contains("odr");
        bool eh_Sodre = nome_sem_espaco.Equals("Sodré");
        Console.WriteLine(comeca_com_S);
        Console.WriteLine(termina_com_e);
        Console.WriteLine(tem_odr);
        Console.WriteLine(eh_Sodre);

        // operações com texto
        string texto1 = "A primeira frase.";
        string texto2 = "A segunda frase.\n";
        string paragrafo = texto1 + " " + texto2;
        Console.WriteLine(paragrafo);

        string paragrafo2 = $"A primeira frase. {texto2}";
        Console.WriteLine(paragrafo2);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(paragrafo);
        stringBuilder.Append(paragrafo2);
        string resultado = stringBuilder.ToString();
        Console.WriteLine(resultado);

        string texto3 = "O usuário {0} gosta do número {1}";
        string resultado2 = string.Format(texto3, "Sodras", "11");
        Console.WriteLine(resultado2);

        // Data dddd/mmmm/yyyy
        DateOnly dia = new DateOnly(2023, 12, 1);
        string diaEmTexto = dia.ToLongDateString();
        string diaEmTextoEmPortugues = dia.ToString("dd MMMM yyyy", new CultureInfo("pt-br"));
        Console.WriteLine(dia);
        Console.WriteLine(diaEmTexto);
        Console.WriteLine(diaEmTextoEmPortugues);

        // Data e Hora
        DateTime dateTime = new DateTime(2023, 12, 1, 20, 07, 1);
        Console.WriteLine(dateTime);
        DateTime hoje = DateTime.Now;
        Console.WriteLine(hoje);
        DateTime hojeSemHora = DateTime.Today;
        Console.WriteLine(hojeSemHora);
        DateTime amanha = hojeSemHora.AddDays(1);
        Console.WriteLine(amanha);
    }
}
