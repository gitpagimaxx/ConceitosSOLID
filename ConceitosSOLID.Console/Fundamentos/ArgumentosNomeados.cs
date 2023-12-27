namespace ConceitosSOLID.App.Fundamentos;

internal class ArgumentosNomeados
{
    static void Enviar(string nome, string email, string telefone)
    {
        Console.WriteLine($"Nome: {nome} - Email: {email} - Telefone: {telefone}");
    }

    public static void Executar()
    {
        Enviar(nome: "Diego", email: "diego@pagimaxx.com", telefone: "11991306333");
    }
}
