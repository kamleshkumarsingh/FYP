using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamleshproject
{
    public partial class StudentAdmission : Form
    {
        public StudentAdmission()
        {
            InitializeComponent();
        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {
            Class_Cb.SelectedIndex = 0;
            Section_cb.SelectedIndex = 0;
            lblHiddenId.Text = "0";
            BindData();
        }


        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (FirstName_Txt.Text.Equals(string.Empty))
            {
                MessageBox.Show("First Name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstName_Txt.Focus();
            }
            else if (LastName_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Last Name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastName_tb.Focus();
            }
            else if (FatherName_tb.Text.Equals(string.Empty))
            {
                MessageBox.Show("Father Name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FatherName_tb.Focus();
            }
            else
            {
                using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                {
                    con.Open();

                    string gender = "";
                    if (Male_radioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else if (Female_radioButton.Checked)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Other";
                    }


                    if (!Directory.Exists(Application.StartupPath + "\\Student"))
                        Directory.CreateDirectory(Application.StartupPath + "\\Student");

                    if (!string.IsNullOrEmpty(Image_Path.Text))
                        pictureBox1.Image.Save(Application.StartupPath + "\\Student\\" + FirstName_Txt.Text + MiddleName_tb.Text + LastName_tb.Text, System.Drawing.Imaging.ImageFormat.Jpeg);

                    if (!lblHiddenId.Text.Equals("0"))
                    {
                        con.Execute("Update dbo.Admission Set AdmissionDate = @AdmissionDate, Class = @Class, Section = @Section, FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, FatherName = @FatherName, TemporaryAddress = @TemporaryAddress, PermanentAddress = @PermanentAddress, Email = @Email, PhoneNo = @PhoneNo, DateOfBirth = @DateOfBirth, Gender = @Gender, Image_Path = @Image_Path Where Id = @Id", new
                        {
                            @Id = lblHiddenId.Text,
                            @AdmissionDate = AdmisionDate_dtp.Text,
                            @Class = Class_Cb.Text,
                            @Section = Section_cb.Text,
                            @FirstName = FirstName_Txt.Text,
                            @MiddleName = MiddleName_tb.Text,
                            @LastName = LastName_tb.Text,
                            @FatherName = FatherName_tb.Text,
                            @TemporaryAddress = TemporaryAddress_tb.Text,
                            @PermanentAddress = PermanentAddress_textBox.Text,
                            @Email = EmailAddress_tb.Text,
                            @PhoneNo = PhoneNumber_tb.Text,
                            @DateOfBirth = DateOfBirth_dtp.Text,
                            @Gender = gender,
                            @Image_Path = Image_Path.Text,
                            @Ent_User = Session.Email,
                            @Ent_DateTime = DateTime.Now
                        });
                    }
                    else
                    {
                        con.Execute("Insert into dbo.Admission (AdmissionDate, Class, Section, FirstName, MiddleName, LastName, FatherName, TemporaryAddress, PermanentAddress, Email, PhoneNo, DateOfBirth, Gender, Image_Path, Ent_User, Ent_DateTime) Values (@AdmissionDate, @Class, @Section, @FirstName, @MiddleName, @LastName, @FatherName, @TemporaryAddress, @PermanentAddress, @Email, @PhoneNo, @DateOfBirth, @Gender, @Image_Path, @Ent_User, @Ent_DateTime)", new
                        {
                            @AdmissionDate = AdmisionDate_dtp.Text,
                            @Class = Class_Cb.Text,
                            @Section = Section_cb.Text,
                            @FirstName = FirstName_Txt.Text,
                            @MiddleName = MiddleName_tb.Text,
                            @LastName = LastName_tb.Text,
                            @FatherName = FatherName_tb.Text,
                            @TemporaryAddress = TemporaryAddress_tb.Text,
                            @PermanentAddress = PermanentAddress_textBox.Text,
                            @Email = EmailAddress_tb.Text,
                            @PhoneNo = PhoneNumber_tb.Text,
                            @DateOfBirth = DateOfBirth_dtp.Text,
                            @Gender = gender,
                            @Image_Path = Image_Path.Text,
                            @Ent_User = Session.Email,
                            @Ent_DateTime = DateTime.Now
                        });
                    }
                    MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindData();

                    lblHiddenId.Text = "0";
                    FirstName_Txt.Text = string.Empty;
                    MiddleName_tb.Text = string.Empty;
                    LastName_tb.Text = string.Empty;
                    Section_cb.Text = string.Empty;
                    FatherName_tb.Text = string.Empty;
                    Class_Cb.Text = string.Empty;
                    TemporaryAddress_tb.Text = string.Empty;
                    PermanentAddress_textBox.Text = string.Empty;
                    EmailAddress_tb.Text = string.Empty;
                    PhoneNumber_tb.Text = string.Empty;
                    DateOfBirth_dtp.Text = string.Empty;
                };
            }
        }

        private void FirstName_Txt_TextChanged(object sender, EventArgs e)
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

                var lst = con.Query<Admission>(@"Select *,FirstName + ' ' + MiddleName + ' ' + LastName as FullName from Admission Where Class = @Class", new { @Class = Class_Cb.Text }).ToList();
                con.Close();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["Id"].DataPropertyName = "Id";
                dataGridView1.Columns["FullName"].DataPropertyName = "FullName";
                dataGridView1.Columns["AdmissionDate"].DataPropertyName = "AdmissionDate";
                dataGridView1.Columns["Class"].DataPropertyName = "Class";
                dataGridView1.Columns["FatherName"].DataPropertyName = "FatherName";
                dataGridView1.Columns["Email"].DataPropertyName = "Email";
                dataGridView1.Columns["Gender"].DataPropertyName = "Gender";
                dataGridView1.DataSource = lst;

            };
        }

        private void Class_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindData();
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

                    var lst = con.Query<Admission>(@"Select * from dbo.Admission Where Id = @Id", new { @Id = dtId.Value }).FirstOrDefault();
                    con.Close();

                    lblHiddenId.Text = lst.Id.ToString();
                    AdmisionDate_dtp.Value = lst.AdmissionDate;
                    Class_Cb.Text = lst.Class;
                    Section_cb.Text = lst.Section;
                    FirstName_Txt.Text = lst.FirstName;
                    MiddleName_tb.Text = lst.MiddleName;
                    LastName_tb.Text = lst.LastName;
                    FatherName_tb.Text = lst.FatherName;
                    TemporaryAddress_tb.Text = lst.TemporaryAddress;
                    PermanentAddress_textBox.Text = lst.PermanentAddress;
                    EmailAddress_tb.Text = lst.Email;
                    PhoneNumber_tb.Text = lst.PhoneNo;
                    DateOfBirth_dtp.Value = lst.DateOfBirth;
                    Image_Path.Text = lst.Image_Path;
                    if (lst.Gender.Equals("Male"))
                        Male_radioButton.Checked = true;
                    else if (lst.Gender.Equals("Female"))
                        Female_radioButton.Checked = true;
                    else
                        Other_radioButton.Checked = true;

                    if (!string.IsNullOrEmpty(lst.Image_Path))
                    {
                        pictureBox1.Image = new Bitmap(lst.Image_Path);
                        Image_Path.Text = lst.Image_Path;
                    }else
                    {
                        pictureBox1.Image = null;
                        Image_Path.Text = "";
                    }
                }
            }
            else if (cell.Value.Equals("Delete"))
            {
                DataGridViewTextBoxCell dtId = (DataGridViewTextBoxCell)row.Cells["Id"];
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                    {
                        con.Open();

                        con.Execute("Delete from dbo.Admission Where Id = @Id", new { @Id = dtId.Value });
                        con.Close();

                        MessageBox.Show("Data Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BindData();
                    };
                }
            }
        }
    }
}