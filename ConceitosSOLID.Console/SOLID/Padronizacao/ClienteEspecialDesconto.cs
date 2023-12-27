namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class ClienteEspecial : ICalculoDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
        return preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
    }
}