namespace _3._Turn_Off_Turn_On_Excercise
{
    public partial class frmOffOn : Form
    {
        public frmOffOn()
        {
            InitializeComponent();
        }

        private void frmOffOn_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            lblName.ForeColor = System.Drawing.Color.White;
            label1.ForeColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            picOn.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult met = MessageBox.Show("Do you really want to exit man?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (met == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            label2.Text = txtName.Text;
            if (picOn.Visible == false)
            {
                btnClick.Text = "Hey " + txtName.Text + " ! Please Turn On The Light";
            }
            else
            {
                btnClick.Text = "Hey " + txtName.Text + " ! Please Turn Off The Light";
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void picLight_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
                picOn.Visible = true;
                picOff.Visible = false;
                btnClick.Text = "Hey " + txtName.Text + " ! Please Turn Off The Light";
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnClick.Text = "Hey " + txtName.Text + " ! Please Turn On The Light";
            }
        }
    }
}
