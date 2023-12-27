namespace ConceitosSOLID.App.OO;

class DepartamentoAgregacao : IDisposable
{
    private string Nome;
    private List<Professor> Professores;

    public void Dispose()
    {
    }
}

class Professor : IDisposable
{
    public string Nome { get; set; }

    public void Dispose()
    {
    }
}

internal class Agregacao
{
    public static void Executar()
    {
        
    }
}
