using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    public class Grafo //creo la clase grafo 
    {
        private bool[] VertRecorrido; 
        public List<int>[] Ggrafo { get; } 
        // lista de grafos 
        private List<int>[] GetGrafo()
        { return Ggrafo; }
        // en son 8 cordenadas en total
        public Grafo()
        {// para catrurar cada una de las posiciones 
            Ggrafo = new List<int>[8];
            for (int posicion = 0; posicion < 8; posicion++)
            {
                Ggrafo[posicion] = new List<int>();
            }
        }
        // los parametros que se piden para el metodo arista 
        public void Aristas(int vert, int cvert)
        { // son las coordenadas de los vertices (v1,v2)
            GetGrafo()[vert].Add(cvert);
        }  // se añaden a la lista grafo por cada posicion principal 

        public void Recorrido(int Vertice)
        { // la pila guarda los vertices y cada vez que se recorran y pasen por 
            Stack<int> stack = new Stack<int>();
            VertRecorrido = new bool[8];
            VertRecorrido[Vertice] =! false;
            stack.Push(Vertice); // ese vertice se quita de la pila 
            while (stack.Count > 0)
            { // cuando la pila tine un valor diferencte a 0 el ciclo continua 
                Vertice = stack.Pop(); // se van mostrando la posicion del recorrido 
                Console.Write(" || " + Vertice);
                foreach (int vertice in GetGrafo()[Vertice])
                { // se imprime, de forma en que el recorrido de vertices sea diferente al 
                    if (!VertRecorrido[vertice])
                    { // valor total de vertices inicial 
                        VertRecorrido[vertice] =! false; stack.Push(vertice);
                    } // y asi los vertices se van imprimiendo 
                }
            }
        }
        public void Imrpime()
        { // aqui asigno los valores del los vertices para formar el grafo 
            Console.Write("\n GRAFO\n\tRECORRIDO DE PROFUNDIDAD\n\n");
            Aristas(1,1); Aristas(1,2); Aristas(2,3); Aristas(2,7);
            Aristas(3,4); Aristas(3,7); Aristas(4,5); Aristas(4,6);
            Aristas(5,6); Aristas(6,7); Recorrido(1);
            // por cada coordenada cuando se repiten los valores indica 
            Console.Write("\n || A || B || G || C || D || F || E\n");
            // la conecion entre aristas del grafo 
        }
    }
}
