namespace ConceitosSOLID.App.OO;

abstract class Figura
{
    protected Figura(string nome)
    {
        Nome = nome;
    }

    protected string Nome { get; set; }

    public abstract void Desenhar();
    public abstract void Identificar();

    public string Duplicar()
        => "Duplicando a figura";
}

interface IFigura
{
    string Nome { get; set; }
    void Desenhar();
    void Identificar();
    void Duplicar(); 
}

class Quadrado : Figura
{
    public Quadrado(string nome) : base(nome) { }

    public override void Desenhar()
    {
        Console.WriteLine($"Desenhando {Nome}...");
        Duplicar();
    }

    public override void Identificar()
        => Console.WriteLine($"Sou o {Nome}...");
}

class Triangulo : IFigura
{
    public Triangulo(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public void Desenhar()
        => Console.WriteLine($"Desenhando {Nome}...");

    public void Duplicar()
        => Console.WriteLine($"Duplicar {Nome}...");

    public void Identificar()
        => Console.WriteLine($"Sou o {Nome}...");
}

internal class AbstratasVsInterface
{
    public static void Executar()
    {
        Quadrado quadrado = new("Quadrado");
        quadrado.Desenhar();
        quadrado.Identificar();

        Triangulo triangulo = new("Triangulo");
        triangulo.Desenhar();
        triangulo.Identificar();
        triangulo.Duplicar();
    }
}
