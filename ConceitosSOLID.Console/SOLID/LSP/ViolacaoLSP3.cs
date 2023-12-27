namespace ConceitosSOLID.App.SOLID.LSP;

abstract class Passaro
{
    protected Passaro(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public virtual void Comer()
    {
        Console.WriteLine($"{Nome} comendo");
    }

    public virtual void BotarOvos()
    {
        Console.WriteLine($"{Nome} bota ovos");
    }
}

abstract class PassarosVoadores : Passaro
{
    protected PassarosVoadores(string nome) : base(nome) { }

    public virtual void Voar()
    {
        Console.WriteLine($"{Nome} voando");
    }
}

class Pato : PassarosVoadores
{
    public Pato(string nome) : base(nome) { }

    public override void Comer()
    {
        Console.WriteLine($"{Nome} come milho");
    }

    public override void BotarOvos()
    {
        Console.WriteLine($"{Nome} bota 6 ovos");
    }

    public override void Voar()
    {
        Console.WriteLine($"{Nome} voa baixo");
    }
}

class Pinguim : Passaro
{
    public Pinguim(string nome) : base(nome)
    {
    }

    public override void Comer()
    {
        Console.WriteLine($"{Nome} come peixes");
    }

    public override void BotarOvos()
    {
        Console.WriteLine($"{Nome} bota 2 ovos");
    }
}

internal class LSPViolacao3
{
    public static void Executar()
    {
        PassarosVoadores pato = new Pato("Donald");
        pato.Comer();
        pato.BotarOvos();
        pato.Voar();

        Passaro pinguim = new Pinguim("Pingu");
        pinguim.Comer();
        pinguim.BotarOvos();
    }
}
