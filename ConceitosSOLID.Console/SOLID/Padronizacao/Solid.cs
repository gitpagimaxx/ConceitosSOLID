namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class Solid
{
    public static void Executar()
    {
        ICalculaDescontoFidelidade descontoFidelidade = new CalculaDescontoFidelidade();
        ICalculaDescontoStatusContaFactory calculaDescontoStatus = new CalculaDescontoStatusContaFactory();

        GerenciadorDeDescontos gerenciarDesconto = new(descontoFidelidade, calculaDescontoStatus);

        Console.WriteLine("Valor da compra 1000 e fidelidade de 10 anos");

        var resultado1 = gerenciarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto {resultado1}");

        var resultado2 = gerenciarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto {resultado2}");

        var resultado3 = gerenciarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 10);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto {resultado3}");

        Console.WriteLine("Valor da compra 1000 e fidelidade de 4 anos (4%)");

        var resultado4 = gerenciarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto {resultado4:n2}");

        var resultado5 = gerenciarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto {resultado5:n2}");

        var resultado6 = gerenciarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 4);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto {resultado6:n2}");
    }
}
