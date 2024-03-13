using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmQuanLyLop : Form
    {
        private string mgv;
        private string tukhoa = "";
        public frmQuanLyLop(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        public void LoadQuanLyLop()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgv
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvQuanlilop.DataSource = new Database().SelectData("TraCuuGV", lst);
            dgvQuanlilop.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvQuanlilop.Columns["mamonhoc"].HeaderText = "Mã Môn Học";
            dgvQuanlilop.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvQuanlilop.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvQuanlilop.Columns["siso"].HeaderText = "Sĩ Số";

        }
        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadQuanLyLop();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            LoadQuanLyLop();
        }
    }
}
