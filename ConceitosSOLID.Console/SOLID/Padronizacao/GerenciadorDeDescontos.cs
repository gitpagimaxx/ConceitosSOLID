namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class GerenciadorDeDescontos
{
    private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;
    private readonly ICalculaDescontoFidelidade descontoFidelidade;

    public GerenciadorDeDescontos(
        ICalculaDescontoFidelidade descontoFidelidade, 
        ICalculaDescontoStatusContaFactory descontoStatusConta)
    {
        this.descontoFidelidade = descontoFidelidade;
        this.descontoStatusConta = descontoStatusConta;
    }

    public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
        decimal precoDesconto = descontoStatusConta.GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);
        precoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDesconto, tempoDeContaEmAnos);

        return precoDesconto;
    }

}
