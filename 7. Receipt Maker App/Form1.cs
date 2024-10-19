namespace _7._Receipt_Maker_App
{
    public partial class frmReceiptMaker : Form
    {
        public frmReceiptMaker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string detail = "";
            detail = "Thong Tin Hoa Don: ";
            detail += "\nKhach Hang: " + txtName.Text;
            detail += "\nPhone: " + txtPhone.Text;
            detail += "\nSan Pham: " + listSanPham.SelectedItem;
            detail += "\nHinh Thuc: " + cboPhuongThuc.SelectedItem;
             richTextBox1.Clear();
            richTextBox1.Text = detail;
        }
    }
}
