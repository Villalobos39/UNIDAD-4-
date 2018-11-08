using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            Console.Write("\n\t>>>ARBOL BINARIO<<<\n");
            // ELEMENTOS DEL LAS HOJAS DEL ARBOL
            arbol.Insertar(50);
            arbol.Insertar(70);
            arbol.Insertar(40);
            arbol.Insertar(80);
            arbol.Insertar(30);
            arbol.Insertar(45);
            arbol.Insertar(65);
            arbol.Insertar(35);
            arbol.Insertar(25);
            arbol.Insertar(42);
            arbol.Insertar(47);
            arbol.Insertar(75);
            arbol.Insertar(85);
            // FORMAS DE ORDENAR LOS ELEMENTOS
            Console.Write("\n\tPreOrden: ");
            arbol.PreOrden();
            Console.Write("\n\tInOrden: ");
            arbol.Inorden();
            Console.Write("\n\tPostOrden: ");
            arbol.PostOrden();

            Console.ReadKey();

        }
    }
}


