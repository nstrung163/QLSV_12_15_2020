using Nhom1_12_1_2020.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_12_1_2020.GUI
{
    public partial class frmLopChiTiet : Form
    {
        Classroom lopHoc;
        public frmLopChiTiet()
        {
            //Thêm mới
            InitializeComponent();
            this.Text = "Thêm mới lớp học";
        }
        public frmLopChiTiet(Classroom lopHoc)
        {
            //Chỉnh sửa
            InitializeComponent();
            this.Text = "Chỉnh sửa lớp học";
            this.lopHoc = lopHoc;
            txtTenLop.Text = this.lopHoc.Name;
            txtPhongHoc.Text = this.lopHoc.Room;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var tenLop = txtTenLop.Text;
            var phongHoc = txtPhongHoc.Text;
            if(this.lopHoc == null)
            {
                //Thêm lớp ở đây
                var lop = new Classroom
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = tenLop,
                    Room = phongHoc
                };
                var db = new AppQLSVDBContext();
                db.Classrooms.Add(lop);
                db.SaveChanges();
                MessageBox.Show("Lớp học đã được thêm thành công!");
                // Nếu thêm thành công thì trả về kết quả là OK
                DialogResult = DialogResult.OK;
            } else
            {
                var db = new AppQLSVDBContext();
                var lop = db.Classrooms.Where(b => b.ID == lopHoc.ID).FirstOrDefault(); // lấy ra lớp cần chỉnh sửa
                lop.Name = tenLop; // chỉnh tên sửa lớp
                lop.Room = phongHoc;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        
    }
}
