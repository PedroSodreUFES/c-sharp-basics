using System;
namespace HelloWorld;

class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Ligado");
    }
    public void Desligar()
    {
        Console.WriteLine("Desligado");
    }

    private void Teste1()
    {
        Console.WriteLine("Desligado");
    }

    internal void Teste2()
    {
        Console.WriteLine("Desligado");
    }
}