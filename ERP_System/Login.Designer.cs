namespace ERP_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtPassword = new TextBox();
            PasswordLabel = new Label();
            txtUsername = new TextBox();
            LoginBtn = new Button();
            UsernameLabel = new Label();
            ShowPassCheck = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Cairo", 15.7499981F);
            txtPassword.Location = new Point(180, 264);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "  password";
            txtPassword.Size = new Size(344, 47);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Cairo", 15.7499981F);
            PasswordLabel.Location = new Point(71, 269);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(106, 39);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "كلمة السر";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Cairo", 15.7499981F);
            txtUsername.Location = new Point(180, 199);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  username";
            txtUsername.Size = new Size(344, 47);
            txtUsername.TabIndex = 7;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.Font = new Font("Cairo", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(180, 340);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(344, 60);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "تسجيل الدخول";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Cairo", 15.7499981F);
            UsernameLabel.Location = new Point(32, 203);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(146, 39);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "اسم المستخدم";
            // 
            // ShowPassCheck
            // 
            ShowPassCheck.AutoSize = true;
            ShowPassCheck.Location = new Point(496, 280);
            ShowPassCheck.Margin = new Padding(3, 4, 3, 4);
            ShowPassCheck.Name = "ShowPassCheck";
            ShowPassCheck.Size = new Size(15, 14);
            ShowPassCheck.TabIndex = 10;
            ShowPassCheck.UseVisualStyleBackColor = true;
            ShowPassCheck.CheckedChanged += ShowPassCheck_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 32.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 42);
            label1.Name = "label1";
            label1.Size = new Size(462, 81);
            label1.TabIndex = 11;
            label1.Text = "مرحبا بك في نظام ERP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(571, -2);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 566);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 561);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ShowPassCheck);
            Controls.Add(txtPassword);
            Controls.Add(PasswordLabel);
            Controls.Add(txtUsername);
            Controls.Add(LoginBtn);
            Controls.Add(UsernameLabel);
            Font = new Font("Cairo", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 8, 6, 8);
            MaximizeBox = false;
            Name = "Login";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label PasswordLabel;
        private TextBox txtUsername;
        private Button LoginBtn;
        private Label UsernameLabel;
        private CheckBox ShowPassCheck;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
