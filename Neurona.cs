using System;
using System.Collections.Generic;
using System.Linq;

namespace Perceptron_Dinamico{
    class Neurona{  

        int Capa;
        int Actual;
        Umbral umbral;
        List<Peso> Entradas = new List<Peso>();
        List<Peso> Salidas = new List<Peso>();

        public Neurona(Umbral umb, int capa, int actual, List<Peso> entradas, List<Peso> salidas)
        {
            Capa = capa;
            Actual = actual;
            umbral = umb;
            Entradas = entradas;
            Salidas = salidas;
        }

    }  
}