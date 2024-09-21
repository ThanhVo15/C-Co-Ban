namespace _6._ListBox_Programming_2
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
            components = new System.ComponentModel.Container();
            lblMa = new Label();
            lblTenSV = new Label();
            txtMSSV = new TextBox();
            txtTenSV = new TextBox();
            btnUpdate = new Button();
            libLop1 = new ListBox();
            btn12SV = new Button();
            btn12ALL = new Button();
            btn21SV = new Button();
            btn21ALL = new Button();
            btnXoaA = new Button();
            btnKetThuc = new Button();
            btnXoaB = new Button();
            libLop2 = new ListBox();
            lblLop = new Label();
            radLop1 = new RadioButton();
            radLop2 = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(46, 16);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(40, 15);
            lblMa.TabIndex = 0;
            lblMa.Text = "MSSV:";
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Location = new Point(6, 47);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(80, 15);
            lblTenSV.TabIndex = 2;
            lblTenSV.Text = "Tên Sinh Viên:";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(92, 11);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(174, 23);
            txtMSSV.TabIndex = 1;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(92, 42);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(261, 23);
            txtTenSV.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(376, 43);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // libLop1
            // 
            libLop1.FormattingEnabled = true;
            libLop1.ItemHeight = 15;
            libLop1.Location = new Point(3, 110);
            libLop1.Name = "libLop1";
            libLop1.SelectionMode = SelectionMode.MultiExtended;
            libLop1.Size = new Size(179, 244);
            libLop1.TabIndex = 5;
            // 
            // btn12SV
            // 
            btn12SV.Location = new Point(188, 111);
            btn12SV.Name = "btn12SV";
            btn12SV.Size = new Size(75, 23);
            btn12SV.TabIndex = 6;
            btn12SV.Text = ">";
            btn12SV.UseVisualStyleBackColor = true;
            btn12SV.Click += btn12SV_Click;
            // 
            // btn12ALL
            // 
            btn12ALL.Location = new Point(188, 155);
            btn12ALL.Name = "btn12ALL";
            btn12ALL.Size = new Size(75, 23);
            btn12ALL.TabIndex = 7;
            btn12ALL.Text = ">>";
            btn12ALL.UseVisualStyleBackColor = true;
            btn12ALL.Click += btn12ALL_Click;
            // 
            // btn21SV
            // 
            btn21SV.Location = new Point(188, 288);
            btn21SV.Name = "btn21SV";
            btn21SV.Size = new Size(75, 23);
            btn21SV.TabIndex = 8;
            btn21SV.Text = "<";
            btn21SV.UseVisualStyleBackColor = true;
            // 
            // btn21ALL
            // 
            btn21ALL.Location = new Point(188, 331);
            btn21ALL.Name = "btn21ALL";
            btn21ALL.Size = new Size(75, 23);
            btn21ALL.TabIndex = 9;
            btn21ALL.Text = "<<";
            btn21ALL.UseVisualStyleBackColor = true;
            // 
            // btnXoaA
            // 
            btnXoaA.Location = new Point(43, 371);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(75, 23);
            btnXoaA.TabIndex = 11;
            btnXoaA.Text = "Xóa Lớp A";
            btnXoaA.UseVisualStyleBackColor = true;
            btnXoaA.Click += btnXoaA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(188, 371);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(75, 23);
            btnKetThuc.TabIndex = 12;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // btnXoaB
            // 
            btnXoaB.Location = new Point(324, 371);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(75, 23);
            btnXoaB.TabIndex = 13;
            btnXoaB.Text = "Xóa Lớp B";
            btnXoaB.UseVisualStyleBackColor = true;
            btnXoaB.Click += btnXoaB_Click;
            // 
            // libLop2
            // 
            libLop2.FormattingEnabled = true;
            libLop2.ItemHeight = 15;
            libLop2.Location = new Point(272, 110);
            libLop2.Name = "libLop2";
            libLop2.SelectionMode = SelectionMode.MultiExtended;
            libLop2.Size = new Size(179, 244);
            libLop2.TabIndex = 10;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(6, 81);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(80, 15);
            lblLop.TabIndex = 14;
            lblLop.Text = "Tên Sinh Viên:";
            // 
            // radLop1
            // 
            radLop1.AutoSize = true;
            radLop1.Location = new Point(92, 79);
            radLop1.Name = "radLop1";
            radLop1.Size = new Size(54, 19);
            radLop1.TabIndex = 15;
            radLop1.TabStop = true;
            radLop1.Text = "Lớp 1";
            radLop1.UseVisualStyleBackColor = true;
            // 
            // radLop2
            // 
            radLop2.AutoSize = true;
            radLop2.Location = new Point(234, 79);
            radLop2.Name = "radLop2";
            radLop2.Size = new Size(54, 19);
            radLop2.TabIndex = 16;
            radLop2.TabStop = true;
            radLop2.Text = "Lớp 2";
            radLop2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 408);
            Controls.Add(radLop2);
            Controls.Add(radLop1);
            Controls.Add(lblLop);
            Controls.Add(libLop2);
            Controls.Add(libLop1);
            Controls.Add(btnXoaB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaA);
            Controls.Add(btn21ALL);
            Controls.Add(btn21SV);
            Controls.Add(btn12ALL);
            Controls.Add(btn12SV);
            Controls.Add(btnUpdate);
            Controls.Add(txtTenSV);
            Controls.Add(txtMSSV);
            Controls.Add(lblTenSV);
            Controls.Add(lblMa);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ex ListBox";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMa;
        private Label lblTenSV;
        private TextBox txtMSSV;
        private TextBox txtTenSV;
        private Button btnUpdate;
        private ListBox libLop1;
        private Button btn12SV;
        private Button btn12ALL;
        private Button btn21SV;
        private Button btn21ALL;
        private Button btnXoaA;
        private Button btnKetThuc;
        private Button btnXoaB;
        private ListBox libLop2;
        private Label lblLop;
        private RadioButton radLop1;
        private RadioButton radLop2;
        private ErrorProvider errorProvider1;
    }
}
