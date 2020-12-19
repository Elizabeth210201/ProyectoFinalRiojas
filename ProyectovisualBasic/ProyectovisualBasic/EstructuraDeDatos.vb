Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Proyecto_Final1

    Public Class Estructura_de_datos
        Inherits Form

        Public Sub New()
            MyBase.New
            InitializeComponent
        End Sub

        Private Sub btnLiDE_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim LDE As ListasDEnlazadas = New ListasDEnlazadas
            LDE.Show
        End Sub

        Private Sub btnLiS_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim LS As ListasSimples = New ListasSimples
            LS.Show
        End Sub

        Private Sub btnLiC_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim LC As ListasCirculares = New ListasCirculares
            LC.Show
        End Sub

        Private Sub btnLiDC_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim LDC As ListasDCirculares = New ListasDCirculares
            LDC.Show
        End Sub

        Private Sub btnPilas_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim P As Pilas = New Pilas
            P.Show
        End Sub

        Private Sub btnColas_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim C As Colas = New Colas
            C.Show
        End Sub

        Private Sub btnArboles_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim A As Arboles = New Arboles
            A.Show
        End Sub

        Private Sub BtnGrafos_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim G As Grafos = New Grafos
            G.Show()
        End Sub

        Private Sub Estructura_de_datos_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'Estructura_de_datos
            '
            Me.ClientSize = New System.Drawing.Size(278, 244)
            Me.Name = "Estructura_de_datos"
            Me.ResumeLayout(False)

        End Sub

        Private Sub Estructura_de_datos_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace