Public Class GrafosconListas
    Class GrafosConListas : Lista 
    {
        Public override String ToString()
        {
            String grafo = "";
            Nodo1 copia = base.Head;
            While (copia!= null)
            {
                grafo += " ------> [ " + copia.Valor;

                copia = copia.Siguiente;
            }
            Return grafo;
        }
    }
End Class
