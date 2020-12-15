namespace Nhom1_12_1_2020.GUI
{
    partial class frmLopChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopChiTiet));
            this.labTenLop = new System.Windows.Forms.Label();
            this.labPhongHoc = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTenLop
            // 
            resources.ApplyResources(this.labTenLop, "labTenLop");
            this.labTenLop.Name = "labTenLop";
            // 
            // labPhongHoc
            // 
            resources.ApplyResources(this.labPhongHoc, "labPhongHoc");
            this.labPhongHoc.Name = "labPhongHoc";
            // 
            // txtTenLop
            // 
            resources.ApplyResources(this.txtTenLop, "txtTenLop");
            this.txtTenLop.Name = "txtTenLop";
            // 
            // txtPhongHoc
            // 
            resources.ApplyResources(this.txtPhongHoc, "txtPhongHoc");
            this.txtPhongHoc.Name = "txtPhongHoc";
            // 
            // btnBoQua
            // 
            resources.ApplyResources(this.btnBoQua, "btnBoQua");
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Image = global::Nhom1_12_1_2020.Properties.Resources.Extras_Close_icon1;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Image = global::Nhom1_12_1_2020.Properties.Resources.Save_icon__1_1;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmLopChiTiet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.txtPhongHoc);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.labPhongHoc);
            this.Controls.Add(this.labTenLop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmLopChiTiet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTenLop;
        private System.Windows.Forms.Label labPhongHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnOk;
    }
}