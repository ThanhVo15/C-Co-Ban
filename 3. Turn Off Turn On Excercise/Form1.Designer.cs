namespace _3._Turn_Off_Turn_On_Excercise
{
    partial class frmOffOn
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
            lblName = new Label();
            pnTitle = new Panel();
            lblTitle = new Label();
            txtName = new TextBox();
            picOn = new PictureBox();
            btnClick = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            picOff = new PictureBox();
            pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOff).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(127, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Enter Your Name Here:";
            lblName.Click += lblName_Click;
            // 
            // pnTitle
            // 
            pnTitle.BackColor = SystemColors.ControlLightLight;
            pnTitle.Controls.Add(lblTitle);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(416, 57);
            pnTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(105, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(191, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Turn Off, Turn On";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.Location = new Point(145, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // picOn
            // 
            picOn.Anchor = AnchorStyles.Top;
            picOn.Image = Properties.Resources.light;
            picOn.Location = new Point(12, 106);
            picOn.Name = "picOn";
            picOn.Size = new Size(392, 178);
            picOn.SizeMode = PictureBoxSizeMode.StretchImage;
            picOn.TabIndex = 3;
            picOn.TabStop = false;
            picOn.Visible = false;
            picOn.Click += picLight_Click;
            // 
            // btnClick
            // 
            btnClick.Anchor = AnchorStyles.Top;
            btnClick.Location = new Point(12, 300);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(392, 28);
            btnClick.TabIndex = 4;
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(12, 336);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 5;
            label1.Text = "Programming By:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(152, 337);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.Location = new Point(329, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // picOff
            // 
            picOff.Anchor = AnchorStyles.Top;
            picOff.Image = Properties.Resources.light1;
            picOff.Location = new Point(12, 106);
            picOff.Name = "picOff";
            picOff.Size = new Size(392, 178);
            picOff.TabIndex = 8;
            picOff.TabStop = false;
            // 
            // frmOffOn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 369);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Controls.Add(picOff);
            Controls.Add(picOn);
            Controls.Add(txtName);
            Controls.Add(pnTitle);
            Controls.Add(lblName);
            Name = "frmOffOn";
            Text = "Turn Off Turn On";
            Load += frmOffOn_Load;
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Panel pnTitle;
        private Label lblTitle;
        private TextBox txtName;
        private PictureBox picOn;
        private Button btnClick;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private PictureBox picOff;
    }
}
