namespace _8._Real_Life_Project
{
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> danhsachDM = new List<DanhMuc>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.CoThayDoi = false;
            if (frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucLenComboBox();
            }
        }

        private void HienThiDanhMucLenComboBox()
        {
            cboDanhMuc.Items.Clear();
            foreach (DanhMuc dm in danhsachDM)
            {
                cboDanhMuc.Items.Add(dm);
            }
        }
    }
}
