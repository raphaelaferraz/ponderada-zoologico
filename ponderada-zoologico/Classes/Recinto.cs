using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponderada_zoologico.Classes;

public class Recinto
{
    // Atributos
    private string _nome;
    private string _especie;
    private bool _estaBemCuidado =  true;
    private List<Animal> _animais = new List<Animal>();

    // Construtor
    public Recinto(string Nome, string Especie, bool EstaBemCuidado, List<Animal> Animais)
    {
        _nome = Nome;
        _especie = Especie;
        _estaBemCuidado = EstaBemCuidado;
        _animais = Animais;
    }

    // Propriedades
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Especie
    {
        get { return _especie; }
        set { _especie = value; }
    }

    public bool EstaBemCuidado
    {
        get { return _estaBemCuidado; }
        set { _estaBemCuidado = value; }
    }

    public List<Animal> Animais
    {
        get { return _animais; }
        set { _animais = value; }
    }

    // Métodos
    public void AdicionarAnimal(Animal animal)
    {
        _animais.Add(animal);
    }
}
