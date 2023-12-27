namespace ConceitosSOLID.App.Fundamentos;

class Item
{
    public Item(int itemId, int pedidoId, string itemNome, double itemPreco)
    {
        if (itemId <= 0)
            throw new ArgumentException("O código do item deve ser maior que zero");

        if (pedidoId <= 0)
            throw new ArgumentException("O código do pedido deve ser maior que zero");

        ItemId = itemId;
        PedidoId = pedidoId;
        ItemNome = itemNome;
        ItemPreco = itemPreco;
    }

    public int ItemId { get; private set; }
    public int PedidoId { get; private set; }

    public string _itemNome;
    public string ItemNome
    {
        get => _itemNome;
        private set
            => _itemNome = (value.Length > 100) ? throw new ArgumentException(nameof(ItemNome), "O nome do item deve conter até 100 caracteres") : value;
    }

    public double _itemPreco;
    public double ItemPreco 
    { 
        get => _itemPreco; 
        private set => _itemPreco = (value <= 0) ? throw new ArgumentException(nameof(ItemPreco), "O preço do item deve maior que zero") : value;
    }
}

class ItemExceptionValidation : Exception
{
    public ItemExceptionValidation(string? message) : base(message)
    {
    }

    public static void When(bool hasError, string error)
    {
        if (hasError)
            throw new DomainExceptionValidation(error);
    }
}

public class ModelosDominioAnemico
{
    public static void Executar()
    {
        Console.WriteLine("Dominio Rico");
        try
        {
            Item clienteRico = new(-1, 0, "", 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}