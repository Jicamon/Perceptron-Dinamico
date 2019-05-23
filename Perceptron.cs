using System;
using System.Collections.Generic;
using System.Linq;

namespace Perceptron_Dinamico{

    class Perceptron{

        public static void Menu(){
            List<List<List<Double>>> laWea = new List<List<List<Double>>>();
            List<Neurona> NeurodasDeEntrada;
            List<Double> entradas;
            List<Double> salidas;
            int CantidadCapas;
             
            do{
                Console.WriteLine("Cantidad de Capas (Min. 2, Max. 4):");
                CantidadCapas = Convert.ToInt32(Console.ReadLine());
            }while(CantidadCapas <= 1 || CantidadCapas > 4);

            int[] cantidadPorCapa = new int[CantidadCapas];
            
            for(int i = 0; i < CantidadCapas; i++){
                Console.WriteLine("Cantidad de Neuronas en la capa " + (i+1) + ":");
                cantidadPorCapa[i] = Convert.ToInt32(Console.ReadLine());
            }

            double[] valoresDeEntradaIniciales = new double[cantidadPorCapa[0]];
            laWea = purosArreglos(CantidadCapas, cantidadPorCapa);

            Console.Write(laWea.ElementAt(0).ElementAt(0).ElementAt(0));

            /*
            for(int i = 0; i < valoresDeEntradaIniciales.Length; i++){
                Console.WriteLine("Valor de entrada en la neurona X" + (i+1) + ":");
                entradas.Add(Convert.ToDouble(Console.ReadLine));
            }
            
            if(CantidadCapas == 4){
                
            }
            else{
                if(CantidadCapas == 3){

                }
                else{

                }
            }
             */

            
            
        }  

        public static void imprimirValoresDeEntradaIniciales(double[] listaDeValores){           
            for(int i = 0; i < listaDeValores.Length; i++){
                Console.WriteLine("Valore de entrada " + (i+1) + ": \t" + listaDeValores[i]);
                
            }
        }

        public static List<List<List<Double>>> purosArreglos(int Capas, int[] NeuronasEnCadaCapa, double[] entradas){
            List<List<List<Double>>> matrizDeTodo = new List<List<List<Double>>>();
            List<List<Double>> matrizDeNeuronasXValores = new List<List<Double>>();
            List<Double> valores = new List<Double>();
            
            for(int j = 0; j < Capas; j++){    
                    for(int i = 0; i < NeuronasEnCadaCapa[j]; i++){
                        
                        if(i==0){
                            valores.Add(1.0);
                        }
                        else{
                            if(j==0){
                                valores.Add(entradas[i]);
                            }else{
                                valores.Add(
                                    1/((1 - Math.Exp()))
                                    );
                            }
                            
                        }
                        
                    }
                    matrizDeNeuronasXValores.Add(valores);
                }

            matrizDeTodo.Add(matrizDeNeuronasXValores);  
            
            return matrizDeTodo;
        }

        public static void otroIntento(int capas, int[] cantidadPorCapa, double[] entradas ,List<Neurona> neuronas, List<Peso> pesos, List<Umbral> umbrales){
            
            for(int k = 0; k < capas; k++){
                for(int i = 0; i < cantidadPorCapa[k]; i++){
                    if(k==0){
                        neuronas.Add(new Neurona(k, i, null));        
                    }else{
                        neuronas.Add(new Neurona(k, i, 1));
                    }
                }
            }

            for(int k = 1; k < capas; k++){
                for(int i = 0; i < cantidadPorCapa[k]; i++){
                    umbrales.Add(new Umbral(k, i, 1));
                }
            }

            

            for(int k = 0; k < capas; k++){
                double sumatoria = 0;
                for(int i = 0; i < cantidadPorCapa[k]; i++){
                    if(k == 0){
                        pesos.Add(new Peso(k, i, i+1, entradas[i]));
                    }else{
                        for(j = 0; j < cantidadPorCapa[k-1]; j++){
                            sumatoria += 1;
                        }
                        pesos.Add(k, i, i+1, umbrales.Where( x => x.capa == k && x.neurona == i).Select(j => j.Valor));
                    }
                    
                }
            }

            

        }
    }
}