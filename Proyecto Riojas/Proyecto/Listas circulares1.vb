Public Class Listas_circulares1
    Class ListasCirculares1
    {
         Private Nodo head;
        Nodo ultimo;
        //Nodo anterior;

        Public ListasCirculares1()
        {
            head = null;
        }

        Public ListasCirculares1(Nodo nuevo)
        {
            head = nuevo;
        }

        Public Nodo Head
        {
            Get { Return head; }
            Set { head = value; }
        }

        Public int CantidadNodos
        {
            Get
            {
                int cantidad = 0;
                Nodo h = head;
                While (h!= head)
                {
                    cantidad++;
                    h = h.Siguiente;
                }
                Return cantidad;
            }
        }


        Public void Insertar(Nodo nuevo)
        {
            //insertar cuando la lista esté vacía
            If (head == null)
            {
                head = nuevo;
                head.Siguiente = nuevo;
                ultimo = nuevo;
                Return;
            }

            //insertar al inicio
            If (nuevo.Dato < head.Dato)
            {
                nuevo.Siguiente = head;
                head = nuevo;
                ultimo.Siguiente = nuevo;
                Return;
            }

            Nodo h = head.Siguiente;
            Nodo a = head;
            While (h!= head)
            {
                
                //insertar entre dos nodos
                If (nuevo.Dato < h.Dato)
                {
                    nuevo.Siguiente = h;
                    a.Siguiente = nuevo;
                    Return;
                }
                a = h;
                h = h.Siguiente;

            }
            //insertar al final
            nuevo.Siguiente = head;
            a.Siguiente = nuevo;
            ultimo = nuevo;  
        }

        Public String Mostrar()
        {
            If (head == null)
        Return "";
            String s = head.Dato + "";
            Nodo h = head.Siguiente;
            While (h!= head)
            {
                s = s + Environment.NewLine + h.Dato;
                h = h.Siguiente;
            }
            Return s;
        }

        Public void Eliminar(int dato)
        {
            If (head == null)
            {
                Return;
            }
            //Eliminar el único nodo en la lista
            If (head.Dato == dato && head.Siguiente == head)
            {
                head = null;
                ultimo = null;
                Return;
            }
            //Eliminar el nodo apuntado por head
            If (head.Dato == dato)
            {
                head = head.Siguiente;
                ultimo.Siguiente = head;
                Return;
            }
            //Eliminar entre dos nodos
            Nodo h = head.Siguiente;
            While (h!= head)
            {
                If (h.Siguiente.Dato == dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
            h.Siguiente = h.Siguiente.Siguiente;
        }

        Public bool Buscar(int dato)
        {
            If (head == null)
            {
                Return False;
            }

            If (head.Dato == dato) Return True;

            Nodo h = head.Siguiente;
            While (h!= head)
            {
                If (h.Dato == dato)
                {
                    Return True;
                }
                h = h.Siguiente;
            }
          
            Return False;
           
        }
    }
End Class
