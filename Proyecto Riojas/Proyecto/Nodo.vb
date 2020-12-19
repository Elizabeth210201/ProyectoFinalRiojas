Public Class Nodo

    Class Nodo
    {
        //VARIVABLES//
        Private int dato;
        Private Nodo siguiente;
        Private Nodo anterior;
        Public Nodo izquierdo;
        Public Nodo derecho;
       
        Public Nodo(int info)
        {
            dato = info;
        }

        //CONSTRUCTORES//
        //Nodo
        Public Nodo()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
            dato = 0;
            izquierdo = null;
            derecho = null;

        }
        //Componentes que contiene el nodo
        Public Nodo(int d, Nodo s, Nodo a)
        {
            dato = d;
            siguiente = s;
            anterior = a;
        }

        //PROPIEDADES O METODOS//
        //Dato
        Public int Dato
        {
            Get { Return dato; }
            Set { dato = value; }
        }
     
      
       

        //Siguiente
        Public Nodo Siguiente
        {
            Get { Return siguiente; }
            Set { siguiente = value; }
        }
        //Anterior
        Public Nodo Anterior
        {
            Get { Return anterior; }
            Set { anterior = value; }
        }
    }
End Class
