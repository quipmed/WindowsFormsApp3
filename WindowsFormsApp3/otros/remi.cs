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


namespace WindowsFormsApp3
{


    public partial class remi : Form
    {

        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        readonly DataTable dt2 = new DataTable();
        readonly DataTable dt3 = new DataTable();
        public string consecu;

        public remi()
        {
           
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "NOMBRE";
            dataGridView2.Columns[2].Name = "Direccion";
            dataGridView2.Columns[3].Name = "RFC";//SELECTION MODE

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
        }
        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rs2 = new ReportDataSource();
        private void cliente()
        {



                ///datos del cliente


                List<client> list2 = new List<client>();
                list2.Clear();

                for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                {


                    
                    client remisio2 = new client
                    {
                        nombre = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                        rfc = dataGridView2.Rows[i].Cells[3].Value.ToString(),
                        direccion = dataGridView2.Rows[i].Cells[2].Value.ToString(),
                        
                    };
                    list2.Add(remisio2);
                }
                rs2.Name = "DataSet2";
                rs2.Value = list2;
             
               
               
                       

        }
        ReportDataSource rs3 = new ReportDataSource();
        private void empres()
        {



            ///datos del cliente


            List<empresa> list3 = new List<empresa>();
            list3.Clear();
            String sql = "SELECT * FROM empresas where  id like ('" + comboBox1.SelectedValue + "')";
            cmd = new MySqlCommand(sql, con);
            try

            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt3);
                //LOOP THROUGH DATATABLE
                

                con.Close();
                //CLEAR DATATABLE 

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            if (comboBox1.SelectedValue.ToString() == "1")
            {
                pictureBox1.Image = pictureBox2.Image;

            }
            else {
                pictureBox1.Image = pictureBox3.Image;
            }
            consecutivo();
            string ob = observaciones.Text;
            empresa remisio3 = new empresa
            {
                nombre = dt3.Rows[0].ItemArray[1].ToString(),
                rfc = dt3.Rows[0].ItemArray[2].ToString(),
                direccion = dt3.Rows[0].ItemArray[3].ToString(),
                telefono = dt3.Rows[0].ItemArray[4].ToString(),
                correo = dt3.Rows[0].ItemArray[5].ToString(),
                logo = GetBytes(pictureBox1.Image),
                serial = consecu,
                observa =ob ,
                fecha = DateTime.Now.ToShortDateString()

            };
                list3.Add(remisio3);
            
            rs3.Name = "DataSet3";
            rs3.Value = list3;

            dt3.Rows.Clear();



        }
        private void guard2()
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string id_remi, id_producto, cantidad, costo, descripcion,producto;

                id_remi = consecu;
                id_producto = dataGridView1[0, row.Index].Value.ToString();
                cantidad = dataGridView1[3, row.Index].Value.ToString();
                costo = dataGridView1[4, row.Index].Value.ToString();
                descripcion = dataGridView1[2, row.Index].Value.ToString();
                producto = dataGridView1[1, row.Index].Value.ToString();
                //SQL STMT
                const string sql = "INSERT INTO remisiones(id_remi,id_producto,cantidad,costo,descripcion,producto)" +
                    " VALUES(@id_remi,@id_producto,@cantidad,@costo,@descripcion,@producto)";
                cmd = new MySqlCommand(sql, con);

                //ADD PARAMS
                cmd.Parameters.AddWithValue("@id_remi", id_remi);
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@costo", costo);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@producto", producto);

                //OPEN CON AND EXEC INSERT
                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {

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

        }
        private void guard()
        {
            //SQL STMT
            const string sql = "INSERT INTO remi_id(id_cliente,id_empresa,fecha,id_remi,observaciones)" +
                " VALUES(@id_cliente,@id_empresa,@fecha,@id_remi,@observaciones)";
            cmd = new MySqlCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue);
            cmd.Parameters.AddWithValue("@id_empresa", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@id_remi", consecu);
            cmd.Parameters.AddWithValue("observaciones",observaciones.Text);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    
                    MessageBox.Show(@"Successfully Inserted");

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            guard2();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           


            if (dataGridView1.Rows.Count != 0)
            {
                ///datos del cliente



                /// 
                ///

                string pris;
                List<remisio> list = new List<remisio>();
                list.Clear();

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {


                    pris = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    pris.Trim();
                    if (pris == "")
                    {
                        pris = "0";
                    }
                    remisio remisio = new remisio
                    {
                        nombre = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        descripcion = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        cantidad = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        pUnitario = pris,
                       
                    };
                    list.Add(remisio);
                }
                rs.Name = "DataSet1";
                rs.Value = list;
                cliente();
                empres();
                guard();
                //Form1 frm = new Form1();
               /* frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.DataSources.Add(rs2);
                frm.reportViewer1.LocalReport.DataSources.Add(rs3);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report2.rdlc";
                this.Hide();
                */
                // show other form
               
             //   frm.ShowDialog();

                // close application
                this.Close();
                
                
            }
        }

        private byte[] GetBytes(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public class client
        {
          
            public string nombre { get; set; }
            public string rfc { get; set; }
            public string direccion { get; set; }
           

        }
        public class empresa
        {

            public string nombre { get; set; }
            public string rfc { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string correo { get; set; }
            public Byte[] logo { get; set; }
            public string fecha { get; set; }
            public string serial { get; set; }
            public string observa { get; set; }
        }

        public class remisio
        {
           
           public string nombre { get; set; }
         public string descripcion { get; set; }
            public string cantidad { get; set; }
            public string pUnitario { get; set; }
        
        }
        remisiones remisiones = new remisiones();
        DataTable dt4 = new DataTable();
     
        private void consecutivo()
        {
            dt4.Clear();
            //SQL STATEMENTSELECT max(visitas) FROM enlace
            String sql = "SELECT  (max(id_remi)+ 1)  FROM remi_id where id_empresa="+ comboBox1.SelectedValue+" ";
            cmd = new MySqlCommand(sql, con);
            try

            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt4);
                //LOOP THROUGH DATATABLE
                consecu = dt4.Rows[0].ItemArray[0].ToString();

                con.Close();
                //CLEAR DATATABLE 


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
           

           

            //SQL STATEMENT marca
            sql = "SELECT idMarca,nombreMarca FROM tbMarca ";
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
            /*
            //SQL STATEMENT contacto
            sql = "SELECT idContacto,nombreContacto FROM tbContacto where idEmpresa='" + cbCliente.SelectedValue + "'  ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
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

            //SQL STATEMENT modelo
            sql = "SELECT idProducto,modeloProducto FROM tbProducto where idMarca='"+cbMarca.SelectedValue+"' ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
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
            */
           
            
            }

        private void remi_Load(object sender, EventArgs e)
        {
            
            combo();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void remisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remisiones.ShowDialog();
        }
        clientes Clientes = new clientes();

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {//SQL STATEMENT contacto
            
           string sql = "SELECT idContacto,nombreContacto FROM tbContacto where idEmpresa='" + cbCliente.SelectedValue + "'  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {

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
            }/*
            dataGridView2.Rows.Clear();
            //SQL STATEMENT

            String sql = "SELECT * FROM tbCliente where  id like ('" + cbCliente.SelectedValue + "')";
            cmd = new MySqlCommand(sql, con);
            try
            {
                //con.Open();
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
            /*/
        }
        productos productos = new productos();
        private void populate(string id, string nombre, string direccion, string rfc)
        {
            dataGridView2.Rows.Add(id, nombre, direccion, rfc);
        }
        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = "SELECT descripcionProducto FROM tbProducto where  idProducto like ('" + cbModelo.SelectedValue + "')";
            cmd = new MySqlCommand(sql, con);
            try
           
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt2);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt2.Rows)
                {
                    textBox2.Text = (row[0].ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (cbModelo.SelectedValue != null)
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
                dataGridView1.Rows[i].Cells[1].Value = cbModelo.Text;
                dataGridView1.Rows[i].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[3].Value = textBox1.Text;
                dataGridView1.Rows[i].Cells[4].Value = textBox3.Text;
            }
            else
            {
                MessageBox.Show("vuelve a seleccionar el producto");

            }
            textBox1.Text = "1";
            textBox3.Text = "0";
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            comboBox1.Enabled = true;
            cbCliente.Enabled = true;
            cbModelo.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
           // button4.Enabled = true;
            observaciones.Enabled = false;
            dataGridView1.Rows.Clear();
            textBox1.Text = "1";

            textBox3.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue != null)
            {
                textBox1.Text = "1";
                textBox3.Text = "0";
                dataGridView1.Enabled = true;
                comboBox1.Enabled = false;
                cbCliente.Enabled = false;
                cbModelo.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
             //   button4.Enabled = false;
                observaciones.Enabled = true;
            }
            else
            {
                MessageBox.Show("vuelve a seleccionar el cliente");
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        void clearTxts()
        {
           
            //Lid.Text = "";
            Class1.LimpiarControles(this);

        }
        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTxts();
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

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }
    }
}
