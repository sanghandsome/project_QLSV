namespace QLSV
{
    partial class frmKetQuaHocTap
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
            dgvKqhoctap = new DataGridView();
            label1 = new Label();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKqhoctap).BeginInit();
            SuspendLayout();
            // 
            // dgvKqhoctap
            // 
            dgvKqhoctap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKqhoctap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKqhoctap.Dock = DockStyle.Bottom;
            dgvKqhoctap.Location = new Point(0, 121);
            dgvKqhoctap.Name = "dgvKqhoctap";
            dgvKqhoctap.RowHeadersWidth = 51;
            dgvKqhoctap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKqhoctap.Size = new Size(800, 329);
            dgvKqhoctap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(379, 50);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(251, 27);
            txtTimkiem.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(653, 48);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tra Cứu";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // frmKetQuaHocTap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Controls.Add(dgvKqhoctap);
            Name = "frmKetQuaHocTap";
            Text = "frmKetQuaHocTap";
            Load += frmKetQuaHocTap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKqhoctap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKqhoctap;
        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
    }
}