namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSV).BeginInit();
            SuspendLayout();
            // 
            // dgvSV
            // 
            dgvSV.AllowUserToAddRows = false;
            dgvSV.AllowUserToDeleteRows = false;
            dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSV.Dock = DockStyle.Bottom;
            dgvSV.Location = new Point(0, 117);
            dgvSV.Name = "dgvSV";
            dgvSV.ReadOnly = true;
            dgvSV.RowHeadersWidth = 51;
            dgvSV.Size = new Size(800, 333);
            dgvSV.TabIndex = 0;
            dgvSV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSV;
    }
}
