using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final1
{
    class Cola
    {
        private int maximo;
        private int frente;
        private int atras;
        private int[] lacola;

        public Cola()
        {

        }


        public Cola(int max)
        {
            frente = -1;
            atras = -1;
            maximo = max;
            lacola = new int[max];

        }
        public bool cola_llena()
        {
            if (atras == maximo - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool cola_vacia()
        {
            if (frente == -1)
            {
                return true;
            }
            else
                return false;
        }
        public void encolar(int n)
        {

            if (cola_llena() == true)
            {
                MessageBox.Show("cola llena");
                
            }
            else
            {
                atras++;
                lacola[atras] = n;
                if (atras == 0)
                {
                    frente = 0;
                }
            }

        }

        public int desencolar()
        {

            int n = 0;
            if (cola_vacia() == true)
            {
                MessageBox.Show("cola vacia");

                return n;
            }
            else
            {

                n = lacola[frente];
                if (frente == atras)
                {
                    frente = -1;
                    atras = -1;
                }
                else
                {
                    frente++;
                }
                return n;
            }
        }
    }
}
