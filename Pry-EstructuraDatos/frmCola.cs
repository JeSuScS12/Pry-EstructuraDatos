using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDatos
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }


        //Instancia de objeto
        clsCola fila = new clsCola();   


        //Agregar
        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodCola.Text);
            obj.Nombre = txtNomCola.Text;
            obj.Tramite = txtTraCola.Text;

            fila.Agregar(obj);
            fila.Recorrer(dgvTablaCola);
            fila.Recorrer(lstCola);
            fila.Recorrer();

            txtCodCola.Text = "";
            txtNomCola.Text = "";
            txtTraCola.Text = "";
        }


        //Eliminar
        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodCola.Text = fila.Primero.Codigo.ToString();
                lblNomCola.Text = fila.Primero.Nombre;
                lblTraCola.Text = fila.Primero.Tramite;

                fila.Eliminar();

                fila.Recorrer(dgvTablaCola);
                fila.Recorrer(lstCola);
                fila.Recorrer();
            }
            else
            {
                lblCodCola.Text = "";
                lblNomCola.Text = "";
                lblTraCola.Text = "";
            }
        }
    }
}
