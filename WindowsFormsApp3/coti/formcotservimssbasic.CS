using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.coti
{
    
    public partial class formcotservimssbasic : Form
    {
        public int ndetalle=0;
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

        private void button1_Click(object sender, EventArgs e)

        {
            string txt;
            txt = txtDescripcion.Text.Trim();
            if (txt == "")
            {
                MessageBox.Show("falta descripcion");

            }
            else
            {
                dataGridView1.AllowUserToAddRows = false;//nadie puede agregar otra fila en la tabla tambien funciona para que no detecte la ultima fila como vacia 


                bool flag = false;
                foreach (DataGridViewRow rw in dataGridView1.Rows)//for mientras exista filas
                {
                    for (int i = 0; i <= rw.Cells.Count - 1; i++)//cuenta las columnas 
                    {

                        if (dataGridView1[i, rw.Index].Value == null || dataGridView1[i, rw.Index].Value == DBNull.Value || string.IsNullOrEmpty(dataGridView1[i, rw.Index].Value.ToString()))
                        // Alguna celda está vacía
                        {
                            MessageBox.Show("Hay alguna celda vacía. Imposible continuar");
                            flag = true; // whenever you want to break
                            break;
                        }
                    }

                    if (flag) break;
                }
                if (!flag)
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)//mientras existan filas disponibles en dta1
                    {

                        dataGridView3.Rows.Add();//agrega una fila en data3
                        int i2 = dataGridView3.Rows.Count - 1;//i2=al total de las filas de data3 -1para que comienzeen 0


                          dataGridView3[1, i2].Value = dataGridView1[0, row.Index].Value.ToString();
                        dataGridView3[2, i2].Value = dataGridView1[1, row.Index].Value.ToString();
                        dataGridView3[3, i2].Value = dataGridView1[2, row.Index].Value.ToString();
                        dataGridView3[4, i2].Value = dataGridView1[3, row.Index].Value.ToString();
                        dataGridView3[0, i2].Value = ndetalle;
                        dataGridView3[5, i2].Value = txtDescripcion.Text;
                    }
                    if (dataGridView3.Rows.Count > 0)
                    {
                        int i = 0;//contador para las multiples items
                        i = dataGridView2.Rows.Count;
                        dataGridView2.Rows.Add();//agrega una fila nueva en data2
                        dataGridView2.Rows[i].Cells[0].Value = ndetalle;
                        dataGridView2.Rows[i].Cells[1].Value = txtDescripcion.Text;//se agrega la descripcion 
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        txtDescripcion.Text = "";
                        ndetalle++;
                    }

                }
                dataGridView1.AllowUserToAddRows = true;
            }
        }
            private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                //se crea el evento keypress dentro de las columnas
                e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
                if (dataGridView1.CurrentCell.ColumnIndex == 3 |
                    dataGridView1.CurrentCell.ColumnIndex == 1 |
                    dataGridView1.CurrentCell.ColumnIndex == 2) //Columnas deseadas
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                    }
                }
            }
        
        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = true;
            }

            if (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator && (sender as TextBox).Text.IndexOf(cc.NumberFormat.NumberDecimalSeparator) > -1)
            {
                e.Handled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            int rows = dataGridView3.Rows.Count;
            int col = dataGridView3.Columns.Count;


            object[,] myArray = new object[rows, col];


            for (int i = 0; i < rows; i++)
                for (int j = 0; j < col; j++)
                    myArray[i, j] = dataGridView3.Rows[i].Cells[j].Value;
            
           for(int i =0; i < rows; i++)
            {
                if (myArray[i,0].ToString()== txtAtencion.Text)
                {
                    dataGridView1.Rows.Add(myArray[i,1], myArray[i,2], myArray[i,3], myArray[i,4]);
                    txtDescripcion.Text = myArray[i, 5].ToString();
                }
            }
        }

        private void formcotservimssbasic_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dataGridView2.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value != null)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    int rows = dataGridView3.Rows.Count;
                    int col = dataGridView3.Columns.Count;


                    object[,] myArray = new object[rows, col];


                    for (int i = 0; i < rows; i++)
                        for (int j = 0; j < col; j++)
                            myArray[i, j] = dataGridView3.Rows[i].Cells[j].Value;

                    for (int i = 0; i < rows; i++)
                    {
                        if (myArray[i, 0].ToString() == selectedIndex.ToString())
                        {
                            dataGridView1.Rows.Add(myArray[i, 1], myArray[i, 2], myArray[i, 3], myArray[i, 4]);
                            txtDescripcion.Text = myArray[i, 5].ToString();
                        }
                    }

                }
            }
        }
    }
}
