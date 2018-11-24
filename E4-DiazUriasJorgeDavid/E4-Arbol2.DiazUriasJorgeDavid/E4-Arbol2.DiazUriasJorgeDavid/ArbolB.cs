using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Arbol2.DiazUriasJorgeDavid
{
    class ArbolB
    {
        public Nodo Raiz;
        public ArbolB()
        {
            Raiz = null;
        }
        public void PostOrden(Nodo Nodo)
        { 
            if (Nodo == null)
            {
                return;
            }             
            PostOrden(Nodo.izq);
            PostOrden(Nodo.der);
            Console.Write(Nodo.key + " ");
        }
        public void PreOrden(Nodo Nodo)
        {  
            if (Nodo == null)
            {
                return;
            }           
            Console.Write(Nodo.key + " ");
            PreOrden(Nodo.izq);
            PreOrden(Nodo.der);
        }
        public void PostOrden()
        {
            PostOrden(Raiz);
        }
        public void PreOrden()
        {
            PreOrden(Raiz);
        }
    }
}
