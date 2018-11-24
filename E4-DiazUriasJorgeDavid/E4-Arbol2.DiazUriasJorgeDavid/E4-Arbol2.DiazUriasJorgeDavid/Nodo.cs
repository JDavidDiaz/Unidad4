using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Arbol2.DiazUriasJorgeDavid
{
    class Nodo
    {
        public string key;
        public Nodo izq, der;
        public Nodo(string N)
        {
            key = N;
            izq = der = null;
        }
    }

}
