using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesRecinto;

public class TesteAdicionarAnimalNoRecinto
{
    private readonly ITestOutputHelper _output;

    public TesteAdicionarAnimalNoRecinto(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void AdicionarAnimalNoRecinto_RecintoVazio_DeveConterUmAnimal()
    {
        // Preparação - Recinto
        string NomeRecintoEsperado = "Recinto dos felinos";
        string EspecieRecintoEsperada = "Gato";
        bool EstaBemCuidadoEsperado = true;
        List<Animal> animaisEsperados = new List<Animal>();
        Recinto recinto = new Recinto(NomeRecintoEsperado, EspecieRecintoEsperada, EstaBemCuidadoEsperado, animaisEsperados);

        // Preparação - Animal
        string NomeAnimalEsperado = "Marrie";
        string EspecieAnimalEsperada = "Gato";
        int NivelFelicidadeEsperado = 10;
        Animal marrie = new Animal(NomeAnimalEsperado, EspecieAnimalEsperada, NivelFelicidadeEsperado);

        // Execução
        recinto.AdicionarAnimal(marrie);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado recinto: Nome={recinto.Nome}, Espécie={recinto.Especie}, Está bem cuidado={recinto.EstaBemCuidado}");
        _output.WriteLine($"Animais no recinto: {recinto.Animais.Count}");

        // Verificação
        Assert.Contains(marrie, recinto.Animais);
        Assert.Single(recinto.Animais);
    }

    [Fact]
    public void AdicionarAnimalNoRecinto_RecintoComAnimais_DeveConterVariosAnimais()
    {
        // Preparação - Recinto
        string NomeRecintoEsperado = "Recinto dos felinos";
        string EspecieRecintoEsperada = "Gato";
        bool EstaBemCuidadoEsperado = true;
        List<Animal> animaisEsperados = new List<Animal>();
        Recinto recinto = new Recinto(NomeRecintoEsperado, EspecieRecintoEsperada, EstaBemCuidadoEsperado, animaisEsperados);

        // Preparação - Animais
        string NomeAnimalEsperado1 = "Marrie";
        string EspecieAnimalEsperada1 = "Gato";
        int NivelFelicidadeEsperado1 = 10;
        Animal marrie = new Animal(NomeAnimalEsperado1, EspecieAnimalEsperada1, NivelFelicidadeEsperado1);

        string NomeAnimalEsperado2 = "Amora";
        string EspecieAnimalEsperada2 = "Gato";
        int NivelFelicidadeEsperado2 = 9;
        Animal amora = new Animal(NomeAnimalEsperado2, EspecieAnimalEsperada2, NivelFelicidadeEsperado2);

        string NomeAnimalEsperado3 = "Branquinho";
        string EspecieAnimalEsperada3 = "Gato";
        int NivelFelicidadeEsperado3 = 8;
        Animal branquinho = new Animal(NomeAnimalEsperado3, EspecieAnimalEsperada3, NivelFelicidadeEsperado3);

        // Execução
        recinto.AdicionarAnimal(marrie);
        recinto.AdicionarAnimal(amora);
        recinto.AdicionarAnimal(branquinho);

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado recinto: Nome={recinto.Nome}, Espécie={recinto.Especie}, Está bem cuidado={recinto.EstaBemCuidado}");
        _output.WriteLine($"Animais no recinto: {recinto.Animais.Count}");

        // Verificação
        Assert.Contains(marrie, recinto.Animais);
        Assert.Contains(amora, recinto.Animais);
        Assert.Contains(branquinho, recinto.Animais);
        Assert.Equal(3, recinto.Animais.Count);
    }
}
