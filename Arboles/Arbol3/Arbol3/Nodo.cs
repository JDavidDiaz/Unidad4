using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol3
{
    class Nodo<T>
    {
        public T Element { get; set; } //Propiedades
        public Nodo<T> Left { get; set; }
        public Nodo<T> Right { get; set; }
        public Nodo<T> BroCenter { get; set; }
        public Nodo<T> BroLeft { get; set; }
        public Nodo<T> BroRight { get; set; }

        public Nodo(T element)
        {
            this.Element = element;
        }

        public override string ToString() //Imprime la representacion textual de el orden de arbol
        {

            string nodeString = "[ " + Element + " ";

            if (Element.ToString() == "D" || Element.ToString() == "E" || Element.ToString() == "G" || Element.ToString() == "I")
            {

            }

            else if ((Left == null))
            {
                nodeString += "(Hoja) " + "]";
            }

            

            if (BroLeft != null)
            {
                nodeString += " Izquierda: [ " + BroLeft.ToString();
            }

            if (BroCenter != null)
            {
                nodeString += " Central: " + BroCenter.ToString();
            }

            if (BroRight != null)
            {
                nodeString += " Derecha: " + BroRight.ToString() + " ]";
            }

            if (Right != null)
            {
                nodeString += " Derecha: " + Right.ToString();
            }
            if (Left != null)
            {
                nodeString += " Izquierda: " + "[ " + Left.ToString();
            }
            return nodeString;
        }
    }
}
