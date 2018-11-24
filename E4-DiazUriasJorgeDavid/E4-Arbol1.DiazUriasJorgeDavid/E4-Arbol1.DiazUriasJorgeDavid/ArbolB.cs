using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Arbol1.DiazUriasJorgeDavid
{
    class ArbolB
    {
        
        public void Tree()
        {
            Arbolito Arbol = new Arbolito();
            Arbol.Raiz = new Nodo("A");
            Arbol.Raiz.Izq = new Nodo("B");
            Arbol.Raiz.Med = new Nodo("C");
            Arbol.Raiz.Der = new Nodo("D");
            Arbol.Raiz.Izq.Izq = new Nodo("E");
            Arbol.Raiz.Izq.Med = new Nodo("F");
            Arbol.Raiz.Izq.Der = new Nodo("G");
            Arbol.Raiz.Der.Izq = new Nodo("H");
            Arbol.Raiz.Der.Med = new Nodo("I");
            Arbol.Raiz.Der.Der = new Nodo("J");
            Arbol.Raiz.Izq.Izq.Izq = new Nodo("K");
            Arbol.Raiz.Izq.Izq.Med = new Nodo("L");
            Arbol.Raiz.Izq.Izq.Der = new Nodo("M");
            Arbol.Raiz.Izq.Der.Med = new Nodo("N");
            Arbol.Raiz.Der.Izq.Med = new Nodo("O");
            Arbol.Raiz.Der.Der.Izq = new Nodo("P");
            Arbol.Raiz.Der.Der.Der = new Nodo("Q");
            Arbol.Raiz.Izq.Der.Med.Izq = new Nodo("R");
            Arbol.Raiz.Izq.Der.Med.Der = new Nodo("S");
            Console.WriteLine("Recorrido preorden:");
            Arbol.PreOrden();
            Console.WriteLine("\nRecorrido posorden:");
            Arbol.PostOrden();
            Console.ReadKey();
        }
    }
}
