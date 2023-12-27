namespace ConceitosSOLID.App.SOLID.Padronizacao;

internal interface ICalculaDescontoFidelidade
{
    decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
}
