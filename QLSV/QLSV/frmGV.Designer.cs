namespace QLSV
{
    partial class frmGV
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHo = new TextBox();
            txtTendem = new TextBox();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            txtDienthoai = new TextBox();
            txtTen = new TextBox();
            rbtNam = new RadioButton();
            rbtNu = new RadioButton();
            mtbNgaysinh = new MaskedTextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 112);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 155);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Đệm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 197);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 233);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 270);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 306);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 349);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 385);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 7;
            label8.Text = "Điện Thoại";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(192, 109);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(258, 27);
            txtHo.TabIndex = 8;
            // 
            // txtTendem
            // 
            txtTendem.Location = new Point(192, 148);
            txtTendem.Name = "txtTendem";
            txtTendem.Size = new Size(258, 27);
            txtTendem.TabIndex = 9;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(192, 299);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(258, 27);
            txtDiachi.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 342);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(192, 378);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(258, 27);
            txtDienthoai.TabIndex = 12;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(192, 190);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(258, 27);
            txtTen.TabIndex = 13;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Location = new Point(192, 265);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(62, 24);
            rbtNam.TabIndex = 14;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(301, 265);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(50, 24);
            rbtNu.TabIndex = 15;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // mtbNgaysinh
            // 
            mtbNgaysinh.Location = new Point(192, 223);
            mtbNgaysinh.Mask = "00/00/0000";
            mtbNgaysinh.Name = "mtbNgaysinh";
            mtbNgaysinh.Size = new Size(258, 27);
            mtbNgaysinh.TabIndex = 16;
            mtbNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(341, 453);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(192, 453);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 578);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(mtbNgaysinh);
            Controls.Add(rbtNu);
            Controls.Add(rbtNam);
            Controls.Add(txtTen);
            Controls.Add(txtDienthoai);
            Controls.Add(txtEmail);
            Controls.Add(txtDiachi);
            Controls.Add(txtTendem);
            Controls.Add(txtHo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGV";
            Text = "frmGV";
            Load += frmGV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtHo;
        private TextBox txtTendem;
        private TextBox txtDiachi;
        private TextBox txtEmail;
        private TextBox txtDienthoai;
        private TextBox txtTen;
        private RadioButton rbtNam;
        private RadioButton rbtNu;
        private MaskedTextBox mtbNgaysinh;
        private Button btnHuy;
        private Button btnLuu;
    }
}