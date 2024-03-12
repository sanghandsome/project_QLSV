namespace QLSV
{
    partial class frmDsMHDky
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
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            dgvDsMHDky = new DataGridView();
            btnDkyhoc = new Button();
            lbTen = new Label();
            lbMsv = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDsMHDky).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 51);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ Khóa";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(344, 51);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(217, 27);
            txtTimkiem.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(567, 51);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 2;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // dgvDsMHDky
            // 
            dgvDsMHDky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsMHDky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsMHDky.Dock = DockStyle.Bottom;
            dgvDsMHDky.Location = new Point(0, 135);
            dgvDsMHDky.Name = "dgvDsMHDky";
            dgvDsMHDky.RowHeadersWidth = 51;
            dgvDsMHDky.Size = new Size(800, 315);
            dgvDsMHDky.TabIndex = 3;
            // 
            // btnDkyhoc
            // 
            btnDkyhoc.Location = new Point(667, 51);
            btnDkyhoc.Name = "btnDkyhoc";
            btnDkyhoc.Size = new Size(94, 29);
            btnDkyhoc.TabIndex = 4;
            btnDkyhoc.Text = "Đăng ký mới";
            btnDkyhoc.UseVisualStyleBackColor = true;
            btnDkyhoc.Click += btnDkyhoc_Click;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Location = new Point(0, 51);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(79, 20);
            lbTen.TabIndex = 5;
            lbTen.Text = "Họ Và Tên:";
            lbTen.Click += label2_Click;
            // 
            // lbMsv
            // 
            lbMsv.AutoSize = true;
            lbMsv.Location = new Point(0, 87);
            lbMsv.Name = "lbMsv";
            lbMsv.Size = new Size(98, 20);
            lbMsv.TabIndex = 6;
            lbMsv.Text = "Mã Sinh Viên:";
            // 
            // frmDsMHDky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMsv);
            Controls.Add(lbTen);
            Controls.Add(btnDkyhoc);
            Controls.Add(dgvDsMHDky);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Name = "frmDsMHDky";
            Text = "Danh sách môn học đã đăng kí";
            Load += frmDsMHDky_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDsMHDky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private DataGridView dgvDsMHDky;
        private Button btnDkyhoc;
        private Label lbTen;
        private Label lbMsv;
    }
}