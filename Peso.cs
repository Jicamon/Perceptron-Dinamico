using System;
using System.Collections.Generic;
using System.Linq;

namespace Perceptron_Dinamico{
    class Peso{

        int Anterior;
        int Siguiente;
        int Capa;
        double Valor;

        public Peso(int ant, int sig, int capa, double valor)
        {
            Capa = capa;
            Anterior = ant;
            Siguiente = sig;
            Valor = valor;
        }

    }
}