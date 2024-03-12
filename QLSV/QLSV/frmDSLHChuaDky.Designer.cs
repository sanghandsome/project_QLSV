namespace QLSV
{
    partial class frmDSLHChuaDky
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
            dgvdsChuaDky = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdsChuaDky).BeginInit();
            SuspendLayout();
            // 
            // dgvdsChuaDky
            // 
            dgvdsChuaDky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdsChuaDky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdsChuaDky.Dock = DockStyle.Bottom;
            dgvdsChuaDky.Location = new Point(0, 0);
            dgvdsChuaDky.Name = "dgvdsChuaDky";
            dgvdsChuaDky.RowHeadersWidth = 51;
            dgvdsChuaDky.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdsChuaDky.Size = new Size(800, 450);
            dgvdsChuaDky.TabIndex = 0;
            dgvdsChuaDky.CellDoubleClick += dgvdsChuaDky_CellDoubleClick;
            // 
            // frmDSLHChuaDky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvdsChuaDky);
            Name = "frmDSLHChuaDky";
            Text = "Danh sách lớp ";
            Load += frmDSLHChuaDky_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdsChuaDky).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvdsChuaDky;
    }
}