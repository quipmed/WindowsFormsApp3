using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.coti
{
    public partial class formcotservimssbasic : Form
    {
        int cont = 0;
        public formcotservimssbasic()
        {
            InitializeComponent();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool ValidateGrid(DataGridView dgvListas)
        {
            for (int i = 0; i < dgvListas.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvListas.ColumnCount; j++)
                {
                    if (string.IsNullOrEmpty( Convert.ToString( dgvListas.Rows[i].Cells[j].Value)))
                    {
                        dgvListas.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        return true;
                    }
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    dataGridView3.Rows.Add();
                    int i2 = dataGridView3.Rows.Count - 1;


                    dataGridView3[0, i2].Value = txtDescripcion.Text;
                    dataGridView3[1, i2].Value = dataGridView1[0, row.Index].Value.ToString();
                    dataGridView3[2, i2].Value = dataGridView1[1, row.Index].Value.ToString();
                    dataGridView3[3, i2].Value = dataGridView1[2, row.Index].Value.ToString();
                    dataGridView3[4, i2].Value = dataGridView1[3, row.Index].Value.ToString();
                }
                int i = 0;
                i = dataGridView2.Rows.Count;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = txtDescripcion.Text;
          
            dataGridView1.AllowUserToAddRows = true;

        }
    }
}
