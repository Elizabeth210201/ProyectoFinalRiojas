using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class ListaDCircular1
    {
        private Nodo head;

        public ListaDCircular1()
        {
            head = null;
        }

        public void Insertar(Nodo n)
        {
            //return;
            //unico nodo - lista vacia
            if (head == null)
            {
                n.Anterior = n;
                n.Siguiente = n;
                head = n;
                return;
            }
            if (Buscar(n.Dato))
            {
                return;
            }
            //Inicio
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                n.Anterior = head.Anterior;
                head.Anterior = n;
                head.Siguiente = n;
                head = n;
                return;
            }
            //recorrer
            Nodo h = head;
            bool a = false;
            while (h.Siguiente != head)
            {
                if (n.Dato < (h.Siguiente).Dato) //insertar centro
                {
                    (h.Siguiente).Anterior = n;
                    n.Siguiente = h.Siguiente;
                    a = true;
                    break;
                }
                h = h.Siguiente;
            } //insertar final
            n.Anterior = h;
            h.Siguiente = n;
            if (a)
            {
                return;
            }
            else
            {
                head.Anterior = n;
                head.Anterior.Siguiente = head;
            }    
        }

        public int Contar()
        {
            Nodo h = head;
            int i = 0;
            do
            {
                i++;
                h = h.Siguiente;
            } while (h != head);
            return i;
        }

        public string MostrarDatos()
        {
            Nodo h = head;
            string s = "";
            do
            {
                s += h.Dato + " - ";
                h = h.Siguiente;
            } while (h != head);
            return s;
        }

        public string MostrarDatosAnt()
        {
            Nodo h = head;
            string s = "";
            do
            {
                s += h.Anterior.Dato + " - ";
                h = h.Anterior;
            } while (h != head);
            return s;
        }

        public bool Buscar(int b)
        {
            Nodo h = head;
            do
            {
                if (b < h.Dato)
                {
                    return false;
                }
                if (b == h.Dato)
                {
                    return true;
                }
                h = h.Siguiente;
            } while (h != head);
            return false;
        }

        public void Borrar(int n)
        {
            if (head == null)
            {
                return;
            }
            if (!Buscar(n))
            {
                return;
            }
            //Inicio
            if (n == head.Dato)
            {
                head.Anterior.Siguiente = head.Siguiente;
                head.Siguiente.Anterior = head.Anterior;
                head = head.Siguiente;
                return;
            }
            Nodo h = head;
            do
            {
                if (n == (h.Siguiente).Dato)
                {
                    if (h.Siguiente.Siguiente != head)//centro
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        h.Siguiente.Anterior = h;
                        return;
                    }
                    else //final
                    {
                        h.Siguiente = head;
                        head.Anterior = head.Anterior.Anterior;
                        return;
                    }                  
                }
                h = h.Siguiente;
            } while (h != head);          
        }
    }
}
