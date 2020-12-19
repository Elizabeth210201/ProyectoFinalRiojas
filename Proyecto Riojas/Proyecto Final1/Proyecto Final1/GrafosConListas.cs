using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final1
{
    class GrafosConListas :Lista 
    {
        public override string ToString()
        {
            string grafo = "";
            Nodo1 copia = base.Head;
            while (copia != null)
            {
                grafo += " ------> [ " + copia.Valor;

                copia = copia.Siguiente;
            }
            return grafo;
        }
    }
}
