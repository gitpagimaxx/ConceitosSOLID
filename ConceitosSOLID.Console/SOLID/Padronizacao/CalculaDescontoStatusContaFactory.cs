namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
{
    public ICalculoDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente status)
    {
        ICalculoDescontoStatusConta calcular = status switch
        {
            StatusContaCliente.NaoRegistrado => new ClienteNaoRegistrado(),
            StatusContaCliente.ClienteComum => new ClienteComum(),
            StatusContaCliente.ClienteEspecial => new ClienteEspecial(),
            StatusContaCliente.ClienteVIP => new ClienteVIP(),
            _ => throw new NotImplementedException(),
        };
        return calcular;
    }
}
