using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Arbol1.DiazUriasJorgeDavid
{
    class Nodo
    {
        public string Node;
        public Nodo Izq, Der, Med;

        public Nodo(string N)
        {
            Node = N;
            Izq = Der = Med = null;
        }
    }
}
