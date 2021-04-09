
namespace Kamleshproject
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.User_Login = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.User_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email_tb
            // 
            this.Email_tb.Location = new System.Drawing.Point(132, 49);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(212, 20);
            this.Email_tb.TabIndex = 1;
            this.Email_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(129, 82);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(132, 98);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '*';
            this.Password_tb.Size = new System.Drawing.Size(212, 20);
            this.Password_tb.TabIndex = 3;
            this.Password_tb.TextChanged += new System.EventHandler(this.Password_tb_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.DarkGray;
            this.Login_Button.Location = new System.Drawing.Point(197, 124);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // User_Login
            // 
            this.User_Login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.User_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_Login.BackgroundImage")));
            this.User_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_Login.Controls.Add(this.Login_Button);
            this.User_Login.Controls.Add(this.pictureBox2);
            this.User_Login.Controls.Add(this.Password_tb);
            this.User_Login.Controls.Add(this.Password);
            this.User_Login.Controls.Add(this.Email_tb);
            this.User_Login.Controls.Add(this.label1);
            this.User_Login.Location = new System.Drawing.Point(23, 12);
            this.User_Login.Name = "User_Login";
            this.User_Login.Size = new System.Drawing.Size(433, 189);
            this.User_Login.TabIndex = 0;
            this.User_Login.TabStop = false;
            this.User_Login.Text = "User Login";
            this.User_Login.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 213);
            this.Controls.Add(this.User_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.User_Login.ResumeLayout(false);
            this.User_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.GroupBox User_Login;
    }
}