namespace _6._ListBox_Programming_2
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMSSV, "");
            if (txtMSSV.Text == "")
            {
                errorProvider1.SetError(txtMSSV, "Ban chua dien thong tin");
                return;
            }

            errorProvider1.SetError(txtTenSV, "");
            if (txtTenSV.Text == "")
            {
                errorProvider1.SetError(txtTenSV, "Ban chua dien thong tin");
                return;
            }
            SinhVien newSV = new SinhVien();
            newSV.MaSinhVien = int.Parse(txtMSSV.Text);
            newSV.TenSinhVien = txtTenSV.Text;

            if ((radLop1.Checked == false) && (radLop2.Checked == false))
            {
                MessageBox.Show("Ban chua chon lop");
            }
            else
            {
                if (radLop1.Checked == true)
                {
                    libLop1.Items.Add(newSV);
                }
                if (radLop2.Checked == true)
                {
                    libLop2.Items.Add(newSV);
                }
                txtMSSV.Clear();
                txtTenSV.Clear();
                txtMSSV.Focus();
            }
        }

        private void btn12SV_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các chỉ mục đã chọn trong libLop1
            for (int i = 0; i < libLop1.SelectedIndices.Count; i++)
            {
                // Lấy chỉ mục của mục được chọn
                int selectedIndex = libLop1.SelectedIndices[i];

                // Lấy giá trị của mục tại chỉ mục đó
                string selectedItem = libLop1.Items[selectedIndex].ToString();

                // Thêm mục vào libLop2
                libLop2.Items.Add(selectedItem);
            }

            // Xóa các mục đã chọn từ libLop1 (nếu muốn)
            // Lưu ý: Xóa phải thực hiện từ cuối danh sách để tránh lỗi chỉ mục
            for (int i = libLop1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                libLop1.Items.RemoveAt(libLop1.SelectedIndices[i]);
            }
        }

        private void btnXoaA_Click(object sender, EventArgs e)
        {
            libLop1.Items.Clear();
        }

        private void btnXoaB_Click(object sender, EventArgs e)
        {
            libLop2.Items.Clear();
        }

        private void btn12ALL_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i < libLop1.Items.Count; i ++)
            {
                string SelectedItems = libLop1.Items[i].ToString();
                libLop2.Items.Add(SelectedItems);
            }
            for (int i = 0; i < libLop1.Items.Count; i++)
            {
                libLop1.Items.Clear();
            }
        }
        // Các nút còn lại tương tự, quá là dễ haha
    }
}
