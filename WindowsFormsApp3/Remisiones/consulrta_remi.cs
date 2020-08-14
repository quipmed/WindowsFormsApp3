using MySqlConnector;
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
        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public consulrta_remi()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Folio";
            dataGridView1.Columns[1].Name = "Empresa";
            dataGridView1.Columns[2].Name = "FECHA";
            dataGridView1.Columns[3].Name = "id";
            dataGridView1.Columns[3].Visible = false;
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
       
        private void populate(string id, string nombre, string empresa, string fecha)
        {
            dataGridView1.Rows.Add(id, nombre, empresa, fecha);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //"Select * from servicio where (fecha) >= #" & valor1 & "# AND (fecha) <= #" & valor2 & "# order by fecha desc"

            retrieve2();
        }

        
        private void retrieve2()
        {
          
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            string valor1 = dateTimePicker1.Value.ToString("yyy-MM-dd");//se invierten los rangos de fecha para poder hacer consulta por acces

            string valor2 = dateTimePicker2.Value.ToString("yyy-MM-dd");
            string valor3 = textBox1.Text;
            
            String sql = "SELECT tbRemi.folioRemicion, tbCliente.nombre, tbRemi.fecha,tbRemi.remiId FROM(tbRemi INNER JOIN tbCliente ON tbRemi.idCliente = tbCliente.ID) where((fecha) >= '" + valor1 + "' AND(fecha) <= '" + valor2 + "')AND tbCliente.nombre LIKE('%"+textBox1.Text+"%') order by fecha desc";


            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
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
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
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
           

            try
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        string folio = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string Cliente = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string empresa = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


                        remision_Consulcs.FOLIO.Text = folio;


                    }

                }
                remision_Consulcs.ShowDialog();

            }
            catch (ArgumentOutOfRangeException)
            {

            }

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
        remision_consulcs remision_Consulcs = new remision_consulcs();
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
