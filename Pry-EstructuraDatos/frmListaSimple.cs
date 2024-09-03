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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple nuevo = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCod.Text);
            obj.Nombre = txtNom.Text;
            obj.Tramite = txtTra.Text;

            nuevo.Agregar(obj);
            nuevo.Recorrer(dgvTablaLs);

            txtCod.Text = "";
            txtNom.Text = "";
            txtTra.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
