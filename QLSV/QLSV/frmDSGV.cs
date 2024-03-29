﻿using System;
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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            LoadDSGV();
        }
        private string tukhoa = "";
        public void LoadDSGV()
        {
            string sql = "SellectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "tukhoa",
                value = @tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã GV";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDSGV.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgvDSGV.Columns["gt"].HeaderText = "Giới Tính";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dgvDSGV.Columns["email"].HeaderText = "Email";
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            LoadDSGV();

        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGV(mgv).ShowDialog();
                LoadDSGV();
            }
        }
    }
}
