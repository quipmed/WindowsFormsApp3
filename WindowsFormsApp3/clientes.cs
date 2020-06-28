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
    public partial class clientes : Form
    {

        public static string directorio = Application.StartupPath;  // variable del directorio de trabajo
        public static string archivo = "spacecraftsDB.mdb";  // variable del directorio de trabajo
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + directorio + @"\" + archivo + ";Persist Security Info=false;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        
        public clientes()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "NOMBRE";
            dataGridView1.Columns[2].Name = "Direccion";
            dataGridView1.Columns[3].Name = "RFC";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE
              
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        string cli, rf, dir;
        private void button1_Click(object sender, EventArgs e)
        {
           cli= cliente.Text.Trim();
           dir= direccion.Text.Trim();
           rf= rfc.Text.Trim();
            if ((cli == "") || (rf == "") || (dir == ""))
            {
                DialogResult dr = MessageBox.Show("falta llenar datos, quieres continuar?",
                      "ALERTA", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        add(cliente.Text, direccion.Text, rfc.Text);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                add(cliente.Text, direccion.Text, rfc.Text);
            }
            retrieve();
        }
        private void add(string nombre, string direccion, string rfc)
        {
            //SQL STMT
            const string sql = "INSERT INTO clientes(nombre,direccion,rfc) VALUES(@nombre,@direccion,@rfc)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@rfc", rfc);

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
        private void clearTxts()
        {
            rfc.Text = "";
            cliente.Text = "";
            direccion.Text = "";
            textBox1.Text = "";

            cliente.Enabled = true;
            direccion.Enabled = true;
            rfc.Enabled = true;
            Lid.Enabled = true;
            button4.Visible = false;
            button1.Visible = true;
            button3.Visible = false;

        }
        private void populate(string id, string nombre, string direccion, string rfc)
        {
            dataGridView1.Rows.Add(id, nombre, direccion, rfc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();


        }

        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM clientes ";
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

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
       
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
                        string Cliente = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string Direccion = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string Rfc = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                        cliente.Text = Cliente;
                        direccion.Text = Direccion;
                        rfc.Text = Rfc;
                        Lid.Text = Id;

                        cliente.Enabled = false;
                        direccion.Enabled = false;
                        rfc.Enabled = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.Enabled = true;
            direccion.Enabled = true;
            rfc.Enabled = true;
            Lid.Enabled = true;
            button4.Visible = true;
            button1.Visible = false;
            button3.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
         *  UPDATE DATABASE
        */
        private void update(int id, string nombre, string direccion, string rfc)
        {
            //SQL STATEMENT
            string sql = "UPDATE clientes SET nombre='" + nombre + "',direccion='" + direccion + "',rfc='" + rfc + "' WHERE ID=" + id + "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(Lid.Text);
                update(id, cliente.Text, direccion.Text, rfc.Text);
            

            clearTxts();
        }

        private void filter()
        {

            dataGridView1.Rows.Clear();
            //SQL STATEMENT

            String sql = "SELECT * FROM clientes where nombre like ('%" + textBox1.Text + "%')";
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

        private void clientes_Load(object sender, EventArgs e)
        {
            clearTxts();
            retrieve();
        }
    }
}
