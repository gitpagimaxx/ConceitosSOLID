using ConceitosSOLID.App.Fundamentos;
using ConceitosSOLID.App.OO;
using ConceitosSOLID.App.SOLID.LSP;
using ConceitosSOLID.App.SOLID.OCP;
using ConceitosSOLID.App.SOLID.Padronizacao;
using CursoCSharpCod3r;

var central = new CentralDeExercicios(new Dictionary<string, Action>() {  
    // Fundamentos
    {"Modelo Anemico - Fundamentos", ModelosAnemico.Executar},
    {"Sobrecarga - Fundamentos", Sobrecarga.Executar},
    {"Parametros Opcionais - Fundamentos", ParametrosOpcionais.Executar},
    {"Argumentos Nomeados - Fundamentos", ArgumentosNomeados.Executar},
    {"Métodos Estáticos - Fundamentos", MetodosEstaticos.Executar},
    {"Métodos de Extensão - Fundamentos", MetodosExtensao.Executar},
    {"Nomenclatura - Fundamentos", Nomenclatura.Executar},
    {"Conceitos Heranca - Fundamentos", ConceitosHeranca.Executar},
    {"Herança Construtor - Fundamentos", HerancaConstrutor.Executar},
    {"Herança Up/Down Casting - Fundamentos", HerancaUpDownCasting.Executar},
    {"Operadores As Is - Fundamentos", OperadoresAsIs.Executar},
    
    // OO
    {"Composicao - OO", Composicao.Executar},
    {"Agregacao - OO", Agregacao.Executar},
    {"Abstratas - OO", Abstratas.Executar},
    {"Interface - OO", Interface.Executar},
    {"Abstratas Vs Interface - OO", AbstratasVsInterface.Executar},
    {"Polimorfismo - OO", Polimorfismo.Executar},

    // SOLID
    {"OCP - SOLID", Ocp.Executar},
    {"LSP Violation/Solution 2 - SOLID", LSPViolacao2.Executar},
    {"LSP Violation/Solution 3 - SOLID", LSPViolacao3.Executar},
    {"SOLID - Padronizacao", Solid.Executar},

});

central.SelecionarEExecutar();