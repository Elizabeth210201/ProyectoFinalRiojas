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
    public partial class Estructura_de_datos : Form
    {
        public Estructura_de_datos()
        {
            InitializeComponent();

        }

        private void btnLiDE_Click(object sender, EventArgs e)
        {
            ListasDEnlazadas LDE = new ListasDEnlazadas();
            LDE.Show();
            
        }

        private void btnLiS_Click(object sender, EventArgs e)
        {
            ListasSimples LS = new ListasSimples();
            LS.Show();
        }

        private void btnLiC_Click(object sender, EventArgs e)
        {
            ListasCirculares LC = new ListasCirculares();
            LC.Show();
        }

        private void btnLiDC_Click(object sender, EventArgs e)
        {
            ListasDCirculares LDC = new ListasDCirculares();
            LDC.Show();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            Pilas P = new Pilas();
            P.Show();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            Colas C = new Colas();
            C.Show();
        }

        private void btnArboles_Click(object sender, EventArgs e)
        {
            Arboles A = new Arboles();
            A.Show();
        }

        private void BtnGrafos_Click(object sender, EventArgs e)
        {
            Grafos G = new Grafos();
            G.Show();
        }

    private void Estructura_de_datos_Load(object sender, EventArgs e)
    {

    }
  }
}
