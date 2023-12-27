namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
{
    public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
    {
        decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;

        return preco - (descontoPorFidelidade * preco);
    }
}
