namespace HelloWord;

public class OperacoesMatematicas
{
    // retorna 1 valor
    public int Adicionar(int valor1, int valor2)
    {
        int resultado = valor1 + valor2;

        return resultado;
    }
    // retornar 2 valores
    public (int resultadoDaSubtracao, string operacao) Subtrair(int valor1, int valor2)
    {
        return (valor1 - valor2, "Subtração");
    }

    // parâmetro opcional
    public void Teste(string value2 = "Usuário")
    {
        Console.WriteLine("Bom dia, " + value2 + "!");
    }

    public static void Multiplicar(int value1, int value2)
    {
        Console.WriteLine(value1 * value2);
    }
}