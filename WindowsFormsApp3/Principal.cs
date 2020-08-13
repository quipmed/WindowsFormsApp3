using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
     
        private void rEMISIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remi remi = new remi();
            remi.ShowDialog();
            remi.Dispose();
        }
       
        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.ShowDialog();
            clientes.Dispose();
        }
        
        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos productos = new productos();
            productos.ShowDialog();
            productos.Dispose();

        }
     
        private void cONSULTADEREMISIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulrta_remi consulrta_Remi = new consulrta_remi();
            consulrta_Remi.ShowDialog();
            consulrta_Remi.Dispose();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Remisiones.remicion puesto = new Remisiones.remicion();
            puesto.ShowDialog();
        }
    }
}
