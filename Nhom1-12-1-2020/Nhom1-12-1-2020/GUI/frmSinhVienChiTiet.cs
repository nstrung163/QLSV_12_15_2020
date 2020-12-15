using Nhom1_12_1_2020.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_12_1_2020.GUI
{
    public partial class frmSinhVienChiTiet : Form
    {
        Student sinhVien;

        public frmSinhVienChiTiet()
        {
            InitializeComponent();
            LoadNameClassroom();
            this.Text = "Thêm mới sinh viên";
        }

        public frmSinhVienChiTiet(Student sinhVien)
        {
            InitializeComponent();
            LoadNameClassroom();
            this.Text = "Chỉnh sửa nhân viên";
            this.sinhVien = sinhVien;
            txtMaSV.Text = this.sinhVien.ID;
            txtHoDem.Text = this.sinhVien.FirstName;
            txtTen.Text = this.sinhVien.LastName;
            //Parse DateTime to String
            /*DateTime dateOfBirth = (DateTime) this.sinhVien.DateOfBirth;
            String DOBstr = dateOfBirth.ToString();*/
            txtNgaySinh.Text = this.sinhVien.DateOfBirth.ToString();
            txtNoiSinh.Text = this.sinhVien.PlaceOfBirth;

            radioNam.Checked = this.sinhVien.Gender == 1;
            radioNu.Checked = this.sinhVien.Gender == 0;
            radioKhac.Checked = this.sinhVien.Gender == 2;

            var db = new AppQLSVDBContext();
            var lopHoc = db.Classrooms.Where(s => s.ID == this.sinhVien.IDClassroom).FirstOrDefault();
            combTenLop.Text = lopHoc.Name;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            AppQLSVDBContext dbc = new AppQLSVDBContext();
            var maSv = txtMaSV.Text;
            var hoDem = txtHoDem.Text;
            var ten = txtTen.Text;
            DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);
            var noiSinh = txtNoiSinh.Text;
            int gioiTinh = radioNu.Checked ? 0 : (radioNam.Checked ? 1 : 2);
            var tenLopHoc = combTenLop.Text;
            var lopHoc = dbc.Classrooms.Where(i => i.Name == tenLopHoc).FirstOrDefault();  // get IDLopHoc
            //var lopHoc = dbc.Classrooms.Where(i => i.ID == combTenLop.Text).FirstOrDefault();
            if (lopHoc == null) {
                MessageBox.Show($"Không tồn tại lớp học có tên là: {tenLopHoc}");
            } else
            {
                if (sinhVien == null)
                {
                    // Thêm mới sinh viên
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var maSvDuplicate = db.Students.Where(a => a.ID == maSv).FirstOrDefault();
                    if(maSvDuplicate == null)
                    {
                        var student = new Student
                        {
                            ID = maSv,
                            FirstName = hoDem,
                            LastName = ten,
                            DateOfBirth = ngaySinh,
                            PlaceOfBirth = noiSinh,
                            Gender = gioiTinh,
                            IDClassroom = lopHoc.ID
                        };
                        db.Students.Add(student);
                        db.SaveChanges();
                        MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    } else
                    {
                        MessageBox.Show($"Mã sinh viên: {maSv} đã bị trùng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    //Chỉnh sửa sinh viên
                    var db = new AppQLSVDBContext();
                    var sv = db.Students.Where(c => c.ID == sinhVien.ID).FirstOrDefault(); // Truy xuất sinh viên đang chọn dưới DB
                    sv.ID = maSv; // chỉnh sửa id ở DB thành txtMaSV
                    sv.FirstName = hoDem;
                    sv.LastName = ten;
                    sv.DateOfBirth = ngaySinh;
                    sv.PlaceOfBirth = noiSinh;
                    sv.Gender = gioiTinh;
                    sv.IDClassroom = lopHoc.ID;
                    // Lưu dữ liệu xuống DB
                   
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật sinh viên thành công!");
                    DialogResult = DialogResult.OK;
                   
                }
            }
        }


        private void bdsTenLop_CurrentChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Select list name classroom
        /// 
        /// </summary>
        List<Classroom> listLopHoc;
        void LoadNameClassroom() {
            AppQLSVDBContext db = new AppQLSVDBContext();
            listLopHoc = db.Classrooms.OrderBy(t => t.Name).ToList();
            bdsTenLop.DataSource = listLopHoc;
            combTenLop.DataSource = bdsTenLop;
            combTenLop.DisplayMember = "Name";
        }
    }
}
