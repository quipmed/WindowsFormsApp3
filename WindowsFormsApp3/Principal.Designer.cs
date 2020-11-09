namespace WindowsFormsApp3
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rrMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMISIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTADEREMISIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEMISIONESToolStripMenuItem,
            this.cONSULTADEREMISIONESToolStripMenuItem,
            this.cotizacionesToolStripMenuItem,
            this.pruebasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rrMedicaToolStripMenuItem,
            this.millToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // rrMedicaToolStripMenuItem
            // 
            this.rrMedicaToolStripMenuItem.Name = "rrMedicaToolStripMenuItem";
            this.rrMedicaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.rrMedicaToolStripMenuItem.Text = "rrMedica";
            this.rrMedicaToolStripMenuItem.Click += new System.EventHandler(this.rrMedicaToolStripMenuItem_Click);
            // 
            // millToolStripMenuItem
            // 
            this.millToolStripMenuItem.Name = "millToolStripMenuItem";
            this.millToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.millToolStripMenuItem.Text = "Mill";
            this.millToolStripMenuItem.Click += new System.EventHandler(this.millToolStripMenuItem_Click);
            // 
            // rEMISIONESToolStripMenuItem
            // 
            this.rEMISIONESToolStripMenuItem.Name = "rEMISIONESToolStripMenuItem";
            this.rEMISIONESToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.rEMISIONESToolStripMenuItem.Text = "REMISIONES";
            this.rEMISIONESToolStripMenuItem.Click += new System.EventHandler(this.rEMISIONESToolStripMenuItem_Click);
            // 
            // cONSULTADEREMISIONESToolStripMenuItem
            // 
            this.cONSULTADEREMISIONESToolStripMenuItem.Name = "cONSULTADEREMISIONESToolStripMenuItem";
            this.cONSULTADEREMISIONESToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.cONSULTADEREMISIONESToolStripMenuItem.Text = "CONSULTA DE REMISIONES";
            this.cONSULTADEREMISIONESToolStripMenuItem.Click += new System.EventHandler(this.cONSULTADEREMISIONESToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sERVICIOToolStripMenuItem});
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.cotizacionesToolStripMenuItem.Text = "COTIZACIONES";
            this.cotizacionesToolStripMenuItem.Click += new System.EventHandler(this.cotizacionesToolStripMenuItem_Click);
            // 
            // sERVICIOToolStripMenuItem
            // 
            this.sERVICIOToolStripMenuItem.Name = "sERVICIOToolStripMenuItem";
            this.sERVICIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sERVICIOToolStripMenuItem.Text = "SERVICIO";
            this.sERVICIOToolStripMenuItem.Click += new System.EventHandler(this.sERVICIOToolStripMenuItem_Click);
            // 
            // pruebasToolStripMenuItem
            // 
            this.pruebasToolStripMenuItem.Name = "pruebasToolStripMenuItem";
            this.pruebasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pruebasToolStripMenuItem.Text = "pruebas";
            this.pruebasToolStripMenuItem.Click += new System.EventHandler(this.pruebasToolStripMenuItem_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1059, 142);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mill";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(964, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RR";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.milllogo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.ac7d7ee3_0fb3_4989_9120_0ddfbce068ad;
            this.pictureBox2.Location = new System.Drawing.Point(37, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(410, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 285);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEMISIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTADEREMISIONESToolStripMenuItem;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rrMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem millToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebasToolStripMenuItem;
    }
}