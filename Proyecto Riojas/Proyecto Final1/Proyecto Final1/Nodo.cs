using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class Nodo
    {
        //VARIVABLES//
        private int dato;
        private Nodo siguiente;
        private Nodo anterior;
        public Nodo izquierdo;
        public Nodo derecho;
       
        public Nodo(int info)
        {
            dato = info;
        }

        //CONSTRUCTORES//
        //Nodo
        public Nodo()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
            dato = 0;
            izquierdo = null;
            derecho = null;

        }
        //Componentes que contiene el nodo
        public Nodo(int d, Nodo s, Nodo a)
        {
            dato = d;
            siguiente = s;
            anterior = a;
        }

        //PROPIEDADES O METODOS//
        //Dato
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
     
      
       

        //Siguiente
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        //Anterior
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
