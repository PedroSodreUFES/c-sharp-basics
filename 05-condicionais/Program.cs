namespace HelloWorld;

public class Program
{
    public static void Main()
    {
        // basicao
        int numero = -11;

        if (numero > 0)
        {
            Console.WriteLine($"{numero} é maior que zero!");
        }
        else if (numero < 0)
        {
            Console.WriteLine($"{numero} é menor que zero!");
        }
        else
        {
            Console.WriteLine("É Zero!");
        }

        // booleanos
        bool boleano = true;
        if (!boleano)
        {
            Console.WriteLine("Falseta");
        }
        else
        {
            Console.WriteLine("Verdade!!!!!!!!!!!");
        }
        if (boleano == false)
        {
            Console.WriteLine("Falseta dnv!!");
        }
        else
        {
            Console.WriteLine("Verdade dnv meu mano!");
        }


        // And
        numero = 25;
        if (numero >= 0 && numero <= 10)
        {
            Console.WriteLine($"{numero} está entre 0 e 10");
        }

        // Or
        if (numero < 0 || numero > 10)
        {
            Console.WriteLine($"{numero} não está entre 0 e 10");
        }

        // apenas o lado esquerdo executa. Código nunca dá erro.
        string mensagem = "Sodré"; // se colocar isso com null não ia dar erro na segunda checagem do if.
        if (mensagem is not null && mensagem.Length > 0)
        {
            Console.WriteLine($"A mensagem é: {mensagem}");
        }

        // if ternário
        string ehSodras = mensagem.Equals("Sodré") ? "É o Sodras!" : "Não é o Sodras";
        Console.WriteLine(ehSodras);

        // switch
        numero = -100;
        switch (numero)
        {
            case 0:
                {
                    Console.WriteLine("É 0");
                }
                break;
            case > 0:
                {
                    Console.WriteLine("É maior que zero");
                }
                break;
            case < -2:
                {
                    Console.WriteLine("É menor que -2");
                }
                break;
            case -1:
                {
                    Console.WriteLine("O número é -1");
                }
                break;
            default:
                {
                    Console.WriteLine("O número é -2");
                }
                break;
        }

        // outra abordagem de switch
        numero = 20;
        string resultado = numero switch
        {
            0 => "Pedro",
            1 => "Vicente",
            2 => "Francis",
            3 => "Fábio",
            > 3 => "Letícia",
            _ => "Nome Desconhecido"
        };

        Console.WriteLine(resultado);
    }
}