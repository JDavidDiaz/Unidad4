using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo.DiazUriasJorgeDavid
{
    class Graph<T>
    {
        public Graph() { }
        public Graph(IEnumerable<T> Vertices, IEnumerable<Tuple<T, T>> Aristas) //Recibe el numero de artistas y vertices enumerados
        {
            foreach (var Ver in Vertices)
            {
                AñadirVertice(Ver); //Manda el vertice actual para añadirlo
            }
            foreach (var Ari in Aristas)
            {
                AñadirArista(Ari); //Manda la arista actual para añadirla
            }
        }
        //Dictionary asigna una clave a un valor
        //HashSet permite saber si un objeto ya esta en el conjunto o no, es una coleccion que contiene elementos unicos (es similar a una lista)
        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

        public void AñadirVertice(T vertice)
        {
            AdjacencyList[vertice] = new HashSet<T>();
        }

        public void AñadirArista(Tuple<T, T> Arista)
        {
            if (AdjacencyList.ContainsKey(Arista.Item1) && AdjacencyList.ContainsKey(Arista.Item2))
            {
                AdjacencyList[Arista.Item1].Add(Arista.Item2);
                AdjacencyList[Arista.Item2].Add(Arista.Item1);
            }
        }
    }
}
