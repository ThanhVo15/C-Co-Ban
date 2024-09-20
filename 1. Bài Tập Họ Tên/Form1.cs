namespace _1._Bài_Tập_Họ_Tên
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Exit Program",
                "Do yopu want to exit the Program?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop);
            if (ret == DialogResult.Yes)
            {
                Close();
            }

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }
    }
}
