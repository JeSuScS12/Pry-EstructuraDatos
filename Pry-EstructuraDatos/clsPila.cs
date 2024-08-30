using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDatos
{
    internal class clsPila
    {
        //Campos
        private clsNodo pri;

        //Propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        //Metodos
        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
            }
        }

        public void Eliminar()
        {
            if(Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }

        //Metodos Eliminar - Sobrecarga


        //TABLA
        public void Recorrer(DataGridView tabla)
        {
            clsNodo aux = Primero;
            tabla.Rows.Clear();
            while (aux != null)
            {
                tabla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        //LISTA
        public void Recorrer(ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        //COMBOBOX
        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        //RECORRER  Y CREAR UN ARCHIVO
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter ad = new StreamWriter("Pila.csv", false, Encoding.UTF8);
            ad.WriteLine("Lista de Espera\n");
            ad.WriteLine("Codigo; Nombre; Tramite");

            while (aux != null)
            {
                ad.Write(aux.Codigo);
                ad.Write(";");
                ad.Write(aux.Nombre);
                ad.Write(";");
                ad.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }

            ad.Close();
        }
    }
}
