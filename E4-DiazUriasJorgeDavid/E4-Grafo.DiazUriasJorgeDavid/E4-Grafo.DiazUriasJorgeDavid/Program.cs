using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Grafo.DiazUriasJorgeDavid
{
    public static class DijkstraAlgoritmo
    {
        public static List<int> DijkstraAlgorithm(int[,] Grafo, int NodoOrigen, int NodoDestino)
        {
            var n = Grafo.GetLength(0);

            var Distancia = new int[n];
            for (int i = 0; i < n; i++)
            {
                Distancia[i] = int.MaxValue;
            }
            Distancia[NodoOrigen] = 0;
            var Visitado = new bool[n];
            var Anterior = new int?[n];
            while (true)
            {
                var DistanciaMin = int.MaxValue;
                var NodoMin = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!Visitado[i] && DistanciaMin > Distancia[i])
                    {
                        DistanciaMin = Distancia[i];
                        NodoMin = i;
                    }
                }
                if (DistanciaMin == int.MaxValue)
                {
                    break;
                }
                Visitado[NodoMin] = true;
                for (int i = 0; i < n; i++)
                {
                    if (Grafo[NodoMin, i] > 0)
                    {
                        var NodoMasCorto = Distancia[NodoMin];
                        var DistanciaSigNodo = Grafo[NodoMin, i];

                        var DistanciaTotal = NodoMasCorto + DistanciaSigNodo;

                        if (DistanciaTotal < Distancia[i])
                        {
                            Distancia[i] = DistanciaTotal;
                            Anterior[i] = NodoMin;
                        }
                    }
                }
            }
            if (Distancia[NodoDestino] == int.MaxValue)
            {
                return null;
            }
            var Camino = new LinkedList<int>();
            int? NodoActual = NodoDestino;
            while (NodoActual != null)
            {
                Camino.AddFirst(NodoActual.Value);
                NodoActual = Anterior[NodoActual.Value];
            }
            return Camino.ToList();
        }
        public static void Camino(int[,] Grafo, int NodoOrigen, int NodoDestino)
        {
            Console.Write("Recorrido mas corto [{0} -> {1}]: ", NodoOrigen, NodoDestino);
            var Camino = DijkstraAlgoritmo.DijkstraAlgorithm(Grafo, NodoOrigen, NodoDestino);
            if (Camino == null)
            {
                Console.WriteLine("no path");
            }
            else
            {
                int LongitudCamino = 0;
                for (int i = 0; i < Camino.Count - 1; i++)
                {
                    LongitudCamino += Grafo[Camino[i], Camino[i + 1]];
                }
                var Recorrido = string.Join("->", Camino);
                Console.WriteLine("{0} (Millas: {1})", Recorrido, LongitudCamino);
            }
        }

        public static void Main()
        {
            var graph = new[,]
            {
            // SF      LA    DV     CH      AT   MM    NY      BT 
            {    0,   359,  957,  1855,    0,    0,  2534,    0 }, // SanFrancisco (SF) - 0 
            {  359,     0,  834,     0,    0,    0,  2451,    0 }, // LosAngeles   (LA) - 1
            {  957,   834,    0,   908,    0,    0,     0,    0 }, // Denver       (DV) - 2
            { 1855,     0,  908,     0,  606,    0,   722,  860 }, // Chicago      (CH) - 3
            {    0,     0,    0,   606,    0,  595,   760,    0 }, // Atlanta      (AT) - 4
            {    0,     0,    0,     0,  595,    0,  1090,    0 }, // Miami        (MM) - 5
            { 2534,  2451,    0,   722,  760, 1090,     0,  191 }, // Nueva York   (NY) - 6
            {    0,     0,    0,   860,    0,    0,   191,    0 }, // Boston       (BT) - 7
            };
            Camino(graph, 1, 7);
            Camino(graph, 0, 6);
            Camino(graph, 0, 4);
            Camino(graph, 2, 6);
            Console.WriteLine("\n\nSan Francisco = 0\nLos Angeles = 1\nDenver = 2\nChicago = 3\nAtlanta = 4\nMiami = 5\nNueva York = 6\nBoston = 7");
            Console.ReadKey();
        }
    }
}
