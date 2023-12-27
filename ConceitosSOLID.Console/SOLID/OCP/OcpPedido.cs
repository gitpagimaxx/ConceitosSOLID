namespace ConceitosSOLID.App.SOLID.OCP;

internal class OcpPedido
{
    public virtual double DescontoPedido(double valorFinal)
        => valorFinal;
}

internal class OcpDescontoClienteAssociado : OcpPedido
{
    public override double DescontoPedido(double valorFinal)
        => valorFinal - 10;
}

internal class OcpDescontoClienteEspecial : OcpPedido
{
    public override double DescontoPedido(double valorFinal)
        => valorFinal - 50;
}

internal class OcpDescontoClienteVIP : OcpPedido
{
    public override double DescontoPedido(double valorFinal)
        => valorFinal - 100;
}

internal class Ocp
{
    public static void Executar()
    {

    }
}