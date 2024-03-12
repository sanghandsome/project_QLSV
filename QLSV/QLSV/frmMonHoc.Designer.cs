namespace QLSV
{
    partial class frmMonHoc
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
            txtTenmonhoc = new TextBox();
            txtSotinchi = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Môn Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 66);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Tín Chỉ";
            // 
            // txtTenmonhoc
            // 
            txtTenmonhoc.Location = new Point(115, 63);
            txtTenmonhoc.Name = "txtTenmonhoc";
            txtTenmonhoc.Size = new Size(254, 27);
            txtTenmonhoc.TabIndex = 2;
            // 
            // txtSotinchi
            // 
            txtSotinchi.Location = new Point(479, 63);
            txtSotinchi.Name = "txtSotinchi";
            txtSotinchi.Size = new Size(86, 27);
            txtSotinchi.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(603, 62);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(85, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(694, 62);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 134);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtSotinchi);
            Controls.Add(txtTenmonhoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMonHoc";
            Text = "frmMonHoc";
            Load += frmMonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenmonhoc;
        private TextBox txtSotinchi;
        private Button btnLuu;
        private Button btnHuy;
    }
}