Public Class Arboles
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          Partial Public Class Arboles :  Form
    {
        ArbolBinario arbol;
        Public Arboles()
        {
            InitializeComponent();
            arbol = New ArbolBinario();
        }

        Private void btnInsertar_Click(Object sender, EventArgs e)
        {
            Nodo n;
            
            int d = Int.Parse(txtDato.Text);
            n = New Nodo();
            n.Dato = d;
            n.derecho = null;
            n.izquierdo = null;
            arbol.Insertar(n);
            lblArbol.Text = d + " ";
            txtDato.Clear();
            txtDato.Focus();
        }

        Private void btnBuscar_Click(Object sender, EventArgs e)
        {
            If (arbol.Buscar(int.Parse(txtDato.Text)))
            {
                lblResultado.Text = "Dato encontrado";
            }
            Else
            {
                lblResultado.Text = "Dato  no encontrado";
            }
        }

        Private void btnPreOrden_Click(Object sender, EventArgs e)
        {
            lblArbol.Text = arbol.PreOrden() + " ";
        }

        Private void btnEnOrden_Click(Object sender, EventArgs e)
        {
            lblArbol.Text = arbol.InOrden() + " ";
        }

        Private void btnPostOrden_Click(Object sender, EventArgs e)
        {
            lblArbol.Text = arbol.PostOrden() + " ";
        }

        Private void btnBorrar_Click(Object sender, EventArgs e)
        {
            arbol.Borrar(int.Parse(txtDato.Text));
        }
    End Sub
End Class
