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
        public string selectorDeEmpresa;
        public remicion ( bool sde)
        {
           
            if (sde== true)
            {
                selectorDeEmpresa = "mill";
            }
            else
            {
                selectorDeEmpresa = "rr";
            }

        InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "nombre";
            dataGridView2.Columns[1].Name = "direccion";
            dataGridView2.Columns[2].Name = "rfc";

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
        }
        int controlCbAtencion = 0, controlCbMarca = 0, controlCbModelo = 0;
        private void remicion_Load(object sender, EventArgs e)
        {
            combo();
            controlCbAtencion = 1;
            atencionCb();
        }
        DataTable dt4 = new DataTable();
        private void consecutivo()
        {
            dt4.Clear();
            //SQL STATEMENTSELECT max(visitas) FROM enlace
            string sql = "";
            if ( selectorDeEmpresa== "rr")
            {
           sql = "SELECT  (max(folioRemicion)+ 1)  FROM tbRemi  ";
            }
            else
            {
                sql = "SELECT  (max(folioRemicion)+ 1)  FROM tbRemiMill  ";
            }
        
            cmd = new MySqlCommand(sql, con);
            try

            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt4);
                //LOOP THROUGH DATATABLE
                consecu = dt4.Rows[0].ItemArray[0].ToString();
                if (consecu == "")
                {
                    consecu = "1";
                }
                con.Close();
                //CLEAR DATATABLE 


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }

        }
        private void atencionCb()
        {
            /*

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
            /*/
        }
        public void combo2()
        { 
             marcaCb();
                modeloCb();
       
                productoCb();
        
             

    
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
        public void combo()
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
        {//llenar textbox
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
                double sumTotal = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    sumTotal += Convert.ToDouble(row.Cells[7].Value);
                }

                granTotal.Text = sumTotal.ToString();//Aqui en cada iteración del for deberia ser el textbox correspondiente
                textBox5.Text = (sumTotal * .16).ToString();
                textBox4.Text = (sumTotal * 1.16).ToString();


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

        public class remisionTb
        {

            public string producto { get; set; }
            public string marca { get; set; }
            public string modelo { get; set; }
            public string cantidad { get; set; }
            public string descripcion { get; set; }
            public string precio { get; set; }

        }
        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rs2 = new ReportDataSource();

        ReportDataSource rs3 = new ReportDataSource();
        void empres()
        {



            ///datos del cliente


            List<empresa> list3 = new List<empresa>();
            list3.Clear();
            string emp;
            if (selectorDeEmpresa=="rr")
            {
                emp = "2";
            }
            else
            {
                emp = "1";
            }
            String sql = "SELECT * FROM tbEmpresas where  id like ('"+ emp + "')";
          
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
            if ( selectorDeEmpresa== "rr")
            {
                pictureBox1.Image = pictureBox3.Image;

            }
            else
            {
                pictureBox1.Image = pictureBox2.Image;
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
                observa = ob,
                fecha = DateTime.Now.ToShortDateString()

            };
            list3.Add(remisio3);

            rs3.Name = "DataSet3";
            rs3.Value = list3;

            dt3.Rows.Clear();



        }
        private byte[] GetBytes(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count != 0)
            {
                ///datos del cliente



                /// 
                ///

                string pris;
                List<remisionTb> list = new List<remisionTb>();
                list.Clear();

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {


                    pris = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    pris.Trim();
                    if (pris == "")
                    {
                        pris = "0";
                    }
                    remisionTb remisio = new remisionTb
                    {
                        producto = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        marca = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        modelo = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        descripcion = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                        cantidad = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                        

                        precio = pris,

                    };
                    list.Add(remisio);
                }
                rs.Name = "DataSet1";
                rs.Value = list;
                cliente();
               empres();
                guard();
                 Form2 frm = new Form2();
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.DataSources.Add(rs2);
                frm.reportViewer1.LocalReport.DataSources.Add(rs3);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Reportes.Report1.rdlc";
                this.Hide();

                // show other form

                frm.ShowDialog();

                // close application
                this.Close();


            }
            
        }
        private void guard2()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idRemi, producto,marca,modelo,descripcion, cantidad, costo,idProducto ;

                idRemi = consecu;
                idProducto = dataGridView1[0, row.Index].Value.ToString();

                producto = dataGridView1[1, row.Index].Value.ToString();
                marca = dataGridView1[2, row.Index].Value.ToString();
                modelo = dataGridView1[3, row.Index].Value.ToString();
                descripcion = dataGridView1[4, row.Index].Value.ToString();
                cantidad = dataGridView1[5, row.Index].Value.ToString();
                costo = dataGridView1[6, row.Index].Value.ToString();
                //SQL STMT
                 string sql="";
                if ( selectorDeEmpresa== "rr")
                {
                    sql = "INSERT INTO tbRemiciones(idRemi, producto,marca,modelo,descripcion, cantidad, costo,idProducto)   VALUES(@idRemi, @producto,@marca,@modelo,@descripcion, @cantidad, @costo,@idProducto)";

                }
                else
                {
                    sql = "INSERT INTO tbRemicionesMill(idRemi, producto,marca,modelo,descripcion, cantidad, costo,idProducto)   VALUES(@idRemi, @producto,@marca,@modelo,@descripcion, @cantidad, @costo,@idProducto)";
                }
                    cmd = new MySqlCommand(sql, con);

                //ADD PARAMS
                cmd.Parameters.AddWithValue("@idRemi", idRemi);
                cmd.Parameters.AddWithValue("@producto", producto);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                  cmd.Parameters.AddWithValue("@costo", costo);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                //OPEN CON AND EXEC INSERT
                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {

                       

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
            consecutivo();
            //SQL STMT
            string sql = "";
            if ( selectorDeEmpresa== "rr")
            { 
              sql = "INSERT INTO tbRemi(idCliente,fecha,folioRemicion,observaciones)" +
                 " VALUES(@idCliente,@fecha,@folioRemicion,@observaciones)";

            }
            else
            {
                sql = "INSERT INTO tbRemiMill(idCliente,fecha,folioRemicion,observaciones)" +
                 " VALUES(@idCliente,@fecha,@folioRemicion,@observaciones)";
            }

            cmd = new MySqlCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmd.Parameters.AddWithValue("@folioRemicion", consecu);
            cmd.Parameters.AddWithValue("@observaciones", observaciones.Text);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {

                   

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
        private void cliente()
        {
 ///datos del cliente
 List<client> list2 = new List<client>();
            list2.Clear();

               
                client remisio2 = new client
                {
                    nombre = dataGridView2.Rows[0].Cells[0].Value.ToString(),
                    direccion = dataGridView2.Rows[0].Cells[1].Value.ToString(),
                    rfc = dataGridView2.Rows[0].Cells[2].Value.ToString(),
                   

                };
                list2.Add(remisio2);
            
            rs2.Name = "DataSet2";
            rs2.Value = list2;
        }
        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlCbMarca == 1)
            {
                modeloCb();
            }
        }                            //empresa            direccion       rfc                 nombre contacto         //nombre puesto

        private void btEquipo_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.ShowDialog();
        }

        private void btMarca_Click(object sender, EventArgs e)
        {
            Productos.frmMarca marca = new Productos.frmMarca();
            marca.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Productos.frmEquipo equipo = new Productos.frmEquipo();
            equipo.ShowDialog();
        }

        private void btModelo_Click(object sender, EventArgs e)
        {
            productos productos = new productos();
            productos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearTxts();
        }
        private void clearTxts()
        {
            textBox1.Text = "1";
            textBox3.Text = "0";
            gbProducto.Enabled = false;
            gbcliente.Enabled = true;
            // txtModelo.Text = "";
            //txtDescripcion.Text = "";
            Class1.LimpiarControles(this);
            //  cliente.Enabled = true;
            // txtDescripcion.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            // Lid.Enabled = true;
            // button1.Visible = true;
        }
            private void populate(string empresa, string direccion, string rfc)
        {
            dataGridView2.Rows.Add(empresa, direccion, rfc);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cbCliente.Items.Count == 0)
            {
                MessageBox.Show("Captura un cliente porfavor", "Falta agregar un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
                
            dataGridView2.Rows.Clear();
            //SQL STATEMENT

            String sql = "select tbCliente.nombre,tbCliente.direccion,tbCliente.rfc from tbCliente where tbCliente.ID = " + cbCliente.SelectedValue + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                //con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {              //empresa            direccion       rfc                 nombre contacto         //nombre puesto
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
        }
    }
}
