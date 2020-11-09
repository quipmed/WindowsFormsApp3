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
        public string empresaSelector = "";
        public Principal()
        {
            InitializeComponent();
        }
     
        private void rEMISIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Remisiones.remicion remi = new Remisiones.remicion(radioButton2.Checked);
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
            consulrta_remi consulrta_Remi = new consulrta_remi(radioButton2.Checked);
            consulrta_Remi.ShowDialog();
            consulrta_Remi.Dispose();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmContacto puesto = new frmContacto();
            puesto.ShowDialog();
        }
       
        private void Principal_Load(object sender, EventArgs e)
        {
            string a;
            a = Properties.Settings.Default.empredeff;
            if (a == "mill")
            {
                pictureBox1.Visible = true;
            pictureBox2.Visible = false;
           
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
      
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rrMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            Properties.Settings.Default.empredeff = "rr";
            Properties.Settings.Default.Save();

        }

        private void millToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            string a;
            a=Properties.Settings.Default.empredeff;

            Properties.Settings.Default.empredeff = "mill";
            Properties.Settings.Default.Save();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coti.reportes.cotservimssbasic cotservimssbasic = new coti.reportes.cotservimssbasic();
            cotservimssbasic.ShowDialog();
        }

        private void sERVICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coti.formcotservimssbasic IMSS = new coti.formcotservimssbasic();
            IMSS.ShowDialog();
        }
    }
}
