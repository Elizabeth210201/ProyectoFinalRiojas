Public Class Lista
    Class Lista
    {
        //Variable(s)
        Private Nodo1 head;

        //Propiedades
        Public Nodo1 Head
        {
            Get
            {
                Return head;
            }
            Set
            {
                head = value;
            }
        }

        //Constructores
        Public Lista()
        {
            head = null;
        }

        //Metodos
        Public void Agregar(Nodo1 nuevo)
        {
            If (head == null)
            {
                head = nuevo;
                Return;
            }

            Nodo1 copia = head;
            While (copia.Siguiente!= null)
            {
                copia = copia.siguiente;
            }
            copia.Siguiente = nuevo;
        }
        Public bool Buscar(int valor)
        {
            If (head == null)
            {
                Return False;
            }

            Nodo1 copia = head;
            While (copia!= null)
            {
                If (copia.Valor == valor)
                {
                    Return True;
                }
                copia = copia.siguiente;
            }

            Return False;
        }

        Public GrafosConListas SeleccionarCamino(int valor)
        {
            If (head == null)
            {
                Return null;
            }

            Nodo1 copia = head;
            While (copia!= null)
            {
                If (copia.Valor == valor)
                {
                    Return copia.Lazos;
                }
                copia = copia.siguiente;
            }
            Return null;
        }



        Public void EliminarLazos(int valor)
        {
            Nodo1 copia = head;
            While (copia!= null)
            {
                GrafosConListas camino = copia.Lazos;
                camino.Eliminar(valor);

                copia = copia.siguiente;
            }
        }

        Public void Eliminar(int valor)
        {
            If (head == null)
            {
                Return;
            }
            If (head.Valor == valor)
            {
                head = head.siguiente;
                Return;
            }

            Nodo1 copia = head;
            Nodo1 auxiliar = head;
            While (copia!= null)
            {
                If (copia.Valor == valor)
                {
                    auxiliar.Siguiente = copia.Siguiente;
                    Return;
                }
                auxiliar = copia;
                copia = copia.siguiente;
            }
        }

        Public override String ToString()
        {
            String grafo = "";
            Nodo1 copia = head;
            While (copia!= null)
            {
                grafo += "[" + copia.Valor + "]";

                GrafosConListas camino = copia.Lazos;
                grafo += camino.ToString();

                copia = copia.siguiente;
                grafo += Environment.NewLine;
            }
            Return grafo;
        }
    }
End Class
