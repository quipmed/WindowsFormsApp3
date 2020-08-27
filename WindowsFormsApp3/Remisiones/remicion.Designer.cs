namespace WindowsFormsApp3.Remisiones
{
    partial class remicion
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
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btModelo = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMarca = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.idProducto = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.observaciones = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.granTotal = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbcliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcliente
            // 
            this.gbcliente.Controls.Add(this.button2);
            this.gbcliente.Controls.Add(this.groupBox2);
            this.gbcliente.Location = new System.Drawing.Point(12, 12);
            this.gbcliente.Name = "gbcliente";
            this.gbcliente.Size = new System.Drawing.Size(728, 67);
            this.gbcliente.TabIndex = 34;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // btEquipo
            // 
            this.btEquipo.Location = new System.Drawing.Point(267, 13);
            this.btEquipo.Name = "btEquipo";
            this.btEquipo.Size = new System.Drawing.Size(39, 23);
            this.btEquipo.TabIndex = 36;
            this.btEquipo.Text = "ADD";
            this.btEquipo.UseVisualStyleBackColor = true;
            this.btEquipo.Click += new System.EventHandler(this.btEquipo_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.groupBox10);
            this.gbProducto.Controls.Add(this.groupBox7);
            this.gbProducto.Controls.Add(this.groupBox8);
            this.gbProducto.Controls.Add(this.groupBox4);
            this.gbProducto.Controls.Add(this.groupBox6);
            this.gbProducto.Controls.Add(this.groupBox1);
            this.gbProducto.Controls.Add(this.button4);
            this.gbProducto.Enabled = false;
            this.gbProducto.Location = new System.Drawing.Point(12, 85);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(728, 200);
            this.gbProducto.TabIndex = 35;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos del producto";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button3);
            this.groupBox10.Controls.Add(this.cbEquipo);
            this.groupBox10.Location = new System.Drawing.Point(147, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(141, 70);
            this.groupBox10.TabIndex = 40;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Equipo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbEquipo
            // 
            this.cbEquipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEquipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(6, 19);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(125, 21);
            this.cbEquipo.TabIndex = 9;
            this.cbEquipo.SelectedIndexChanged += new System.EventHandler(this.cbEquipo_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Location = new System.Drawing.Point(592, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(96, 51);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Precio";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "0";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox2);
            this.groupBox8.Location = new System.Drawing.Point(12, 94);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(461, 100);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Descripcion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(449, 67);
            this.textBox2.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btModelo);
            this.groupBox4.Controls.Add(this.cbModelo);
            this.groupBox4.Location = new System.Drawing.Point(294, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 69);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modelo";
            // 
            // btModelo
            // 
            this.btModelo.Location = new System.Drawing.Point(81, 46);
            this.btModelo.Name = "btModelo";
            this.btModelo.Size = new System.Drawing.Size(39, 23);
            this.btModelo.TabIndex = 33;
            this.btModelo.Text = "ADD";
            this.btModelo.UseVisualStyleBackColor = true;
            this.btModelo.Click += new System.EventHandler(this.btModelo_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(6, 19);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(177, 21);
            this.cbModelo.TabIndex = 9;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(493, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(93, 51);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "1";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btMarca);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 70);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // btMarca
            // 
            this.btMarca.Location = new System.Drawing.Point(43, 46);
            this.btMarca.Name = "btMarca";
            this.btMarca.Size = new System.Drawing.Size(39, 23);
            this.btMarca.TabIndex = 32;
            this.btMarca.Text = "ADD";
            this.btMarca.UseVisualStyleBackColor = true;
            this.btMarca.Click += new System.EventHandler(this.btMarca_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(8, 19);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(114, 21);
            this.cbMarca.TabIndex = 31;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 44);
            this.button4.TabIndex = 16;
            this.button4.Text = "AGREGAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // idProducto
            // 
            this.idProducto.AutoSize = true;
            this.idProducto.Location = new System.Drawing.Point(721, 438);
            this.idProducto.Name = "idProducto";
            this.idProducto.Size = new System.Drawing.Size(35, 13);
            this.idProducto.TabIndex = 41;
            this.idProducto.Text = "label1";
            this.idProducto.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(12, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(728, 175);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prod,
            this.producto,
            this.marca,
            this.modelo,
            this.descripcion,
            this.cantidad,
            this.pUnitario,
            this.subTotal});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_prod
            // 
            this.id_prod.HeaderText = "id_prod";
            this.id_prod.Name = "id_prod";
            this.id_prod.ReadOnly = true;
            this.id_prod.Visible = false;
            this.id_prod.Width = 67;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.producto.FillWeight = 85.34483F;
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 75;
            // 
            // marca
            // 
            this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 62;
            // 
            // modelo
            // 
            this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 67;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descripcion.FillWeight = 101.9878F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantidad.FillWeight = 112.6674F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 74;
            // 
            // pUnitario
            // 
            this.pUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pUnitario.HeaderText = "P. Unitario";
            this.pUnitario.Name = "pUnitario";
            this.pUnitario.ReadOnly = true;
            this.pUnitario.Width = 81;
            // 
            // subTotal
            // 
            this.subTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.subTotal.HeaderText = "Sub total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 74;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.observaciones);
            this.groupBox9.Location = new System.Drawing.Point(12, 472);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(595, 75);
            this.groupBox9.TabIndex = 28;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Observaciones generales";
            // 
            // observaciones
            // 
            this.observaciones.Location = new System.Drawing.Point(6, 19);
            this.observaciones.Multiline = true;
            this.observaciones.Name = "observaciones";
            this.observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observaciones.Size = new System.Drawing.Size(585, 46);
            this.observaciones.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(195, 583);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 40);
            this.button5.TabIndex = 20;
            this.button5.Text = "LIMPIAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(406, 583);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 40);
            this.button6.TabIndex = 43;
            this.button6.Text = "Imprimir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.ac7d7ee3_0fb3_4989_9120_0ddfbce068ad;
            this.pictureBox3.Location = new System.Drawing.Point(392, 930);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.milllogo;
            this.pictureBox2.Location = new System.Drawing.Point(329, 771);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.milllogo;
            this.pictureBox1.Location = new System.Drawing.Point(148, 944);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(620, 576);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 46);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total general";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(6, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 59;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox5);
            this.groupBox11.Location = new System.Drawing.Point(620, 524);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(113, 46);
            this.groupBox11.TabIndex = 64;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "I.V.A General";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(6, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 58;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.granTotal);
            this.groupBox12.Location = new System.Drawing.Point(620, 472);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(113, 46);
            this.groupBox12.TabIndex = 63;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Sub total";
            // 
            // granTotal
            // 
            this.granTotal.BackColor = System.Drawing.Color.White;
            this.granTotal.Location = new System.Drawing.Point(6, 16);
            this.granTotal.Name = "granTotal";
            this.granTotal.ReadOnly = true;
            this.granTotal.Size = new System.Drawing.Size(100, 20);
            this.granTotal.TabIndex = 57;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(746, 279);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 150);
            this.dataGridView2.TabIndex = 66;
            this.dataGridView2.Visible = false;
            // 
            // remicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 634);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.idProducto);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbcliente);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "remicion";
            this.Text = "remicion";
            this.Load += new System.EventHandler(this.remicion_Load);
            this.gbcliente.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbProducto.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btEquipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btModelo;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label idProducto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox observaciones;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox granTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}