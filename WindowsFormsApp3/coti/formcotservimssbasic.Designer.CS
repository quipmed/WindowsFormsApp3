namespace WindowsFormsApp3.coti
{
    partial class formcotservimssbasic
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
            this.gbcliente = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btEquipo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAtencion = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gbcliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcliente
            // 
            this.gbcliente.Controls.Add(this.groupBox1);
            this.gbcliente.Controls.Add(this.button2);
            this.gbcliente.Controls.Add(this.groupBox2);
            this.gbcliente.Location = new System.Drawing.Point(12, 12);
            this.gbcliente.Name = "gbcliente";
            this.gbcliente.Size = new System.Drawing.Size(728, 67);
            this.gbcliente.TabIndex = 35;
            this.gbcliente.TabStop = false;
            this.gbcliente.Text = "Datos del cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCliente);
            this.groupBox2.Controls.Add(this.btEquipo);
            this.groupBox2.Location = new System.Drawing.Point(5, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 41);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre del cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(6, 13);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(255, 21);
            this.cbCliente.TabIndex = 4;
            // 
            // btEquipo
            // 
            this.btEquipo.Location = new System.Drawing.Point(267, 13);
            this.btEquipo.Name = "btEquipo";
            this.btEquipo.Size = new System.Drawing.Size(39, 23);
            this.btEquipo.TabIndex = 36;
            this.btEquipo.Text = "ADD";
            this.btEquipo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAtencion);
            this.groupBox1.Location = new System.Drawing.Point(358, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 41);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Con atencion a:";
            // 
            // txtAtencion
            // 
            this.txtAtencion.Location = new System.Drawing.Point(6, 14);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Size = new System.Drawing.Size(208, 20);
            this.txtAtencion.TabIndex = 0;
            this.txtAtencion.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPresentacion);
            this.groupBox8.Location = new System.Drawing.Point(12, 85);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(728, 68);
            this.groupBox8.TabIndex = 40;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Presentacion:";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(6, 19);
            this.txtPresentacion.Multiline = true;
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPresentacion.Size = new System.Drawing.Size(716, 43);
            this.txtPresentacion.TabIndex = 18;
            this.txtPresentacion.Text = "POR MEDIO DE LA PRESENTE, ME PERMITO PRESENTAR LA SIGUIENTE COTIZACIÓN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 226);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.preciounitario,
            this.importe});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 192);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(632, 130);
            this.dataGridView2.TabIndex = 44;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(12, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 420);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descripcion";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 19);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(716, 27);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Canitdad";
            this.Cantidad.Name = "Cantidad";
            // 
            // preciounitario
            // 
            this.preciounitario.HeaderText = "P.U.";
            this.preciounitario.Name = "preciounitario";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 44;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formcotservimssbasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.gbcliente);
            this.Name = "formcotservimssbasic";
            this.Text = "formcotservimssbasic";
            this.gbcliente.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAtencion;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button button1;
    }
}