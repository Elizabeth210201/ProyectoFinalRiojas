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
    public partial class MetodosOrdenamiento : Form
    {
        Ordenar ord;
        int[] vector;
        int a;
        Random r;
        int fusion;
        int pasadas, intercambios;
        static int cuentas;
        static int recorridos;
        public MetodosOrdenamiento()
        {
            InitializeComponent();
            cuentas = 0; ;
            recorridos = 0;
            ord = new Ordenar();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstOrdenado.Items.Clear();
            label4.Text = "";
            label5.Text = "";
            label2.Text = "";
            label3.Text = "";
            if (CHBBurbuja.Checked == true)
            {
                DateTime fi = DateTime.Now;
                vector = ordenamientoCuentas(vector);

                for (int i = 0; i < vector.Length; i++)
                    lstOrdenado.Items.Add(vector[i]);
                DateTime ff = DateTime.Now;
                label1.Text = ("Tiempo: " + (ff - fi));
                label2.Text = ("Cuentas: " + cuentas);
                label5.Text = ("Recorridos: " + recorridos);

            }
            if (CHBBurbujaBid.Checked == true)
            {
                DateTime fi = DateTime.Now;
                OrdBubujaBidireccional(vector);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = "Tiempo: " + (ff - fi);
                label5.Text = "Intercambios: " + intercambios;
                label2.Text = "Pasadas: " + pasadas;
            }
            if (CHBInsercion.Checked == true)
            {
                DateTime fi = DateTime.Now;
                InsercionDirecta(vector);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = "Tiempo: " + (ff - fi);
                label5.Text = ("Intercambios: " + intercambios);
                label2.Text = ("Pasadas: " + pasadas);
            }
            if (CHBBucketSort.Checked == true)
            {
                DateTime fi = DateTime.Now;
                int N;
                N = int.Parse(txtTamaño.Text);
                bucketsort(vector, N);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = ("Tiempo: " + (ff - fi));
                label2.Text = ("Pasadas: " + pasadas);
            }
            if (CHBCuentas.Checked == true)
            {
                DateTime fi = DateTime.Now;
                vector = ordenamientoCuentas(vector);

                for (int i = 0; i < vector.Length; i++)
                    lstOrdenado.Items.Add(vector[i]);
                DateTime ff = DateTime.Now;
                label1.Text = ("Tiempo: " + (ff - fi));
                label2.Text = ("Cuentas: " + cuentas);
                label5.Text = ("Recorridos: " + recorridos);
            }
            if (CHBMezclaDirecta.Checked == true)
            {
                DateTime fi = DateTime.Now;
                mezclaDirecta(vector);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = ("Tiempo: " + (ff - fi));
                label2.Text = ("Fusiones: " + fusion);

            }
            if (CHBMezclaNatural.Checked == true)
            {
                DateTime fi = DateTime.Now;
                mezclaNatural(vector);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = ("Tiempo: " + (ff - fi));
                label2.Text = ("Fusiones: " + a);
            }
            if (CHBArbolBinario.Checked == true)
            {
                DateTime time = DateTime.Now;
                label1.Text = ord.InOrden() + " ";
                string[] datos = label1.Text.Split(' ');
                for (int i = 0; i < datos.Length; i++)
                {
                    lstOrdenado.Items.Add(datos[i]);
                }
                label1.Text = " ";
                DateTime time2 = DateTime.Now;
                TimeSpan total = new TimeSpan(time2.Ticks - time.Ticks);
                label1.Text = ("Tiempo: " + total.ToString());
            }
            if (CHBRadix.Checked == true)
            {
                DateTime fi = DateTime.Now;
                Radix(vector);
                DateTime ff = DateTime.Now;
                label1.Text = "Tiempo: " + (ff - fi);
            }
            if (CHBShellSort.Checked == true)
            {
                DateTime fi = DateTime.Now;
                ShellSort(vector, true);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = "Tiempo: " + (ff - fi);

                label5.Text = "Intercambios: " + intercambios;
                label2.Text = "Pasadas: " + pasadas;
            }
            if (CHBMonticulosMin.Checked == true)
            {
                DateTime fi = DateTime.Now;
                Ordenar min = new Ordenar();
                min.HeapSortMinimo(vector);
                for (int m = 0; m < vector.Length; m++)
                {

                    lstOrdenado.Items.Add(vector[m]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = ("Tiempo: " + (ff - fi));
            }
            if (CHBMonticulosMax.Checked == true)
            {
                DateTime f1 = DateTime.Now;
                Ordenar max = new Ordenar();
                max.HeapSortAscending(vector);
                for (int j = 0; j < vector.Length; j++)
                {

                    lstOrdenado.Items.Add(vector[j]);
                }
                DateTime f2 = DateTime.Now;
                label1.Text = "Tiempo: " + (f2 - f1);
            }
            if (CHBQuickSort.Checked == true)
            {
                DateTime fi = DateTime.Now;
                Quicksort(vector, 0, vector.Length - 1);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstOrdenado.Items.Add(vector[i]);
                }
                DateTime ff = DateTime.Now;
                label1.Text = "Tiempo: " + (ff - fi);
                label5.Text = ("Intercambios: " + intercambios);
                label2.Text = ("Pasadas: " + pasadas);
            }
        }
        private void bucketsort(int[] vector, int N)//BS
        {
            DateTime Ti = DateTime.Now;
            pasadas = 0;
            if (N <= 0)
                return;                                   // el Array esta vacio
            int min = vector[0];
            int max = min;
            for (int r = 1; r < N; r++)                // Encontrar minimo y maximo
                if (vector[r] > max)
                    max = vector[r];
                else if (vector[r] < min)
                    min = vector[r];
            int[] bucket = new int[max - min / 5 + 1];         // Crear casilleros
            pasadas = max - min / 5 + 1;
            for (int u = 0; u < N; u++)                // llenar casilleros
                bucket[vector[u] - min]++;                   //contando cada dato
            int i = 0;
            for (int b = 0; b < bucket.Length; b++)   // vaciar casilleros
                for (int j = 0; j < bucket[b]; j++)      // regresarlos al arry
                    vector[i++] = b + min;
            DateTime Tf = DateTime.Now;
            label1.Text = (Ti - Tf + "Tiempo: ");
        }

        public static int[] ordenamientoCuentas(int[] vector)//Cuentas
        {
            int[] vectorOrdenado = new int[vector.Length];// arreglo ordenado = metodo
            // encontrar mayor y menor
            int valorMinimo = vector[0];
            int valorMaximo = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < valorMinimo) valorMinimo = vector[i]; //recorrer para encontrar el menor
                else if (vector[i] > valorMaximo) valorMaximo = vector[i]; //recorrer para encontrar el mayor
            }
            // iniciar arreglo de frecuencias
            int[] vectorAuxiliar = new int[valorMaximo - valorMinimo + 1]; //arreglo de auxiliar de frecuencias
            // iniciar las frecuencias
            for (int i = 0; i < vector.Length; i++)
            {
                vectorAuxiliar[vector[i] - valorMinimo]++;
                cuentas++;
            }
            // recalcular
            vectorAuxiliar[0]--;
            for (int i = 1; i < vectorAuxiliar.Length; i++)
            {
                vectorAuxiliar[i] = vectorAuxiliar[i] + vectorAuxiliar[i - 1];
                recorridos++;
            }
            // Acomodar el Arreglo
            for (int i = vector.Length - 1; i >= 0; i--)
            {
                vectorOrdenado[vectorAuxiliar[vector[i] - valorMinimo]--] = vector[i];
            }
            return vectorOrdenado;
        }

        public string ShellSort(Int32[] array, Boolean tipo)//ShellSort
        {
            string a = "";
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            int izq = 0;
            int der = 0;
            der = array.Length - 1;
            salto = array.Length / 2;
            pasadas = 0;
            intercambios = 0;
            DateTime fi = DateTime.Now;
            do
            {
                pasadas++;
                for (int i = izq; i < der; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        intercambios++;
                        auxi = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = auxi;
                    }
                }
                izq++;
                der--;

            } while (izq < der);
            DateTime ff = DateTime.Now;
            label1.Text = "Tiempo: " + (ff - fi);
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    if (tipo == true)
                    {
                        while (e <= (array.Length - salto))
                        {
                            if (array[e - 1] > array[(e - 1) + salto])
                            {
                                auxi = array[(e - 1) + salto];
                                array[(e - 1) + salto] = array[e - 1];
                                array[(e - 1)] = auxi;
                                sw = 1;
                                intercambios++;
                            }
                            e++;
                        }
                    }
                    else
                    {
                        while (e <= (array.Length - salto))
                        {
                            if (array[e - 1] < array[(e - 1) + salto])
                            {
                                auxi = array[(e - 1) + salto];
                                array[(e - 1) + salto] = array[e - 1];
                                array[(e - 1)] = auxi;
                                sw = 1;
                                intercambios++;
                            }
                            e++;
                        }
                    }
                    salto = salto / 2;
                    pasadas++;
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                a += vector[i] + Environment.NewLine;
            }
            return a;
        }

        private void OrdenamientoBurbuja(int[] vector) //Burbuja
        {
            int aux = 0;
            pasadas = 0;
            intercambios = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToInt32(lstDesordenado.Items[i].ToString());
            }
            int x = 0;
            for (int i = 1; i < vector.Length; i++)
            {
                x = 0;
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        x++;
                        intercambios++;
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
                if (x == 0)
                {
                    return;
                }
                pasadas++;
            }
        }

        private void OrdBubujaBidireccional(int[] vector) //Burbuja bidireccional
        {
            int der = 0;
            int izq = 0;
            int aux = 0;
            der = vector.Length - 1;
            pasadas = 0;
            intercambios = 0;
            DateTime fi = DateTime.Now;
            for (int i = 0; i < vector.Length; i++)
            {

                vector[i] = Convert.ToInt32(lstDesordenado.Items[i].ToString());
            }
            do
            {
                pasadas++;
                for (int i = izq; i < der; i++)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        intercambios++;
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                    }
                }
                for (int j = der; j > izq; j--)
                {
                    if (vector[j] < vector[j - 1])
                    {
                        intercambios++;
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                    }
                }
                izq++;
                der--;
            } while (izq < der);
            DateTime ff = DateTime.Now;
            label1.Text = "Tiempo: " + (ff - fi);
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left;
            int j = right;
            int pasadas = 0;
            int intercambios = 0;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                    intercambios++;
                }
                pasadas++;
            }
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

        public void Radix(int[] vector)//RadixSort
        {
            pasadas = 0;
            int[] t = new int[vector.Length];
            int r = 4;
            int b = vector.Length;
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];
            int grupos = (int)Math.Ceiling((double)b / (double)r);
            int mask = (1 << r) - 1;

            for (int c = 0, shift = 0; c < grupos; c++, shift += r)
            {
                for (int i = 0; i < count.Length; i++)
                {
                    count[i] = 0;
                }
                for (int j = 0; j < vector.Length; j++)
                {
                    count[(vector[j] >> shift) & mask]++;
                }
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                {
                    pref[i] = pref[i - 1] + count[i - 1];
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    t[pref[(vector[i] >> shift) & mask]++] = vector[i];
                }
                pasadas++;
                t.CopyTo(vector, 0);
            }
            for (int i = 0; i < vector.Length; i++)
            {

                lstOrdenado.Items.Add(vector[i]);
            }
            label2.Text = ("Pasadas:  " + pasadas + "");
        }

        private void InsercionDirecta(int[] vector)//Insercion
        {
            DateTime fi = DateTime.Now;
            int Aux = 0;
            int i, j;
            pasadas = 0;
            intercambios = 0;
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToInt32(lstDesordenado.Items[i].ToString());
            }
            for (i = 1; i <= vector.Length - 1; i++)
            {
                Aux = vector[i];
                j = i;
                while ((j > 0) && (Aux < vector[j - 1]))
                {
                    intercambios++;
                    vector[j] = vector[--j];
                }
                vector[j] = Aux;
                pasadas++;
            }
            DateTime ff = DateTime.Now;
            label1.Text = ("Tiempo: " + (ff - fi));
        }

        public void mezclaDirecta(int[] arreglo)//Mezcla Directa
        {
            int i, j, k;
            //si hay que ordenar
            if (arreglo.Length > 1)
            {
                //tamaño sub lista izquierda
                int nElementosIzq = arreglo.Length / 2;
                //tamaño sub lista derecha
                int nElementosDer = arreglo.Length - nElementosIzq;
                int[] arregloizq;
                arregloizq = new int[nElementosIzq];
                int[] arregloder;
                arregloder = new int[nElementosDer];
                //copiar elementos izq
                for (i = 0; i < nElementosIzq; i++)
                {
                    arregloizq[i] = arreglo[i];
                }
                //copiar elementos der
                for (i = nElementosIzq; i < nElementosIzq + nElementosDer; i++)
                {
                    arregloder[i - nElementosIzq] = arreglo[i];
                }
                //recursividad
                mezclaDirecta(arregloizq);
                mezclaDirecta(arregloder);
                i = 0; j = 0; k = 0;
                while (arregloizq.Length != j && arregloder.Length != k)
                {
                    if (arregloizq[j] < arregloder[k])
                    {
                        arreglo[i] = arregloizq[j];
                        i++;
                        j++;
                    }
                    else
                    {
                        arreglo[i] = arregloder[k];
                        i++;
                        k++;
                    }
                    fusion++;
                }
                while (arregloizq.Length != j)
                {
                    arreglo[i] = arregloizq[j];
                    i++;
                    j++;
                }
                while (arregloder.Length != k)
                {
                    arreglo[i] = arregloder[k];
                    i++;
                    k++;
                }
                fusion++;
            }
        }

        public void mezclaNatural(int[] arreglo)//Mezcla Natural
        {
            int izquierda = 0, izq = 0, derecha = arreglo.Length - 1, der = derecha;
            Boolean ordenado = false;
            do
            {
                ordenado = true;
                izquierda = 0;
                while (izquierda < derecha)
                {
                    izq = izquierda;
                    while (izq < derecha && arreglo[izq] <= arreglo[izq + 1])
                    {
                        izq++;
                    }
                    der = izq + 1;
                    while (der == derecha - 1 || der < derecha && arreglo[der] <= arreglo[der + 1])
                    {
                        der++;
                    }
                    a++;
                    if (der <= derecha)
                    {

                        mezclaDirecta2(arreglo);
                        ordenado = false;
                        a++;
                    }
                    a++;
                    izquierda = izq;
                    a++;
                }
                a++;
            } while (!ordenado);
        }

        public void mezclaDirecta2(int[] arreglo)
        {
            int i, j, k;
            if (arreglo.Length > 1)
            {
                int nElementosIzq = arreglo.Length / 2;
                int nElementosDer = arreglo.Length - nElementosIzq;
                int[] arregloizq;
                arregloizq = new int[nElementosIzq];
                int[] arregloder;
                arregloder = new int[nElementosDer];
                //copiar elementos izq
                for (i = 0; i < nElementosIzq; i++)
                {
                    arregloizq[i] = arreglo[i];
                }
                //copiar elementos der
                for (i = nElementosIzq; i < nElementosIzq + nElementosDer; i++)
                {
                    arregloder[i - nElementosIzq] = arreglo[i];
                }
                //recursividad
                mezclaDirecta(arregloizq);
                mezclaDirecta(arregloder);
                i = 0; j = 0; k = 0;
                while (arregloizq.Length != j && arregloder.Length != k)
                {
                    if (arregloizq[j] < arregloder[k])
                    {
                        arreglo[i] = arregloizq[j];
                        i++;
                        j++;
                    }
                    else
                    {
                        arreglo[i] = arregloder[k];
                        i++;
                        k++;
                    }
                    a++;
                }
                //arreglo final
                while (arregloizq.Length != j)
                {

                    arreglo[i] = arregloizq[j];
                    i++;
                    j++;
                }
                while (arregloder.Length != k)
                {

                    arreglo[i] = arregloder[k];
                    i++;
                    k++;
                }
                a++;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            vector = new int[int.Parse(txtTamaño.Text)];
            r = new Random();
            Nodo n;
            for (int i = 0; i < vector.Length; i++)
            {

                n = new Nodo();
                n.derecho = null;
                n.izquierdo = null;
                vector[i] = r.Next(0, 1000);
                lstDesordenado.Items.Add(vector[i]);
                n.Dato = vector[i];
                ord.Insertar(n);
            }

            txtTamaño.Focus();
        }
    }
}

