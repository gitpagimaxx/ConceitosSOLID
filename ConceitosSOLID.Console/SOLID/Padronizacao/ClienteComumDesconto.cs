namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class ClienteComum : ICalculoDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
        return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
    }
}