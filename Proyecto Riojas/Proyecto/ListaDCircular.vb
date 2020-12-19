Public Class ListaDCircular
    Class ListaDCircular1
    {
        Private Nodo head;

        Public ListaDCircular1()
        {
            head = null;
        }

        Public void Insertar(Nodo n)
        {
            //return;
            //unico nodo - lista vacia
            If (head == null)
            {
                n.Anterior = n;
                n.Siguiente = n;
                head = n;
                Return;
            }
            If (Buscar(n.Dato))
            {
                Return;
            }
            //Inicio
            If (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                n.Anterior = head.Anterior;
                head.Anterior = n;
                head.Siguiente = n;
                head = n;
                Return;
            }
            //recorrer
            Nodo h = head;
            bool a = False;
            While (h.Siguiente!= head)
            {
                If (n.Dato < (h.Siguiente).Dato) // insertar centro
                {
                    (h.Siguiente).Anterior = n;
                    n.Siguiente = h.Siguiente;
                    a = true;
                    break;
                }
                h = h.Siguiente;
            } //insertar final
            n.Anterior = h;
            h.Siguiente = n;
            If (a)
            {
                Return;
            }
            Else
            {
                head.Anterior = n;
                head.Anterior.Siguiente = head;
            }    
        }

        Public int Contar()
        {
            Nodo h = head;
            int i = 0;
            Do
            {
                i++;
                h = h.Siguiente;
            } while (h != head);
            Return i;
        }

        Public String MostrarDatos()
        {
            Nodo h = head;
            String s = "";
            Do
            {
                s += h.Dato + " - ";
                h = h.Siguiente;
            } while (h != head);
            Return s;
        }

        Public String MostrarDatosAnt()
        {
            Nodo h = head;
            String s = "";
            Do
            {
                s += h.Anterior.Dato + " - ";
                h = h.Anterior;
            } while (h != head);
            Return s;
        }

        Public bool Buscar(int b)
        {
            Nodo h = head;
            Do
            {
                If (b < h.Dato)
                {
                    Return False;
                }
                If (b == h.Dato)
                {
                    Return True;
                }
                h = h.Siguiente;
            } while (h != head);
            Return False;
        }

        Public void Borrar(int n)
        {
            If (head == null)
            {
                Return;
            }
            If (!Buscar(n))
            {
                Return;
            }
            //Inicio
            If (n == head.Dato)
            {
                head.Anterior.Siguiente = head.Siguiente;
                head.Siguiente.Anterior = head.Anterior;
                head = head.Siguiente;
                Return;
            }
            Nodo h = head;
            Do
            {
                If (n == (h.Siguiente).Dato)
                {
                    If (h.Siguiente.Siguiente!= head) // centro
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        h.Siguiente.Anterior = h;
                        Return;
                    }
                    Else //final
                    {
                        h.Siguiente = head;
                        head.Anterior = head.Anterior.Anterior;
                        Return;
                    }                  
                }
                h = h.Siguiente;
            } while (h != head);          
        }
    }
End Class
