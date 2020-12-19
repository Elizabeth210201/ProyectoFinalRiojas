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
    public partial class ListasSimples : Form
    {
        ListaSimple lista;
        public ListasSimples()
        {
            InitializeComponent();
            lista = new ListaSimple();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Nodo n;
            int d = int.Parse(txtDato.Text);
            n = new Nodo();
            n.Dato = d;
            n.Siguiente = null;
            lista.Insertar(n);
            txtDato.Clear();
            txtDato.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = lista.Contar().ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = lista.MostrarDatos().ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(int.Parse(txtDato.Text)))
            {
                textBox1.Text = "Si esta";
            }
            else
            {
                textBox1.Text = "No esta ";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lista.Eliminar(int.Parse(txtDato.Text));
        }
    }
}
