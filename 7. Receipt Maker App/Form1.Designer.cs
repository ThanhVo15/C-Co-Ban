namespace _7._Receipt_Maker_App
{
    partial class frmReceiptMaker
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            groupBox1 = new GroupBox();
            listSanPham = new ListBox();
            label4 = new Label();
            cboPhuongThuc = new ComboBox();
            btnThanhToan = new Button();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 0;
            label1.Text = "Màn Hình Đặt Hàng";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 54);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 83);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 1;
            label3.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(74, 80);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 23);
            txtPhone.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listSanPham);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 242);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listSanPham
            // 
            listSanPham.FormattingEnabled = true;
            listSanPham.ItemHeight = 15;
            listSanPham.Items.AddRange(new object[] { "Samsung Galaxy J7 Prime", "Kẹo Kéo Quận 9", "Bánh Mì Sài Gòn", "RedBull", "Coca Cola" });
            listSanPham.Location = new Point(6, 22);
            listSanPham.Name = "listSanPham";
            listSanPham.Size = new Size(207, 214);
            listSanPham.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 364);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 1;
            label4.Text = "Phương thức thanh toán:";
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.FormattingEnabled = true;
            cboPhuongThuc.Items.AddRange(new object[] { "ATM", "Trực tiếp tại Cửa Hàng", "Sau khi nhận hàng" });
            cboPhuongThuc.Location = new Point(30, 382);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(201, 23);
            cboPhuongThuc.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(30, 411);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(95, 23);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(237, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 360);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Chi Tiết Đơn Hàng:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(136, 411);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(211, 329);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // frmReceiptMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 458);
            Controls.Add(groupBox2);
            Controls.Add(btnExit);
            Controls.Add(btnThanhToan);
            Controls.Add(cboPhuongThuc);
            Controls.Add(groupBox1);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmReceiptMaker";
            Text = "Receipt Maker App";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPhone;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cboPhuongThuc;
        private Button btnThanhToan;
        private GroupBox groupBox2;
        private Button btnExit;
        private ListBox listSanPham;
        private RichTextBox richTextBox1;
    }
}
