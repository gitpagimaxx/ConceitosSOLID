namespace ConceitosSOLID.App.Fundamentos;

internal class ParametrosOpcionais
{
    static int Somar(int a, int b = 10, int c = 20, int d = 30)
        => a + b + c + d;

    public static void Executar()
    {
        var res1 = Somar(100);
        var res2 = Somar(100, 200);
        var res3 = Somar(100, 200, 300);
        var res4 = Somar(100, 200, 300, 400);

        Console.WriteLine($"Resultados = {res1} - {res2} - {res3} - {res4}");

        
    }
}
