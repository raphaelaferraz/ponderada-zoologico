using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesZoologico;

public class TesteCriarZoologico
{
    private readonly ITestOutputHelper _output;

    public TesteCriarZoologico(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void CriarZoologico_DeveConterRecintosVazios_DeveConterNenhumVisitante()
    {
        // Preparação
        string NomeEsperado = "Zoológico de São Paulo";
        int DinheiroRecebido = 0;
        List<Recinto> recintos = new List<Recinto>();
        List<Visitante> visitantes = new List<Visitante>();

        // Execução
        Zoologico zoologico = new Zoologico(NomeEsperado, recintos, visitantes, DinheiroRecebido);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado zoológico: Nome={zoologico.Nome}");
        _output.WriteLine($"Recintos no zoológico: {zoologico.Recintos.Count}");
        _output.WriteLine($"Visitantes no zoológico: {zoologico.Visitantes.Count}");

        // Verificação
        Assert.Equal(NomeEsperado, zoologico.Nome);
        Assert.Empty(zoologico.Recintos);
        Assert.Empty(zoologico.Visitantes);
    }
}
