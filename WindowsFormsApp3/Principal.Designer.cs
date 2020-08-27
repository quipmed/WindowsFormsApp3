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
            this.rEMISIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTADEREMISIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rrMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cLIENTESToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.cONSULTADEREMISIONESToolStripMenuItem,
            this.puestoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rEMISIONESToolStripMenuItem
            // 
            this.rEMISIONESToolStripMenuItem.Name = "rEMISIONESToolStripMenuItem";
            this.rEMISIONESToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.rEMISIONESToolStripMenuItem.Text = "REMISIONES";
            this.rEMISIONESToolStripMenuItem.Click += new System.EventHandler(this.rEMISIONESToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click);
            // 
            // cONSULTADEREMISIONESToolStripMenuItem
            // 
            this.cONSULTADEREMISIONESToolStripMenuItem.Name = "cONSULTADEREMISIONESToolStripMenuItem";
            this.cONSULTADEREMISIONESToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.cONSULTADEREMISIONESToolStripMenuItem.Text = "CONSULTA DE REMISIONES";
            this.cONSULTADEREMISIONESToolStripMenuItem.Click += new System.EventHandler(this.cONSULTADEREMISIONESToolStripMenuItem_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Checked = true;
            this.puestoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.puestoToolStripMenuItem.Text = "CONTACTO";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTADEREMISIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rrMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem millToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}