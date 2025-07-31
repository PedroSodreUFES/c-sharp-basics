namespace HelloWord;

public class Carro
{
    // poderia ser colocado public required string ao invés do construtor
    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(string Modelo, Cor Cor, DateOnly LancadoEm)
    {
        this.Modelo = Modelo;
        this.Cor = Cor;
        this.LancadoEm = LancadoEm;
    }

    public void NomeDoModelo() => Console.WriteLine("Modelo do Carro: " + Modelo);
}

