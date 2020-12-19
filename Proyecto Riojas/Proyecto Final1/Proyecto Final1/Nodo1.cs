using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class Nodo1
    {
        
        //Variables
        public int valor;
        public Nodo1 siguiente;
        public GrafosConListas lazos;

        //Propiedades
        public int Valor 
        { 
            get 
            { 
                return valor; 
            } 
        }
        public Nodo1 Siguiente 
        {
            get 
     {             return siguiente;        } 
            set 
            { 
                siguiente = value; 
            } 
        }
        public GrafosConListas Lazos 
        { 
            get 
            { 
                return lazos; 
            } 
            set 
            { 
                lazos = value; 
            } 
        }
        
        //Constructores
        public Nodo1(int valor, Nodo1 Siguiente,GrafosConListas lazos)
        {
            this.valor = valor;
            this.Siguiente = siguiente;
            this.lazos = lazos;
        }

    }
}
