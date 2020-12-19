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
    public partial class ListasDEnlazadas : Form
    {
        ListasDoblesE lista;

        public ListasDEnlazadas()
        {
            InitializeComponent();
            lista = new ListasDoblesE();
        }
       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo(int.Parse(txtDatos.Text), null, null);
            int d = int.Parse(txtDatos.Text);

            n = new Nodo();
            n.Dato = d;
            n.Siguiente = null;
            n.Anterior = null;
            lista.Ingresar(n);
            lista.recorrerhaciaatras(n);
            txtDatos.Clear();
            txtDatos.Focus();
        }

        private void btnRecorrerAdelante_Click(object sender, EventArgs e)
        {
            lblDato.Text = lista.RecorrerAdelante().ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            lblDato.Text = lista.RecorrerAtras().ToString();
        }

        private void bntBorrarPrimero_Click(object sender, EventArgs e)
        {
            lista.borrarPrimero();
        }

        private void bntBorrarUltimo_Click(object sender, EventArgs e)
        {
            lista.borrarUltimo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lista.borrar(int.Parse(txtDatos.Text));
        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void lblDato_Click(object sender, EventArgs e)
    {

    }

    private void txtDatos_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
