using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace QLSV
{
    public partial class frmLopHoc : Form
    {
        private string mlh;
        private string nguoithucthi = "admin";
        public frmLopHoc(string mlh)
        {
            InitializeComponent();
            this.mlh = mlh;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cbbGiaovien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            if(cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            string sql = "";
            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mlh))
            {
                sql = "insertLH";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithucthi
                });
            }
            else
            {
                sql = "updateLH";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithucthi
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = mlh
                });
            }
            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbMonhoc.SelectedValue.ToString()
            });
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = cbbGiaovien.SelectedValue.ToString()
            });
            var rs = new Database().ExeCute(sql,lst);
            if(rs == 1)
            {
                if(string.IsNullOrEmpty(mlh))
                {
                    MessageBox.Show("Thêm Mới Lớp Học Thành Công");
                }
                else
                {
                    MessageBox.Show("Cập Nhật Lớp Học Thành Công");
                }
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực Thi Thất Bại");
            }
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = ""
            });
            cbbMonhoc.DataSource = new Database().SelectData("sellectAllMonHoc", lst);
            cbbMonhoc.DisplayMember = "tenmonhoc";
            cbbMonhoc.ValueMember = "mamonhoc";
            cbbMonhoc.SelectedIndex = -1;


            cbbGiaovien.DataSource = new Database().SelectData("SellectAllGV", lst);
            cbbGiaovien.DisplayMember = "hoten";
            cbbGiaovien.ValueMember = "magiaovien";
            cbbGiaovien.SelectedIndex = -1;


            if (string.IsNullOrEmpty(mlh))
            {
                this.Text = "Thêm Mới Lớp Học";
            }
            else
            {
                this.Text = "Cập Nhật Thông Tin Lớp Học";
                var r = new Database().Select("exec sellectLH '" + this.mlh + "'");
                cbbGiaovien.SelectedValue = r["magiaovien"].ToString();
                cbbMonhoc.SelectedValue = r["mamonhoc"].ToString();
            }
           
            
        }
    }
}
