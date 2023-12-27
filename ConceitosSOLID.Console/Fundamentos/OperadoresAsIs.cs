namespace ConceitosSOLID.App.Fundamentos;

internal class OperadoresAsIs
{
    private static void Upcasting_As()
    {
        Forma f = new();
        Circulo c = f as Circulo;

        if (c != null)
            c.Pintar();
        else
            Console.WriteLine("Operacao de downcast inválida (as)");
    }

    private static void Downcasting_Is()
    {
        Circulo circulo = new();
        Forma f = circulo;
        if (f is Circulo)
            ((Circulo)f).Pintar();
        else
            Console.WriteLine("Operacao de downcast inválida (is)");
    }

    public static void Executar()
    {
        Upcasting_As();
        Downcasting_Is();
    }
}
