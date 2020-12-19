using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class Lista
    {
        //Variable(s)
        private Nodo1 head;

        //Propiedades
        public Nodo1 Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        //Constructores
        public Lista()
        {
            head = null;
        }

        //Metodos
        public void Agregar(Nodo1 nuevo)
        {
            if (head == null)
            {
                head = nuevo;
                return;
            }

            Nodo1 copia = head;
            while (copia.Siguiente != null)
            {
                copia = copia.siguiente;
            }
            copia.Siguiente = nuevo;
        }
        public bool Buscar(int valor)
        {
            if (head == null)
            {
                return false;
            }

            Nodo1 copia = head;
            while (copia != null)
            {
                if (copia.Valor == valor)
                {
                    return true;
                }
                copia = copia.siguiente;
            }

            return false;
        }

        public GrafosConListas SeleccionarCamino(int valor)
        {
            if (head == null)
            {
                return null;
            }

            Nodo1 copia = head;
            while (copia != null)
            {
                if (copia.Valor == valor)
                {
                    return copia.Lazos;
                }
                copia = copia.siguiente;
            }
            return null;
        }



        public void EliminarLazos(int valor)
        {
            Nodo1 copia = head;
            while (copia != null)
            {
                GrafosConListas camino = copia.Lazos;
                camino.Eliminar(valor);

                copia = copia.siguiente;
            }
        }

        public void Eliminar(int valor)
        {
            if (head == null)
            {
                return;
            }
            if (head.Valor == valor)
            {
                head = head.siguiente;
                return;
            }

            Nodo1 copia = head;
            Nodo1 auxiliar = head;
            while (copia != null)
            {
                if (copia.Valor == valor)
                {
                    auxiliar.Siguiente = copia.Siguiente;
                    return;
                }
                auxiliar = copia;
                copia = copia.siguiente;
            }
        }

        public override string ToString()
        {
            string grafo = "";
            Nodo1 copia = head;
            while (copia != null)
            {
                grafo += "[" + copia.Valor + "]";

                GrafosConListas camino = copia.Lazos;
                grafo += camino.ToString();

                copia = copia.siguiente;
                grafo += Environment.NewLine;
            }
            return grafo;
        }
    }
}
