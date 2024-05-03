using Microsoft.VisualStudio.TestPlatform.Utilities;
using ponderada_zoologico.Classes;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesAnimal;

public class TestesCriarAnimal
{
    private readonly ITestOutputHelper _output;

    public TestesCriarAnimal(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void CriarAnimal_DeveAtribuirPropriedadesCorretas()
    {
        // Preparação 
        string NomeEsperado = "Marrie";
        string EspecieEsperada = "Gato";
        int NivelFelicidadeEsperado = 10;

        // Execução
        Animal animal = new Animal(NomeEsperado, EspecieEsperada, NivelFelicidadeEsperado);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado animal: Nome={animal.Nome}, Espécie={animal.Especie}, Nível de Felicidade={animal.NivelFelicidade}");

        // Verificação
        Assert.Equal(NomeEsperado, animal.Nome);
        Assert.Equal(EspecieEsperada, animal.Especie);
        Assert.Equal(NivelFelicidadeEsperado, animal.NivelFelicidade);
    }
}