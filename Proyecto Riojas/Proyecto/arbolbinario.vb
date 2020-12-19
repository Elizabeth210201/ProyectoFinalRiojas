Public Class arbolbinario
      {
   Dim raiz As Nodo
    Dim cant As Int32

    Dim altura As Int32
    Public ArbolBinario()
        
            raiz = null
        
    
    Public Sub void Insertar( Nodo n )
        
            Insertar(raiz, n)
    End Sub

    Public void Insertar(ref Nodo raiz, Nodo n)
        
            If (raiz == null)
            {

                raiz = n;
                Return;
            }

            Else

    If (n.Dato < raiz.Dato)
                Insertar(ref raiz.izquierdo, n);
                

            Else
            {
                Insertar(ref raiz.derecho, n);
            }

        }



        String s ;
        Private void PreOrden(Nodo r)
        {
            
            
            If (r!= null)
            {
                s += r.Dato + " ";
                PreOrden(r.izquierdo);
                PreOrden (r.derecho);
            }
           
        }
        Public String PreOrden()
        {
            s = "";
            PreOrden(raiz);
            Return s;
        }

       
        Private void InOrden(Nodo r)
        {
            If (r!= null)
            {
                InOrden(r.izquierdo);
                s += r.Dato + " ";
                InOrden(r.derecho);

            }
        }

        Public String InOrden()
        {
            s = "";
            InOrden(raiz);
            Return s;
        }
        
        Private void PostOrden(Nodo r)
        {
            If (r!= null)
            {
                PostOrden(r.izquierdo);
                PostOrden(r.derecho);
                s += r.Dato + " ";
               
            }
            
        }

        Public String PostOrden()
        {
            s = "";
            PostOrden(raiz);
            Return s ;
        }


     

        Public bool Buscar(int b)
        {
            Nodo r = raiz;


            While (r!= null)
            {
                If (b == r.Dato)
                {
                    Return True;
                }

                If (r.Dato > b)
                {
                    If (r.izquierdo == null)
                    {
                        Return False;
                    }
                    r = r.izquierdo;
                    
                    
                }
               
                Else
                {
                    If (r.derecho == null)
                    {
                        Return False;
                    }
                    r = r.derecho;
                   
                   
                }
               
            }
           
            Return False;
        }

        Public void Borrar (int b)
        {
            If (raiz == null)
            {
                Return;
            }
            If (!Buscar(b))
            {
                Return;
            }
            
            Nodo r = raiz;
            Nodo Aux = null;

            While (r.Dato!= b)
            {
                Aux = r;
                If (r.Dato > b)
                    r = r.izquierdo;

                Else
                    r = r.derecho;
            }

            If (r == raiz)
            {

                If (r.derecho!= null)
                {
                    r = r.derecho;
                    While (r.izquierdo!= null)
                    {
                        Aux = r;
                        r = r.izquierdo;
                    }
                    raiz.Dato = r.Dato;
                    Aux.izquierdo = r.derecho;
                    Return;
                }
                If (r.izquierdo! = null)
                {
                    r = r.izquierdo;
                    Aux = r;
                    While (r.derecho!= null)
                    {
                       
                        r = r.derecho;
                    }
                    raiz.Dato = r.Dato;
                    Aux.derecho = Aux.derecho.izquierdo;
                    Return;

                }
                Else
                {
                    raiz = null;
                }

            }
            If (r.derecho == null && r.izquierdo == null)
            {
                If (b == Aux.izquierdo.Dato)
                    Aux.izquierdo = null;
                Else
                    Aux.derecho = null;

            }
            Else
            {
                Nodo r2 = r; 

                If (r.derecho!= null)
                {
                    r = r.derecho;
                    While (r.izquierdo!= null)
                    {
                        Aux = r;
                        r = r.izquierdo;
                    }
                    r2.Dato = r.Dato;
                    Aux.izquierdo = Aux.izquierdo.derecho;
                    Return;
                }
                If (r.izquierdo!= null)
                {
                    r = r.izquierdo;
                    While (r.derecho!= null)
                    {
                        Aux = r;
                        r = r.derecho;
                    }
                    r2.Dato = r.Dato;
                    Aux.derecho = Aux.derecho.izquierdo;
                    Return;

                }
                Else
                {
                    raiz = null
                }
            }




        }
    }
}
End Class
