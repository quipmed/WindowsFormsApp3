using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class consulrta_remi : Form
    {
        public string caden = "";
        public static string directorio = Application.StartupPath;  // variable del directorio de trabajo
        public static string archivo = "spacecraftsDB.mdb";  // variable del directorio de trabajo
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + directorio + @"\" + archivo + ";Persist Security Info=false;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public consulrta_remi()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "REMISION";
            dataGridView1.Columns[1].Name = "NOMBRE";
            dataGridView1.Columns[2].Name = "EMPRESA";
            dataGridView1.Columns[3].Name = "FECHA";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void consulrta_remi_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
        private void imprimir()
        {

        }
        private void populate(string id, string nombre, string empresa, string fecha)
        {
            dataGridView1.Rows.Add(id, nombre, empresa, fecha);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //"Select * from servicio where (fecha) >= #" & valor1 & "# AND (fecha) <= #" & valor2 & "# order by fecha desc"

            retrieve2();
        }

        private void checks()
        {
            caden = "";
            // (remi_id.id_empresa=2   OR remi_id.id_empresa=1 )
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {

                caden = "and (remi_id.id_empresa=2   OR remi_id.id_empresa=1 )";
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {

                caden = "and remi_id.id_empresa=2 ";
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {

                caden = "and remi_id.id_empresa=1 ";
            }
        }
        private void retrieve()
        {
            checks();

            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            string valor1 = dateTimePicker1.Value.ToShortDateString();
            string valor2 = dateTimePicker2.Value.ToShortDateString();
            String sql = "SELECT remi_id.id_remi, clientes.nombre, empresas.nombre, remi_id.fecha FROM(remi_id INNER JOIN clientes ON remi_id.id_cliente = clientes.Id) INNER JOIN empresas ON remi_id.id_empresa = empresas.Id  where(fecha) >= #" + valor1 + "#  AND (fecha) <= #" + valor2 + "# " + caden + " order by fecha desc";


            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void retrieve2()
        {
            checks();
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            string valor1 = dateTimePicker1.Value.ToShortDateString();
            string valor2 = dateTimePicker2.Value.ToShortDateString();
            string valor3 = textBox1.Text;
            String sql = "SELECT remi_id.id_remi, clientes.nombre, empresas.nombre, remi_id.fecha FROM(remi_id INNER JOIN clientes ON remi_id.id_cliente = clientes.Id) INNER JOIN empresas ON remi_id.id_empresa = empresas.Id  where(fecha) >= #" + valor1 + "#  AND (fecha) <= #" + valor2 + "# AND  clientes.nombre LIKE ('%" + valor3 + "%') " + caden + "order by fecha desc";


            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            string valor1 = dateTimePicker1.Value.ToShortDateString();
            string valor2 = dateTimePicker2.Value.ToShortDateString();
            String sql = textBox1.Text;
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            retrieve2();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            imprimir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            retrieve2();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            retrieve2();
        }
    }
}
