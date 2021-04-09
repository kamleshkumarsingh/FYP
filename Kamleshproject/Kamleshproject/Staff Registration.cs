using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kamleshproject
{
    public partial class Staff_Registration : Form
    {
        public Staff_Registration()
        {
            InitializeComponent();
        }

        private void Staff_Registration_Load(object sender, EventArgs e)
        {
            lblHiddenId.Text = "0";
            Faculty_cb.SelectedIndex = 0;
            BindData();
        }

        private void JoinDate_lable_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_lable_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailAddress_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Faculty_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Password_tb_TextChanged(object sender, EventArgs e)
        {


        }

        private void JoinDate_dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_b_Click(object sender, EventArgs e)
        {
            if (FirstName_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("First Name Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirstName_tb.Focus();
            }
            else if (LastName_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Last Name Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (EmailAddress_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Email Address Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (JoinDate_dtp.Text.Equals(string.Empty))
            {
                MessageBox.Show("Join Date Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Password_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Password Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (PhoneNumber_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Phone Number Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Faculty_cb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Faculty Is Required", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                {
                    con.Open();

                    if (con.Query<int>("Select 1 from dbo.StaffRegistration Where Email = @Email", new { @Email = EmailAddress_tb.Text }).FirstOrDefault() == 1 && lblHiddenId.Text == "0")
                    {
                        MessageBox.Show("Email Already Exists.", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string gender = "";
                        if (Male_rb.Checked)
                        {
                            gender = "Male";
                        }
                        else if (Female_rb.Checked)
                        {
                            gender = "Female";
                        }
                        else
                        {
                            gender = "Other";
                        }


                        if (!Directory.Exists(Application.StartupPath + "\\Staff"))
                            Directory.CreateDirectory(Application.StartupPath + "\\Staff");

                        if (!string.IsNullOrEmpty(Image_Path.Text))
                            pictureBox1.Image.Save(Application.StartupPath + "\\Staff\\" + FirstName_tb.Text + MiddleName_tb.Text + LastName_tb.Text, System.Drawing.Imaging.ImageFormat.Jpeg);

                        if (!lblHiddenId.Text.Equals("0"))
                        {
                            con.Execute("Update dbo.StaffRegistration Set FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Address = @Address, Email = @Email, PhoneNo = @PhoneNo, JoinDate = @JoinDate, Faculty = @Faculty, Gender = @Gender, Password = @Password, Image_Path = @Image_Path Where Id = @Id", new
                            {
                                @Id = lblHiddenId.Text,
                                @FirstName = FirstName_tb.Text,
                                MiddleName = MiddleName_tb.Text,
                                LastName = LastName_tb.Text,
                                Address = Address_tb.Text,
                                Email = EmailAddress_tb.Text,
                                PhoneNo = PhoneNumber_tb.Text,
                                JoinDate = JoinDate_dtp.Value,
                                Faculty = Faculty_cb.Text,
                                Password = Password_tb.Text,
                                @Gender = gender,
                                @Image_Path = Image_Path.Text,
                                @Ent_User = Session.Email,
                                @Ent_DateTime = DateTime.Now
                            });
                        }
                        else
                        {
                            con.Execute("Insert into dbo.StaffRegistration (FirstName, MiddleName, LastName, Address, Email, PhoneNo, JoinDate, Faculty, Gender, Password, Image_Path, Ent_User, Ent_DateTime) Values (  @FirstName, @MiddleName, @LastName , @Address , @Email, @PhoneNo, @JoinDate,@Faculty, @Gender,@Password, @Image_Path, @Ent_User, @Ent_DateTime)", new
                            {
                                @FirstName = FirstName_tb.Text,
                                @MiddleName = MiddleName_tb.Text,
                                @LastName = LastName_tb.Text,
                                @Address = Address_tb.Text,
                                @Email = EmailAddress_tb.Text,
                                @PhoneNo = PhoneNumber_tb.Text,
                                @JoinDate = JoinDate_dtp.Text,
                                @Faculty = Faculty_cb.Text,
                                @Gender = gender,
                                @Password = Password_tb.Text,
                                @Image_Path = "",
                                @Ent_User = Session.Email,
                                @Ent_DateTime = DateTime.Now
                            });
                        }
                        MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindData();
                        lblHiddenId.Text = "0";
                        FirstName_tb.Text = string.Empty;
                        MiddleName_tb.Text = string.Empty;
                        LastName_tb.Text = string.Empty;
                        Address_tb.Text = string.Empty;
                        EmailAddress_tb.Text = string.Empty;
                        PhoneNumber_tb.Text = string.Empty;
                        JoinDate_dtp.Text = string.Empty;
                        Password_tb.Text = string.Empty;
                    }
                }

            }
        }

        private void StaffRegistration_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                Image_Path.Text = open.FileName;
            }
        }


        protected void BindData()
        {
            using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
            {
                con.Open();

                var lst = con.Query<Admission>(@"Select *,FirstName + ' ' + MiddleName + ' ' + LastName as FullName from StaffRegistration ").ToList();
                con.Close();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["Id"].DataPropertyName = "Id";
                dataGridView1.Columns["FullName"].DataPropertyName = "FullName";
                dataGridView1.Columns["JoinDate"].DataPropertyName = "JoinDate";
                dataGridView1.Columns["PhoneNo"].DataPropertyName = "PhoneNo";
                dataGridView1.Columns["Faculty"].DataPropertyName = "Faculty";
                dataGridView1.Columns["Email"].DataPropertyName = "Email";
                dataGridView1.Columns["Gender"].DataPropertyName = "Gender";
                dataGridView1.DataSource = lst;
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            DataGridViewCell cell = dataGridView1.CurrentCell;

            if (cell.Value.Equals("Modify"))
            {
                DataGridViewTextBoxCell dtId = (DataGridViewTextBoxCell)row.Cells["Id"];
                using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var lst = con.Query<StaffRegistration>(@"Select * from dbo.StaffRegistration Where Id = @Id", new { @Id = dtId.Value }).FirstOrDefault();
                    con.Close();

                    lblHiddenId.Text = lst.Id.ToString();
                    JoinDate_dtp.Value = lst.JoinDate;
                    FirstName_tb.Text = lst.FirstName;
                    MiddleName_tb.Text = lst.MiddleName;
                    LastName_tb.Text = lst.LastName;
                    Faculty_cb.Text = lst.Faculty;
                    PhoneNumber_tb.Text = lst.PhoneNo;
                    Password_tb.Text = lst.Password;
                    EmailAddress_tb.Text = lst.Email;
                    Address_tb.Text = lst.Address;
                    Image_Path.Text = lst.Image_Path;
                    if (lst.Gender.Equals("Male"))
                        Male_rb.Checked = true;
                    else if (lst.Gender.Equals("Female"))
                        Female_rb.Checked = true;
                    else
                        Other_rb.Checked = true;

                    if (!string.IsNullOrEmpty(lst.Image_Path))
                    {
                        pictureBox1.Image = new Bitmap(lst.Image_Path);
                        Image_Path.Text = lst.Image_Path;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        Image_Path.Text = "";
                    }
                }
            }
            else if (cell.Value.Equals("Delete"))
            {
                DataGridViewTextBoxCell dtId = (DataGridViewTextBoxCell)row.Cells["Id"];
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                    {
                        con.Open();

                        con.Execute("Delete from dbo.StaffRegistration Where Id = @Id", new { @Id = dtId.Value });
                        con.Close();

                        MessageBox.Show("Data Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BindData();
                    };
                }
            }
        }
    }
}