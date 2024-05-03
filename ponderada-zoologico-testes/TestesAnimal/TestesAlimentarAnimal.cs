using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesAnimal;

public class TestesAlimentarAnimal
{
    private readonly ITestOutputHelper _output;

    public TestesAlimentarAnimal(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void AlimentarAnimal_DeveAumentarNivelDeFelicidade()
    {
        // Preparação 
        string NomeEsperado = "Marrie";
        string EspecieEsperada = "Gato";
        int AumentoDaFelicidade = 5;
        int NivelFelicidadeEsperado = 10;

        // Execução
        Animal animal = new Animal(NomeEsperado, EspecieEsperada, 5);
        animal.Alimentar(AumentoDaFelicidade);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado animal: Nome={animal.Nome}, Espécie={animal.Especie}, Nível de Felicidade={animal.NivelFelicidade}");

        // Verificação
        Assert.Equal(NivelFelicidadeEsperado, animal.NivelFelicidade);
    }

    [Fact]
    public void AlimentarAnimal_DeveEvitarFelicidadeNegativa()
    {
        // Preparação
        string NomeEsperado = "Marrie";
        string EspecieEsperada = "Gato";
        int AumentoDaFelicidade = -6;
        int NivelFelicidadeEsperado = 0;

        // Execução
        Animal animal = new Animal(NomeEsperado, EspecieEsperada, 5);
        animal.Alimentar(AumentoDaFelicidade);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado animal: Nome={animal.Nome}, Espécie={animal.Especie}, Nível de Felicidade={animal.NivelFelicidade}");

        // Verificação
        Assert.Equal(NivelFelicidadeEsperado, animal.NivelFelicidade);
    }
}
