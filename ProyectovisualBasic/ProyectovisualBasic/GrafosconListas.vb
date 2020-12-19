Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class GrafosConListas
        Inherits Lista

        Public Overrides Function ToString() As String
            Dim grafo As String = ""
            Dim copia As Nodo1 = MyBase.Head

            While (Not (copia) Is Nothing)
                grafo = (grafo + (" ------> [ " + copia.Valor))
                copia = copia.Siguiente

            End While

            Return grafo
        End Function
    End Class
End Namespace
