using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    class Imprimir
    {
        Arbol arbol = new Arbol();

        public void PrimerArbol()
        { // NODO RAIZ " E "
            Nodo raiz = arbol.InsertarNodo("E", null); // NODO HIJO "F" 
                arbol.InsertarNodo("F", raiz);
                // NODO HERMANO "A" Y PADRE (RAIZ)
                Nodo ARaiz = arbol.InsertarNodo("A", raiz);
                // NODOS HIJOS , HERMANOS ENTRE ELLOS (C, B, D)
                    arbol.InsertarNodo("C", ARaiz);
                    arbol.InsertarNodo("B", ARaiz);
                    arbol.InsertarNodo("D", ARaiz);
            arbol.Preorden(raiz);
            Console.Write("\n\t ALTURA: {0}", arbol.Altura());
            Console.Write("\n\t NIVEL: {0}", arbol.Nivel()); 
        }

        public void SegundoArbol()
        { // NODO RAIZ " C "
            Nodo raiz = arbol.InsertarNodo("C", null);
                // NODO HERMANO "A" Y PADRE (RAIZ)
                Nodo ARaiz = arbol.InsertarNodo("A", raiz);
                    Nodo BRaiz = arbol.InsertarNodo("B", ARaiz);
                    // NODO HIJO "E" 
                    arbol.InsertarNodo("E", BRaiz);
            // NODOS HIJOS , HERMANOS ENTRE ELLOS (D, F, G)
            arbol.InsertarNodo("D", raiz); // CADA QUE SE CREA UN NODO ESTO INDICA 
            arbol.InsertarNodo("F", raiz); // QUE TIENE HIJOS
            arbol.InsertarNodo("G", raiz);  // Y TODOS LOS QUE TIENE EL NOMBRE DE LA RAIZ 
            arbol.Preorden(raiz); // SON SUS HERMANOS 
            arbol.MayorValorl();
        }

        public void TercerArbol()
        { // NODO RAIZ " K "
            Nodo raiz = arbol.InsertarNodo("K", null);
            // NODOS HIJOS , HERMANOS ENTRE ELLOS (C, B, D)
                arbol.InsertarNodo("A", raiz);
                arbol.InsertarNodo("B", raiz);
                arbol.InsertarNodo("C", raiz);
            Nodo ARaiz = arbol.InsertarNodo("D", raiz);
            Nodo IRaiz = arbol.InsertarNodo("I", ARaiz);
                         arbol.InsertarNodo("J", IRaiz);
            Nodo ERaiz = arbol.InsertarNodo("E", ARaiz);
                         arbol.InsertarNodo("F", ERaiz);
            Nodo GRaiz = arbol.InsertarNodo("G", ERaiz);
                         arbol.InsertarNodo("H", GRaiz);
            // NODO HERMANO "A" Y PADRE (RAIZ)
            arbol.Preorden(raiz);     
            arbol.Busqueda();

        }
    }
}

//Console.Write("\n\t ALTURA: {0}", (arbol.Altura() - 1));
//Console.Write("\n\t NIVEL: {0}", (arbol.Nivel() - 3));
//Console.Write("\n\t ALTURA: {0}", (arbol.Altura()+2));
//Console.Write("\n\t NIVEL: {0}", (arbol.Nivel()+2));
//  arbol.MayorValorl();