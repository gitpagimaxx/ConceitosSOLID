namespace ConceitosSOLID.App.Fundamentos;

class Forma
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhar Forma");
    }
}

class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhar Circulo");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando o circulo");
    }
}

internal class HerancaUpDownCasting
{
    public static void Executar()
    {
        Circulo circulo = new();
        Forma forma = circulo;

        Console.WriteLine(forma == circulo);

        forma.Desenhar();

        Circulo circulo1 = (Circulo)forma;
        Console.WriteLine(circulo1 == circulo);

        circulo1.Desenhar();
        circulo1.Pintar();
    }
}
