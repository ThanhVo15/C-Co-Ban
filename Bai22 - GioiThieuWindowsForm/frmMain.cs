namespace Bai22___GioiThieuWindowsForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.Text = "Toi da la mau do";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ban chon dong cua so dung ko");
        }
    }
}
