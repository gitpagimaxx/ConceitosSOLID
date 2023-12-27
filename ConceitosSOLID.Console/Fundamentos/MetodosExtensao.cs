namespace ConceitosSOLID.App.Fundamentos;

public static class Extended
{
    public static string CaixaAltaPrimeiraLetra(this string texto)
    {
        if (texto.Length > 0)
        {
            char[] array = texto.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }

        return texto;
    }
}

internal class MetodosExtensao
{
    public static void Executar()
    {
        var texto = "texto";

        Console.WriteLine(texto.CaixaAltaPrimeiraLetra());
    }
}
