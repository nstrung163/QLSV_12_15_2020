using Nhom1_12_1_2020.DAL;
using Nhom1_12_1_2020.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_12_1_2020
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            gridLopHoc.AutoGenerateColumns = false;
            gridSinhVien.AutoGenerateColumns = false;
            LoadDanhSachLopHoc();
            LoadDanhSachSinhVien();
        }

         void LoadDanhSachLopHoc()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            var ls = db.Classrooms.OrderBy(e => e.Name).ToList();
            bdLopHoc.DataSource = ls;
            gridLopHoc.DataSource = bdLopHoc;
        }

        void LoadDanhSachSinhVien()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            var ls = db.Students.ToList();
            bdSinhVien.DataSource = ls;
            gridSinhVien.DataSource = bdSinhVien;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var f = new frmLopChiTiet();
            if(f.ShowDialog() == DialogResult.OK) {
                LoadDanhSachLopHoc();
            }
        }

        private void btnThemSv_Click(object sender, EventArgs e)
        {
            var f = new frmSinhVienChiTiet();
            if(f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachSinhVien();
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdLopHoc.Current as Classroom;
            if(lopDangChon != null)
            {
               var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var lop = db.Classrooms.Where(t => t.ID == lopDangChon.ID).FirstOrDefault();
                    if(lop != null)
                    {
                        db.Classrooms.Remove(lop);
                        db.SaveChanges();
                        LoadDanhSachLopHoc();
                    }
                }
            }
        }
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdSinhVien.Current as Student;
            var ten = sinhVienDangChon.FirstName + " " + sinhVienDangChon.LastName;
            if(sinhVienDangChon != null)
            {
                var rs = MessageBox.Show($"Bạn có thực sự muốn xóa sinh viên {ten} không?","Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var sv = db.Students.Where(a => a.ID == sinhVienDangChon.ID).FirstOrDefault();
                    if(sv != null)
                    {
                        db.Students.Remove(sv);
                        db.SaveChanges();
                        LoadDanhSachSinhVien();
                    }
                }
            }
        }

        private void bdLopHoc_CurrentChanged(object sender, EventArgs e)
        {
            var lopDangChon = bdLopHoc.Current as Classroom;
            if(lopDangChon != null)
            {
                var db = new AppQLSVDBContext();
                var dsSV = db.Students.Where(d => d.IDClassroom == lopDangChon.ID).ToList();
                bdSinhVien.DataSource = dsSV;
                gridSinhVien.DataSource = bdSinhVien;
            }
        }

        private void bdSinhVien_CurrentChanged(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdSinhVien.Current as Student;
            if(sinhVienDangChon != null)
            {
                var db = new AppQLSVDBContext();
                
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdLopHoc.Current as Classroom;
            if(lopDangChon != null)
            {
                var f = new frmLopChiTiet(lopDangChon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachLopHoc();
                }
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdSinhVien.Current as Student;
            if(sinhVienDangChon != null)
            {
                var f = new frmSinhVienChiTiet(sinhVienDangChon);
                if(f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachSinhVien();
                }
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == (char) 13) 
            {
                var keyword = txtKeyword.Text;
                var db = new AppQLSVDBContext();
                var ls = db.Students.Where(
                    t => t.FirstName.Contains(keyword) 
                    || t.LastName.Contains(keyword) 
                    || t.PlaceOfBirth.Contains(keyword)
                    || t.ID.Contains(keyword)
                    ).ToList();
                gridSinhVien.DataSource = ls;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            var f = new frmImportExcel();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachSinhVien();
            }
        }
    }
}
