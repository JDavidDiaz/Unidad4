using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol<string> intTree = new Arbol<string>();
            //Se declara variable por cada posicion que tendran los nodos en el arbol
            string Raiz = "Raiz";
            string Derecha = "Derecha";
            string Izquierda = "Izquierda";
            string BroDerecho = "BroDerecho";
            string BroIzquierdo = "BroIzquierdo";
            string BroCentral = "BroCentral";
            //Se añaden los elementos al arbol junto con la posicion que tendran en el arbol
            intTree.Insert("K", Raiz);
            intTree.Insert("B", BroIzquierdo);
            intTree.Insert("A", BroCentral);
            intTree.Insert("C", BroDerecho);
            intTree.Insert("D", Derecha);
            intTree.Insert("E", Izquierda);
            intTree.Insert("F", Izquierda);
            intTree.Insert("G", Derecha);
            intTree.Insert("H", Derecha);
            intTree.Insert("I", Derecha);
            intTree.Insert("J", Derecha);
            Console.WriteLine("Nodo mas lejano de la raiz: " + intTree.FindMax()); //Encuentra el nodo con el nodo mas lejano de la raiz
            Console.WriteLine("Raiz: " + intTree.Root.Element); //Encuentra la raiz de el arbol
            Console.WriteLine("Arbol: " + intTree); //Representacion del arbol
            Console.WriteLine("Altura: " + intTree.RetornarAltura()); //Calcula la altura del arbol
            Console.WriteLine("No. de Niveles: " + (intTree.RetornarAltura() - 1)); //Calcula numero de niveles en el arbol
            Console.WriteLine("Ruta del elemento mas lejano: K > D > E > G > H\nRuta de la raiz a C: A > C\nRuta de la raiz a H: K > D > E > G\nRuta de la raiz a J: K > D > I > J"); //:)
            Console.ReadKey();
        }
    }
}
