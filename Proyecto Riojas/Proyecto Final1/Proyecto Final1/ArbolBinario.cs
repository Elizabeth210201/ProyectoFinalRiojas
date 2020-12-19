using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class ArbolBinario
    {
        private Nodo raiz;
        private int cant;
        private int altura;
        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar( Nodo n )
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



        string s ;
        private void PreOrden(Nodo r)
        {
            
            
            if (r != null)
            {
                s += r.Dato + " ";
                PreOrden(r.izquierdo);
                PreOrden (r.derecho);
            }
           
        }
        public string PreOrden()
        {
            s = "";
            PreOrden(raiz);
            return s;
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
            s = "";
            InOrden(raiz);
            return s;
        }
        
        private void PostOrden(Nodo r)
        {
            if (r != null)
            {
                PostOrden(r.izquierdo);
                PostOrden(r.derecho);
                s += r.Dato + " ";
               
            }
            
        }

        public string PostOrden()
        {
            s = "";
            PostOrden(raiz);
            return s ;
        }


     

        public bool Buscar(int b)
        {
            Nodo r = raiz;


            while (r != null)
            {
                if (b == r.Dato)
                {
                    return true;
                }

                if (r.Dato > b)
                {
                    if (r.izquierdo == null)
                    {
                        return false;
                    }
                    r = r.izquierdo;
                    
                    
                }
               
                else
                {
                    if (r.derecho == null)
                    {
                        return false;
                    }
                    r = r.derecho;
                   
                   
                }
               
            }
           
            return false;
        }

        public void Borrar (int b)
        {
            if (raiz == null)
            {
                return;
            }
            if (!Buscar(b))
            {
                return;
            }
            
            Nodo r = raiz;
            Nodo Aux = null;

            while (r.Dato != b)
            {
                Aux = r;
                if (r.Dato > b)
                    r = r.izquierdo;

                else
                    r = r.derecho;
            }

            if (r == raiz )
            {

                if (r.derecho != null)
                {
                    r = r.derecho;
                    while (r.izquierdo != null)
                    {
                        Aux = r;
                        r = r.izquierdo;
                    }
                    raiz.Dato = r.Dato;
                    Aux.izquierdo = r.derecho;
                    return;
                }
                if (r.izquierdo!= null)
                {
                    r = r.izquierdo;
                    Aux = r;
                    while (r.derecho != null)
                    {
                       
                        r = r.derecho;
                    }
                    raiz.Dato = r.Dato;
                    Aux.derecho = Aux.derecho.izquierdo;
                    return;

                }
                else
                {
                    raiz = null;
                }

            }
            if (r.derecho == null && r.izquierdo == null)
            {
                if (b == Aux.izquierdo.Dato)
                    Aux.izquierdo = null;
                else
                    Aux.derecho = null;

            }
            else
            {
                Nodo r2 = r; 

                if(r.derecho != null)
                {
                    r = r.derecho;
                    while (r.izquierdo != null)
                    {
                        Aux = r;
                        r = r.izquierdo;
                    }
                    r2.Dato = r.Dato;
                    Aux.izquierdo = Aux.izquierdo.derecho;
                    return;
                }
                if (r.izquierdo != null)
                {
                    r = r.izquierdo;
                    while (r.derecho != null)
                    {
                        Aux = r;
                        r = r.derecho;
                    }
                    r2.Dato = r.Dato;
                    Aux.derecho = Aux.derecho.izquierdo;
                    return;

                }
                else
                {
                    raiz = null;
                }
            }




        }
    }
}
