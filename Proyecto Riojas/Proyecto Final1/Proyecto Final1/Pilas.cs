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
    public partial class Pilas : Form
    {
        Pila pila;
        public Pilas()
        {
            InitializeComponent();
            pila = new Pila();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Nodo n;

            int d = int.Parse(txtDato.Text);
            n = new Nodo();
            n.Dato = d;
            n.Siguiente = null;

            pila.Push(n);
            txtDato.Clear();
            txtDato.Focus();
            listBox1.Items.Add(d);

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pila.pila_vacia())
            {
                MessageBox.Show("pila vacia");
                return;

            }
            Nodo n;
            n = pila.Pop();

            MessageBox.Show("salio " + n.Dato);
            int a;
            a = n.Dato;
            listBox1.Items.Remove(a);
        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void txtDato_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
  }
}
