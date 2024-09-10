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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {

        }

        clsArbolBI objArbol = new clsArbolBI();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo persona = new clsNodo();
            persona.Codigo = Convert.ToInt32(txtCod.Text);
            persona.Nombre = txtNom.Text;
            persona.Tramite = txtTra.Text;

            objArbol.Agregar(persona);
            objArbol.Recorrer(cmbCod);

            txtCod.Text = "";
            txtNom.Text = "";
            txtTra.Text = "";

        }
    }
}
