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
        string selectorDeEmpresa;
        public consulrta_remi(bool sde)
        {
            

            if (sde == true)
            {
                selectorDeEmpresa = "mill";
            }
            else
            {
                selectorDeEmpresa = "rr";
            }
        
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Folio";
            dataGridView1.Columns[1].Name = "Empresa";
            dataGridView1.Columns[2].Name = "FECHA";
            dataGridView1.Columns[3].Name = "id";
            dataGridView1.Columns[4].Name = "Cancelada";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Name = "Motivo";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void consulrta_remi_Load(object sender, EventArgs e)
        {
            string a;
            a = Properties.Settings.Default.empredeff;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            retrieve2();
        }
       
        private void populate(string id, string nombre, string empresa, string fecha,string cancelada, string motivo)
        {
            dataGridView1.Rows.Add(id, nombre, empresa, fecha,cancelada,motivo);
            if (cancelada == "1")
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
            }
            if (cancelada == "")
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
            }
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
            string sql = "";
            if (selectorDeEmpresa == "rr")
            {
                sql = "SELECT tbRemi.folioRemicion, tbCliente.nombre, tbRemi.fecha,tbRemi.remiId,tbRemi.cancelada ,tbRemi.motivo  FROM(tbRemi INNER JOIN tbCliente ON tbRemi.idCliente = tbCliente.ID) where((fecha) >= '" + valor1 + "' AND(fecha) <= '" + valor2 + "')AND tbCliente.nombre LIKE('%" + textBox1.Text + "%') order by fecha desc";
            }
            else
            {
                sql = "SELECT tbRemiMill.folioRemicion, tbCliente.nombre, tbRemiMill.fecha,tbRemiMill.remiId,tbRemiMill.cancelada ,tbRemiMill.motivo  FROM(tbRemiMill INNER JOIN tbCliente ON tbRemiMill.idCliente = tbCliente.ID) where((fecha) >= '" + valor1 + "' AND(fecha) <= '" + valor2 + "')AND tbCliente.nombre LIKE('%" + textBox1.Text + "%') order by fecha desc";

            }

            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),row[4].ToString(), row[5].ToString());
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
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
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

            remision_consulcs remision_Consulcs = new remision_consulcs(selectorDeEmpresa);

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
                        string motivo = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                        remision_Consulcs.FOLIO.Text = folio;
                        remision_Consulcs.txtCancelacion.Text = motivo;


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
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
