using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    /// <summary>
    /// Ejemplo de lista y clase static.
    /// </summary>
    public static class Lista
    {
        public static string[] ListaArray() 
        {
            string[] miArrayDeNombresDePerros = new string[4];
            miArrayDeNombresDePerros[0] = "Laika";
            miArrayDeNombresDePerros[1] = "Coco";
            miArrayDeNombresDePerros[2] = "Thor";
            miArrayDeNombresDePerros[3] = "Tobi";

            return miArrayDeNombresDePerros;
        }

        public static List<string> ListaList()
        {
            List<string> personaNombres = new List<string>() 
            {
                "Danilo","Luis","Josué","Juan"
            };
            //personaNombres.Add("Danilo");
            //personaNombres.Add("Luis");
            return personaNombres;
        }

        public static LinkedList<int> EjemploLinkedList() 
        {
            LinkedList<int> numerosLinkedList = new LinkedList<int>();
            int[] arreglo = new int[6] {10,7,4,2,0,6 };
            foreach (var itemNumero in arreglo)
            {
                numerosLinkedList.AddFirst(itemNumero);
                //numerosLinkedList.AddLast(itemNumero);
            }
            numerosLinkedList.Remove(7);
            return numerosLinkedList;
        }
    }
}
  