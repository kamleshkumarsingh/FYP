using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kamleshproject
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (OldPassword_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Old Password Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OldPassword_tb.Focus();
            }
            else if (NewPassword_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("New Password Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPassword_tb.Focus();
            }
            else if (!NewPassword_tb.Text.Equals(ConfirmPassword_tb.Text))
            {
                MessageBox.Show("Confirm Password Is Invalid", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfirmPassword_tb.Focus();
            }
            else
            {
                using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                {
                    con.Open();

                    con.Execute("Update dbo.StaffRegistration Set Password = @Password Where Email = @Email", new
                    {
                        @Password = NewPassword_tb.Text,
                        @Email = Session.Email
                    });

                    MessageBox.Show("Password Changed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                };
            }
        }
    }
}
