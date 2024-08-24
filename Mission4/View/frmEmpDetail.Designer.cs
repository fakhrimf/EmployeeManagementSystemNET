namespace Mission4.View
{
    partial class frmEmpDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpDetail));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.grpEmp = new System.Windows.Forms.GroupBox();
            this.lblEditCertificate = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lstCertificate = new System.Windows.Forms.ListBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.cboManager = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.errEmpNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errHireDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHireDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.CausesValidation = false;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(292, 315);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 47);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Tutup";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWork
            // 
            this.btnWork.Image = ((System.Drawing.Image)(resources.GetObject("btnWork.Image")));
            this.btnWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWork.Location = new System.Drawing.Point(169, 315);
            this.btnWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(86, 47);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "Work";
            this.btnWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // grpEmp
            // 
            this.grpEmp.Controls.Add(this.lblEditCertificate);
            this.grpEmp.Controls.Add(this.label9);
            this.grpEmp.Controls.Add(this.lstCertificate);
            this.grpEmp.Controls.Add(this.txtHireDate);
            this.grpEmp.Controls.Add(this.label8);
            this.grpEmp.Controls.Add(this.txtEmpNo);
            this.grpEmp.Controls.Add(this.cboManager);
            this.grpEmp.Controls.Add(this.label1);
            this.grpEmp.Controls.Add(this.label7);
            this.grpEmp.Controls.Add(this.label2);
            this.grpEmp.Controls.Add(this.txtBonus);
            this.grpEmp.Controls.Add(this.txtName);
            this.grpEmp.Controls.Add(this.label6);
            this.grpEmp.Controls.Add(this.label3);
            this.grpEmp.Controls.Add(this.txtSalary);
            this.grpEmp.Controls.Add(this.cboDept);
            this.grpEmp.Controls.Add(this.label5);
            this.grpEmp.Controls.Add(this.label4);
            this.grpEmp.Controls.Add(this.txtTitle);
            this.grpEmp.Location = new System.Drawing.Point(14, 7);
            this.grpEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEmp.Name = "grpEmp";
            this.grpEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEmp.Size = new System.Drawing.Size(528, 288);
            this.grpEmp.TabIndex = 1;
            this.grpEmp.TabStop = false;
            // 
            // lblEditCertificate
            // 
            this.lblEditCertificate.AutoSize = true;
            this.lblEditCertificate.Location = new System.Drawing.Point(380, 211);
            this.lblEditCertificate.Name = "lblEditCertificate";
            this.lblEditCertificate.Size = new System.Drawing.Size(82, 16);
            this.lblEditCertificate.TabIndex = 17;
            this.lblEditCertificate.TabStop = true;
            this.lblEditCertificate.Text = "Edit sertifikat";
            this.lblEditCertificate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditCertificate_LinkClicked);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Held sertifikat";
            // 
            // lstCertificate
            // 
            this.lstCertificate.FormattingEnabled = true;
            this.lstCertificate.ItemHeight = 16;
            this.lstCertificate.Location = new System.Drawing.Point(127, 180);
            this.lstCertificate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCertificate.Name = "lstCertificate";
            this.lstCertificate.Size = new System.Drawing.Size(227, 100);
            this.lstCertificate.TabIndex = 15;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(406, 136);
            this.txtHireDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(114, 22);
            this.txtHireDate.TabIndex = 14;
            this.txtHireDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtHireDate_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tanggal Bergabung";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(127, 27);
            this.txtEmpNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(114, 22);
            this.txtEmpNo.TabIndex = 0;
            this.txtEmpNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmpNo_Validating);
            // 
            // cboManager
            // 
            this.cboManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManager.FormattingEnabled = true;
            this.cboManager.Location = new System.Drawing.Point(127, 137);
            this.cboManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboManager.Name = "cboManager";
            this.cboManager.Size = new System.Drawing.Size(114, 24);
            this.cboManager.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Karyawan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pengelola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(406, 101);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(114, 22);
            this.txtBonus.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(406, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bonus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departemen";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(127, 101);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(114, 22);
            this.txtSalary.TabIndex = 4;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(406, 63);
            this.cboDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(114, 24);
            this.cboDept.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gaji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jabatan";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 63);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(114, 22);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // errEmpNo
            // 
            this.errEmpNo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEmpNo.ContainerControl = this;
            // 
            // errName
            // 
            this.errName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errName.ContainerControl = this;
            // 
            // errTitle
            // 
            this.errTitle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errTitle.ContainerControl = this;
            // 
            // errSalary
            // 
            this.errSalary.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSalary.ContainerControl = this;
            // 
            // errHireDate
            // 
            this.errHireDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errHireDate.ContainerControl = this;
            // 
            // frmEmpDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 386);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.grpEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Karyawan";
            this.Load += new System.EventHandler(this.frmEmpDetail_Load);
            this.grpEmp.ResumeLayout(false);
            this.grpEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHireDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.GroupBox grpEmp;
        protected System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtEmpNo;
        protected System.Windows.Forms.ComboBox cboManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtBonus;
        protected System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtSalary;
        protected System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ErrorProvider errEmpNo;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errTitle;
        private System.Windows.Forms.ErrorProvider errSalary;
        private System.Windows.Forms.ErrorProvider errHireDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstCertificate;
        private System.Windows.Forms.LinkLabel lblEditCertificate;
    }
}