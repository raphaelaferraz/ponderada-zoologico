using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponderada_zoologico.Classes;

public class Animal
{
    // Atributos 
    private string _nome;
    private string _especie;
    private int _nivelFelicidade;

    // Construtor
    public Animal(string Nome, string Especie, int NivelFelicidade)
    {
        _nome = Nome;
        _especie = Especie;
        _nivelFelicidade = NivelFelicidade;
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

    public int NivelFelicidade 
    { 
        get { return _nivelFelicidade; }
        set
        {
            _nivelFelicidade = Math.Max(0, Math.Min(value, 10)); 
        }
    }

    // Métodos
    public void Alimentar(int mudancaDeFelicidade)
    {
        // Aumenta o nível de felicidade do animal
        _nivelFelicidade += mudancaDeFelicidade;

        // Garante que o nível de felicidade não ultrapasse 10 ou fique negativo
        _nivelFelicidade = Math.Min(_nivelFelicidade, 10);
        _nivelFelicidade = Math.Max(_nivelFelicidade, 0);
    }
}
