Public Class Cola
    Class Cola
    {
        Private int maximo;
        Private int frente;
        Private int atras;
        Private int[] lacola;

        Public Cola()
        {

        }


        Public Cola(int max)
        {
            frente = -1;
            atras = -1;
            maximo = max;
            lacola = New int[max];

        }
        Public bool cola_llena()
        {
            If (atras == maximo - 1)
            {
                Return True;
            }
            Else
            {
                Return False;
            }
        }
        Public bool cola_vacia()
        {
            If (frente == -1)
            {
                Return True;
            }
            Else
        Return False;
        }
        Public void encolar(int n)
        {

            If (cola_llena() == True)
            {
                MessageBox.Show("cola llena");
                
            }
            Else
            {
                atras++;
                lacola[atras] = n;
                If (atras == 0)
                {
                    frente = 0;
                }
            }

        }

        Public int desencolar()
        {

            int n = 0;
            If (cola_vacia() == True)
            {
                MessageBox.Show("cola vacia");

                Return n;
            }
            Else
            {

                n = lacola[frente];
                If (frente == atras)
                {
                    frente = -1;
                    atras = -1;
                }
                Else
                {
                    frente++;
                }
                Return n;
            }
        }
    }
End Class
