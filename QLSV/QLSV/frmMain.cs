namespace QLSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string tk;
        private string loaitk;
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangNhap();
            fn.ShowDialog();

            tk = fn.tendangnhap;
            loaitk = fn.loaitk;

            if (loaitk.Equals("admin"))
            {
                chucNangToolStripMenuItem.Visible = false;
                QuanliToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
            }
            if (loaitk.Equals("gv"))
            {
                quanLyToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;

            }
            else
            {
                QuanliToolStripMenuItem.Visible = false;
            }

        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }
        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            AddForm(f);
        }



        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLH f = new frmDSLH();
            AddForm(f);
        }

        private void dkMonhocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsMHDky f = new frmDsMHDky(tk);
            AddForm(f);
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap f = new frmKetQuaHocTap(tk);
            AddForm(f);
        }

        private void ChamDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyLop f = new frmQuanLyLop(tk);
            AddForm(f);
        }
    }
}
