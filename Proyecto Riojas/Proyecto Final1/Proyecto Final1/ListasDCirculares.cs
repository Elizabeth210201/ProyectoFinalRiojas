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
    public partial class ListasDCirculares : Form
    {
        ListaDCircular1 lista;
        public ListasDCirculares()
        {
            InitializeComponent();
            lista = new ListaDCircular1();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Nodo n;
            int d = Int32.Parse(txtInsertar.Text);
            n = new Nodo();
            n.Dato = d;
            n.Siguiente = null;
            n.Anterior = null;
            lista.Insertar(n);
            txtInsertar.Clear();
            txtInsertar.Focus();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            lblContar.Text = lista.MostrarDatos();
            lblContarDes.Text = lista.MostrarDatosAnt();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            lblContar.Text = lista.Contar() + "";  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (lista.Buscar(int.Parse(txtInsertar.Text)))
            {
                lblContar.Text = "Si está";
            }
            else
            {
                lblContar.Text = "No está";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lista.Borrar(int.Parse(txtInsertar.Text));
        }

    private void lblContar_Click(object sender, EventArgs e)
    {

    }

    private void lblContarDes_Click(object sender, EventArgs e)
    {

    }

    private void txtInsertar_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
