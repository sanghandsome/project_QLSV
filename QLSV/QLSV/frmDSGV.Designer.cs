namespace QLSV
{
    partial class frmDSGV
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
            btnThemmoi = new Button();
            dgvDSGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(374, 12);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(217, 27);
            txtTimkiem.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(597, 12);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 2;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Location = new Point(706, 12);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 3;
            btnThemmoi.Text = "Thêm Mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // dgvDSGV
            // 
            dgvDSGV.AllowUserToAddRows = false;
            dgvDSGV.AllowUserToDeleteRows = false;
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSGV.Dock = DockStyle.Bottom;
            dgvDSGV.Location = new Point(0, 140);
            dgvDSGV.MultiSelect = false;
            dgvDSGV.Name = "dgvDSGV";
            dgvDSGV.ReadOnly = true;
            dgvDSGV.RowHeadersWidth = 51;
            dgvDSGV.Size = new Size(828, 343);
            dgvDSGV.TabIndex = 4;
            dgvDSGV.CellDoubleClick += dgvDSGV_CellDoubleClick;
            // 
            // frmDSGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 483);
            Controls.Add(dgvDSGV);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Name = "frmDSGV";
            Text = "frmDSGV";
            Load += frmDSGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnThemmoi;
        private DataGridView dgvDSGV;
    }
}