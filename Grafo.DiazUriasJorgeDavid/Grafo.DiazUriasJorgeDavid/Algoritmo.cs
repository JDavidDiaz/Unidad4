using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo.DiazUriasJorgeDavid
{
    class Algoritmo
    {
        public HashSet<T> BFS<T>(Graph<T> Grafo, T Vinicial)
        {
            var Visitado = new HashSet<T>();
            if (!Grafo.AdjacencyList.ContainsKey(Vinicial))
            {
                return Visitado;
            }
            var queue = new Queue<T>(); //Se crea una Cola
            queue.Enqueue(Vinicial); //Añade el vertice inicial del grafo a la cola
            while (queue.Count > 0)
            {
                var Vertice = queue.Dequeue(); //Se crea una variable y obtiene el valor sacado de la cola               
                Visitado.Add(Vertice); //Añade el vertice a la "lista" de visitados
                foreach (var Vecino in Grafo.AdjacencyList[Vertice])
                {
                    if (!Visitado.Contains(Vecino))
                    {
                        queue.Enqueue(Vecino);
                    }
                }
            }
            return Visitado;
        }

        public Func<T, IEnumerable<T>> CaminoCortoFuncion<T>(Graph<T> Grafo, T VInicial)
        {
            var Anterior = new Dictionary<T, T>();
            var queue = new Queue<T>();
            queue.Enqueue(VInicial); //Añade el vertice inicial a la cola
            while (queue.Count > 0)
            {
                var Vertice = queue.Dequeue(); //Se crea una variable y obtiene el valor sacado de la cola 
                foreach (var Vecino in Grafo.AdjacencyList[Vertice])
                {
                    if (Anterior.ContainsKey(Vecino))
                    {
                        continue;
                    }
                    Anterior[Vecino] = Vertice;
                    queue.Enqueue(Vecino);
                }
            }

            Func<T, IEnumerable<T>> CaminoCorto = v =>
            {
                var Camino = new List<T> { }; //Se crea una lista
                var Actual = v;
                while (!Actual.Equals(VInicial))
                {
                    Camino.Add(Actual); //Añade el vertice actual de recorrido
                    Actual = Anterior[Actual];
                }
                Camino.Add(VInicial);
                Camino.Reverse();
                return Camino;
            };
            return CaminoCorto;
        }
    }
}
