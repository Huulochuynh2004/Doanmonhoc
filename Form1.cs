using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchoolApp.Models;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        SchoolContext db = new SchoolContext();
        BindingSource bs = new BindingSource();
        int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10);

            cboMajor.Items.AddRange(new string[] {
                "Công nghệ thông tin",
                "Kinh tế",
                "Cơ khí",
                "Điện – Điện tử"
            });

            StyleButton(btnAdd, Color.FromArgb(46, 204, 113));
            StyleButton(btnEdit, Color.FromArgb(241, 196, 15));
            StyleButton(btnDelete, Color.FromArgb(231, 76, 60));
            StyleButton(btnPrev, Color.FromArgb(52, 152, 219));
            StyleButton(btnNext, Color.FromArgb(52, 152, 219));

            StyleGrid();
            LoadData();
        }

        void StyleButton(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        void StyleGrid()
        {
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStudents.RowTemplate.Height = 28;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void LoadData()
        {
            bs.DataSource = db.Students.ToList();
            dgvStudents.DataSource = bs;

            txtName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            cboMajor.DataBindings.Clear();

            txtName.DataBindings.Add("Text", bs, "FullName");
            txtAge.DataBindings.Add("Text", bs, "Age");
            cboMajor.DataBindings.Add("Text", bs, "Major");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.Students.Add(new Student
            {
                FullName = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Major = cboMajor.Text
            });
            db.SaveChanges();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student s = bs.Current as Student;
            if (s == null) return;

            s.FullName = txtName.Text;
            s.Age = int.Parse(txtAge.Text);
            s.Major = cboMajor.Text;
            db.SaveChanges();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student s = bs.Current as Student;
            if (s == null) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Students.Remove(s);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < bs.Count - 1)
            {
                currentIndex++;
                bs.Position = currentIndex;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                bs.Position = currentIndex;
            }
        }
    }
}
