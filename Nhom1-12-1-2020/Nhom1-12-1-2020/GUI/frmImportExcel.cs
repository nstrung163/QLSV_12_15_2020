using ExcelDataReader;
using Nhom1_12_1_2020.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace Nhom1_12_1_2020.GUI
{
    public partial class frmImportExcel : Form
    {
        public frmImportExcel()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = tableCollection[cboSheet.SelectedItem.ToString()];
            //gridDataImport.DataSource = dataTable;
            if(dataTable != null)
            {
                List<Student> students = new List<Student>();
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Student student = new Student();
                    student.ID = dataTable.Rows[i]["ID"].ToString();
                    student.FirstName = dataTable.Rows[i]["FirstName"].ToString();
                    student.LastName = dataTable.Rows[i]["LastName"].ToString();
                    student.DateOfBirth = DateTime.Parse(dataTable.Rows[i]["DateOfBirth"].ToString());
                    student.PlaceOfBirth = dataTable.Rows[i]["PlaceOfBirth"].ToString();
                    student.Gender = int.Parse(dataTable.Rows[i]["Gender"].ToString());
                    student.IDClassroom = dataTable.Rows[i]["IDClassroom"].ToString();
                    students.Add(student);
                }
                studentBindingSource.DataSource = students;
            }
        }

        DataTableCollection tableCollection;


        private void btnChonFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() 
                    { Filter= "Excel Wordbook|*.xlsx|Excel 97-2003 Wordbook|*.xls" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=> new ExcelDataTableConfiguration
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName); // Add sheet to combobox

                        }
                    }

                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string conectionString = "Server=DESKTOP-39FGVIL\\SQLEXPRESS;Database=QLSV;User=sa; Password=123";
                DapperPlusManager.Entity<Student>().Table("Student");
                List<Student> students = studentBindingSource.DataSource as List<Student>;
                if(students != null)
                {
                    using (IDbConnection db = new SqlConnection(conectionString))
                    {
                        db.BulkInsert(students);
                    }
                }
                MessageBox.Show("Import dữ liệu từ file excel thành công!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
