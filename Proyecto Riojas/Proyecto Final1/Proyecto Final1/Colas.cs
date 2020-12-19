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
    public partial class Colas : Form
    {
        Cola valor = new Cola();
        public Colas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtMaximo.Text);
            valor = new Cola(n);
            MessageBox.Show("Cola Creada");
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            int n; 
            n = int.Parse(txtNumero.Text);
            if (n==null)
            {
                MessageBox.Show("INGRESE UN DATO");
            }
            else
            {
           
            valor.encolar(n);
            txtNumero.Clear();
            txtNumero.Focus();
            }   
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            int n;

            n = valor.desencolar();
            MessageBox.Show("Salió " + n);
        }

    private void txtNumero_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txtMaximo_TextChanged(object sender, EventArgs e)
    {

    }

    private void Numero_Click(object sender, EventArgs e)
    {

    }
  }
}
