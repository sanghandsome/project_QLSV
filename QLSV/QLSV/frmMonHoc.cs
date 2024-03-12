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
    public partial class frmMonHoc : Form
    {
        private string mmh;
        public frmMonHoc(string mmh)
        {
            InitializeComponent();
            this.mmh = mmh;
        }


        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mmh))
            {
                this.Text = "Thêm Mới Môn Học";
            }
            else
            {
                this.Text = "Cập Nhật Môn Học";
                var r = new Database().Select("sellectMH '" + mmh + "'");
                txtTenmonhoc.Text = r["tenmonhoc"].ToString();
                txtSotinchi.Text = r["sotinchi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                var sotinchi = int.Parse(txtSotinchi.Text);
                if (sotinchi <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSotinchi.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tín chỉ là số nguyên");
                txtSotinchi.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtTenmonhoc.Text))
            {
                MessageBox.Show("Tên Môn Học Không Được Để Trống");
                txtTenmonhoc.Select(); return;
            }
            string nguoitao = "admin";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(this.mmh))
            {
                sql = "InsertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoitao,
                });
            }
            else
            {
                sql = "updateMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mmh,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoitao,
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtTenmonhoc.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txtSotinchi.Text
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(this.mmh))
                {
                    MessageBox.Show("Thêm Mới Thành Công");
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lỗi Thực Thi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
