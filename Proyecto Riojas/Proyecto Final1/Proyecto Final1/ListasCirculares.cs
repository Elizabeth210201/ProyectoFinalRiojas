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
    public partial class ListasCirculares : Form
    {
        ListasCirculares1 lista = new ListasCirculares1();
        Nodo nuevo;
        public ListasCirculares()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista.Buscar(int.Parse(txtDato.Text)))
                {
                    MessageBox.Show("Ya existe este dato");
                    return;
                }
                nuevo = new Nodo(Int32.Parse(txtDato.Text));
                lista.Insertar(nuevo);
                txtDato.Clear();
                txtDato.Focus();
                txtLista.Text = lista.Mostrar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Eliminar(Int32.Parse(txtDato.Text));
                txtDato.Clear();
                txtDato.Focus();
                txtLista.Text = lista.Mostrar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

      
    }
}
