namespace QLSV
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            ThoatToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            sinhVienToolStripMenuItem = new ToolStripMenuItem();
            giaoVienToolStripMenuItem = new ToolStripMenuItem();
            monHocToolStripMenuItem = new ToolStripMenuItem();
            lopHocToolStripMenuItem = new ToolStripMenuItem();
            chucNangToolStripMenuItem = new ToolStripMenuItem();
            dangkiToolStripMenuItem = new ToolStripMenuItem();
            traCuuDiemToolStripMenuItem = new ToolStripMenuItem();
            QuanliToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, toolStripMenuItem1, quanLyToolStripMenuItem, chucNangToolStripMenuItem, QuanliToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1260, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, ThoatToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(88, 24);
            heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(183, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // ThoatToolStripMenuItem
            // 
            ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            ThoatToolStripMenuItem.Size = new Size(183, 26);
            ThoatToolStripMenuItem.Text = "Thoát";
            ThoatToolStripMenuItem.Click += ThoatToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhVienToolStripMenuItem, giaoVienToolStripMenuItem, monHocToolStripMenuItem, lopHocToolStripMenuItem });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(75, 24);
            quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            sinhVienToolStripMenuItem.Size = new Size(156, 26);
            sinhVienToolStripMenuItem.Text = "Sinh Viên";
            sinhVienToolStripMenuItem.Click += sinhVienToolStripMenuItem_Click;
            // 
            // giaoVienToolStripMenuItem
            // 
            giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            giaoVienToolStripMenuItem.Size = new Size(156, 26);
            giaoVienToolStripMenuItem.Text = "Giáo Viên";
            giaoVienToolStripMenuItem.Click += giaoVienToolStripMenuItem_Click;
            // 
            // monHocToolStripMenuItem
            // 
            monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            monHocToolStripMenuItem.Size = new Size(156, 26);
            monHocToolStripMenuItem.Text = "Môn Học";
            monHocToolStripMenuItem.Click += monHocToolStripMenuItem_Click;
            // 
            // lopHocToolStripMenuItem
            // 
            lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            lopHocToolStripMenuItem.Size = new Size(156, 26);
            lopHocToolStripMenuItem.Text = "Lớp Học";
            lopHocToolStripMenuItem.Click += lopHocToolStripMenuItem_Click;
            // 
            // chucNangToolStripMenuItem
            // 
            chucNangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangkiToolStripMenuItem, traCuuDiemToolStripMenuItem });
            chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            chucNangToolStripMenuItem.Size = new Size(93, 24);
            chucNangToolStripMenuItem.Text = "Chức năng";
            chucNangToolStripMenuItem.Click += dkMonhocToolStripMenuItem_Click;
            // 
            // dangkiToolStripMenuItem
            // 
            dangkiToolStripMenuItem.Name = "dangkiToolStripMenuItem";
            dangkiToolStripMenuItem.Size = new Size(205, 26);
            dangkiToolStripMenuItem.Text = "Đăng kí môn học";
            dangkiToolStripMenuItem.Click += dangkiToolStripMenuItem_Click;
            // 
            // traCuuDiemToolStripMenuItem
            // 
            traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            traCuuDiemToolStripMenuItem.Size = new Size(205, 26);
            traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            traCuuDiemToolStripMenuItem.Click += traCuuDiemToolStripMenuItem_Click;
            // 
            // QuanliToolStripMenuItem
            // 
            QuanliToolStripMenuItem.Name = "QuanliToolStripMenuItem";
            QuanliToolStripMenuItem.Size = new Size(96, 24);
            QuanliToolStripMenuItem.Text = "Quản lí lớp";
            QuanliToolStripMenuItem.Click += ChamDiemToolStripMenuItem_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 28);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1260, 489);
            pnlContent.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 517);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Main Form";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem ThoatToolStripMenuItem;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem sinhVienToolStripMenuItem;
        private ToolStripMenuItem giaoVienToolStripMenuItem;
        private ToolStripMenuItem monHocToolStripMenuItem;
        private Panel pnlContent;
        private ToolStripMenuItem lopHocToolStripMenuItem;
        private ToolStripMenuItem chucNangToolStripMenuItem;
        private ToolStripMenuItem QuanliToolStripMenuItem;
        private ToolStripMenuItem dangkiToolStripMenuItem;
        private ToolStripMenuItem traCuuDiemToolStripMenuItem;
    }
}
