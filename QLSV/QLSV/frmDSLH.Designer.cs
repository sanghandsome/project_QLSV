namespace QLSV
{
    partial class frmDSLH
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
            btnTimKiem = new Button();
            btnThemmoi = new Button();
            dgvDSLH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 66);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            label1.Click += label1_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(397, 62);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(184, 27);
            txtTimkiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(587, 62);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Location = new Point(694, 62);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 3;
            btnThemmoi.Text = "Thêm Mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // dgvDSLH
            // 
            dgvDSLH.AllowUserToAddRows = false;
            dgvDSLH.AllowUserToDeleteRows = false;
            dgvDSLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLH.Dock = DockStyle.Bottom;
            dgvDSLH.Location = new Point(0, 118);
            dgvDSLH.Name = "dgvDSLH";
            dgvDSLH.ReadOnly = true;
            dgvDSLH.RowHeadersWidth = 51;
            dgvDSLH.Size = new Size(800, 332);
            dgvDSLH.TabIndex = 4;
            dgvDSLH.CellDoubleClick += dgvDSLH_CellDoubleClick;
            // 
            // frmDSLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDSLH);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Name = "frmDSLH";
            Text = "frmDSLH";
            Load += frmDSLH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnThemmoi;
        private DataGridView dgvDSLH;
    }
}