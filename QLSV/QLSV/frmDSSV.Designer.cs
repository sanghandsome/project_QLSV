namespace QLSV
{
    partial class frmDSSV
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
            label1 = new Label();
            txtTuKhoa = new TextBox();
            btnTimKiem = new Button();
            btnThemmoi = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 1;
            label1.Text = "Từ Khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(411, 28);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(189, 27);
            txtTuKhoa.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(606, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Location = new Point(706, 25);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 4;
            btnThemmoi.Text = "Thêm Mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Dock = DockStyle.Bottom;
            dgvSinhVien.Location = new Point(0, 117);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(800, 333);
            dgvSinhVien.TabIndex = 5;
            dgvSinhVien.CellDoubleClick += dgvSinhVien_CellDoubleClick;
            // 
            // frmDSSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "frmDSSV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh Sách Sinh Viên";
            Load += frmDSSV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnTimKiem;
        private Button btnThemmoi;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvSinhVien;
    }
}