using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class ListaSimple
    {
        //Variables
        private Nodo Head;
        //Constructores 
        public ListaSimple()
        {
            Head = null;
        }
        //Propiedades

        //Metodos
        //Insertar
        public void Insertar(Nodo n)
        {

            //unico nodo//Cuando la lista esta vacía 
            if (Head == null)
            {
                Head = n;
                return;
            }
            if (Buscar(n.Dato))
            {
                return;
            }

            //Inicio
            if (n.Dato < Head.Dato)
            {
                n.Siguiente = Head;
                Head = n;
                return;
            }
            Nodo h = Head;
            while (h.Siguiente != null)
            {
                if (n.Dato < (h.Siguiente).Dato)
                {
                    break;

                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;


        }
        public int Contar()
        {
            Nodo h = Head;
            int i = 0;
            while (h != null)
            {
                i++;
                h = h.Siguiente;
            }
            return i;
        }
        public string MostrarDatos()
        {
            Nodo h = Head;
            string s = "";
            while (h != null)
            {
                s += h.Dato + ",";
                h = h.Siguiente;

            }
            return s;
        }

        public bool Buscar(int b)
        {
            Nodo h = Head;

            while (h != null)
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
            }
            return false;
        }

        public void Eliminar(int b)
        {
            Nodo h = Head;
            if (Head == null)
            {
                return;
            }
            // !  = Not
            if (!Buscar(b))
            {
                return;
            }
            //Borrar al inicio
            if (b == Head.Dato)
            {
                Head = Head.Siguiente;
                return;
            }
            while (h.Siguiente != null)
            {
                if (b == h.Siguiente.Dato)
                {
                    h.Siguiente = h.Siguiente.Siguiente;
                    return;

                }
                h = h.Siguiente;
            }
        }
    }
}
