using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    class Nodo
    {
        public string Dato { get; set; }//LOS PARAMETROS
        public Nodo Hijo { get; set; }//  LOS NODOS HIJOS DETERMINAN SI ESTOS TIENEN HERMANOS O NO 
        public Nodo Hermano { get; set; } // NODO HERMANO ESTE ES EL NODO PRINCIPAL YA QUE SI 
        // UN NODO NO TIENE HERMANO POR DEFECTO ES EL NODO RAIZ 
        public Nodo ()
        {
            Dato =" ";
            Hijo = null;
            Hermano = null;
        }

    }
}
