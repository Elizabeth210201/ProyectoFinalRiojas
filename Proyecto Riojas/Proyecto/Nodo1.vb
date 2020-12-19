Public Class Nodo1
    Class Nodo1
    {
        
        //Variables
        Public int valor;
        Public Nodo1 siguiente;
        Public GrafosConListas lazos;

        //Propiedades
        Public int Valor 
        { 
            Get
            { 
                Return valor; 
            } 
        }
        Public Nodo1 Siguiente 
        {
            Get
     {             return siguiente;        } 
            Set
            { 
                siguiente = value; 
            } 
        }
        Public GrafosConListas Lazos 
        { 
            Get
            { 
                Return lazos; 
            } 
            Set
            { 
                lazos = value; 
            } 
        }
        
        //Constructores
        Public Nodo1(int valor, Nodo1 Siguiente,GrafosConListas lazos)
        {
            this.valor = valor;
            this.Siguiente = siguiente;
            this.lazos = lazos;
        }

    }
End Class
