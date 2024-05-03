using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesVisitante;

public class TestesCriarrVisitante
{
    private readonly ITestOutputHelper _output;

    public TestesCriarrVisitante(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void CriarVisitante_DeveConterNomeEIdade()
    {
        // Preparação
        string NomeEsperado = "Raphaela";
        int IdadeEsperada = 19;

        // Execução
        Visitante visitante = new Visitante(NomeEsperado, IdadeEsperada);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado visitante: Nome={visitante.Nome}, Idade={visitante.Idade}");

        // Verificação
        Assert.Equal(NomeEsperado, visitante.Nome);
        Assert.Equal(IdadeEsperada, visitante.Idade);
    }
}
