using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamleshproject
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Email_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show(" Email Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Password_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Password Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                {
                    con.Open();

                    var user = con.Query<StaffRegistration>("Select * from dbo.StaffRegistration Where Email = @Email", new
                    {
                        @Email = Email_tb.Text
                    }).FirstOrDefault();

                    if (user != null)
                    {
                        if (user.Password.Equals(Password_tb.Text))
                        {
                            Session.FullName = user.FirstName + " " + user.MiddleName + " " + user.LastName;
                            Session.Email = user.Email;
                            Session.Faculty = user.Faculty;
                            Session.PhoneNo = user.PhoneNo;
                            Session.LoginDateTime = DateTime.Now;

                            this.Hide();
                            MDIParent1 mDIParent1 = new MDIParent1();
                            mDIParent1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password.", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Email_tb.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password.", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Email_tb.Focus();
                    }
                }
            }

        }

        private void Password_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
