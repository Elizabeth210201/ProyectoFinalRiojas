Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Proyecto_Final1

    Class Program

        ''' <summary>
        ''' Punto de entrada principal para la aplicaci�n.
        ''' </summary>
        <STAThread()>
        Private Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Menu)
        End Sub
    End Class
End Namespace
