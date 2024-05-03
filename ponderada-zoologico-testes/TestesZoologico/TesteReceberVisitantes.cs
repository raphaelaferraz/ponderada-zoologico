using ponderada_zoologico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ponderada_zoologico_testes.TestesZoologico;

public class TesteReceberVisitantes
{
    private readonly ITestOutputHelper _output;

    public TesteReceberVisitantes(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void ReceberVisitantes_QuandoRecintosEstaoBemCuidados_DeveAumentarVisitantesEDinheiro()
    {
        // Preparação - Recinto
        string NomeRecintoEsperado = "Recinto dos felinos";
        string EspecieEsperada = "Gato";
        bool EstaBemCuidado = true;
        List<Animal> animais = new List<Animal>();
        Recinto recinto = new Recinto(NomeRecintoEsperado, EspecieEsperada, EstaBemCuidado, animais);

        // Preparação - Visitante
        string NomeVisitanteEsperado = "Raphaela";
        int IdadeEsperada = 19;
        Visitante visitante = new Visitante(NomeVisitanteEsperado, IdadeEsperada);

        // Preparação - Zoologico
        string NomeZoologicoEsperado = "Zoológico de São Paulo";
        int DinheiroRecebido = 0;
        List<Recinto> recintos = new List<Recinto>();
        List<Visitante> visitantes = new List<Visitante>();
        Zoologico zoologico = new Zoologico(NomeZoologicoEsperado, recintos, visitantes, DinheiroRecebido);
        zoologico.AdicionarRecinto(recinto);
        zoologico.AdicionarVisitante(visitante);

        // Execução
        zoologico.ReceberVisitantes();

        // Logging para verificar o que foi criado
        _output.WriteLine($"Criado zoológico: Nome={zoologico.Nome}");
        _output.WriteLine($"Recintos no zoológico: {zoologico.Recintos.Count}");
        _output.WriteLine($"Visitantes no zoológico: {zoologico.Visitantes.Count}");
        _output.WriteLine($"Dinheiro recebido: {zoologico.DinheiroRecebido}");

        // Verificação
        Assert.Equal(1, zoologico.Visitantes.Count);
        Assert.True(zoologico.DinheiroRecebido > 0);
        Assert.Equal(10, zoologico.DinheiroRecebido);
    }
}
