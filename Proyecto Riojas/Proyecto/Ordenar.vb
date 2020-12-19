Public Class Ordenar
    Class Ordenar
    {
        Private Nodo raiz;
        String s;
        //int cont = 0;



        Public Ordenar()
        {
            raiz = null;
        }

        Public void Insertar(Nodo n)
        {
            Insertar(ref raiz, n);
        }
        Public void Insertar(ref Nodo raiz, Nodo n)
        {
            If (raiz == null)
            {
                raiz = n;
                Return;
            }

            Else

        If (n.Dato < raiz.Dato)
                    Insertar(ref raiz.izquierdo, n);

                Else
                {
                    Insertar(ref raiz.derecho, n);
                }

        }

        Private void InOrden(Nodo r)
        {
            If (r!= null)
            {
                InOrden(r.izquierdo);
                s += r.Dato + " ";
                InOrden(r.derecho);

            }
        }

        Public String InOrden()
        {
            s = " ";
            InOrden(raiz);
            Return s;
        }
        //-----------------------Monticulos
        Public void HeapSortAscending(int[] arr)
        {
            int heap_size = arr.Length - 1;
            For (int i = heap_size / 2; i >= 0; i--)
            {
                MaxHepify(arr, heap_size, i);
            }
            For (int k = arr.Length - 1; k >= 0; k--)
            {
                int tmpa = arr[k];
                arr[k] = arr[0];
                arr[0] = tmpa;

                heap_size--;
                MaxHepify(arr, heap_size, 0);
            }
        }
        Public void MaxHepify(int[] arr, int heapSize, int index)
        {
            int l = 2 * index + 1;
            int r = 2 * index + 2;
            int largest = index;

            If (l <= heapSize && arr[l] < arr[index])
            {
                largest = l;
            }
            Else
            {
                largest = index;
            }
            If (r <= heapSize && arr[r] < arr[largest])
            {
                largest = r;
            }
            If (largest!= index)
            {
                int tmp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = tmp;

                MaxHepify(arr, heapSize, largest);
            }
        }

        Public void HeapSortMinimo(int[] input)
        {

            int heapSize = Input.Length - 1;  //modificado
            For (int p = heapSize / 2; p >= 0; p--) //modificado
            {
                MinHeapify(input, heapSize, p);
            }
            For (int i = input.Length - 1; i >= 0; i--)
            {
                int temp = Input()[i];
                input[i] = Input()[0];
                input[0] = temp;

                heapSize--;
                MinHeapify(input, heapSize, 0);
            }
        }
        Public void MinHeapify(int[] input, int heapSize, int index)
        {
            int left = index * 2 + 1;     /*modiicadp*/
            int right = 2 * index + 2;        /*modificado*/
            int largest = index;

            If (left <= heapSize && input[left] > input[index])
            {
                largest = left;
            }
            Else
            {
                largest = index;
            }
            If (right <= heapSize && input[right] > input
                [largest])
            {
                largest = right;
            }

            If (largest!= index)
            {
                int temp = Input()[index];
                input[index] = Input()[largest];
                input[largest] = temp;


                MinHeapify(input, heapSize, largest);
            }

        }


    }
End Class
