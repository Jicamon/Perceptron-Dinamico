using System;
using System.Collections.Generic;
using System.Linq;

namespace Perceptron_Dinamico{

    class Perceptron{

        public static void Menu(){
            int CantidadCapas;
             
            do{
                Console.WriteLine("Cantidad de Capas (Min. 2):");
                CantidadCapas = Convert.ToInt32(Console.ReadLine());
            }while(CantidadCapas <= 1);

            int[] cantidadPorCapa = new int[CantidadCapas];
            
            for(int i = 0; i < CantidadCapas; i++){
                Console.WriteLine("Cantidad de Neuronas en la capa " + (i+1) + ":");
                cantidadPorCapa[i] = Convert.ToInt32(Console.ReadLine());
            }

            double[] valoresDeEntradaIniciales = new double[cantidadPorCapa[0]];

            for(int i = 0; i < valoresDeEntradaIniciales.Length; i++){
                Console.WriteLine("Valor de entrada en la neurona X" + (i+1) + ":");
                valoresDeEntradaIniciales[i] = Convert.ToDouble(Console.ReadLine());
            }

            
            
        }  

        public static void imprimirValoresDeEntradaIniciales(double[] listaDeValores){
            for(int i = 0; i < listaDeValores.Length; i++){
                Console.WriteLine("Valore de entrada " + (i+1) + ": \t" + listaDeValores[i]);
            }
        }
    }
}