using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir Arboles = new Imprimir();
            
            Console.Write("\n\t>>> ARBOLES  <<<\n");
            Console.Write("ARBOL 1 || ARBOL 2|| ARBOL 3");
            
            Console.Write("\n\n\t>>> ARBOL UNO  <<<\n");
                Arboles.PrimerArbol();
                //   RAIZ                   E                  NIVEL 0  ALTURA 1
                //   NODO HIJOS       A            F           NIVEL 1  ALTURA 2
                //   HOJAS        B   C   D                    NIVEL 2  ALTURA 3
                //
           
            Console.Write("\n\n\t>>> ARBOL DOS  <<<\n");
            Arboles.SegundoArbol();

                //   RAIZ                   C                  NIVEL 0  ALTURA 1
                //   NODO PADRE         A      D     F    G    NIVEL 1  ALTURA 2
                //   NODO HIJO       B                         NIVEL 2  ALTURA 3
                //   NODO HOJA     E                           NIVEL 3  ALTURA 4   

            Console.Write("\n\n\t>>> ARBOL TRES  <<<\n");
            Arboles.TercerArbol();

            //   RAIZ                   K                      NIVEL 0  ALTURA 1
            //   NODO PADRE     A    B     C    D              NIVEL 1  ALTURA 2
            //   NODO HIJO                    I    E           NIVEL 2  ALTURA 3
            //   NODO HOJA                  J     F  G         NIVEL 3  ALTURA 4   
            //   NODO HOJA                             H       NIVEL 4  ALTURA 5 

            Console.ReadKey();
        }
    }
}
