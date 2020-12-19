Public Class listasdoblesE

    Class ListasDoblesE
    { 
        Private Nodo head;
        Private Nodo bottom;

        Public ListasDoblesE()
        {
            head = null;
            bottom = null;
        }
        //Ingresar Datos
        Public void Ingresar(Nodo d)

        {
          //  Nodo actual = New Nodo();
            Nodo ne = New Nodo();
            ne = d;
         //   actual = head;

            //unico nodo//Cuando la lista esta vacía 
            If (head == null)
            {
                head = ne;
                bottom = ne;
                Return;
            }


            //Inicio

            If (ne.Dato < head.Dato)
            {
                ne.Siguiente = head;
                head.Anterior = ne;
                head = ne;
                Return;
            }

            //recorrer
            Nodo h = head;
            While (h.Siguiente!= null)
            {
                If (ne.Dato < (h.Siguiente).Dato)
                {
                    break;

                }
                h = h.Siguiente;
            }
            ne.Siguiente = h.Siguiente;
            h.Siguiente = ne;

            }
        Public void recorrerhaciaatras(Nodo d)
        {

            Nodo nodito = New Nodo();
            nodito = d;
            If (bottom == null)
            {
                bottom = d;

            }
            If (bottom!= null)
            {
                 If (nodito.Dato > bottom.Dato)
                {
                    nodito.Anterior = bottom;
                    bottom = nodito;

                }

                If (nodito.Dato < head.Dato)
                {
                    nodito.Siguiente  = bottom.Anterior;
                    nodito.Anterior = nodito;

                        
                }

            }
          
           


        }
        Public bool Buscar(int d)
        {
            Nodo h = head;

            While (h!= null)
            {
                If (d < h.Dato)
                {
                    Return False;
                }
                If (d == h.Dato)
                {
                    Return True;
                }
                h = h.Siguiente;

            }
            Return False;
        }
       
        //Eliminar dato específico
        Public void borrar(int d)
        {
            If (head == null)
            {
                Return;
            }
            If (!Buscar(d))
            {
                Return;
            }
            If (d == head.Dato)
            {
                head = head.Siguiente;
                head = head.Anterior;
                Return;
            }

            Nodo h = head;
           
            While (h.Anterior == null)
            {
                If (d == h.Anterior.Dato)
                {
                    h.Anterior = h.Anterior.Anterior;
                    Return;
                }
                h = h.Anterior;
            }
           
        
           

        }
        //Eliminar primer dato
        Public void borrarPrimero()
        {
            head = head.Siguiente;
            head.Anterior = null;
        }
        //Eliminar ultimo dato
        Public void borrarUltimo()
        {
            If (bottom.Anterior == null)
            {
                head = null;
                bottom = null;
            }
            Else
            {
                bottom = bottom.Anterior;
                bottom.Siguiente = null;
            }
        }
        //Recorrer de cabeza a cola
        Public String RecorrerAdelante()
        {
            Nodo h = head;
            String s = "";
            While (h! = null)
            {
                s += h.Dato + "-";
                h = h.Siguiente;
            }
            Return s;
        }
        //Recorrer de cola a cabeza
        Public String RecorrerAtras()
        {
            
            Nodo b = bottom ;
            String s = "";
            While (b!= null)
            {
                s += b.Dato + "-";
                b = b.Anterior ;
            }
            Return s;
        }
    }
End Class
