namespace ConceitosSOLID.App.OO;

class Departamento : IDisposable
{
    private Escola escola;
    private string nome;

    public Departamento(Escola escola, string nome)
    {
        this.escola = escola;
        this.nome = nome;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

class Escola : IDisposable
{
    public string Nome { get; set; }
    private List<Departamento> departamentos = new();

    public void AddDepartamento(string nome)
    {
        departamentos.Add(new Departamento(this, nome));
    }

    public void Dispose()
    {
        foreach (var item in departamentos)
        {
            item.Dispose();
        }
    }
}

internal class Composicao
{
    public static void Executar()
    {
        
    }
}
