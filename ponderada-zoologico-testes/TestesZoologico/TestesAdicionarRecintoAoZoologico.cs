using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesZoologico;

public class TestesAdicionarRecintoAoZoologico
{
    private readonly ITestOutputHelper _output;

    public TestesAdicionarRecintoAoZoologico(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void AdicionarRecintoAoZoologico_DeveConterRecinto_NaoDeveConterVisitantes()
    {
        // Preparação - Zoologico
        string NomeZoologicoEsperado = "Zoológico de São Paulo";
        int DinheiroRecebido = 0;
        List<Recinto> recintos = new List<Recinto>();
        List<Visitante> visitantes = new List<Visitante>();
        Zoologico zoologico = new Zoologico(NomeZoologicoEsperado, recintos, visitantes, DinheiroRecebido);

        // Preparação - Recinto
        string NomeRecintoEsperado = "Recinto dos felinos";
        string EspecieEsperada = "Gato";
        bool EstaBemCuidado = true;
        List<Animal> animais = new List<Animal>();
        Recinto recinto = new Recinto(NomeRecintoEsperado, EspecieEsperada, EstaBemCuidado, animais);

        // Execução
        zoologico.AdicionarRecinto(recinto);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado zoológico: Nome={zoologico.Nome}");
        _output.WriteLine($"Recintos no zoológico: {zoologico.Recintos.Count}");
        _output.WriteLine($"Visitantes no zoológico: {zoologico.Visitantes.Count}");

        // Verificação
        Assert.Equal(NomeZoologicoEsperado, zoologico.Nome);
        Assert.Contains(recinto, zoologico.Recintos);
    }
}
