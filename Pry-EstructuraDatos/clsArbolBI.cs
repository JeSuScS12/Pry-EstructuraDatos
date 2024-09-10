using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDatos
{
    internal class clsArbolBI
    {

        private clsNodo PrimerNodo;

        public clsNodo Raiz
        { 
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            nuevo.Izquierda = null;
            nuevo.Derecha = null;

            if(Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                clsNodo nodoPadre = Raiz;
                clsNodo aux = Raiz;
                while(aux != null)
                {
                    nodoPadre = aux;

                    if(nuevo.Codigo < aux.Codigo) aux = aux.Izquierda;
                    else aux = aux.Derecha;
                }

                if (nuevo.Codigo < nodoPadre.Codigo) nodoPadre.Izquierda = nuevo;
                else nodoPadre.Derecha = nuevo;
            }
        }

        public void Recorrer(ComboBox lista)
        {
            lista.Items.Clear();
            InOrderAsc(lista, Raiz);

        }

        public void InOrderAsc(ComboBox lst, clsNodo r)
        {
            if(r.Izquierda != null)
            {
                InOrderAsc(lst, r.Izquierda);
            }
            lst.Items.Add(r.Codigo);
            if(r.Derecha != null)
            {
                InOrderAsc(lst, r.Derecha);
            }
        }

    }
}
