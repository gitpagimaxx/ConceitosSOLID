namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class ClienteVIP : ICalculoDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
        return preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
    }
}