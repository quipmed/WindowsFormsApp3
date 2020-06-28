using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{


    public partial class remi : Form
    {

        public static string directorio = Application.StartupPath;  // variable del directorio de trabajo
        public static string archivo = "spacecraftsDB.mdb";  // variable del directorio de trabajo
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + directorio + @"\" + archivo + ";Persist Security Info=false;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        readonly DataTable dt2 = new DataTable();
        readonly DataTable dt3 = new DataTable();

        public remi()
        {
           
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "NOMBRE";
            dataGridView2.Columns[2].Name = "Direccion";
            dataGridView2.Columns[3].Name = "RFC";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE

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
            cmd = new OleDbCommand(sql, con);
            try

            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
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
           


                empresa remisio3 = new empresa
                {
                    nombre = dt3.Rows[0].ItemArray[1].ToString(),
                    rfc = dt3.Rows[0].ItemArray[2].ToString(),
                    direccion = dt3.Rows[0].ItemArray[3].ToString(),

                };
                list3.Add(remisio3);
            
            rs3.Name = "DataSet3";
            rs3.Value = list3;

            dt3.Rows.Clear();



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


                    pris = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    pris.Trim();
                    if (pris == "")
                    {
                        pris = "0";
                    }
                    remisio remisio = new remisio
                    {
                        nombre = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        descripcion = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        cantidad = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        pUnitario = pris,
                        logo = GetBytes(pictureBox1.Image)
                    };
                    list.Add(remisio);
                }
                rs.Name = "DataSet1";
                rs.Value = list;
                cliente();
                empres();
                Form1 frm = new Form1();
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.DataSources.Add(rs2);
                frm.reportViewer1.LocalReport.DataSources.Add(rs3);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report2.rdlc";
               
                frm.ShowDialog();
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


        }

        public class remisio
        {
            public Byte[] logo { get; set; }
           public string nombre { get; set; }
         public string descripcion { get; set; }
            public string cantidad { get; set; }
            public string pUnitario { get; set; }
        
        }
        remisiones remisiones = new remisiones();
        private void combo()
        {
         
            //SQL STATEMENT
            String sql = "SELECT id,nombre FROM clientes ";
            cmd = new OleDbCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(ds, "clientes");
                //LOOP THROUGH DATATABLE

                comboBox2.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                comboBox2.ValueMember = "id";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                comboBox2.DisplayMember = "nombre";


                
                comboBox2.DataSource = ds.Tables[0].DefaultView;
            

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
           sql = "SELECT id,nombre FROM productos ";
            cmd = new OleDbCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(ds, "productos");
                //LOOP THROUGH DATATABLE
                con.Close();
         
                //se especifica el campo de la tabla
                comboBox3.ValueMember = "id";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                comboBox3.DisplayMember = "nombre";



                comboBox3.DataSource = ds.Tables[0].DefaultView;


               
                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            //SQL STATEMENT
            sql = "SELECT id,nombre FROM empresas ";
            cmd = new OleDbCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(ds, "empresas");
                //LOOP THROUGH DATATABLE
                con.Close();

                //se especifica el campo de la tabla
                comboBox1.ValueMember = "id";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                comboBox1.DisplayMember = "nombre";



                comboBox1.DataSource = ds.Tables[0].DefaultView;



                //CLEAR DATATABLE 

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


        }

        private void remi_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = 0;
            comboBox1.SelectedValue = 0;
            comboBox1.Text = "RR MEdica";
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
        {
            dataGridView2.Rows.Clear();
            //SQL STATEMENT

            String sql = "SELECT * FROM clientes where  id like ('" + comboBox2.SelectedValue + "')";
            cmd = new OleDbCommand(sql, con);
            try
            {
                //con.Open();
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
            String sql = "SELECT descripcion FROM productos where  id like ('" + comboBox3.SelectedValue + "')";
            cmd = new OleDbCommand(sql, con);
            try
           
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
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
            int i;
            i = dataGridView1.Rows.Count ;
            dataGridView1.Rows.Add();

            dataGridView1.Rows[i].Cells[0].Value = comboBox3.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = numericUpDown1.Text;
            dataGridView1.Rows[i].Cells[3].Value = numericUpDown2.Text;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            numericUpDown1.Value = 0;

            numericUpDown2.Value = 0;
        }
    }
}
