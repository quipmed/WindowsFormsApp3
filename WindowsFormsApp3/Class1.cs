using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Class1
    {

        public static ADODB.Connection cnn = new ADODB.Connection();  // variable para realizar la conexion con access
        public static ADODB.Recordset regs = new ADODB.Recordset();  // variable para abrir una tabla de la Base de Datos
        public static string directorio = Application.StartupPath;  // variable del directorio de trabajo
        public static void AbrirBD(string archivo)
        {
            if (System.IO.File.Exists(archivo))
            {
                
                if (Convert.ToInt32(cnn.State) == 1)
                {
                    cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + directorio + @"\" + archivo + ";Persist Security Info=false;";  // Database Password=1234;
                    cnn.Open();
                }
            }
            else
            {
                MessageBox.Show(string.Format("No existe la base de datos " + archivo));
               
                System.Environment.Exit(0);
            }
        }

        public static void CerrarBD()
        {
            if (Convert.ToInt32(cnn.State) == 1)
                cnn.Close();
        }

        

        // Metodo que hara la limpieza de los TextBox
        public static void LimpiarControles(Form Frm)
        {
            // Hacemos un chequeo por todos los controles del Form
            foreach (Control Ctrl in Frm.Controls)
            {
                // Si un control del Form resulta ser GroupBox
                if (Ctrl is GroupBox)
                {
                    // Hacemos un chequeo por todos los controles del GroupBox
                    foreach (Control subControl in Ctrl.Controls)
                    {
                        // Si un control del GroupBox es un TextBox
                        if (subControl is TextBox)
                            // Entonces borramos su texto
                            subControl.Text = "";
                    }
                }
                // Si un control del Form resulta ser TexBox
                if (Ctrl is TextBox)
                    // Entonces borramos su texto
                    Ctrl.Text = "";
            }
        }

    }
}

