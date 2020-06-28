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
  

    public partial class productos : Form
    {

        public static string directorio = Application.StartupPath;  // variable del directorio de trabajo
        public static string archivo = "spacecraftsDB.mdb";  // variable del directorio de trabajo
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + directorio + @"\" + archivo + ";Persist Security Info=false;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public productos()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "NOMBRE";
            dataGridView1.Columns[2].Name = "descripcion";
           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void productos_Load(object sender, EventArgs e)
        {
            clearTxts();
            retrieve();
        }
        private void clearTxts()
        {
           
            cliente.Text = "";
            descripcion.Text = "";
            textBox1.Text = "";

            cliente.Enabled = true;
            descripcion.Enabled = true;
           
            Lid.Enabled = true;
            button4.Visible = false;
            button1.Visible = true;
            button3.Visible = false;

        }
        private void populate(string id, string nombre, string descripcion)
        {
            dataGridView1.Rows.Add(id, nombre, descripcion);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM productos ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
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
            clearTxts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {

            dataGridView1.Rows.Clear();
            //SQL STATEMENT

            String sql = "SELECT * FROM productos where nombre like ('%" + textBox1.Text + "%')";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
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

        private void button4_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Lid.Text);
            update(id, cliente.Text, descripcion.Text);


            clearTxts();
        }
        private void update(int id, string nombre, string descripcion)
        {
            //SQL STATEMENT
            string sql = "UPDATE productos SET nombre='" + nombre + "',descripcion='" + descripcion + "' WHERE id=" + id + "";
            cmd = new OleDbCommand(sql, con);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Updated");
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

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.Enabled = true;
            descripcion.Enabled = true;
            
            Lid.Enabled = true;
            button4.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
        }
        private void add(string nombre, string descripcion)
        {
            //SQL STMT
            const string sql = "INSERT INTO productos(nombre,descripcion) VALUES(@nombre,@direccion)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@direccion", descripcion);
          

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Inserted");

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        string cli, dir;

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string Cliente = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string Direccion = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        
                        cliente.Text = Cliente;
                        descripcion.Text = Direccion;

                        Lid.Text = Id;

                        cliente.Enabled = false;
                        descripcion.Enabled = false;
                        Lid.Enabled = false;
                        button1.Visible = false;
                        button3.Visible = true;

                    }

                }

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cli = cliente.Text.Trim();
            dir = descripcion.Text.Trim();
            
            if ((cli == "")  || (dir == ""))
            {
                DialogResult dr = MessageBox.Show("falta llenar datos, quieres continuar?",
                      "ALERTA", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        add(cliente.Text, descripcion.Text);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                add(cliente.Text, descripcion.Text);
            }
            retrieve();
        }
    }
}
