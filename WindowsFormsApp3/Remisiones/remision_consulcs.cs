using Microsoft.Reporting.WinForms;
using MySqlConnector;
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
    public partial class remision_consulcs : Form
    {
        public string empresaControl = "2";
        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        readonly DataTable dt2 = new DataTable();
        readonly DataTable dt3 = new DataTable();
        readonly DataTable dt1 = new DataTable();
        public remision_consulcs()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES

            //SELECTION MODE

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        public class remisio
        {

            public string nombre { get; set; }
            public string descripcion { get; set; }
            public string cantidad { get; set; }
            public string pUnitario { get; set; }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void populate(string producto, string marca, string modelo, string descripcion, string cantidad, string costo)
        {
            dataGridView1.Rows.Add(producto, marca, modelo, descripcion, cantidad, costo, (Convert.ToDouble(costo) * Convert.ToDouble(cantidad)).ToString());
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT producto,marca,modelo,descripcion,cantidad,costo FROM tbRemiciones where idRemi=" + FOLIO.Text + " ";
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

                double sumTotal = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    sumTotal += Convert.ToDouble(row.Cells[6].Value);
                }

                granTotal.Text = sumTotal.ToString();//Aqui en cada iteración del for deberia ser el textbox correspondiente
                textBox3.Text = (sumTotal * .16).ToString();
                textBox4.Text = (sumTotal * 1.16).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgvp()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT producto,marca,modelo,descripcion,cantidad,costo FROM tbRemiciones where idRemi=" + FOLIO.Text + " ";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {

                    // populate2(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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
        private void llenarTxt()
        {
            String sql = "SELECT DATE_FORMAT(tbRemi.fecha, '%Y-%m-%d'),tbRemi.observaciones,tbCliente.nombre,tbCliente.direccion,tbCliente.rfc FROM tbRemi INNER JOIN tbCliente on tbRemi.idCliente= tbCliente.ID WHERE tbRemi.folioRemicion=" + FOLIO.Text + "";
            cmd = new MySqlCommand(sql, con);
            try

            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt1);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt1.Rows)
                {
                    textBox1.Text = (row[0].ToString());

                    txtobser.Text = (row[1].ToString());
                    txtEmpresa.Text = (row[2].ToString());

                    txtDireccion.Text = (row[3].ToString());
                    txtRfc.Text = (row[4].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 

                dt1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void FOLIO_TextChanged(object sender, EventArgs e)
        {
            retrieve();
            llenarTxt();
            // dgvp();

        }
        public class client
        {

            public string nombre { get; set; }
            public string rfc { get; set; }
            public string direccion { get; set; }
      

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
        private void remision_consulcs_Load(object sender, EventArgs e)
        {

        }
        ReportDataSource rs = new ReportDataSource();
        private byte[] GetBytes(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        ReportDataSource rs2 = new ReportDataSource();

        ReportDataSource rs3 = new ReportDataSource();
        void empres()
        {



            ///datos del cliente


            List<empresa> list3 = new List<empresa>();
            list3.Clear();
            String sql = "SELECT * FROM tbEmpresas where  id like ('" + empresaControl + "')";
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
            if (empresaControl == "1")
            {
                pictureBox1.Image = pictureBox2.Image;

            }
            else
            {
                pictureBox1.Image = pictureBox3.Image;
            }

            string ob = txtobser.Text;
            empresa remisio3 = new empresa
            {
                nombre = dt3.Rows[0].ItemArray[1].ToString(),
                rfc = dt3.Rows[0].ItemArray[2].ToString(),
                direccion = dt3.Rows[0].ItemArray[3].ToString(),
                telefono = dt3.Rows[0].ItemArray[4].ToString(),
                correo = dt3.Rows[0].ItemArray[5].ToString(),
                logo = GetBytes(pictureBox1.Image),
                serial = FOLIO.Text,
                observa = ob,
                fecha = DateTime.Now.ToShortDateString()

            };
            list3.Add(remisio3);

            rs3.Name = "DataSet3";
            rs3.Value = list3;

            dt3.Rows.Clear();



        }
        private void cliente()
        {
            ///datos del cliente
            List<client> list2 = new List<client>();
            list2.Clear();


            client remisio2 = new client
            {
                nombre = txtEmpresa.Text,
                    direccion = txtDireccion.Text,
                    rfc = txtRfc.Text,
                   
                };
                list2.Add(remisio2);
            
            rs2.Name = "DataSet2";
            rs2.Value = list2;
        }
        private void button1_Click(object sender, EventArgs e)
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
                Form2 frm = new Form2();
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.DataSources.Add(rs2);
                frm.reportViewer1.LocalReport.DataSources.Add(rs3);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Reportes.Report1.rdlc";
                this.Hide();

                // show other form

                frm.ShowDialog();



            }
        }
    }
}
