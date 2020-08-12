using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmContacto : Form
    {

        public static string conString = "datasource=162.241.60.245;port=3306;username=quipmedc_rrmedica;password=#Linux2018;database=quipmedc_rrmedica;";
        readonly MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public frmContacto()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Empresa";
            dataGridView1.Columns[2].Name = "Departamento";
            dataGridView1.Columns[3].Name = "Nombre";
            dataGridView1.Columns[4].Name = "Correo";
            dataGridView1.Columns[5].Name = "Celular";
            dataGridView1.Columns[6].Name = "Telefono";

            dataGridView1.Columns[7].Name = "idEmpresa";
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[8].Name = "idDepartamento";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //SELECTION MODE

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clientes.frmPuesto puesto = new Clientes.frmPuesto();

            openbd = 0;
            puesto.ShowDialog();

        }
        private void populate(string id, string empresa, string departamento,
             string nombre, string correo, string celular, string tel,string idEmpresa, string idDepartamento)
        {
            dataGridView1.Rows.Add( id,  empresa,  departamento,
              nombre,  correo,  celular,  tel,idEmpresa,idDepartamento);
        }
        public void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT tbContacto.idContacto, tbCliente.nombre,tbPuesto.nombrePuesto,tbContacto.nombreContacto," +
                " tbContacto.correoContacto, tbContacto.celularContacto, tbContacto.telContacto, tbContacto.idEmpresa,tbContacto.idDepartamento FROM " +
                "(tbContacto INNER JOIN tbCliente on tbCliente.ID=tbContacto.idEmpresa) INNER JOIN tbPuesto on tbContacto.idDepartamento= tbPuesto.idPuesto " +
                "where tbContacto.idEmpresa like ('%" + cbEmpresa.SelectedValue + "%')";
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
        private void frmContacto_Load(object sender, EventArgs e)
        {
            combo();
            retrieve();
        }
        public void combo()
        {

            //SQL STATEMENT
            String sql = "SELECT id,nombre FROM tbCliente ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbCliente");
                //LOOP THROUGH DATATABLE

                cbEmpresa.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cbEmpresa.ValueMember = "id";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbEmpresa.DisplayMember = "nombre";



                 cbEmpresa.DataSource = ds.Tables[0].DefaultView;


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
              sql = "SELECT idPuesto,nombrePuesto FROM tbPuesto ";
            cmd = new MySqlCommand(sql, con);
            try
            {

                DataSet ds = new DataSet();
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tbPuesto");
                //LOOP THROUGH DATATABLE

                cbPuesto.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cbPuesto.ValueMember = "idPuesto";
                //indicamos el valor de los miembros

                //se indica el valor a desplegar en el combobox
                cbPuesto.DisplayMember = "nombrePuesto";



                cbPuesto.DataSource = ds.Tables[0].DefaultView;


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
        public int openbd;//evita errores de abrir bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddEmpresa_Click(object sender, EventArgs e)
        {
            openbd = 0;
            clientes clientes = new clientes();
            clientes.ShowDialog();
            clearTxts();
           
        }

        private void frmContacto_Enter(object sender, EventArgs e)
        {
            combo();
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (txNombre.Text.Trim() == "")
            {
                MessageBox.Show("Captura un nombre porfavor", "Falta agregar nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                add( Convert.ToInt16( cbEmpresa.SelectedValue), Convert.ToInt16(cbPuesto.SelectedValue), txNombre.Text, txCorreo.Text,txCelular.Text,txTelefono.Text);
                retrieve();
            }
        }
        private void add(int empresa, int puesto, string nombre,string correo,string cel,string tel)
        {
            //SQL STMT
            const string sql = "INSERT INTO tbContacto(idEmpresa,idDepartamento,nombreContacto,correoContacto,celularContacto,telContacto) VALUES(@idEmpresa,@idDepartamento,@nombreContacto,@correoContacto,@celularContacto,@telContacto)";
            cmd = new MySqlCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@idEmpresa", empresa);
            cmd.Parameters.AddWithValue("@idDepartamento", puesto);
            cmd.Parameters.AddWithValue("@nombreContacto", nombre);
                cmd.Parameters.AddWithValue("@correoContacto", correo);
            cmd.Parameters.AddWithValue("@celularContacto", cel);
            cmd.Parameters.AddWithValue("@telContacto", tel);

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
        void clearTxts()
        {
            desbloqueotxt();
         
            btEditar.Visible = false;
            btGuardar.Visible = false;
            btInsertar.Visible = true;
//Lid.Text = "";
            Class1.LimpiarControles(this);

        }
        private void txTelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openbd == 1)
            {
                retrieve();
            }
            

        }

        private void cbEmpresa_MouseLeave(object sender, EventArgs e)
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
                        string empresa = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        string puesto = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                        string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                       

                        string nombre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        string correo = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        string celular = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        string telefono = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                        cbEmpresa.SelectedValue = empresa;
                        cbPuesto.SelectedValue = puesto;
                        txNombre.Text = nombre;
                        txCorreo.Text = correo;
                        txCelular.Text = celular;
                        txTelefono.Text = telefono;
                        Lid.Text = id;

                        groupBox4.Enabled = false;
                      
                        btEditar.Visible = true;
                        btInsertar.Visible = false;
                        //button3.Visible = true;

                    }

                }

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            desbloqueotxt();
            btEditar.Visible = false;
            btGuardar.Visible = true;
        }
        private void desbloqueotxt()
        {
            groupBox4.Enabled = true;
        }
        private void update(int id, string empresa, string puesto, string nombre, string correo, string celular, string telefono)
        {
            //SQL STATEMENT
            string sql = "UPDATE tbContacto SET idEmpresa='" + empresa + "',idDepartamento='" + puesto + "',nombreContacto='" + nombre + "',correoContacto='" + correo + "',celularContacto='" + celular + "',telContacto='" + telefono + "' WHERE idContacto=" + id + "";
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Lid.Text);
            update(id, Convert.ToString(cbEmpresa.SelectedValue), Convert.ToString( cbPuesto.SelectedValue), txNombre.Text,txCorreo.Text,txCelular.Text,txTelefono.Text);


            clearTxts();
        }
    }
}
