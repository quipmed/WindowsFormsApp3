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
  

    public partial class productos : Form
    {


        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public productos()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Marca";
            dataGridView1.Columns[5].Name = "Procedencia";
            dataGridView1.Columns[2].Name = "Equipo";
            dataGridView1.Columns[3].Name = "Modelo";
            dataGridView1.Columns[4].Name = "Descripcion";

            dataGridView1.Columns[6].Name = "idProcedencia";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Name = "idMArca"; 
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Name = "idEquipo";
            dataGridView1.Columns[8].Visible = false;

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
            combo();
            clearTxts();
            retrieve();
        }
        public void combo()
        {

            //SQL STATEMENT
            String sql = "SELECT idMarca,nombreMarca FROM tbMarca ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbMarca");
                //LOOP THROUGH DATATABLE

                cbMarca.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cbMarca.ValueMember = "idMarca";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbMarca.DisplayMember = "nombreMarca";



                cbMarca.DataSource = ds.Tables[0].DefaultView;


                con.Close();
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            //SQL STATEMENT
             sql = "SELECT idEquipo,nombreEquipo FROM tbEquipo ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbEquipo");
                //LOOP THROUGH DATATABLE

                cbEquipo.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cbEquipo.ValueMember = "idEquipo";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbEquipo.DisplayMember = "nombreEquipo";



                cbEquipo.DataSource = ds.Tables[0].DefaultView;


                con.Close();
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


            //SQL STATEMENT
            sql = "SELECT idProcedencia,nombreProcedencia FROM tbProcedencia ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbProcedencia");
                //LOOP THROUGH DATATABLE

                cbProcedencia.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cbProcedencia.ValueMember = "idProcedencia";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbProcedencia.DisplayMember = "nombreProcedencia";



                cbProcedencia.DataSource = ds.Tables[0].DefaultView;


                con.Close();
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            openbd = 1;
        }
        public int openbd;
        private void clearTxts()
        {
           
           txtModelo.Text = "";
            txtDescripcion.Text = "";
            Class1.LimpiarControles(this);
            //  cliente.Enabled = true;
            txtDescripcion.Enabled = true;
           
            Lid.Enabled = true;
            button4.Visible = false;
            button1.Visible = true;
            button3.Visible = false;

        }
        private void populate(string id, string marca, string equipo, string modelo, string descripcion, string procedencia, 
            string idProcedencia, string idMarca, string idEquipo)
        {
              
            dataGridView1.Rows.Add(id,  marca,  equipo,  modelo,  descripcion,  procedencia,idProcedencia,idMarca, idEquipo)  ;
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT tbProducto.idProducto, tbMarca.nombreMarca,tbEquipo.nombreEquipo,tbProducto.modeloProducto, " +
                "tbProducto.descripcionProducto, tbProcedencia.nombreProcedencia, tbProducto.idProcedencia, tbProducto.idMarca, tbProducto.idEquipo " +
                "FROM ((tbProducto INNER JOIN tbMarca on tbProducto.idMarca=tbMarca.idMarca) INNER JOIN tbEquipo on tbProducto.idEquipo= tbEquipo.idEquipo)" +
                "INNER JOIN tbProcedencia on tbProducto.idProcedencia= tbProcedencia.idProcedencia";

            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
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
            gbInfo.Enabled = true;
            clearTxts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {
            /*


            dataGridView1.Rows.Clear();
            //SQL STATEMENT

            String sql = "SELECT * FROM productos where nombre like ('%" + textBox1.Text + "%')";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
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
            }*/

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Lid.Text);
            update(id, cbMarca.SelectedValue.ToString(), cbEquipo.SelectedValue.ToString(), txtModelo.Text, txtDescripcion.Text, cbProcedencia.SelectedValue.ToString());



            clearTxts();
        }
        private void update(int id, string marca, string equipo, string modelo, string descripcion, string procedencia)
        {
            //SQL STATEMENT
            string sql = "UPDATE tbProducto SET idProcedencia='" + procedencia + "',idEquipo='" + equipo + "',modeloProducto='" + modelo + "',descripcionProducto='" + descripcion + "',idMarca='" + marca + "' WHERE idProducto=" + id + "";
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
            //cliente.Enabled = true;
            gbInfo.Enabled = true;
            button4.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
        }
        private void add(string marca, string equipo, string modelo, string descripcion, string procedencia)
        {
            //SQL STMT
            const string sql = "INSERT INTO tbProducto(idProcedencia, idEquipo, modeloProducto, descripcionProducto, idMarca)" +
                " VALUES(@idProcedencia, @idEquipo, @modeloProducto, @descripcionProducto, @idMarca)";
            cmd = new MySqlCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@idProcedencia", procedencia);
            cmd.Parameters.AddWithValue("@idEquipo", equipo);
            cmd.Parameters.AddWithValue("@modeloProducto", modelo);
            cmd.Parameters.AddWithValue("@descripcionProducto", descripcion);
            cmd.Parameters.AddWithValue("@idMarca", marca);
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Productos.frmMarca frmMarca = new Productos.frmMarca();
            frmMarca.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Productos.frmEquipo frmMarca = new Productos.frmEquipo();
            frmMarca.ShowDialog();

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
                        string marca = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string equipo = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string modelo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        string descripcion = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        string procedencia = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                        string idProcedencia = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        string idMarca = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        string idEquipo = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

                        txtModelo.Text = modelo;
                        txtDescripcion.Text = descripcion;
                        cbProcedencia.SelectedValue = idProcedencia;
                        cbMarca.SelectedValue = idMarca;
                        cbEquipo.SelectedValue = idEquipo;

                        Lid.Text = Id;

                        //  cliente.Enabled = false;
                        gbInfo.Enabled = false;
                        button1.Visible = false;
                        button3.Visible = true;

                    }

                }

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Productos.procedencia procedencia = new Productos.procedencia();
            procedencia.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show("Captura un modelo porfavor", "Falta agregar un modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                add( cbMarca.SelectedValue.ToString(),cbEquipo.SelectedValue.ToString(),txtModelo.Text,txtDescripcion.Text,cbProcedencia.SelectedValue.ToString());
            }
            retrieve();
        }
    }
}
