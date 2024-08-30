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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        //Llamar al frmCola  ---> Cola
        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola ventanaC = new frmCola();
            ventanaC.ShowDialog();
        }


        //Llamar al frmPila ---> Pila
        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila ventanaP = new frmPila();
            ventanaP.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ventanaListaS = new frmListaSimple();
            ventanaListaS.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLsitaDoble ventanaListaD = new frmLsitaDoble();
            ventanaListaD.ShowDialog();
        }
    }
}
