using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDatos
{
    internal class clsGrafo
    {
        public string[] Ciudad = {"Cordoba","Carlos Paz","Cosquin","San Francisco","Villa Maria",
                                  "Jujuy","Salta","Tucuman","Chaco","La Rioja"};

        private decimal[,] Precios = new decimal[10, 10];

        //Metodos de la Clase

        //Metodo CARGAR
        public void Cargar(int f,int c, decimal valor)
        {
            Precios[f,c] = valor;
        }

        //Metodo CONSULTAR
        public decimal Consultar(int f, int c)
        {
            return  Precios[f,c];
        }

        //Metodo ELIMINAR todo dentro de la matriz
        public void Eliminar()
        {
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++) Precios[f, c] = 0;
            }
        }

        //Mostrar Origen
        public void MostrarOrigen(DataGridView tabla, int c)
        {
            tabla.Rows.Clear();
            for (int f = 0; f < 10; f++) 
            {
                tabla.Rows.Add(Ciudad[f], Precios[f, c]);
            } 
        }

        public void MostrarDestino(DataGridView tabla, int f)
        {
            tabla.Rows.Clear();
            for (int c = 0; c < 10; c++)
            {
                tabla.Rows.Add(Ciudad[c],Precios[f, c]);
            }
        }

        //Mostrar Ciudades
        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < Ciudad.Length; i++) cmb.Items.Add(Ciudad[i]); 
        }

        //Random
        public void CargarMatriz()
        {
            Random random = new Random();
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    decimal i = random.Next(15, 100);
                    Precios[f, c] = i;
                }
            }

        }
    }
}
