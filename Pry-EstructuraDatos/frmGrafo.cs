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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }

        clsGrafo nuevo = new clsGrafo();

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            nuevo.MostrarCiudades(cmbOrigen);
            nuevo.MostrarCiudades(cmbDestino);
            nuevo.MostrarCiudades(cmbOri);
            nuevo.MostrarCiudades(cmbDest);
            nuevo.MostrarCiudades(cmbListaOrigen);
            nuevo.MostrarCiudades(cmbListaDestino);

            nuevo.CargarMatriz();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int f = cmbOrigen.SelectedIndex;
            int c = cmbDestino.SelectedIndex;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            nuevo.Cargar(f, c, precio);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int f = cmbOrigen.SelectedIndex;
            int c = cmbDestino.SelectedIndex;

            txtPrec.Text = nuevo.Consultar(f, c).ToString();
        }

        private void btnListaOrigen_Click(object sender, EventArgs e)
        {
            nuevo.MostrarOrigen(dgvTabla, cmbListaOrigen.SelectedIndex);
        }

        private void btnListarDestino_Click(object sender, EventArgs e)
        {
            nuevo.MostrarOrigen(dgvTabla, cmbListaDestino.SelectedIndex);
        }
    }
}
