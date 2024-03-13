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
    public partial class frmKetQuaHocTap : Form
    {
        private string msv;
        private string tukhoa = "";
        public frmKetQuaHocTap(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        public void loadKQHocTap()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv,
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            dgvKqhoctap.DataSource = new Database().SelectData("TraCuu", lst);
            dgvKqhoctap.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvKqhoctap.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvKqhoctap.Columns["giaovien"].HeaderText = "Giáo Viên";
            dgvKqhoctap.Columns["lanhoc"].HeaderText = "Lần Học";
            dgvKqhoctap.Columns["diemthilan1"].HeaderText = "Điểm Thi Lần 1";
            dgvKqhoctap.Columns["diemthilan2"].HeaderText = "Điểm Thi Lần 2";
        }
        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            loadKQHocTap();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            loadKQHocTap();
        }
    }
}
