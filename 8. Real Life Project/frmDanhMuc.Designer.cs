namespace _8._Real_Life_Project
{
    partial class frmDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lstDanhMuc = new ListBox();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            txtTenDanhMuc = new TextBox();
            label2 = new Label();
            txtMaDanhMuc = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhMuc);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Danh Mục:";
            // 
            // lstDanhMuc
            // 
            lstDanhMuc.Dock = DockStyle.Fill;
            lstDanhMuc.FormattingEnabled = true;
            lstDanhMuc.ItemHeight = 15;
            lstDanhMuc.Location = new Point(3, 19);
            lstDanhMuc.Name = "lstDanhMuc";
            lstDanhMuc.Size = new Size(194, 186);
            lstDanhMuc.TabIndex = 0;
            lstDanhMuc.SelectedIndexChanged += lstDanhMuc_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(txtTenDanhMuc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaDanhMuc);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(200, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Danh Mục:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(164, 90);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(83, 90);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(2, 90);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.Location = new Point(99, 51);
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.Size = new Size(142, 23);
            txtTenDanhMuc.TabIndex = 3;
            txtTenDanhMuc.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 57);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên Danh Mục:";
            // 
            // txtMaDanhMuc
            // 
            txtMaDanhMuc.Location = new Point(99, 22);
            txtMaDanhMuc.Name = "txtMaDanhMuc";
            txtMaDanhMuc.Size = new Size(142, 23);
            txtMaDanhMuc.TabIndex = 1;
            txtMaDanhMuc.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Danh Mục:";
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 208);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Danh Mục";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstDanhMuc;
        private GroupBox groupBox2;
        private TextBox txtMaDanhMuc;
        private Label label1;
        private TextBox txtTenDanhMuc;
        private Label label2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
    }
}