namespace _5._ListBox_Programming
{
    partial class frmListBox
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
            lblNhapSo = new Label();
            txtNhapSo = new TextBox();
            btnCapNhap = new Button();
            grbDanhSachSo = new GroupBox();
            listBox1 = new ListBox();
            grpChucNang = new GroupBox();
            btnLe = new Button();
            btnChan = new Button();
            btnBinhPhuong = new Button();
            btnTang2 = new Button();
            btnXoaChon = new Button();
            btnXoaDauCuoi = new Button();
            btnTong = new Button();
            btnKetThuc = new Button();
            grbDanhSachSo.SuspendLayout();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapSo
            // 
            lblNhapSo.Anchor = AnchorStyles.Top;
            lblNhapSo.AutoSize = true;
            lblNhapSo.Location = new Point(21, 18);
            lblNhapSo.Name = "lblNhapSo";
            lblNhapSo.Size = new Size(55, 15);
            lblNhapSo.TabIndex = 0;
            lblNhapSo.Text = "Nhập Số:";
            // 
            // txtNhapSo
            // 
            txtNhapSo.Anchor = AnchorStyles.Top;
            txtNhapSo.Location = new Point(82, 15);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(244, 23);
            txtNhapSo.TabIndex = 1;
            // 
            // btnCapNhap
            // 
            btnCapNhap.Anchor = AnchorStyles.Top;
            btnCapNhap.Location = new Point(345, 15);
            btnCapNhap.Name = "btnCapNhap";
            btnCapNhap.Size = new Size(75, 23);
            btnCapNhap.TabIndex = 2;
            btnCapNhap.Text = "Cập Nhập";
            btnCapNhap.UseVisualStyleBackColor = true;
            btnCapNhap.Click += btnCapNhap_Click;
            // 
            // grbDanhSachSo
            // 
            grbDanhSachSo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbDanhSachSo.Controls.Add(listBox1);
            grbDanhSachSo.Location = new Point(21, 44);
            grbDanhSachSo.Name = "grbDanhSachSo";
            grbDanhSachSo.Size = new Size(200, 233);
            grbDanhSachSo.TabIndex = 3;
            grbDanhSachSo.TabStop = false;
            grbDanhSachSo.Text = "Danh Sách Số";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(194, 211);
            listBox1.TabIndex = 0;
            // 
            // grpChucNang
            // 
            grpChucNang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpChucNang.Controls.Add(btnLe);
            grpChucNang.Controls.Add(btnChan);
            grpChucNang.Controls.Add(btnBinhPhuong);
            grpChucNang.Controls.Add(btnTang2);
            grpChucNang.Controls.Add(btnXoaChon);
            grpChucNang.Controls.Add(btnXoaDauCuoi);
            grpChucNang.Controls.Add(btnTong);
            grpChucNang.Location = new Point(227, 44);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(200, 233);
            grpChucNang.TabIndex = 4;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức Năng:";
            // 
            // btnLe
            // 
            btnLe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLe.Location = new Point(5, 196);
            btnLe.Name = "btnLe";
            btnLe.Size = new Size(188, 23);
            btnLe.TabIndex = 6;
            btnLe.Text = "Chọn Số Lẻ";
            btnLe.UseVisualStyleBackColor = true;
            btnLe.Click += btnLe_Click;
            // 
            // btnChan
            // 
            btnChan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChan.Location = new Point(5, 167);
            btnChan.Name = "btnChan";
            btnChan.Size = new Size(188, 23);
            btnChan.TabIndex = 5;
            btnChan.Text = "Chọn Số Chẵn";
            btnChan.UseVisualStyleBackColor = true;
            btnChan.Click += btnChan_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBinhPhuong.Location = new Point(6, 138);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(188, 23);
            btnBinhPhuong.TabIndex = 4;
            btnBinhPhuong.Text = "Thay Bằng Bình Phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnTang2
            // 
            btnTang2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTang2.Location = new Point(6, 109);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(188, 23);
            btnTang2.TabIndex = 3;
            btnTang2.Text = "Tăng Mỗi Phần Tử Lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaChon.Location = new Point(5, 80);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(188, 23);
            btnXoaChon.TabIndex = 2;
            btnXoaChon.Text = "Xóa Phần Tử Đang Chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaDauCuoi.Location = new Point(6, 51);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(188, 23);
            btnXoaDauCuoi.TabIndex = 1;
            btnXoaDauCuoi.Text = "Xóa Phần Tử Đầu và Cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnTong
            // 
            btnTong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTong.Location = new Point(6, 22);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(188, 23);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tổng Của Danh Sách";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Anchor = AnchorStyles.Bottom;
            btnKetThuc.Location = new Point(24, 283);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(403, 23);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Kết Thúc Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // frmListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 319);
            Controls.Add(btnKetThuc);
            Controls.Add(grpChucNang);
            Controls.Add(grbDanhSachSo);
            Controls.Add(btnCapNhap);
            Controls.Add(txtNhapSo);
            Controls.Add(lblNhapSo);
            Name = "frmListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai Tap Ve ListBox";
            FormClosing += frmListBox_FormClosing;
            grbDanhSachSo.ResumeLayout(false);
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapSo;
        private TextBox txtNhapSo;
        private Button btnCapNhap;
        private GroupBox grbDanhSachSo;
        private ListBox listBox1;
        private GroupBox grpChucNang;
        private Button btnKetThuc;
        private Button btnLe;
        private Button btnChan;
        private Button btnBinhPhuong;
        private Button btnTang2;
        private Button btnXoaChon;
        private Button btnXoaDauCuoi;
        private Button btnTong;
    }
}
