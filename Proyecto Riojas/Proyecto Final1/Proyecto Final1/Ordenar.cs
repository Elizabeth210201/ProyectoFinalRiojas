using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class Ordenar
    {
        private Nodo raiz;
        string s;
        //int cont = 0;



        public Ordenar()
        {
            raiz = null;
        }

        public void Insertar(Nodo n)
        {
            Insertar(ref raiz, n);
        }
        public void Insertar(ref Nodo raiz, Nodo n)
        {
            if (raiz == null)
            {
                raiz = n;
                return;
            }

            else

                if (n.Dato < raiz.Dato)
                    Insertar(ref raiz.izquierdo, n);

                else
                {
                    Insertar(ref raiz.derecho, n);
                }

        }

        private void InOrden(Nodo r)
        {
            if (r != null)
            {
                InOrden(r.izquierdo);
                s += r.Dato + " ";
                InOrden(r.derecho);

            }
        }

        public string InOrden()
        {
            s = " ";
            InOrden(raiz);
            return s;
        }
        //-----------------------Monticulos
        public void HeapSortAscending(int[] arr)
        {
            int heap_size = arr.Length - 1;
            for (int i = heap_size / 2; i >= 0; i--)
            {
                MaxHepify(arr, heap_size, i);
            }
            for (int k = arr.Length - 1; k >= 0; k--)
            {
                int tmpa = arr[k];
                arr[k] = arr[0];
                arr[0] = tmpa;

                heap_size--;
                MaxHepify(arr, heap_size, 0);
            }
        }
        public void MaxHepify(int[] arr, int heapSize, int index)
        {
            int l = 2 * index + 1;
            int r = 2 * index + 2;
            int largest = index;

            if (l <= heapSize && arr[l] < arr[index])
            {
                largest = l;
            }
            else
            {
                largest = index;
            }
            if (r <= heapSize && arr[r] < arr[largest])
            {
                largest = r;
            }
            if (largest != index)
            {
                int tmp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = tmp;

                MaxHepify(arr, heapSize, largest);
            }
        }

        public void HeapSortMinimo(int[] input)
        {

            int heapSize = input.Length - 1;  //modificado
            for (int p = heapSize / 2; p >= 0; p--) //modificado
            {
                MinHeapify(input, heapSize, p);
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MinHeapify(input, heapSize, 0);
            }
        }
        public void MinHeapify(int[] input, int heapSize, int index)
        {
            int left = index * 2 + 1;     /*modiicadp*/
            int right = 2 * index + 2;        /*modificado*/
            int largest = index;

            if (left <= heapSize && input[left] > input[index])
            {
                largest = left;
            }
            else
            {
                largest = index;
            }
            if (right <= heapSize && input[right] > input
                [largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;


                MinHeapify(input, heapSize, largest);
            }

        }


    }
}
