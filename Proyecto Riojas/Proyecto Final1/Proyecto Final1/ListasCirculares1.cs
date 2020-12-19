using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class ListasCirculares1
    {
         private Nodo head;
        Nodo ultimo;
        //Nodo anterior;

        public ListasCirculares1 ()
        {
            head = null;
        }

        public ListasCirculares1(Nodo nuevo)
        {
            head = nuevo;
        }

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        public int CantidadNodos
        {
            get
            {
                int cantidad = 0;
                Nodo h = head;
                while (h != head)
                {
                    cantidad++;
                    h = h.Siguiente;
                }
                return cantidad;
            }
        }


        public void Insertar(Nodo nuevo)
        {
            //insertar cuando la lista esté vacía
            if (head == null)
            {
                head = nuevo;
                head.Siguiente = nuevo;
                ultimo = nuevo;
                return;
            }

            //insertar al inicio
            if (nuevo.Dato < head.Dato)
            {
                nuevo.Siguiente = head;
                head = nuevo;
                ultimo.Siguiente = nuevo;
                return;
            }

            Nodo h = head.Siguiente;
            Nodo a = head;
            while (h != head)
            {
                
                //insertar entre dos nodos
                if (nuevo.Dato < h.Dato)
                {
                    nuevo.Siguiente = h;
                    a.Siguiente = nuevo;
                    return;
                }
                a = h;
                h = h.Siguiente;

            }
            //insertar al final
            nuevo.Siguiente = head;
            a.Siguiente = nuevo;
            ultimo = nuevo;  
        }

        public string Mostrar()
        {
            if (head == null)
                return "";
            string s = head.Dato + "";
            Nodo h = head.Siguiente;
            while (h != head)
            {
                s = s + Environment.NewLine + h.Dato;
                h = h.Siguiente;
            }
            return s;
        }

        public void Eliminar(int dato)
        {
            if (head == null)
            {
                return;
            }
            //Eliminar el único nodo en la lista
            if (head.Dato == dato && head.Siguiente == head)
            {
                head = null;
                ultimo = null;
                return;
            }
            //Eliminar el nodo apuntado por head
            if (head.Dato == dato)
            {
                head = head.Siguiente;
                ultimo.Siguiente = head;
                return;
            }
            //Eliminar entre dos nodos
            Nodo h = head.Siguiente;
            while (h != head)
            {
                if (h.Siguiente.Dato == dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
            h.Siguiente = h.Siguiente.Siguiente;
        }

        public bool Buscar(int dato)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Dato == dato) return true;

            Nodo h = head.Siguiente;
            while (h != head)
            {
                if (h.Dato == dato)
                {
                    return true;
                }
                h = h.Siguiente;
            }
          
            return false;
           
        }
    }
    }

