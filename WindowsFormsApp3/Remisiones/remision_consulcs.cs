using Microsoft.Reporting.WinForms;
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
    public partial class remision_consulcs : Form
    {
        public static string directorio = Application.StartupPath;  // variable del directorio de trabajo
        public static string archivo = "spacecraftsDB.mdb";  // variable del directorio de trabajo
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + directorio + @"\" + archivo + ";Persist Security Info=false;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public remision_consulcs()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "NOMBRE";
            dataGridView1.Columns[1].Name = "DESCRIPCION";
            dataGridView1.Columns[2].Name = "CANTIDAD";
            dataGridView1.Columns[3].Name = "COSTO";
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
        private void populate(string producto, string descripcion, string cantidad, string costo)
        {
            dataGridView1.Rows.Add(producto, descripcion, cantidad, costo);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT producto, descripcion, cantidad, costo FROM remisiones where id_remi=" + FOLIO.Text + " ";
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
        private void populate2(string producto, string descripcion, string cantidad, string costo)
        {
            dataGridView2.Rows.Add(producto, descripcion, cantidad, costo);
        }
        private void dgvp()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT producto, descripcion, cantidad, costo FROM remisiones where id_remi=" + FOLIO.Text + " ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {

                    populate2(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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
        private void FOLIO_TextChanged(object sender, EventArgs e)
        {
            retrieve();
           // dgvp();

        }

        private void remision_consulcs_Load(object sender, EventArgs e)
        {

        }
        ReportDataSource rs = new ReportDataSource();
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
                rs.Name = "DataSet4";
                rs.Value = list;
                BindingSource bs = (BindingSource)dataGridView1.DataSource;//You should first convert DataSourse into Binding Sourse
                DataTable dt = (DataTable)bs.DataSource; //Get GridView data source to Data table
                Form2 frm = new Form2();
                ReportDataSource rds = new ReportDataSource("DataSet4", dt); // ReportViewerDataSource : ReportViewer is to be bind to this DataSource
                frm.reportViewer1.LocalReport.DataSources.Clear(); // Clear the Previous DataSource of ReportViewer
                frm.reportViewer1.LocalReport.DataSources.Add(rds); //bind ReportViewer1 to the new datasource(Which you wish)
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
               
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report2.rdlc";

                frm.ShowDialog();
           }
        }
    }
}
