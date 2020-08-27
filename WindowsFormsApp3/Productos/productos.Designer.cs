namespace WindowsFormsApp3
{
    partial class productos
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbProcedencia = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lid = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 56);
            this.button4.TabIndex = 27;
            this.button4.Text = "GUARDAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(490, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 54);
            this.button3.TabIndex = 26;
            this.button3.Text = "EDITAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(18, 196);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "AGREGAR NUEVO CLIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(4, 19);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(311, 35);
            this.txtDescripcion.TabIndex = 18;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(6, 21);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(139, 21);
            this.cbMarca.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Location = new System.Drawing.Point(134, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 77);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            this.toolTip1.SetToolTip(this.groupBox1, "Aqui podemos seleccionar una marca ya registradfa\r\n");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.cbProcedencia);
            this.groupBox3.Location = new System.Drawing.Point(11, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 77);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procedencia";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "ADD";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbProcedencia
            // 
            this.cbProcedencia.FormattingEnabled = true;
            this.cbProcedencia.Location = new System.Drawing.Point(6, 21);
            this.cbProcedencia.Name = "cbProcedencia";
            this.cbProcedencia.Size = new System.Drawing.Size(105, 21);
            this.cbProcedencia.TabIndex = 28;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Location = new System.Drawing.Point(153, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 60);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descripcion";
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(102, 384);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(21, 13);
            this.Lid.TabIndex = 35;
            this.Lid.Text = "Lid";
            this.Lid.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.cbEquipo);
            this.groupBox5.Location = new System.Drawing.Point(291, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 77);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Equipo";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(73, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "ADD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cbEquipo
            // 
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(6, 21);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(174, 21);
            this.cbEquipo.TabIndex = 28;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtModelo);
            this.groupBox8.Location = new System.Drawing.Point(6, 112);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(141, 60);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(6, 22);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(126, 20);
            this.txtModelo.TabIndex = 19;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.groupBox1);
            this.gbInfo.Controls.Add(this.groupBox5);
            this.gbInfo.Controls.Add(this.groupBox4);
            this.gbInfo.Controls.Add(this.groupBox8);
            this.gbInfo.Controls.Add(this.groupBox3);
            this.gbInfo.Location = new System.Drawing.Point(1, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(483, 178);
            this.gbInfo.TabIndex = 35;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informacion del equipo";
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 418);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.Lid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.productos_FormClosing);
            this.Load += new System.EventHandler(this.productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbProcedencia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button button6;
    }
}