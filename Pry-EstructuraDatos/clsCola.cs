using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pry_EstructuraDatos
{
    internal class clsCola
    {
        //Campos
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }


        //-----------Metodos ------------


        //Metodo - Agregar
        public void Agregar(clsNodo nuevo)
        {
            if(Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        //Metodo Eliminar
        public void Eliminar()
        {
            if(Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
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
            while(aux != null)
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
            StreamWriter ad = new StreamWriter("Cola.csv", false, Encoding.UTF8);
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
