namespace Nhom1_12_1_2020
{
    partial class FormMain
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gridLopHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaLop = new System.Windows.Forms.ToolStripButton();
            this.btnSuaLop = new System.Windows.Forms.ToolStripButton();
            this.btnThemLop = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridSinhVien = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnImportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnXoaSV = new System.Windows.Forms.ToolStripButton();
            this.btnSuaSV = new System.Windows.Forms.ToolStripButton();
            this.btnThemSv = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.bdLopHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.gridLopHoc);
            this.panelLeft.Controls.Add(this.toolStrip1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(284, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // gridLopHoc
            // 
            this.gridLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLopHoc.Location = new System.Drawing.Point(0, 25);
            this.gridLopHoc.Name = "gridLopHoc";
            this.gridLopHoc.Size = new System.Drawing.Size(284, 425);
            this.gridLopHoc.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên lớp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room";
            this.Column2.HeaderText = "Phòng học";
            this.Column2.Name = "Column2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoaLop,
            this.btnSuaLop,
            this.btnThemLop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(105, 22);
            this.toolStripLabel1.Text = "Danh sách lớp học";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaLop.Image = global::Nhom1_12_1_2020.Properties.Resources.Button_Close_icon;
            this.btnXoaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(47, 22);
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaLop.Image = global::Nhom1_12_1_2020.Properties.Resources.edit_gnote_icon;
            this.btnSuaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(46, 22);
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemLop.Image = global::Nhom1_12_1_2020.Properties.Resources.add_1_icon1;
            this.btnThemLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(57, 22);
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridSinhVien);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(284, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 450);
            this.panel1.TabIndex = 1;
            // 
            // gridSinhVien
            // 
            this.gridSinhVien.AllowUserToOrderColumns = true;
            this.gridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gridSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSinhVien.Location = new System.Drawing.Point(0, 25);
            this.gridSinhVien.Name = "gridSinhVien";
            this.gridSinhVien.Size = new System.Drawing.Size(635, 425);
            this.gridSinhVien.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ID";
            this.Column3.HeaderText = "Mã Sinh Viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FirstName";
            this.Column4.HeaderText = "Họ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LastName";
            this.Column5.HeaderText = "Tên";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateOfBirth";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PlaceOfBirth";
            this.Column7.HeaderText = "Nơi sinh";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Gender";
            this.Column8.HeaderText = "GT";
            this.Column8.Name = "Column8";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportExcel,
            this.btnReset,
            this.btnXoaSV,
            this.btnSuaSV,
            this.btnThemSv,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.txtKeyword});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(635, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnImportExcel.Image = global::Nhom1_12_1_2020.Properties.Resources.Microsoft_Excel_2013_icon;
            this.btnImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(93, 22);
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnReset.Image = global::Nhom1_12_1_2020.Properties.Resources.Button_Load_icon;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 22);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaSV.Image = global::Nhom1_12_1_2020.Properties.Resources.Button_Close_icon;
            this.btnXoaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(47, 22);
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaSV.Image = global::Nhom1_12_1_2020.Properties.Resources.edit_gnote_icon;
            this.btnSuaSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(46, 22);
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnThemSv
            // 
            this.btnThemSv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemSv.Image = global::Nhom1_12_1_2020.Properties.Resources.add_1_icon;
            this.btnThemSv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSv.Name = "btnThemSv";
            this.btnThemSv.Size = new System.Drawing.Size(57, 22);
            this.btnThemSv.Text = "Thêm";
            this.btnThemSv.Click += new System.EventHandler(this.btnThemSv_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "Tìm kiếm:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(100, 25);
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // bdLopHoc
            // 
            this.bdLopHoc.CurrentChanged += new System.EventHandler(this.bdLopHoc_CurrentChanged);
            // 
            // bdSinhVien
            // 
            this.bdSinhVien.CurrentChanged += new System.EventHandler(this.bdSinhVien_CurrentChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp học";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView gridLopHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnThemLop;
        private System.Windows.Forms.ToolStripButton btnSuaLop;
        private System.Windows.Forms.ToolStripButton btnXoaLop;
        private System.Windows.Forms.DataGridView gridSinhVien;
        private System.Windows.Forms.BindingSource bdLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.BindingSource bdSinhVien;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripButton btnXoaSV;
        private System.Windows.Forms.ToolStripButton btnSuaSV;
        private System.Windows.Forms.ToolStripButton btnThemSv;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripButton btnImportExcel;
    }
}

