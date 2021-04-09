
namespace Kamleshproject
{
    partial class Staff_Registration
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
            this.Address_tb = new System.Windows.Forms.TextBox();
            this.Address_l = new System.Windows.Forms.Label();
            this.Faculty_cb = new System.Windows.Forms.ComboBox();
            this.Faculty_label = new System.Windows.Forms.Label();
            this.Other_rb = new System.Windows.Forms.RadioButton();
            this.Female_rb = new System.Windows.Forms.RadioButton();
            this.Male_rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.JoinDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.JoinDate_lable = new System.Windows.Forms.Label();
            this.PhoneNumber_tb = new System.Windows.Forms.TextBox();
            this.PhoneNumber_lable = new System.Windows.Forms.Label();
            this.EmailAddress_tb = new System.Windows.Forms.TextBox();
            this.EmailAddress_lable = new System.Windows.Forms.Label();
            this.LastName_tb = new System.Windows.Forms.TextBox();
            this.LastName_lable = new System.Windows.Forms.Label();
            this.FirstName_tb = new System.Windows.Forms.TextBox();
            this.FirstName_lable = new System.Windows.Forms.Label();
            this.MiddleName_tb = new System.Windows.Forms.TextBox();
            this.MiddleName_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_b = new System.Windows.Forms.Button();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHiddenId = new System.Windows.Forms.Label();
            this.Image_Path = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Address_tb
            // 
            this.Address_tb.Location = new System.Drawing.Point(454, 40);
            this.Address_tb.Name = "Address_tb";
            this.Address_tb.Size = new System.Drawing.Size(183, 20);
            this.Address_tb.TabIndex = 4;
            this.Address_tb.TextChanged += new System.EventHandler(this.Address_tb_TextChanged);
            // 
            // Address_l
            // 
            this.Address_l.Location = new System.Drawing.Point(342, 43);
            this.Address_l.Name = "Address_l";
            this.Address_l.Size = new System.Drawing.Size(106, 13);
            this.Address_l.TabIndex = 46;
            this.Address_l.Text = "Address : ";
            this.Address_l.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Faculty_cb
            // 
            this.Faculty_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Faculty_cb.FormattingEnabled = true;
            this.Faculty_cb.Items.AddRange(new object[] {
            "Admin",
            "Teacher ",
            "Cleaning",
            "Accountant",
            "Guard",
            "Others"});
            this.Faculty_cb.Location = new System.Drawing.Point(117, 118);
            this.Faculty_cb.Name = "Faculty_cb";
            this.Faculty_cb.Size = new System.Drawing.Size(211, 21);
            this.Faculty_cb.TabIndex = 8;
            this.Faculty_cb.SelectedIndexChanged += new System.EventHandler(this.Faculty_cb_SelectedIndexChanged);
            // 
            // Faculty_label
            // 
            this.Faculty_label.Location = new System.Drawing.Point(45, 121);
            this.Faculty_label.Name = "Faculty_label";
            this.Faculty_label.Size = new System.Drawing.Size(62, 13);
            this.Faculty_label.TabIndex = 42;
            this.Faculty_label.Text = "Faculty :";
            this.Faculty_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Other_rb
            // 
            this.Other_rb.AutoSize = true;
            this.Other_rb.Location = new System.Drawing.Point(570, 95);
            this.Other_rb.Name = "Other_rb";
            this.Other_rb.Size = new System.Drawing.Size(51, 17);
            this.Other_rb.TabIndex = 41;
            this.Other_rb.Text = "Other";
            this.Other_rb.UseVisualStyleBackColor = true;
            // 
            // Female_rb
            // 
            this.Female_rb.AutoSize = true;
            this.Female_rb.Location = new System.Drawing.Point(505, 95);
            this.Female_rb.Name = "Female_rb";
            this.Female_rb.Size = new System.Drawing.Size(59, 17);
            this.Female_rb.TabIndex = 40;
            this.Female_rb.Text = "Female";
            this.Female_rb.UseVisualStyleBackColor = true;
            // 
            // Male_rb
            // 
            this.Male_rb.AutoSize = true;
            this.Male_rb.Checked = true;
            this.Male_rb.Location = new System.Drawing.Point(454, 94);
            this.Male_rb.Name = "Male_rb";
            this.Male_rb.Size = new System.Drawing.Size(48, 17);
            this.Male_rb.TabIndex = 9;
            this.Male_rb.TabStop = true;
            this.Male_rb.Text = "Male";
            this.Male_rb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(343, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Gender :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // JoinDate_dtp
            // 
            this.JoinDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JoinDate_dtp.Location = new System.Drawing.Point(454, 67);
            this.JoinDate_dtp.Name = "JoinDate_dtp";
            this.JoinDate_dtp.Size = new System.Drawing.Size(183, 20);
            this.JoinDate_dtp.TabIndex = 7;
            this.JoinDate_dtp.ValueChanged += new System.EventHandler(this.JoinDate_dtp_ValueChanged);
            // 
            // JoinDate_lable
            // 
            this.JoinDate_lable.Location = new System.Drawing.Point(343, 67);
            this.JoinDate_lable.Name = "JoinDate_lable";
            this.JoinDate_lable.Size = new System.Drawing.Size(105, 13);
            this.JoinDate_lable.TabIndex = 34;
            this.JoinDate_lable.Text = "Join Date :";
            this.JoinDate_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.JoinDate_lable.Click += new System.EventHandler(this.JoinDate_lable_Click);
            // 
            // PhoneNumber_tb
            // 
            this.PhoneNumber_tb.Location = new System.Drawing.Point(117, 92);
            this.PhoneNumber_tb.Name = "PhoneNumber_tb";
            this.PhoneNumber_tb.Size = new System.Drawing.Size(211, 20);
            this.PhoneNumber_tb.TabIndex = 6;
            this.PhoneNumber_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PhoneNumber_lable
            // 
            this.PhoneNumber_lable.Location = new System.Drawing.Point(22, 92);
            this.PhoneNumber_lable.Name = "PhoneNumber_lable";
            this.PhoneNumber_lable.Size = new System.Drawing.Size(85, 13);
            this.PhoneNumber_lable.TabIndex = 32;
            this.PhoneNumber_lable.Text = "Phone Number : ";
            this.PhoneNumber_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.PhoneNumber_lable.Click += new System.EventHandler(this.PhoneNumber_lable_Click);
            // 
            // EmailAddress_tb
            // 
            this.EmailAddress_tb.Location = new System.Drawing.Point(117, 66);
            this.EmailAddress_tb.Name = "EmailAddress_tb";
            this.EmailAddress_tb.Size = new System.Drawing.Size(211, 20);
            this.EmailAddress_tb.TabIndex = 5;
            this.EmailAddress_tb.TextChanged += new System.EventHandler(this.EmailAddress_tb_TextChanged);
            // 
            // EmailAddress_lable
            // 
            this.EmailAddress_lable.Location = new System.Drawing.Point(4, 69);
            this.EmailAddress_lable.Name = "EmailAddress_lable";
            this.EmailAddress_lable.Size = new System.Drawing.Size(103, 13);
            this.EmailAddress_lable.TabIndex = 30;
            this.EmailAddress_lable.Text = "Email Address :";
            this.EmailAddress_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LastName_tb
            // 
            this.LastName_tb.Location = new System.Drawing.Point(117, 40);
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.Size = new System.Drawing.Size(211, 20);
            this.LastName_tb.TabIndex = 3;
            this.LastName_tb.TextChanged += new System.EventHandler(this.LastName_tb_TextChanged);
            // 
            // LastName_lable
            // 
            this.LastName_lable.Location = new System.Drawing.Point(5, 40);
            this.LastName_lable.Name = "LastName_lable";
            this.LastName_lable.Size = new System.Drawing.Size(104, 13);
            this.LastName_lable.TabIndex = 28;
            this.LastName_lable.Text = "Last Name : ";
            this.LastName_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.Location = new System.Drawing.Point(117, 14);
            this.FirstName_tb.Name = "FirstName_tb";
            this.FirstName_tb.Size = new System.Drawing.Size(211, 20);
            this.FirstName_tb.TabIndex = 1;
            this.FirstName_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstName_lable
            // 
            this.FirstName_lable.Location = new System.Drawing.Point(6, 14);
            this.FirstName_lable.Name = "FirstName_lable";
            this.FirstName_lable.Size = new System.Drawing.Size(103, 13);
            this.FirstName_lable.TabIndex = 26;
            this.FirstName_lable.Text = "First Name : ";
            this.FirstName_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MiddleName_tb
            // 
            this.MiddleName_tb.Location = new System.Drawing.Point(454, 14);
            this.MiddleName_tb.Name = "MiddleName_tb";
            this.MiddleName_tb.Size = new System.Drawing.Size(183, 20);
            this.MiddleName_tb.TabIndex = 2;
            this.MiddleName_tb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // MiddleName_lable
            // 
            this.MiddleName_lable.Location = new System.Drawing.Point(343, 14);
            this.MiddleName_lable.Name = "MiddleName_lable";
            this.MiddleName_lable.Size = new System.Drawing.Size(105, 13);
            this.MiddleName_lable.TabIndex = 48;
            this.MiddleName_lable.Text = "Middle Name : ";
            this.MiddleName_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHiddenId);
            this.panel1.Controls.Add(this.Image_Path);
            this.panel1.Controls.Add(this.Save_b);
            this.panel1.Controls.Add(this.Password_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.FirstName_tb);
            this.panel1.Controls.Add(this.MiddleName_tb);
            this.panel1.Controls.Add(this.FirstName_lable);
            this.panel1.Controls.Add(this.MiddleName_lable);
            this.panel1.Controls.Add(this.LastName_lable);
            this.panel1.Controls.Add(this.Address_tb);
            this.panel1.Controls.Add(this.LastName_tb);
            this.panel1.Controls.Add(this.Address_l);
            this.panel1.Controls.Add(this.EmailAddress_lable);
            this.panel1.Controls.Add(this.Faculty_cb);
            this.panel1.Controls.Add(this.EmailAddress_tb);
            this.panel1.Controls.Add(this.Faculty_label);
            this.panel1.Controls.Add(this.PhoneNumber_lable);
            this.panel1.Controls.Add(this.Other_rb);
            this.panel1.Controls.Add(this.PhoneNumber_tb);
            this.panel1.Controls.Add(this.Female_rb);
            this.panel1.Controls.Add(this.JoinDate_lable);
            this.panel1.Controls.Add(this.Male_rb);
            this.panel1.Controls.Add(this.JoinDate_dtp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 183);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Save_b
            // 
            this.Save_b.Location = new System.Drawing.Point(508, 134);
            this.Save_b.Name = "Save_b";
            this.Save_b.Size = new System.Drawing.Size(129, 23);
            this.Save_b.TabIndex = 11;
            this.Save_b.Text = "&Save";
            this.Save_b.UseVisualStyleBackColor = true;
            this.Save_b.Click += new System.EventHandler(this.Save_b_Click);
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(117, 147);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(211, 20);
            this.Password_tb.TabIndex = 10;
            this.Password_tb.TextChanged += new System.EventHandler(this.Password_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(755, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 43);
            this.label2.TabIndex = 51;
            this.label2.Text = "Upload Photo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(758, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblHiddenId
            // 
            this.lblHiddenId.AutoSize = true;
            this.lblHiddenId.Location = new System.Drawing.Point(715, 139);
            this.lblHiddenId.Name = "lblHiddenId";
            this.lblHiddenId.Size = new System.Drawing.Size(13, 13);
            this.lblHiddenId.TabIndex = 62;
            this.lblHiddenId.Text = "_";
            this.lblHiddenId.Visible = false;
            // 
            // Image_Path
            // 
            this.Image_Path.AutoSize = true;
            this.Image_Path.Location = new System.Drawing.Point(734, 113);
            this.Image_Path.Name = "Image_Path";
            this.Image_Path.Size = new System.Drawing.Size(13, 13);
            this.Image_Path.TabIndex = 61;
            this.Image_Path.Text = "_";
            this.Image_Path.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.JoinDate,
            this.Faculty,
            this.Email,
            this.PhoneNo,
            this.Gender,
            this.Modify,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(879, 290);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // JoinDate
            // 
            this.JoinDate.HeaderText = "Join Date";
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone No.";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "Modify";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "Modify";
            this.Modify.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // Staff_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Staff_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Registration";
            this.Load += new System.EventHandler(this.Staff_Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Address_tb;
        private System.Windows.Forms.Label Address_l;
        private System.Windows.Forms.ComboBox Faculty_cb;
        private System.Windows.Forms.Label Faculty_label;
        private System.Windows.Forms.RadioButton Other_rb;
        private System.Windows.Forms.RadioButton Female_rb;
        private System.Windows.Forms.RadioButton Male_rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker JoinDate_dtp;
        private System.Windows.Forms.Label JoinDate_lable;
        private System.Windows.Forms.TextBox PhoneNumber_tb;
        private System.Windows.Forms.Label PhoneNumber_lable;
        private System.Windows.Forms.TextBox EmailAddress_tb;
        private System.Windows.Forms.Label EmailAddress_lable;
        private System.Windows.Forms.TextBox LastName_tb;
        private System.Windows.Forms.Label LastName_lable;
        private System.Windows.Forms.TextBox FirstName_tb;
        private System.Windows.Forms.Label FirstName_lable;
        private System.Windows.Forms.TextBox MiddleName_tb;
        private System.Windows.Forms.Label MiddleName_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_b;
        private System.Windows.Forms.Label lblHiddenId;
        private System.Windows.Forms.Label Image_Path;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewLinkColumn Modify;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}