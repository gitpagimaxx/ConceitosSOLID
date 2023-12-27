using System.Net.Http.Headers;

namespace ConceitosSOLID.App.SOLID.SRP;

internal interface ILogger
{
    void Info(string message);
}

internal class SrpLog : ILogger
{
    public void Info(string message)
    {
        Console.WriteLine();
    }
}

internal class SrpEnviarEmail
{
    public SrpEnviarEmail(string emailFrom, string emailTo, string emailSubject)
    {
        EmailFrom = emailFrom;
        EmailTo = emailTo;
        EmailSubject = emailSubject;
    }

    public string EmailFrom { get; set; }
    public string EmailTo { get; set; }
    public string EmailSubject { get; set; }
    public string EmailBody { get; set; }

    public void Enviar()
    {
        
    }
}

internal class SrpPedido
{
    private readonly ILogger _logger;
    private readonly SrpEnviarEmail _enviarEmail;

    public SrpPedido()
    {
        _enviarEmail = new SrpEnviarEmail("diego@pagimaxx", "from@pagimaxx", "SRP");
        _logger = new SrpLog();
    }

    public long Quantidade { get; set; }
    public DateTime Data { get; set; }

    public void IncluirPedido()
    {
		try
		{
            _logger.Info("Incluindo pedido");
            _enviarEmail.EmailBody = "Body do email";
            _enviarEmail.Enviar();
        }
		catch (Exception ex)
		{
            _logger.Info("Erro ao incluir o pedido. " + ex.Message);
        }
    }

    public void DeletarPedido()
    {
        try
        {
            _logger.Info("Deletar pedido");
        }
        catch (Exception ex)
        {
            _logger.Info("Erro ao incluir o pedido. " + ex.Message);
        }
    }
}
