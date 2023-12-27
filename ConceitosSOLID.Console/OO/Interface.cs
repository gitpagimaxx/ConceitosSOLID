namespace ConceitosSOLID.App.OO;

interface IRegistro
{
    void RegistraInfo(string mensagem);
}

class RegistraOcorrencia
{
    private readonly IRegistro _registro;

    public RegistraOcorrencia(IRegistro registro)
    {
        _registro = registro;
    }

    public void Registrar(string mensagem)
    {
        _registro.RegistraInfo($"{DateTime.Now}: {mensagem}");
    }
}

class RegistraNoConsole : IRegistro
{
    public void RegistraInfo(string mensagem)
    {
        Console.WriteLine($"INFO: {mensagem}");
    }
}

class RegistraNoArquivo : IRegistro
{
    private readonly string _caminhoNomeArquivo;

    public RegistraNoArquivo(string caminhoNomeArquivo)
    {
        _caminhoNomeArquivo = caminhoNomeArquivo;
    }

    private void Log(string mensagem)
    {
        using var streamWriter = new StreamWriter(_caminhoNomeArquivo, true);
        streamWriter.WriteLine(mensagem);
    }

    public void RegistraInfo(string mensagem)
        => Log(mensagem);
}

internal class Interface
{
    public static void Executar()
    {
        var registraOcorrenciaConsole = new RegistraOcorrencia(new RegistraNoConsole());
        registraOcorrenciaConsole.Registrar("Registro no Console");

        var registraOcorrenciaArquivo = new RegistraOcorrencia(new RegistraNoArquivo(@"C:\_dev\ConceitosSOLID\info.txt"));
        registraOcorrenciaArquivo.Registrar("Registrar no arquivo");
    }
}
