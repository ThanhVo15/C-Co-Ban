using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._Real_Life_Project
{
    public partial class frmDanhMuc : Form
    {
        public static bool CoThayDoi = false;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDM = txtMaDanhMuc.Text;
            dm.TenDM = txtTenDanhMuc.Text;
            frmSanPham.danhsachDM.Add(dm);
            HienThiDanhMucLenListBox();
            CoThayDoi = true;
        }
        void HienThiDanhMucLenListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach (DanhMuc dm in frmSanPham.danhsachDM)
            {
                lstDanhMuc.Items.Add(dm);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (CoThayDoi == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDanhMuc.Text = dm.MaDM;
                txtTenDanhMuc.Text = dm.TenDM;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                lstDanhMuc.Items.Remove(dm);
            }
            CoThayDoi = true;
        }
    }
}
