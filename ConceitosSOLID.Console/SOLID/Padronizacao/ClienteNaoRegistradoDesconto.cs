namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class ClienteNaoRegistrado : ICalculoDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
        return preco;
    }
}
