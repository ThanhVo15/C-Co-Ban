namespace _2._Formater_App_Excercise
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
            lblTen = new Label();
            txtNhapTen = new TextBox();
            grbCheck = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            grbRad = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            lblLapTrinh = new Label();
            btnKetThuc = new Button();
            label1 = new Label();
            grbCheck.SuspendLayout();
            grbRad.SuspendLayout();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(12, 18);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(99, 15);
            lblTen.TabIndex = 0;
            lblTen.Text = "Enter Your Name:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(117, 15);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(301, 23);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // grbCheck
            // 
            grbCheck.Controls.Add(radBlack);
            grbCheck.Controls.Add(radBlue);
            grbCheck.Controls.Add(radGreen);
            grbCheck.Controls.Add(radRed);
            grbCheck.Location = new Point(12, 56);
            grbCheck.Name = "grbCheck";
            grbCheck.Size = new Size(200, 161);
            grbCheck.TabIndex = 2;
            grbCheck.TabStop = false;
            grbCheck.Text = "Color";
            grbCheck.Enter += grbCheck_Enter;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(24, 112);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(55, 19);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(24, 87);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(50, 19);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(24, 62);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(60, 19);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(24, 37);
            radRed.Name = "radRed";
            radRed.Size = new Size(47, 19);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // grbRad
            // 
            grbRad.Controls.Add(chkUnderline);
            grbRad.Controls.Add(chkItalic);
            grbRad.Controls.Add(chkBold);
            grbRad.Location = new Point(218, 56);
            grbRad.Name = "grbRad";
            grbRad.Size = new Size(200, 161);
            grbRad.TabIndex = 3;
            grbRad.TabStop = false;
            grbRad.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            chkUnderline.Location = new Point(23, 112);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(77, 19);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Underline";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            chkItalic.Location = new Point(23, 71);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(51, 19);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.Location = new Point(23, 31);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(51, 19);
            chkBold.TabIndex = 0;
            chkBold.Text = "Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLapTrinh.Location = new Point(12, 232);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(92, 15);
            lblLapTrinh.TabIndex = 4;
            lblLapTrinh.Text = "Programing By:";
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(361, 228);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(55, 23);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Exit";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(110, 232);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 267);
            Controls.Add(label1);
            Controls.Add(btnKetThuc);
            Controls.Add(lblLapTrinh);
            Controls.Add(grbRad);
            Controls.Add(grbCheck);
            Controls.Add(txtNhapTen);
            Controls.Add(lblTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formater Application";
            Load += Form1_Load;
            grbCheck.ResumeLayout(false);
            grbCheck.PerformLayout();
            grbRad.ResumeLayout(false);
            grbRad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtNhapTen;
        private GroupBox grbCheck;
        private GroupBox grbRad;
        private Label lblLapTrinh;
        private Button btnKetThuc;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private Label label1;
    }
}
