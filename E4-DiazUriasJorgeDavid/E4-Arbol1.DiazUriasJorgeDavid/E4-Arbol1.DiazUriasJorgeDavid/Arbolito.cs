using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Arbol1.DiazUriasJorgeDavid
{
    class Arbolito
    {
        public Nodo Raiz;
        public Arbolito()
        {
            Raiz = null;
        }
        public void PostOrden(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            PostOrden(nodo.Izq);
            PostOrden(nodo.Med);
            PostOrden(nodo.Der);
            Console.Write(nodo.Node + " ");
        }
        public void PreOrden(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            Console.Write(nodo.Node + " ");
            PreOrden(nodo.Izq);
            PreOrden(nodo.Med);
            PreOrden(nodo.Der);
        }
        public void PostOrden() { PostOrden(Raiz); }
        public void PreOrden() { PreOrden(Raiz); }
    }
}
