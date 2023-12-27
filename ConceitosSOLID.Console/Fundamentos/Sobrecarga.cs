namespace ConceitosSOLID.App.Fundamentos;

internal class Sobrecarga
{
    static int Somar(int a, int b)
        => a + b;

    static double Somar(double a, double b, double c)
        => a + b + c;

    static int Somar(params int[] numeros)
    {
        var resultado = 0;
        foreach (var item in numeros)
            resultado += item;

        return resultado;
    }

    public static void Executar()
    {
        var res1 = Somar(100, 200);
        var res2 = Somar(100, 200, 300);
        var res3 = Somar(new int[] {1, 2, 3, 4});

        Console.WriteLine($"Resultados = {res1} - {res2} - {res3}");

        
    }
}
