using System;
using System.Collections.Generic;
using System.Linq;

namespace Perceptron_Dinamico{
    class Neurona{  

        int Capa;
        Umbral umbral;
        int Identificador;

        public Neurona(int capa, int id, Umbral umb, List<Peso> entradas, List<Peso> salidas)
        {
            Capa = capa;
            Identificador = id;
            umbral = umb;
        }

    }  
}