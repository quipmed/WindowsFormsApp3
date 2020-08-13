namespace WindowsFormsApp3.Productos
{
    partial class procedencia
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.Lid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(147, 21);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 39);
            this.btGuardar.TabIndex = 59;
            this.btGuardar.Text = "Modificar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(147, 21);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 39);
            this.btEditar.TabIndex = 58;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(147, 21);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 39);
            this.btAgregar.TabIndex = 57;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(74, 191);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 39);
            this.btLimpiar.TabIndex = 56;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(50, 188);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(35, 13);
            this.Lid.TabIndex = 55;
            this.Lid.Text = "label5";
            this.Lid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(163, 114);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 53);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedencia";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(3, 19);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(120, 20);
            this.txtDepartamento.TabIndex = 2;
            // 
            // procedencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 240);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.Lid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "procedencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "procedencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.procedencia_FormClosing);
            this.Load += new System.EventHandler(this.procedencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDepartamento;
    }
}