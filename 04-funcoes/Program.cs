namespace HelloWord;

class Program
{
    static void Main()
    {
        // retorna 1 parâmetro
        var matematica = new OperacoesMatematicas();
        var soma = matematica.Adicionar(valor1: 3, valor2: 1); // parametros nomeados

        // retorna 2 parâmetros
        var subtracao = matematica.Subtrair(3, 1); // parametros não nomeados
        Console.WriteLine("Soma: " + soma + $"\n{subtracao.operacao}: " + subtracao.resultadoDaSubtracao);

        // segunda opção
        (int resultado, string operacao) = matematica.Subtrair(3, 1);
        Console.WriteLine(operacao + ": " + resultado);

        // Valor opcional
        matematica.Teste("Sodré");
        matematica.Teste();

        // Classes
        Console.WriteLine("\n\nClasses:");
        var carro = new Carro("Lamborghini", Cor.Azul, new DateOnly(2025, 7, 12));
        var carro2 = new Carro("Ferrari", Cor.Azul, new DateOnly(2025, 12, 31));

        carro.NomeDoModelo();
        carro2.NomeDoModelo();

        // Função estática de uma classe: não depende de algo de dentro da classe.
        OperacoesMatematicas.Multiplicar(10, 2);
    }
}