using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Pry_EstructuraDatos
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        //Instancia de objeto
        clsPila fila = new clsPila();


        //Boton Agregar-Pila
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodPila.Text);
            obj.Nombre = txtNomPila.Text;
            obj.Tramite = txtTraPila.Text;

            fila.Agregar(obj);
            fila.Recorrer(dgvTablaPila);
            fila.Recorrer(lstPila);
            fila.Recorrer();

            txtCodPila.Text = "";
            txtNomPila.Text = "";
            txtTraPila.Text = "";
        }


        //Boton Eliminar-Pila
        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodPila.Text = fila.Primero.Codigo.ToString();
                lblNomPila.Text = fila.Primero.Nombre;
                lblTraPila.Text = fila.Primero.Tramite;

                fila.Eliminar();

                fila.Recorrer(dgvTablaPila);
                fila.Recorrer(lstPila);
                fila.Recorrer();
            }
            else
            {
                lblCodPila.Text = "";
                lblNomPila.Text = "";
                lblTraPila.Text = "";
            }
        }
    }
}
