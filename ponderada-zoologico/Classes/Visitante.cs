using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponderada_zoologico.Classes;

public class Visitante
{
    // Atributos
    private string _nome;
    private int _idade;

    // Construtor
    public Visitante(string Nome, int Idade)
    {
        _nome = Nome;
        _idade = Idade;
    }

    // Propriedades
    public string Nome
    {
        get { return _nome; }
    }

    public int Idade
    {
        get { return _idade; }
    }

}
