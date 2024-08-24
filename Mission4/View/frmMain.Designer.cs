namespace Mission4.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDeptMgt = new System.Windows.Forms.ToolStripButton();
            this.btnEmpMgt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBaseMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeptMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeptMgt,
            this.btnEmpMgt,
            this.toolStripSeparator1,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(602, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDeptMgt
            // 
            this.btnDeptMgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeptMgt.Image = ((System.Drawing.Image)(resources.GetObject("btnDeptMgt.Image")));
            this.btnDeptMgt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeptMgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeptMgt.Name = "btnDeptMgt";
            this.btnDeptMgt.Size = new System.Drawing.Size(26, 26);
            this.btnDeptMgt.Text = "toolStripButton1";
            this.btnDeptMgt.Click += new System.EventHandler(this.btnDeptMgt_Click);
            // 
            // btnEmpMgt
            // 
            this.btnEmpMgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEmpMgt.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpMgt.Image")));
            this.btnEmpMgt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmpMgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmpMgt.Name = "btnEmpMgt";
            this.btnEmpMgt.Size = new System.Drawing.Size(26, 26);
            this.btnEmpMgt.Text = "toolStripButton2";
            this.btnEmpMgt.Click += new System.EventHandler(this.btnEmpMgt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 26);
            this.btnExit.Text = "toolStripButton3";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaseMgt,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBaseMgt
            // 
            this.mnuBaseMgt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeptMgt,
            this.mnuEmpMgt});
            this.mnuBaseMgt.Name = "mnuBaseMgt";
            this.mnuBaseMgt.Size = new System.Drawing.Size(85, 20);
            this.mnuBaseMgt.Text = "Informasi standar(&B)";
            // 
            // mnuDeptMgt
            // 
            this.mnuDeptMgt.Name = "mnuDeptMgt";
            this.mnuDeptMgt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDeptMgt.Size = new System.Drawing.Size(196, 22);
            this.mnuDeptMgt.Text = "Manajemen Departemen(&D)";
            this.mnuDeptMgt.Click += new System.EventHandler(this.mnuDeptMgt_Click);
            // 
            // mnuEmpMgt
            // 
            this.mnuEmpMgt.Name = "mnuEmpMgt";
            this.mnuEmpMgt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEmpMgt.Size = new System.Drawing.Size(196, 22);
            this.mnuEmpMgt.Text = "manajemen karyawan(&E)";
            this.mnuEmpMgt.Click += new System.EventHandler(this.mnuEmpMgt_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(62, 20);
            this.mnuExit.Text = "Exit(&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 412);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "sistem manajemen personalia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDeptMgt;
        private System.Windows.Forms.ToolStripButton btnEmpMgt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBaseMgt;
        private System.Windows.Forms.ToolStripMenuItem mnuDeptMgt;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpMgt;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}