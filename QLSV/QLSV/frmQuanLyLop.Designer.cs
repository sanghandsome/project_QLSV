namespace QLSV
{
    partial class frmQuanLyLop
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
            dgvQuanlilop = new DataGridView();
            label1 = new Label();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuanlilop).BeginInit();
            SuspendLayout();
            // 
            // dgvQuanlilop
            // 
            dgvQuanlilop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuanlilop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanlilop.Dock = DockStyle.Bottom;
            dgvQuanlilop.Location = new Point(0, 147);
            dgvQuanlilop.Name = "dgvQuanlilop";
            dgvQuanlilop.RowHeadersWidth = 51;
            dgvQuanlilop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuanlilop.Size = new Size(800, 303);
            dgvQuanlilop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(418, 59);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(229, 27);
            txtTimkiem.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(667, 59);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(96, 29);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tra Cứu";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // frmQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Controls.Add(dgvQuanlilop);
            Name = "frmQuanLyLop";
            Text = "frmQuanLyLop";
            Load += frmQuanLyLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuanlilop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQuanlilop;
        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
    }
}