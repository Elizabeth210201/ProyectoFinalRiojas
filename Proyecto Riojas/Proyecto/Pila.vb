Public Class Pila
    Class Pila
    {
        Private Nodo head;
        Public Pila()
        {
            head = null;
        }
        Public bool pila_vacia()
        {
            If (head == null)
            {
                Return True;
            }
            Else
            {
                Return False;
            }
        }
        Public void Push(Nodo n)
        {
            If (head == null)
            {
                head = n;
                Return;
            }
            n.Siguiente = head;
            head = n;
            Return;
        }
        Public Nodo Pop()
        {


            Nodo h = head;
            head = head.Siguiente;
            Return h;
        }
    }
End Class
