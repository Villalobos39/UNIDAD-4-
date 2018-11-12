using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    class Arbol
    {
        private Nodo raiz; // EL NODO RAIZ O PRINCIPAL 
        private Nodo rama; private int valor = 0; // I 
        public int altura = 0, nivel = 0;

        public Arbol()
        {
            raiz = new Nodo(); // INICIlIZO EN NODO RAIZ
        }

        // CUANDO SE INCERTA UN NUEVO NODO 
        public Nodo InsertarNodo(string letra,Nodo nodo)
        {   // EN ESTE METODO INSERTAREMOS DOS PARAMETROS 
            // EL PRIMERO ES EL CARACTER QUE VAMOS A INSERTAR
            // Y EL NODO CORRESPONDE A LA POSICION DENDE SE ENCONTRARA 
            if (nodo==null)
            { // CUANDO EN NODO NO EXISTE , EL ELEMENTO PRINCIPAL 
                // SE CONVERTIRA EN LA RAIZ 
                raiz = new Nodo { Dato = letra,  Hijo = null, Hermano = null }; return raiz;
            }
            // COMO LA RAIZ NO TIENE HERMANOS EL VALOR QUE SE LE PONE ES NULL
            // AL DETERMINAR QUE LA RAIZ TIENE O NO UN HIJO 
            if (nodo.Hijo == null)
            { // SI DICE QUE NO, ENTONCE SE LE PUEDE INSERTAR UNO SI ASI LO DESEA 
                Nodo elemento = new Nodo(); // CREE UN NODO ELEMENTO QUE SERA EL ENCARGADO DE GUARDAR 
                elemento.Dato = letra; // EL CRACTER QUE EL USUSRIO INGRESE, EN ESTE CASO YA ESTAN POR DEFECTO
                nodo.Hijo = elemento; 
                return elemento; // ESE ELEMNTO SERA ASIGNADO COMO UN NODO HIJO.
            } // SI EL NODO YA TIENE HIJOS ENTONCES 
            else
            {// EL SISGUIENETE ELEMENTO SERA DECLARADO COMO HERMANO 
                rama = nodo.Hijo;
                // DE ESTA MANERA SE PODRIA DECIR QUE ESTE ARBO PUEDE TENER MAS DE DOS HIJOS 
                while (rama.Hermano!=null)
                { // MIENTRAS LA RAMA NO SEA IGUAL A NULL    
                    rama = rama.Hermano;
                } // SE AVANZA HASTA LLEGAR AL FINAL QUE SERUA EL ULTIMO HERMANO
                Nodo elemento = new Nodo();
                elemento.Dato = letra; rama.Hermano = elemento;
                return elemento;
            }
        }

        public void Preorden(Nodo nodo)
        {
            if (nodo == null)  return; // ASIGNA EL ESPACIO EN QUE SE ENCUENTRA EL NODO 
            for (int num = 0; num < valor; num++)  Console.Write("- ");            
            Console.WriteLine(nodo.Dato);            
            if(nodo.Hijo!=null) // DEPENDIENDO SE SUS HIJOS DE CADA NODO SE VAN CONCANTENANDO 
            {// COMODANDOLOS EN ORDEN 
                valor++;// EL VALOR DETERMINA SU POSICION POR LO CUAL POR CADA HIJO SE 
                Preorden(nodo.Hijo);// AUMENTA UN ESPACIO PERO POR CADA OTRO SE QUITA PARA 
                valor--; //  QUE NO SE COLOQUE EN UNA POSOCION MAYOR QUE SU HIJO POR CONSIGUIENTE 
            }
            if (nodo.Hermano != null) // SI EXISTE UN NODO HERMANO SE ANEXA 
               Preorden(nodo.Hermano);
        }

        private void Calcular(Nodo hoja, int estan)
        {
            if (hoja != null) // SI EXISTE UN NODO 
            {
                if (estan <= altura) // SI EL VALOR DE ESTAN ES MENOS O IGUAL A LA ALTURA 
                    altura = estan; // EL VALOR DE ALTURA ES IGUAL A ESTAN QUE ES EL MISMO 
                Calcular(hoja.Hijo, estan); altura++; // ESTE CON
                if (estan <= nivel)
                    nivel = estan;
                Calcular(hoja.Hijo, estan+1); nivel++;
            }
        }

        public int Altura()
        {
            // LA ALTURA SE MARCA DESSDE EL PRIMER NODO LA RAIZ 1 
            altura = 1; // LA ALTURA COMIENZA EN 1
            Calcular(raiz, altura); // MANDAMOS A LLAMAR AL METODO 
            return altura; // ENVIANDOLE LOS PARAMETROS POR DEFECTO
        }

        public int  Nivel()
        {
            // EL NIVEL DE UN ARBOL COMIENZA DESDE EL NIVEL 0 
            nivel = 0;
            Calcular(raiz, nivel);
            return nivel;
        }

        private Nodo Recorrido(string letra, Nodo nodo)
        {
            Nodo encontrar = null; // SI SE BUSCA EL NODO DE LA RAIZ
            if (nodo == null) // CUANDO YA NO HAY NODO QUE BUSCAR  
                return encontrar;
            if (nodo.Dato.CompareTo(letra)==0) // CUANDO SE LLEGA A BUSCAR EL NODO 
            {  encontrar = nodo; return encontrar; }

            if (nodo.Hijo !=null)// SI EL NODO QUE SE BUSCA ES EL HIJO DEL NODO PADRE 
            {
                encontrar = Recorrido(letra, nodo.Hijo);
                if (encontrar != null) return encontrar; 
            }

            if (nodo.Hermano != null)// SI EL NODO QUE SE BUSCA ES EL HIJO DEL NODO PADRE 
            {
                encontrar = Recorrido(letra, nodo.Hermano);
                if (encontrar != null) return encontrar;
            }
            return encontrar;
        }

        public void MayorValorl()
        {
            if (raiz != null)
            {
                Nodo nodo = raiz;              
                while (nodo.Hijo != null) // SI EL NODO HIJO ES DIFERENTE A NULL 
                    nodo = nodo.Hijo; // AVANZA HASTA EL ULTIMO DE ELLOS 
                while (nodo.Hermano != null) // SI ALGUNO DE ESOS NODOS TIENE 
                    nodo = nodo.Hermano;  // HIJOS CON HERMANOS LOS RECORRE            
                Console.WriteLine("\nHIJO MAYOR DEL ARBOL :" + nodo.Dato);
            }
        }

        public void Busqueda()
        {
            Console.Write("\n RECORREDO DE BUSQUE : \n");// EL BUSCADOR 
            Console.Write("QUE ELEMENTO BUSCA EN EL ARBOL  : ");
            string variable = Console.ReadLine();// DETERMINA SI LA VARIABLES QUE INGRESE EL USUARIO EXISTE 
            Nodo Encontrar = Recorrido(variable, raiz);
            if (Encontrar != null) // SI SE ENCUENTRA EN EL ARBOL 
            { Console.WriteLine("SI SE ENCUENTA {0}", Encontrar.Dato); }
            else { Console.Write("NO SE ENCONTRO"); Busqueda(); } // SI VUELVE A PREGUNTAR 
        }
    }
}



