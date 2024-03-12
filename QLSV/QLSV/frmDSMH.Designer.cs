namespace QLSV
{
    partial class frmDSMH
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
            dgvDSMH = new DataGridView();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            btnThemmoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // dgvDSMH
            // 
            dgvDSMH.AllowUserToAddRows = false;
            dgvDSMH.AllowUserToDeleteRows = false;
            dgvDSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMH.Dock = DockStyle.Bottom;
            dgvDSMH.Location = new Point(0, 125);
            dgvDSMH.MultiSelect = false;
            dgvDSMH.Name = "dgvDSMH";
            dgvDSMH.ReadOnly = true;
            dgvDSMH.RowHeadersWidth = 51;
            dgvDSMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMH.Size = new Size(800, 325);
            dgvDSMH.TabIndex = 1;
            dgvDSMH.CellDoubleClick += dgvDSMH_CellDoubleClick;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(401, 30);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(199, 27);
            txtTimkiem.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(606, 30);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Location = new Point(706, 30);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 4;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // frmDSMH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(dgvDSMH);
            Controls.Add(label1);
            Name = "frmDSMH";
            Text = "frmDSMH";
            Load += frmDSMH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDSMH;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnThemmoi;
    }
}