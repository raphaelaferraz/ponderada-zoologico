using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponderada_zoologico.Classes;

public class Zoologico
{
    // Atributos
    private string _nome;
    private List<Recinto> _recintos = new List<Recinto>();
    private List<Visitante> _visitantes = new List<Visitante>();
    private int _dinheiroRecebido = 0;

    // Construtor 
    public Zoologico(string Nome, List<Recinto> recintos, List<Visitante> visitantes, int dinheiroRecebido)
    {
        _nome = Nome;
        _recintos = recintos;
        _visitantes = visitantes;
        _dinheiroRecebido = dinheiroRecebido;
    }

    // Propriedades
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public List<Recinto> Recintos
    {
        get { return _recintos; }
        set { _recintos = value; }
    }

    public List<Visitante> Visitantes
    {
        get { return _visitantes; }
        set { _visitantes = value; }
    }

    public int DinheiroRecebido
    {
        get { return _dinheiroRecebido; }
        set { _dinheiroRecebido = value; }
    }

    // Métodos
    public void AdicionarRecinto(Recinto recinto)
    {
        _recintos.Add(recinto);
    }

    public void AdicionarVisitante(Visitante visitante)
    {
        _visitantes.Add(visitante);
    }

    public void ReceberVisitantes()
    {
        int totalVisitantes = 0;
        decimal precoPorVisitante = 10; 

        foreach (var recinto in _recintos)
        {
            if (recinto.EstaBemCuidado) 
            {
                int baseVisitantes = 1; 
                int bonusPorAnimal = recinto.Animais.Sum(animal => animal.NivelFelicidade) / 10; 

                int visitantesPorRecinto = baseVisitantes + bonusPorAnimal;
                totalVisitantes += visitantesPorRecinto;
            }
        }

        _dinheiroRecebido += totalVisitantes * (int)precoPorVisitante;
    }

}
