using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.coti.reportes
{
    public partial class cotservimssbasic : Form
    {
        public cotservimssbasic()
        {
            InitializeComponent();
        }

        private void cotservimssbasic_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
