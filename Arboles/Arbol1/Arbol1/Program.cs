using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol1
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
            intTree.Insert("A", Izquierda);
            intTree.Insert("B", BroIzquierdo);
            intTree.Insert("C", BroCentral);
            intTree.Insert("D", BroDerecho);
            intTree.Insert("F", Derecha);        
            Console.WriteLine("Max: " + intTree.FindMax()); //Encuentra el nodo con el valor mayor de el arbol
            Console.WriteLine("Min: " + intTree.FindMin()); //Encuentra el nodo con el valor menor de el arbol
            Console.WriteLine("Raiz: " + intTree.Root.Element); //Encuentra la raiz de el arbol
            Console.WriteLine("Arbol: " + intTree); //Representacion del arbol
            Console.WriteLine("Altura: " + intTree.RetornarAltura()); //Calcula la altura del arbol
            Console.WriteLine("No. de Niveles: " + (intTree.RetornarAltura() - 1)); //Calcula numero de niveles en el arbol
            Console.WriteLine("Ruta del elemento mas lejano: E > A > (B, C, D)\nRuta de la raiz hasta C: E > A > C"); //:v ez
            Console.ReadKey();
        }
    }
}
