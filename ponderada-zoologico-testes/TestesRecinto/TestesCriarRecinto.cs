using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesRecinto;

public class TestesCriarRecinto
{
    private readonly ITestOutputHelper _output;

    public TestesCriarRecinto(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void CriarRecinto_DeveIncializarVazioEEmBomEstado()
    {
        // Preparação
        string NomeEsperado = "Recinto dos felinos";
        string EspecieEsperada = "Gato";
        bool EstaBemCuidado = true;
        List<Animal> animals = new List<Animal>();

        // Execução
        Recinto recinto = new Recinto(NomeEsperado, EspecieEsperada, EstaBemCuidado, animals);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado recinto: Nome={recinto.Nome}, Espécie={recinto.Especie}, Está bem cuidado={recinto.EstaBemCuidado}");
        _output.WriteLine($"Animais no recinto: {recinto.Animais.Count}");

        // Verificação
        Assert.Equal(NomeEsperado, recinto.Nome);
        Assert.Equal(EspecieEsperada, recinto.Especie);
        Assert.Equal(EstaBemCuidado, recinto.EstaBemCuidado);
        Assert.Empty(recinto.Animais);
    }
}
