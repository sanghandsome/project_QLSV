namespace QLSV
{
    partial class frmDangNhap
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
            label2 = new Label();
            label3 = new Label();
            cbbLoaitaikhoan = new ComboBox();
            txtTendangnhap = new TextBox();
            txtMatkhau = new TextBox();
            btnDangnhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 98);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 199);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // cbbLoaitaikhoan
            // 
            cbbLoaitaikhoan.FormattingEnabled = true;
            cbbLoaitaikhoan.Items.AddRange(new object[] { "Quản Trị Viên", "Sinh Viên", "Giáo Viên" });
            cbbLoaitaikhoan.Location = new Point(275, 98);
            cbbLoaitaikhoan.Name = "cbbLoaitaikhoan";
            cbbLoaitaikhoan.Size = new Size(226, 28);
            cbbLoaitaikhoan.TabIndex = 3;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(275, 150);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(226, 27);
            txtTendangnhap.TabIndex = 4;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(275, 199);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(226, 27);
            txtMatkhau.TabIndex = 5;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(275, 264);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(99, 36);
            btnDangnhap.TabIndex = 6;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(402, 264);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 36);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendangnhap);
            Controls.Add(cbbLoaitaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbLoaitaikhoan;
        private TextBox txtTendangnhap;
        private TextBox txtMatkhau;
        private Button btnDangnhap;
        private Button btnThoat;
    }
}