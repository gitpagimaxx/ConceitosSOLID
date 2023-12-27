using System.Runtime.Serialization;

namespace ConceitosSOLID.App.Fundamentos;

class ClienteAnemico
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Endereco { get; set; }
}

class ClienteRico
{
    public int Id { get; private set; }
    public string? Nome { get; private set; }
    public string? Endereco { get; private set; }

    public ClienteRico(int id, string? nome, string? endereco)
    {
        //if (id < 0)
        //    throw new InvalidOperationException("Id inválido");

        //if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
        //    throw new InvalidOperationException("Nome ou Endereço inválidos");

        DomainExceptionValidation.When(id < 0, "O Id não pode ser negativo");
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome deve ser preenchido");
        DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O endereço deve ser preenchido");

        Id = id;
        Nome = nome;
        Endereco = endereco;
    }
}

class DomainExceptionValidation : Exception
{
    public DomainExceptionValidation(string? message) : base(message)
    {
    }

    public static void When(bool hasError, string error)
    {
        if (hasError)
            throw new DomainExceptionValidation(error);
    }
}

public class ModelosAnemico
{
    public static void Executar()
    {
        ClienteAnemico cliente = new ClienteAnemico();
        cliente.Id = -1;
        cliente.Nome = "";
        cliente.Endereco = null;

        Console.WriteLine("Dominio Anemico");
        Console.WriteLine($"{cliente.Id}/{cliente.Nome}/{cliente.Endereco}");

        Console.WriteLine("Dominio Rico");
        try
        {
            ClienteRico clienteRico = new ClienteRico(-1, "", null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}