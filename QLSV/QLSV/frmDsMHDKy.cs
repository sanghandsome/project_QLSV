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
    public partial class frmDsMHDky : Form
    {
        private string msv;

        public frmDsMHDky(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        public void LoadDsMHDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv,
            });
         
            dgvDsMHDky.DataSource = new Database().SelectData("monDangDKy", lst);
            dgvDsMHDky.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvDsMHDky.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDsMHDky.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvDsMHDky.Columns["giaovien"].HeaderText = "Giáo Viên";
            var r = new Database().Select("selectSV '" + msv + "' ");
            if (string.IsNullOrEmpty(r["tendem"].ToString()))
            {
                lbTen.Text = "Họ Và Tên: " + r["ho"].ToString() + " " + r["tendem"].ToString() + " " + r["ten"].ToString();
            }
            else
            {
                lbTen.Text = "Họ Và Tên: " + r["ho"].ToString() + " " + r["ten"].ToString();
            }
            lbMsv.Text = "Mã Sinh Viên: " + msv;




        }
        private void frmDsMHDky_Load(object sender, EventArgs e)
        {
            LoadDsMHDky();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           
            LoadDsMHDky();
        }

        private void btnDkyhoc_Click(object sender, EventArgs e)
        {
            new frmDSLHChuaDky(msv).ShowDialog();
            LoadDsMHDky() ;
        }
    }
}
