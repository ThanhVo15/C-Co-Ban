namespace _2._Formater_App_Excercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Italic);
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

        private void grbCheck_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtNhapTen.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
                label1.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
                label1.ForeColor = Color.Blue;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
                label1.ForeColor = Color.Red;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
                label1.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Bold);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Underline);
        }
    }
}
