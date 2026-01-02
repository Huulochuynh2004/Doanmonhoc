namespace SchoolApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cboMajor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMajor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // ===== TITLE =====
            this.lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(200, 10);
            this.lblTitle.AutoSize = true;

            // ===== DATAGRIDVIEW =====
            this.dgvStudents.Location = new System.Drawing.Point(20, 50);
            this.dgvStudents.Size = new System.Drawing.Size(740, 250);

            // ===== LABELS =====
            this.lblName.Text = "Họ tên:";
            this.lblName.Location = new System.Drawing.Point(20, 320);

            this.lblAge.Text = "Tuổi:";
            this.lblAge.Location = new System.Drawing.Point(20, 360);

            this.lblMajor.Text = "Ngành học:";
            this.lblMajor.Location = new System.Drawing.Point(20, 400);

            // ===== INPUT =====
            this.txtName.Location = new System.Drawing.Point(120, 315);
            this.txtName.Width = 250;

            this.txtAge.Location = new System.Drawing.Point(120, 355);
            this.txtAge.Width = 100;

            this.cboMajor.Location = new System.Drawing.Point(120, 395);
            this.cboMajor.Width = 250;
            this.cboMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // ===== BUTTON CRUD =====
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(420, 315);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Text = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(420, 360);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(420, 405);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ===== NAVIGATION =====
            this.btnPrev.Text = "◀ Previous";
            this.btnPrev.Location = new System.Drawing.Point(600, 330);
            this.btnPrev.Size = new System.Drawing.Size(140, 35);
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            this.btnNext.Text = "Next ▶";
            this.btnNext.Location = new System.Drawing.Point(600, 380);
            this.btnNext.Size = new System.Drawing.Size(140, 35);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cboMajor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
