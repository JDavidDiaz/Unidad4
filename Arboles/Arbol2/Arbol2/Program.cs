using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbolito<string> intTree = new Arbolito<string>();
            //Se declara variable por cada posicion que tendran los nodos en el arbol
            string Raiz = "Raiz";
            string Derecha = "Derecha";
            string Izquierda = "Izquierda";
            string BroDerecho = "BroDerecho";
            string BroIzquierdo = "BroIzquierdo";
            string BroCentral = "BroCentral";
            //Se añaden los elementos al arbol junto con la posicion que tendran en el arbol
            intTree.Insert("E", Raiz);
            intTree.Insert("D", BroIzquierdo);
            intTree.Insert("F", BroCentral);
            intTree.Insert("G", BroDerecho);
            intTree.Insert("A", Derecha);
            intTree.Insert("B", Derecha);
            intTree.Insert("C", Derecha);
            Console.WriteLine("Nodo mas lejano de la raiz: " + intTree.FindMax()); //Encuentra el nodo con el nodo mas lejano de la raiz
            Console.WriteLine("Raiz: " + intTree.Root.Element); //Encuentra la raiz de el arbol
            Console.WriteLine("Arbol: " + intTree); //Representacion del arbol
            Console.WriteLine("Altura: " + intTree.RetornarAltura()); //Calcula la altura del arbol
            Console.WriteLine("No. de Niveles: " + (intTree.RetornarAltura() - 1)); //Calcula numero de niveles en el arbol
            Console.WriteLine("Ruta del elemento mas lejano: E > A > B > C"); //:)
            Console.ReadKey();
        }
    }
}
