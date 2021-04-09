
namespace Kamleshproject
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.OldPassword_tb = new System.Windows.Forms.TextBox();
            this.NewPassword_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPassword_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password : ";
            // 
            // OldPassword_tb
            // 
            this.OldPassword_tb.Location = new System.Drawing.Point(123, 16);
            this.OldPassword_tb.Name = "OldPassword_tb";
            this.OldPassword_tb.PasswordChar = '*';
            this.OldPassword_tb.Size = new System.Drawing.Size(131, 20);
            this.OldPassword_tb.TabIndex = 1;
            // 
            // NewPassword_tb
            // 
            this.NewPassword_tb.Location = new System.Drawing.Point(123, 42);
            this.NewPassword_tb.Name = "NewPassword_tb";
            this.NewPassword_tb.PasswordChar = '*';
            this.NewPassword_tb.Size = new System.Drawing.Size(131, 20);
            this.NewPassword_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password : ";
            // 
            // ConfirmPassword_tb
            // 
            this.ConfirmPassword_tb.Location = new System.Drawing.Point(123, 68);
            this.ConfirmPassword_tb.Name = "ConfirmPassword_tb";
            this.ConfirmPassword_tb.PasswordChar = '*';
            this.ConfirmPassword_tb.Size = new System.Drawing.Size(131, 20);
            this.ConfirmPassword_tb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password : ";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.DarkGray;
            this.Login_Button.Location = new System.Drawing.Point(123, 104);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(131, 33);
            this.Login_Button.TabIndex = 7;
            this.Login_Button.Text = "&Change Password";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 157);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.ConfirmPassword_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPassword_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OldPassword_tb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldPassword_tb;
        private System.Windows.Forms.TextBox NewPassword_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmPassword_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_Button;
    }
}