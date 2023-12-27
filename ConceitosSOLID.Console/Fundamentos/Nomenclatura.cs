namespace ConceitosSOLID.App.Fundamentos;

internal class Nomenclatura
{
    static double taxaEncargos = 1.99;
    public int ValorImpostoTotal { get; set; }

    public static double CalculoEncargos(double valorTotal)
    {
        return valorTotal * taxaEncargos;
    }

    public static void Executar()
    {
        // validos
        string nomeAluno = "Diego";
        int idadeMinima = 41;
        int IdadeMinima = 21;
        double _taxa = 1.25;
        int numero_aluno1 = 10;
        double y2x5_w7 = 3.14;
        var \u0043sharp = "C#";

        Console.WriteLine(CalculoEncargos(20));
    }

}
