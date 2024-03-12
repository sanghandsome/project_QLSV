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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mmh = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new frmMonHoc(mmh).ShowDialog();
                LoadDSMH();
            }
        }
        string tukhoa = "";
        public void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            string sql = "sellectAllMonHoc";
            dgvDSMH.DataSource = new Database().SelectData(sql, lstPara);
            dgvDSMH.Columns["mamonhoc"].HeaderText = "Mã MH";
            dgvDSMH.Columns["tenmonhoc"].HeaderText = "Tên MH";
            dgvDSMH.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";

        }
        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            LoadDSMH();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmMonHoc(null).ShowDialog();
            LoadDSMH() ;
        }
    }
}
