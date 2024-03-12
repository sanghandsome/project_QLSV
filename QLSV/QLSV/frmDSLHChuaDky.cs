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
    public partial class frmDSLHChuaDky : Form
    {
        private string msv;
        public frmDSLHChuaDky(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        public void LoadDSLHChuaDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            dgvdsChuaDky.DataSource = new Database().SelectData("dsLopChuaDangKi", lst);
            dgvdsChuaDky.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvdsChuaDky.Columns["mamonhoc"].HeaderText = "Mã Môn Học";
            dgvdsChuaDky.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvdsChuaDky.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvdsChuaDky.Columns["giaovien"].HeaderText = "Giáo Viên";

        }
        private void frmDSLHChuaDky_Load(object sender, EventArgs e)
        {
            LoadDSLHChuaDky();
        }

        private void dgvdsChuaDky_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdsChuaDky.Rows[e.RowIndex].Index >= 0)
            {
                string mlh = dgvdsChuaDky.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();

                if (
                      DialogResult.Yes == MessageBox.Show(
                          "Bạn có muốn đăng kí học phần [" + dgvdsChuaDky.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "] ?",
                          "Xác nhận đăng kí",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question
                      )               
                )
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = msv
                    });
                    lst.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = mlh
                    });
                    var r = new Database().ExeCute("DaDky",lst);
                    if(r == -1)
                    {
                        MessageBox.Show("Học phần đã đang kí", "Cảnh báo!!!");
                    }
                    if(r == 1)
                    {
                        MessageBox.Show("Đăng kí học thành công", "Thông báo");
                        LoadDSLHChuaDky();
                    }
                }
            }
        }
    }
}
