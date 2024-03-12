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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSSV_Load(object sender, EventArgs e)
        {
            loadDSSV();

        }
        private void loadDSSV()
        {   
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,

            });
            dgvSinhVien.DataSource = new Database().SelectData(("SellectAllSinhVien"), lstPara);
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ Tên";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gtinh"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quên Quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
        }
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frmSinhVien(msv).ShowDialog();
                loadDSSV();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            loadDSSV();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            loadDSSV() ;
        }
    }
}
