using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo.DiazUriasJorgeDavid
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Vertice = new[] { "A", "B", "C", "G", "F", "D", "E" }; //Se crea una matriz con las vertices del grafo
            var Arista = new[]{Tuple.Create("A","B"), Tuple.Create("B","G"), //Camino 1
                Tuple.Create("C","B"), Tuple.Create("D","C"), Tuple.Create("C","G"), //Tuple permite almacenar 2 valores diferentes en la matriz que estan relacionados
                Tuple.Create("D","F"), Tuple.Create("D","E"), Tuple.Create("F","E")}; //En este caso permite saber los vertices que estan conectados entre si

            var Arista2 = new[]{Tuple.Create("A","B"), Tuple.Create("B","C"),
                Tuple.Create("G","B"), Tuple.Create("F","G"), Tuple.Create("C","G"), //Camino 2
                Tuple.Create("D","F"), Tuple.Create("D","E"), Tuple.Create("F","E")};

            var Grafo = new Graph<string>(Vertice, Arista); //Crea un objeto para el Camino 1
            var Grafo2 = new Graph<string>(Vertice, Arista2); //Crea un objeto para el Camino 2
            var Algoritmo = new Algoritmo(); //Se crea un objeto de la clase algoritmo

            var CaminoCorto = Algoritmo.CaminoCortoFuncion(Grafo, "A"); //Envia como parametro el grafo junto con el vertice inicial del grafo

            foreach (var item in Vertice) //Impresion de los caminos para cada vertice
            {   //String.Join combina varias cadenas en una sola
                Console.WriteLine("Camino mas corto para el vertice {0}: {1}", item, string.Join(" > ", CaminoCorto(item)));
            }
            Console.WriteLine("\nRecorridos simples para el grafo:");
            Console.WriteLine(string.Join(" > ", Algoritmo.BFS(Grafo, "A"))); //Camino 1
            Console.WriteLine(string.Join(" > ", Algoritmo.BFS(Grafo2, "A"))); //Camino 2
            Console.ReadKey();
        }
    }
}
