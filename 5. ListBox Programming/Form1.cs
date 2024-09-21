using System.Collections.Generic;

namespace _5._ListBox_Programming
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string input = txtNhapSo.Text;
            int result;
            bool sucess = int.TryParse(input, out result);

            if (sucess == true)
            {
                listBox1.Items.Add(input);
            }
            if (sucess == false)
            {
                string[] elements = txtNhapSo.Text.Split(',');
                foreach (string element in elements)
                {
                    int input1 = int.Parse(element);
                    listBox1.Items.Add(input1);
                }

            }

        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i];
                sum += x;
            }
            MessageBox.Show("Tong cua List Box la: " + sum, "Tong cua List Box la:",
                MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            // ta phải luôn luôn kiểm tra xem người sử dụng có đnag chọn dòng nào hay không?
            //if (listBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Ban chua chon so nao ca!",
            //        "Warning",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
            //else
            //{
            //    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //}
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult met = MessageBox.Show("Do you really want to exit man?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (met == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult met = MessageBox.Show("Do you really want to exit man?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (met != DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i];
                listBox1.Items[i] = x + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i];
                listBox1.Items[i] = Math.Pow(x, 2);
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1; // Bo chon cac lua chon cu
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i];
                if (x % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1; // Bo chon cac lua chon cu
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i];
                if (x % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }
    }
}
