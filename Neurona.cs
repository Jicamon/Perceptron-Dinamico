using System;
using System.Collections.Generic;
using System.Linq;

namespace Perceptron_Dinamico{
    class Neurona{  

        int Capa;
        int Actual;
        List<double> Entradas = new List<double>();
        List<double> Salidas = new List<double>();

        public Neurona(int umbral, int capa, int actual, List<double> entradas, List<double> salidas)
        {
            Capa = capa;
            Actual = actual;
            Entradas = entradas;
            Salidas = salidas;
        }

    }  
}