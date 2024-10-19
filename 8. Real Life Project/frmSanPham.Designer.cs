namespace _8._Real_Life_Project
{
    partial class frmSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            lstSanPham = new ListBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dateTimePickerHanDung = new DateTimePicker();
            txtXuatXu = new TextBox();
            txtDonGia = new TextBox();
            label7 = new Label();
            txtTenSP = new TextBox();
            label6 = new Label();
            txtMaSP = new TextBox();
            label5 = new Label();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnQuanLyDanhMuc = new Button();
            label4 = new Label();
            cboDanhMuc = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(668, 67);
            label1.TabIndex = 0;
            label1.Text = "Chương Trình Quản Lý Sản Phẩm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(668, 388);
            splitContainer1.SplitterDistance = 222;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSanPham);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Sản Phẩm:";
            // 
            // lstSanPham
            // 
            lstSanPham.Dock = DockStyle.Fill;
            lstSanPham.FormattingEnabled = true;
            lstSanPham.ItemHeight = 15;
            lstSanPham.Location = new Point(3, 19);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(216, 366);
            lstSanPham.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 237);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePickerHanDung);
            groupBox2.Controls.Add(txtXuatXu);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnQuanLyDanhMuc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboDanhMuc);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 237);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Chi Tiết:";
            // 
            // dateTimePickerHanDung
            // 
            dateTimePickerHanDung.CustomFormat = "dd/MM/yyyy";
            dateTimePickerHanDung.Format = DateTimePickerFormat.Custom;
            dateTimePickerHanDung.Location = new Point(92, 175);
            dateTimePickerHanDung.Name = "dateTimePickerHanDung";
            dateTimePickerHanDung.Size = new Size(332, 23);
            dateTimePickerHanDung.TabIndex = 12;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(92, 146);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(332, 23);
            txtXuatXu.TabIndex = 10;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(92, 117);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(332, 23);
            txtDonGia.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 178);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 11;
            label7.Text = "Hạn Dùng:";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(92, 88);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(332, 23);
            txtTenSP.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 149);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Xuất Xứ:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(92, 59);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(332, 23);
            txtMaSP.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 120);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Đơn Gía:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(295, 204);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(214, 204);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(133, 204);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyDanhMuc
            // 
            btnQuanLyDanhMuc.Location = new Point(349, 28);
            btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            btnQuanLyDanhMuc.Size = new Size(75, 23);
            btnQuanLyDanhMuc.TabIndex = 2;
            btnQuanLyDanhMuc.Text = "...";
            btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            btnQuanLyDanhMuc.Click += btnQuanLyDanhMuc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 91);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 5;
            label4.Text = "Tên Sản Phẩm:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(92, 28);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(235, 23);
            cboDanhMuc.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 62);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "Mã Sản Phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Danh Mục:";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 455);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sản Phẩm";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListBox lstSanPham;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button btnQuanLyDanhMuc;
        private ComboBox cboDanhMuc;
        private Label label2;
        private TextBox txtMaSP;
        private Label label3;
        private TextBox txtTenSP;
        private Label label4;
        private DateTimePicker dateTimePickerHanDung;
        private TextBox txtXuatXu;
        private TextBox txtDonGia;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
    }
}
