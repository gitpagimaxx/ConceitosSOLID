namespace ConceitosSOLID.App.Fundamentos;

class Veiculo
{
    private string numeroChasis;

    public Veiculo(string _numeroChasis)
    {
        numeroChasis = _numeroChasis;
        Console.WriteLine($"Inicializando Veiculo: {numeroChasis}");
    }

    public Veiculo()
    {
        Console.WriteLine("Inicializando Veiculo");
    }

    public virtual void Teste()
    {
        Console.WriteLine("acessei o teste veiculo");
    }
}

class Carro : Veiculo
{
    public Carro(string numeroChasis) : base(numeroChasis)
    {
        Console.WriteLine($"Inicializando Carro: {numeroChasis}");
    }

    public Carro()
    {
        Console.WriteLine("Inicializando Carro");
    }

    public override void Teste()
    {
        base.Teste();
        Console.WriteLine("acessei o teste carro");
    }
}

internal class HerancaConstrutor
{
    public static void Executar()
    {
        Carro carro = new(numeroChasis: "123456");
        new Carro().Teste();
    }
}
