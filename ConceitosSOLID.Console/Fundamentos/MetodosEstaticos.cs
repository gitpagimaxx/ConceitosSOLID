namespace ConceitosSOLID.App.Fundamentos;

internal class MetodosEstaticos
{
    static int Somar(int a, int b)
        => a + b;

    static int Sub(int a, int b)
        => a - b;

    public static void Executar()
    {
        Console.WriteLine(Somar(3,2));
        Console.WriteLine(Sub(3,2));
    }
}
