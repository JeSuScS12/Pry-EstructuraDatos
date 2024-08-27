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


    }
}
