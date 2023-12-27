namespace ConceitosSOLID.App.Fundamentos;

class Conta
{
    public int Numero { get; set; } 
    public double Saldo { get; set; }

    public Conta()
    {
        Console.WriteLine("Construtor da Conta");
    }

    internal virtual void GetSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo:N2}");
    }
}

class ContaPoupanca : Conta
{
    public double JurosMensais { get; set; }

    internal override void GetSaldo()
    {
        Console.WriteLine($"Saldo da poupança: {Saldo:N2}");
    }

    public override string ToString()
    {
        return $"Número: {Numero} / Saldo: {Saldo:N2} / Juros: {JurosMensais:N2}";
    }
}


internal class ConceitosHeranca
{
    public static void Executar()
    {
        ContaPoupanca cp = new()
        {
            Numero = 123456,
            Saldo = 10.5,
            JurosMensais = 0.6
        };

        cp.GetSaldo();

        Console.WriteLine(cp);
    }
}
