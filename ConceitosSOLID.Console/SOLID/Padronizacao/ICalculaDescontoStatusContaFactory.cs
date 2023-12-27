namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal interface ICalculaDescontoStatusContaFactory
{
    ICalculoDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente status);
}
