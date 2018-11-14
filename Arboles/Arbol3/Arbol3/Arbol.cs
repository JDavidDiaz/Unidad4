using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol3
{
    class Arbol<T>
    {
        private int altura;
        public Nodo<T> Root { get; set; }

        public Arbol()
        {
            this.Root = null;
        }

        public void Insert(T x, string r) //Metodo para insertar los nodos
        {
            this.Root = Insert(x, Root, r); //Se envia como parametro el valor del nodo y su posicion
        }

        public T FindMin() //Obtiene el nodo de menor valor
        {
            return ElementAt(FindMin(Root)); //Manda como parametro la raiz para buscar el elemento menor en el arbol
        }

        public T FindMax()
        {
            return ElementAt(FindMax(Root)); //Manda como parametro la raiz para buscar el elemento mayor en el arbol
        }

        private T ElementAt(Nodo<T> t)
        {
            return t == null ? default(T) : t.Element;
        }


        private Nodo<T> FindMin(Nodo<T> t) //Encuentra el elemento menor en el arbol
        {
            if (t != null)
            {
                while (t.Left != null)
                {
                    t = t.Left;
                }
            }
            return t;
        }

        private void RetornarAltura(Nodo<T> reco, int nivel) //Recibe como parametro la raiz y el nivel (1)
        {
            if (reco != null)
            {
                RetornarAltura(reco.Left, nivel + 1);
                if (nivel > altura)
                {
                    altura = nivel; //Si el nivel es mayor que la altura entonces la altura sera igual al nivel + 1
                }
                RetornarAltura(reco.Right, nivel + 1);
            }
        }

        public int RetornarAltura()
        {
            altura = 0;
            RetornarAltura(Root, 0); //Envia como parametro la raiz y un 1
            return altura;
        }


        private Nodo<T> FindMax(Nodo<T> t) //Encuentra el elemento mayor del nodo
        {
            if (t != null)
            {
                while (t.Right != null)
                {
                    t = t.Right;
                }
            }
            return t;
        }

        protected Nodo<T> Insert(T x, Nodo<T> t, string r) //Acomoda los nodos segun la posicion en la que hayan entrado
        {
            if (t == null)
            {
                t = new Nodo<T>(x);
            }
            else if (r == "Izquierda")
            {
                t.Left = Insert(x, t.Left, r);
            }
            else if (r == "Derecha")
            {
                t.Right = Insert(x, t.Right, r);
            }
            else if (r == "BroCentral")
            {
                t.BroCenter = Insert(x, t.BroCenter, r);
            }
            else if (r == "BroIzquierdo")
            {
                t.BroLeft = Insert(x, t.BroLeft, r);
            }
            else if (r == "BroDerecho")
            {
                t.BroRight = Insert(x, t.BroRight, r);
            }
            return t;
        }

        public override string ToString()
        {
            return Root.ToString();
        }

    }
}
