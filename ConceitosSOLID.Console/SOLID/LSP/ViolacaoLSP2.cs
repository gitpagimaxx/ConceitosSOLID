namespace ConceitosSOLID.App.SOLID.LSP;

abstract class LspCalculadora
{
    protected readonly int[] _numeros;

    public LspCalculadora(int[] numeros)
    {
        _numeros = numeros;
    }

    public abstract int Calcular();
}

class LspCalculaSoma : LspCalculadora
{
    public LspCalculaSoma(int[] numeros) : base(numeros) { }

    public override int Calcular() => _numeros.Sum();
}

class LspCalculaSomaNumerosPares : LspCalculadora
{
    public LspCalculaSomaNumerosPares(int[] numeros) : base(numeros) { }

    public override int Calcular()
        => _numeros.Where(x => x % 2 == 0).Sum();

}


internal class LSPViolacao2
{
    public static void Executar()
    {
        var numeros = new int[] { 5, 7, 9, 8, 1, 6, 4 };
        LspCalculadora lspCalculaSoma = new LspCalculaSoma(numeros);
        Console.WriteLine($"A soma é: {lspCalculaSoma.Calcular()}");

        LspCalculaSomaNumerosPares somaPares = new(numeros);
        Console.WriteLine($"A soma pares é: {somaPares.Calcular()}");

        LspCalculadora calculaSoma = new LspCalculaSomaNumerosPares(numeros);
        Console.WriteLine($"A soma pares é: {calculaSoma.Calcular()}");

    }
}
