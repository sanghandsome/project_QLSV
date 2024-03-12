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
    public partial class frmDSLH : Form
    {
        public frmDSLH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string tukhoa = " ";
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            string sql = "allLopHoc";
            dgvDSLH.DataSource = new Database().SelectData(sql, lstPara);
            dgvDSLH.Columns["gv"].HeaderText = "Tên GV";
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
        }

        private void frmDSLH_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            LoadDSLH();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();
            LoadDSLH();
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mlh = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                new frmLopHoc(mlh).ShowDialog();
                LoadDSLH() ;
            }
        }
    }
}
