using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_EstructuraDatos
{
    internal class clsNodo
    {
        //Agregando Campos de la Clase

        private int cod;
        private string nom;
        private string tra;
        private clsNodo sig;
        private clsNodo ant;

        //Declaracion de las Propiedades
        public int Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        //----------------------------------------------------------------------

        public clsNodo Izquierda
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Derecha
        {
            get { return ant; }
            set { ant = value; }
        }

    }
}
