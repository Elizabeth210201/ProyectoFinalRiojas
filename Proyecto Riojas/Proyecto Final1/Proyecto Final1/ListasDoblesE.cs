using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class ListasDoblesE
    { 
        private Nodo head;
        private Nodo bottom;

        public ListasDoblesE ()
        {
            head = null;
            bottom = null;
        }
        //Ingresar Datos
        public void Ingresar(Nodo d)

        {
          //  Nodo actual = new Nodo();
            Nodo ne = new Nodo();
            ne = d;
         //   actual = head;

            //unico nodo//Cuando la lista esta vacía 
            if (head == null)
            {
                head = ne;
                bottom = ne;
                return;
            }


            //Inicio

            if (ne.Dato < head.Dato)
            {
                ne.Siguiente = head;
                head.Anterior = ne;
                head = ne;
                return;
            }

            //recorrer
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (ne.Dato < (h.Siguiente).Dato)
                {
                    break;

                }
                h = h.Siguiente;
            }
            ne.Siguiente = h.Siguiente;
            h.Siguiente = ne;

            }
        public void recorrerhaciaatras(Nodo d)
        {

            Nodo nodito = new Nodo();
            nodito = d;
            if (bottom  == null)
            {
                bottom = d;

            }
            if (bottom !=null)
            {
                 if (nodito.Dato > bottom.Dato)
                {
                    nodito.Anterior = bottom;
                    bottom = nodito;

                }

                if (nodito.Dato < head.Dato)
                {
                    nodito.Siguiente  = bottom.Anterior;
                    nodito.Anterior = nodito;

                        
                }

            }
          
           


        }
        public bool Buscar(int d)
        {
            Nodo h = head;

            while (h != null)
            {
                if (d < h.Dato)
                {
                    return false;
                }
                if (d == h.Dato)
                {
                    return true;
                }
                h = h.Siguiente;

            }
            return false;
        }
       
        //Eliminar dato específico
        public void borrar(int d)
        {
            if (head==null)
            {
                return;
            }
            if (!Buscar(d))
            {
                return;
            }
            if (d==head.Dato)
            {
                head = head.Siguiente;
                head = head.Anterior;
                return;
            }

            Nodo h = head;
           
            while (h.Anterior == null)
            {
                if (d == h.Anterior.Dato)
                {
                    h.Anterior = h.Anterior.Anterior;
                    return;
                }
                h = h.Anterior;
            }
           
        
           

        }
        //Eliminar primer dato
        public void borrarPrimero()
        {
            head = head.Siguiente;
            head.Anterior = null;
        }
        //Eliminar ultimo dato
        public void borrarUltimo()
        {
            if (bottom.Anterior == null)
            {
                head = null;
                bottom = null;
            }
            else
            {
                bottom = bottom.Anterior;
                bottom.Siguiente = null;
            }
        }
        //Recorrer de cabeza a cola
        public string RecorrerAdelante()
        {
            Nodo h = head;
            string s = "";
            while(h!=null)
            {
                s += h.Dato + "-";
                h = h.Siguiente;
            }
            return s;
        }
        //Recorrer de cola a cabeza
        public string RecorrerAtras()
        {
            
            Nodo b = bottom ;
            string s = "";
            while (b != null)
            {
                s += b.Dato + "-";
                b = b.Anterior ;
            }
            return s;
        }
    }
}
