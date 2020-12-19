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
    public partial class Grafos : Form
    {
            Lista lista = new Lista();
            Lista grafo = new Lista();
            GrafosConListas caminos = new GrafosConListas();
            Nodo1 nuevo;
        public Grafos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                return;
            }
            if (grafo.Buscar(int.Parse(txtDato.Text)))
            {
                return;
            }
            caminos = new GrafosConListas();
            nuevo = new Nodo1(int.Parse(txtDato.Text), null, caminos);
            grafo.Agregar(nuevo);
            Nodos.Items.Add(txtDato.Text);
            Union.Items.Add(txtDato.Text);
            Nodos.SelectedIndex = 0;
            Union.SelectedIndex = 0;
            Nodos.Focus();
            txtDato.Clear();
            lblResultado.Text = "RESULTADO: " + Environment.NewLine + Environment.NewLine + grafo.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                return;
            }
            grafo.Eliminar(int.Parse(txtDato.Text));
            grafo.EliminarLazos(int.Parse(txtDato.Text));
            Nodos.Items.Remove(txtDato.Text);
            Union.Items.Remove(txtDato.Text);
            Nodos.SelectedIndex = 0;
            Union.SelectedIndex = 0;
            lblResultado.Text = "RESULTADO: " + Environment.NewLine + Environment.NewLine + grafo.ToString();
            txtDato.Clear();
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            nuevo = new Nodo1(int.Parse(Union.Text), null, null);
            grafo.SeleccionarCamino(int.Parse(Nodos.Text)).Agregar(nuevo);
            //caminos.Agregar - nuevo;
            lblResultado.Text = "RESULTADO: " + Environment.NewLine + Environment.NewLine + grafo.ToString();
            txtDato.Clear();
        }

        private void btnEliminarArista_Click(object sender, EventArgs e)
        {
            grafo.SeleccionarCamino(int.Parse(Nodos.Text)).Eliminar(int.Parse(Union.Text));
            txtDato.Clear();
            lblResultado.Text = "RESULTADO: ";
        }
    }
}
