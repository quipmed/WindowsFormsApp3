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

//Provider=SpecifiedSQLProv;Data Source = specifieddb; User Id = specifiedUsername; Password=specifiedPassword;


namespace WindowsFormsApp3.Clientes
{

    public partial class frmPuesto : Form
    {

        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public frmPuesto()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "NOMBRE";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }
        private void populate(string id, string nombre)
        {
            dataGridView1.Rows.Add(id, nombre);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM tbPuesto ";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString());
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
            clearTxts();
        }
        private void frmPuesto_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            retrieve();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string txt1 = txtPuesto.Text.Trim();

            if ((txt1 == ""))
            {
                DialogResult dr = MessageBox.Show("Falta llenar datos, quieres continuar?",
                      "ALERTA", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        add(txtPuesto.Text);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                add(txtPuesto.Text);
            }
            retrieve();


        }
        private void add(string nombre)
        {
            //SQL STMT
            const string sql = "INSERT INTO tbPuesto(nombrePuesto) VALUES(@nombre)";
            cmd = new MySqlCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@nombre", nombre);
            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {

                    MessageBox.Show(@"Agregado de manera correcta");

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
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
                        string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string puesto = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        txtPuesto.Text = puesto;
                        Lid.Text = Id;

                        txtPuesto.Enabled = false;
                        button1.Visible = false;
                        button2.Visible = true;
                        button3.Visible = false;

                    }

                }

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPuesto.Enabled = true;
            button2.Visible = false;
            button3.Visible=true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Quieres editar este registro?",
                      "ALERTA", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    int id = Convert.ToInt32(Lid.Text);
                    update(id, txtPuesto.Text);
                    break;
                case DialogResult.No:
                    break;
            }
          


            clearTxts();
        }
        private void update(int id, string puesto)
        {
            //SQL STATEMENT
            string sql = "UPDATE tbPuesto SET nombrePuesto='" + puesto + "' WHERE idPuesto=" + id + "";
            cmd = new MySqlCommand(sql, con);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Editado de manera correcta");
                }
                con.Close();

                //REFRESH DATA
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        void  clearTxts()
        {
            txtPuesto.Enabled = true;
            button3.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            Lid.Text = "";
            Class1.LimpiarControles(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se modifica el form hijo 
            if (System.Windows.Forms.Application.OpenForms["frmContacto"] != null)
            {

                (System.Windows.Forms.Application.OpenForms["frmContacto"] as frmContacto).combo();

            }
        }
    }
}
