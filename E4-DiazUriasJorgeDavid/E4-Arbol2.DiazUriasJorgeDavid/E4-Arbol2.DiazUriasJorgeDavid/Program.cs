using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Arbol2.DiazUriasJorgeDavid
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolB Arbol = new ArbolB();
            Arbol.Raiz = new Nodo("A");
            Arbol.Raiz.izq = new Nodo("B");
            Arbol.Raiz.der = new Nodo("E");
            Arbol.Raiz.izq.izq = new Nodo("C");
            Arbol.Raiz.izq.der = new Nodo("D");
            Arbol.Raiz.der.der = new Nodo("F");
            Arbol.Raiz.der.der.izq = new Nodo("G");
            Arbol.Raiz.der.der.der = new Nodo("H");
            Console.WriteLine("Recorrido preorden: ");
            Arbol.PreOrden();
            Console.WriteLine("\nRecorrido posorden:");
            Arbol.PostOrden();
            Console.ReadKey();
        }
    }
}
