using Microsoft.Reporting.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Remisiones
{
    public partial class remicion : Form
    {
        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        readonly DataTable dt2 = new DataTable();
        readonly DataTable dt3 = new DataTable();
        public string consecu;
        public remicion()
        {
            InitializeComponent();
        }
        int controlCbAtencion = 0, controlCbMarca = 0, controlCbModelo = 0;
        private void remicion_Load(object sender, EventArgs e)
        {
            combo();
            controlCbAtencion = 1;
            atencionCb();
        }
        private void atencionCb()
        {


            //SQL STATEMENT contacto

            string sql = "SELECT idContacto,nombreContacto FROM tbContacto where idEmpresa='" + cbCliente.SelectedValue + "'  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                cbAtencion.ResetText();

                DataSet ds = new DataSet();
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbContacto");
                //LOOP THROUGH DATATABLE
                con.Close();

                //se especifica el campo de la tabla
                cbAtencion.ValueMember = "idContacto";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbAtencion.DisplayMember = "nombreContacto";



                cbAtencion.DataSource = ds.Tables[0].DefaultView;


                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void modeloCb()
        {
            cbModelo.ResetText();
            //SQL STATEMENT modelo
            string sql = "SELECT idProducto,modeloProducto FROM tbProducto where idMarca='" + cbMarca.SelectedValue + "'  and idEquipo='" + cbEquipo.SelectedValue + "'";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbProducto");
                //LOOP THROUGH DATATABLE
                con.Close();

                //se especifica el campo de la tabla
                cbModelo.ValueMember = "idProducto";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbModelo.DisplayMember = "modeloProducto";



                cbModelo.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void combo()
        {

            //SQL STATEMENT
            String sql = "SELECT ID,nombre FROM tbCliente ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbCliente");
                //LOOP THROUGH DATATABLE

                cbCliente.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cbCliente.ValueMember = "ID";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbCliente.DisplayMember = "nombre";



                cbCliente.DataSource = ds.Tables[0].DefaultView;


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
        private void productoCb()
        {
            String sql = "SELECT idProducto,descripcionProducto FROM tbProducto where  idProducto like ('" + cbModelo.SelectedValue + "')";
            cmd = new MySqlCommand(sql, con);
            try

            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt2);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt2.Rows)
                {
                    textBox2.Text = (row[1].ToString());

                    idProducto.Text = (row[0].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 

                dt2.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void marcaCb()
        {
            //SQL STATEMENT marca
            string sql = "SELECT idMarca,nombreMarca FROM tbMarca ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbMarca");
                //LOOP THROUGH DATATABLE
                con.Close();

                //se especifica el campo de la tabla
                cbMarca.ValueMember = "idMarca";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbMarca.DisplayMember = "nombreMarca";



                cbMarca.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();


            }
            //SQL STATEMENT equipo

            sql = "SELECT idEquipo,nombreEquipo FROM tbEquipo ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbEquipo");
                //LOOP THROUGH DATATABLE
                con.Close();

                //se especifica el campo de la tabla
                cbEquipo.ValueMember = "idEquipo";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbEquipo.DisplayMember = "nombreEquipo";



                cbEquipo.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlCbAtencion == 1)
            {
                atencionCb();
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlCbMarca == 1)
            {
                modeloCb();
            }
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlCbModelo == 1)
            {
                productoCb();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbMarca.Items.Count == 0)
            {
                MessageBox.Show("Captura una marca porfavor", "Falta agregar una marca", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cbEquipo.Items.Count == 0)
            {
                MessageBox.Show("Captura un equipo porfavor", "Falta agregar un equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cbModelo.Items.Count == 0)
            {
                MessageBox.Show("Captura un modelo porfavor", "Falta agregar un modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "1";
                }
                if (textBox3.Text == "")
                {
                    textBox3.Text = "0";
                }
                int i;
                i = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = cbModelo.SelectedValue;
                dataGridView1.Rows[i].Cells[1].Value = cbEquipo.Text;
                dataGridView1.Rows[i].Cells[2].Value = cbMarca.Text;
                dataGridView1.Rows[i].Cells[3].Value = cbModelo.Text;
                dataGridView1.Rows[i].Cells[4].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[5].Value = textBox1.Text;
                dataGridView1.Rows[i].Cells[6].Value = textBox3.Text;
                dataGridView1.Rows[i].Cells[7].Value = (( Convert.ToDouble( textBox1.Text)) * (Convert.ToDouble(textBox3.Text))).ToString();

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);

        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlCbMarca == 1)
            {
                modeloCb();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbAtencion.Items.Count == 0)
            {
                MessageBox.Show("Captura un contacto porfavor", "Falta agregar un contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
            else
            {
                gbcliente.Enabled = false;
                gbProducto.Enabled = true;
                marcaCb();
                controlCbMarca = 1;
                modeloCb();
                controlCbModelo = 1;
                productoCb();
            }
        }
    }
}
