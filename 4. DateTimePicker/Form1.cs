namespace _4._DateTimePicker
{
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTen, "");
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Ban can nhap thong tin!");
                return;
            }

            errorProvider1.SetError(txtTuoi, "");
            int tuoi = 0;
            if (txtTuoi.Text == "")
            {
                errorProvider1.SetError(txtTuoi, "Ban can nhap thong tin!");
                return;
            }
            else
            {
                if (int.TryParse(txtTuoi.Text, out tuoi) == false)
                {
                    errorProvider1.SetError(txtTuoi, "Ban phai nhap so nhe!");
                    return;
                }
                else
                {
                    if (int.Parse(txtTuoi.Text) <= 17)
                    {
                        errorProvider1.SetError(txtTuoi, "Ban chua du tuoi nhe!");
                        return;
                    }
                }
            }

            errorProvider1.SetError(dateTimePicker1, "");
            if (dateTimePicker1.Value <= DateTime.Today)
            {
                errorProvider1.SetError(dateTimePicker1, "Ban song o qua khu a?");
                return;
            }
            else
            {
                if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    errorProvider1.SetError(dateTimePicker1, "Ban chon dung ngay chu nhat roi, chon ngay khac nhe!");
                    return;
                }
            }
            MessageBox.Show("Thanh cong roi!");
        }

        private void frmErrorProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult met = MessageBox.Show("Do you really want to exit man?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (met != DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
