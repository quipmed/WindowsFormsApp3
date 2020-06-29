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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        remi remi = new remi();
        private void rEMISIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remi.ShowDialog();
        }
        clientes clientes = new clientes();
        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes.ShowDialog();
        }
        productos productos = new productos();
        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos.ShowDialog();
            
        }
        consulrta_remi consulrta_Remi = new consulrta_remi();
        private void cONSULTADEREMISIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            consulrta_Remi.ShowDialog();
        }
    }
}
