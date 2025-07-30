namespace HelloWorld;

class Program
{
    enum NivelDeDificuldade {
        Baixo = 12,
        Medio = 36,
        Dificil = 24
    }
    static void Main()
    {
        // usando enum
        NivelDeDificuldade nivel = NivelDeDificuldade.Dificil;

        int nivelInteiro = (int)nivel;
        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);

        // var: identifica a tipagem para mim.
        var variavel = "Pedro Sodras";
        Console.WriteLine(variavel);

        // null
        int? idade = null;
        Console.WriteLine(idade.HasValue);
    }
}