namespace ConceitosSOLID.App.OO;

class PoliFigura
{
    public int Lado { get; set; }
    public virtual void Desenhar()
    {
        Console.WriteLine($"Executando desenhar na classe base");
    }
}

class PoliCirculo : PoliFigura
{
    public override void Desenhar()
    {
        Console.WriteLine($"Executando desenhar na classe Circulo");
    }
}

class PoliTriangulo : PoliFigura
{
    public override void Desenhar()
    {
        Console.WriteLine($"Executando desenhar na classe Triangulo");
    }
}

internal class Polimorfismo
{
    public static void Executar()
    {
        var figuras = new List<PoliFigura>
        {
            new PoliTriangulo(),
            new PoliCirculo()
        };

        foreach (var item in figuras)
        {
            item.Desenhar();
        }

    }
}
