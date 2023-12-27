namespace ConceitosSOLID.App.OO;

abstract class FormaAbs
{
    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public string Descricao()
        => "Sou a classe abstrata";
}

internal class QuadradroAbs : FormaAbs
{
    public double Lado { get; set; }

    public override void CalcularArea()
    {
        Area = Lado * Lado;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 4 * Lado;
    }
}

internal class Abstratas
{
    public static void Executar()
    {
        QuadradroAbs q = new();
        Console.WriteLine(q.Descricao());

        Console.Write("Informe a cor da figura: ");
        q.Cor = Console.ReadLine();

        Console.Write("Informe o lado do quadrado: ");
        int.TryParse(Console.ReadLine(), out int ladoQuadrado);
        q.Lado = ladoQuadrado;

        q.CalcularArea();
        q.CalcularPerimetro();

        Console.WriteLine($"A área do quadrado é: {q.Area} m²");
        Console.WriteLine($"O perímetro do quadrado é {q.Perimetro} m³");
        Console.WriteLine($"O quadrado tem a cor: {q.Cor}");

    }
}
