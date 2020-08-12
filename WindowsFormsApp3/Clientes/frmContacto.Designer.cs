namespace WindowsFormsApp3
{
    partial class frmContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.btAddEmpresa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.btAddPuesto = new System.Windows.Forms.Button();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.Lid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btEditar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txTelefono);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.txNombre);
            this.groupBox4.Controls.Add(this.txCorreo);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txCelular);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 130);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contacto";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(289, 99);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(86, 20);
            this.txTelefono.TabIndex = 39;
            this.txTelefono.TextChanged += new System.EventHandler(this.txTelefono_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Correo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmpresa);
            this.groupBox1.Controls.Add(this.btAddEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 48);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(6, 21);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(133, 21);
            this.cbEmpresa.TabIndex = 38;
            this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            this.cbEmpresa.MouseLeave += new System.EventHandler(this.cbEmpresa_MouseLeave);
            // 
            // btAddEmpresa
            // 
            this.btAddEmpresa.Location = new System.Drawing.Point(145, 19);
            this.btAddEmpresa.Name = "btAddEmpresa";
            this.btAddEmpresa.Size = new System.Drawing.Size(39, 23);
            this.btAddEmpresa.TabIndex = 30;
            this.btAddEmpresa.Text = "ADD";
            this.btAddEmpresa.UseVisualStyleBackColor = true;
            this.btAddEmpresa.Click += new System.EventHandler(this.btAddEmpresa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPuesto);
            this.groupBox2.Controls.Add(this.btAddPuesto);
            this.groupBox2.Location = new System.Drawing.Point(204, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 48);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departamaneto";
            // 
            // cbPuesto
            // 
            this.cbPuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(6, 21);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(120, 21);
            this.cbPuesto.TabIndex = 38;
            // 
            // btAddPuesto
            // 
            this.btAddPuesto.Location = new System.Drawing.Point(132, 19);
            this.btAddPuesto.Name = "btAddPuesto";
            this.btAddPuesto.Size = new System.Drawing.Size(39, 23);
            this.btAddPuesto.TabIndex = 30;
            this.btAddPuesto.Text = "ADD";
            this.btAddPuesto.UseVisualStyleBackColor = true;
            this.btAddPuesto.Click += new System.EventHandler(this.button6_Click);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(65, 73);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(180, 20);
            this.txNombre.TabIndex = 2;
            // 
            // txCorreo
            // 
            this.txCorreo.Location = new System.Drawing.Point(65, 99);
            this.txCorreo.Name = "txCorreo";
            this.txCorreo.Size = new System.Drawing.Size(180, 20);
            this.txCorreo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre ";
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(289, 73);
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(86, 20);
            this.txCelular.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Celular";
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(405, 53);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 42);
            this.btInsertar.TabIndex = 39;
            this.btInsertar.Text = "Agregar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(207, 268);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 42);
            this.btLimpiar.TabIndex = 43;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(77, 278);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(35, 13);
            this.Lid.TabIndex = 42;
            this.Lid.Text = "label5";
            this.Lid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(428, 114);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(405, 53);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 42);
            this.btEditar.TabIndex = 44;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Visible = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(405, 53);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 42);
            this.btGuardar.TabIndex = 45;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Visible = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 318);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.Lid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContacto";
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
            this.Enter += new System.EventHandler(this.frmContacto_Enter);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddPuesto;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Button btAddEmpresa;
        private System.Windows.Forms.TextBox txCorreo;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btGuardar;
    }
}