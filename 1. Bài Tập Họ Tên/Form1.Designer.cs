namespace _1._Bài_Tập_Họ_Tên
{
    partial class Form1
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
            lblHoTen = new Label();
            lblHoLot = new Label();
            lblTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.Coral;
            lblHoTen.Dock = DockStyle.Top;
            lblHoTen.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(304, 58);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Mời bạn nhập:";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // lblHoLot
            // 
            lblHoLot.AutoSize = true;
            lblHoLot.Location = new Point(27, 78);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(46, 15);
            lblHoLot.TabIndex = 0;
            lblHoLot.Text = "Họ Lót:";
            lblHoLot.Click += label1_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(27, 107);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(28, 15);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên:";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(79, 75);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(185, 23);
            txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(79, 104);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(185, 23);
            txtTen.TabIndex = 3;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(27, 144);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(75, 23);
            btnHo.TabIndex = 4;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(108, 144);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(75, 23);
            btnTen.TabIndex = 5;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(189, 144);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(75, 23);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKetThuc.Location = new Point(79, 173);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(149, 23);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKetThuc;
            ClientSize = new Size(304, 217);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblTen);
            Controls.Add(lblHoLot);
            Controls.Add(lblHoTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblHoLot;
        private Label lblTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
    }
}
