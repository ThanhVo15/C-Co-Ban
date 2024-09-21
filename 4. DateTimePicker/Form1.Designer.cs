namespace _4._DateTimePicker
{
    partial class frmErrorProvider
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnDangKy = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            txtTuoi = new TextBox();
            lblTuoi = new Label();
            txtTen = new TextBox();
            lblTen = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(32, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ THI BẰNG LÁI XE";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 63);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 167);
            panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 20F);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghi Chú";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(18, 99);
            label6.Name = "label6";
            label6.Size = new Size(312, 21);
            label6.TabIndex = 2;
            label6.Text = "- Không cho đăng ký thi vào ngày Chủ Nhật";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(18, 69);
            label5.Name = "label5";
            label5.Size = new Size(165, 21);
            label5.TabIndex = 1;
            label5.Text = "- Tuổi phải lớn hơn 17";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(18, 39);
            label4.Name = "label4";
            label4.Size = new Size(255, 21);
            label4.TabIndex = 0;
            label4.Text = "- Tên học viên không được để trống";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDangKy);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(txtTuoi);
            panel3.Controls.Add(lblTuoi);
            panel3.Controls.Add(txtTen);
            panel3.Controls.Add(lblTen);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 172);
            panel3.TabIndex = 1;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(144, 132);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(75, 23);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(100, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(43, 95);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(100, 60);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(200, 23);
            txtTuoi.TabIndex = 3;
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(43, 63);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(33, 15);
            lblTuoi.TabIndex = 2;
            lblTuoi.Text = "Tuổi:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(100, 31);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 23);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(43, 34);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(28, 15);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên:";
            lblTen.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmErrorProvider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 402);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmErrorProvider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += frmErrorProvider_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtTen;
        private Label lblTen;
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private TextBox txtTuoi;
        private Label lblTuoi;
        private Label label6;
        private Label label5;
        private Button btnDangKy;
        private ErrorProvider errorProvider1;
    }
}
