using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmDangNhap : Form
    {
        public string tendangnhap = "";
        public string loaitk = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {   
            if(cbbLoaitaikhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if(string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Tài khoản không được để trống");
                return ;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không được để trống");
                return;
            }
            tendangnhap = txtTendangnhap.Text;
            switch (cbbLoaitaikhoan.Text)
            {
                case "Quản Trị Viên":
                    loaitk = "admin";
                    break;
                case "Giáo Viên":
                    loaitk = "gv";
                    break;
                case "Sinh Viên":
                    loaitk = "sv";
                    break;
            }

            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@loaitaikhoan",
                value = loaitk,
            });
            lst.Add(new CustomParameter()
            {
                key = "@taikhoan",
                value = txtTendangnhap.Text,
            });
            lst.Add(new CustomParameter()
            {
                key = "@matkhau",
                value = txtMatkhau.Text,
            });

            var r = new Database().SelectData("dangnhap", lst);
            if(r.Rows.Count > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Tài Khoản Hoặc Mật Khẩu Không Đúng");
            }

            
        }
    }
}
