using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final1
{
    public partial class Arboles : Form
    {
        ArbolBinario arbol;
        public Arboles()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Nodo n;
            
            int d = int.Parse(txtDato.Text);
            n = new Nodo();
            n.Dato = d;
            n.derecho = null;
            n.izquierdo = null;
            arbol.Insertar(n);
            lblArbol.Text = d + " ";
            txtDato.Clear();
            txtDato.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (arbol.Buscar(int.Parse(txtDato.Text)))
            {
                lblResultado.Text = "Dato encontrado";
            }
            else
            {
                lblResultado.Text = "Dato  no encontrado";
            }
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            lblArbol.Text = arbol.PreOrden() + " ";
        }

        private void btnEnOrden_Click(object sender, EventArgs e)
        {
            lblArbol.Text = arbol.InOrden() + " ";
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            lblArbol.Text = arbol.PostOrden() + " ";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            arbol.Borrar(int.Parse(txtDato.Text));
        }

    private void Arboles_Load(object sender, EventArgs e)
    {

    }
  }
}
