using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class Pila
    {
        private Nodo head;
        public Pila()
        {
            head = null;
        }
        public bool pila_vacia()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(Nodo n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            n.Siguiente = head;
            head = n;
            return;
        }
        public Nodo Pop()
        {


            Nodo h = head;
            head = head.Siguiente;
            return h;
        }
    }
}
