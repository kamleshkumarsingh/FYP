using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Kamleshproject
{
    public partial class FeeRateSetupForm : Form
    {
        public FeeRateSetupForm()
        {
            InitializeComponent();
            BindData();
            lblHiddenId.Text = "0";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FeeColumn_tb.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Fee Column Is Required", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Rate_tb.Text.Equals(string.Empty) || Convert.ToDecimal(Rate_tb.Text) == 0)
                {
                    MessageBox.Show("Fee Rate Is Required", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
                    {
                        con.Open();

                        if (con.Query<int>("Select 1 from dbo.FeeColumns Where FeeColumn = @FeeColumn", new { @FeeColumn = FeeColumn_tb.Text }).FirstOrDefault() == 1 && lblHiddenId.Text == "0")
                        {
                            MessageBox.Show("Fee Column Already Exists.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (lblHiddenId.Text == "0")
                            {
                                con.Execute("Insert Into dbo.FeeColumns (Class, FeeColumn, Rate) Values (@Class, @FeeColumn, @Rate)", new
                                {
                                    @Class = Class_cb.Text,
                                    @FeeColumn = FeeColumn_tb.Text,
                                    @Rate = Rate_tb.Text
                                });
                            }
                            else
                            {
                                con.Execute("Update dbo.FeeColumns Set Class = @Class, FeeColumn = @FeeColumn, Rate = @Rate Where Id = @Id", new
                                {
                                    @Id = lblHiddenId.Text,
                                    @Class = Class_cb.Text,
                                    @FeeColumn = FeeColumn_tb.Text,
                                    @Rate = Rate_tb.Text
                                });
                            }

                            MessageBox.Show("Fee Rate Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            BindData();

                            lblHiddenId.Text = "0"; 
                            FeeColumn_tb.Text = string.Empty;
                            Rate_tb.Text = string.Empty;
                            FeeColumn_tb.Focus();
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FeeRateSetupForm_Load(object sender, EventArgs e)
        {
            Class_cb.SelectedIndex = 0;
        }

        protected void BindData()
        {
            using (IDbConnection con = new SqlConnection(SQLConnection.getConnection()))
            {
                con.Open();

                var lst = con.Query<FeeColumns>(@"Select * From FeeColumns Where Class = @Class", new { @Class = Class_cb.Text }).ToList();
                con.Close();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["Id"].DataPropertyName = "Id";
                dataGridView1.Columns["FeeColumn"].DataPropertyName = "FeeColumn";
                dataGridView1.Columns["Rate"].DataPropertyName = "Rate";
                dataGridView1.DataSource = lst;
            };
        }

        private void Class_cb_SelectedIndexChanged(object sender, EventArgs e)
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

                    var lst = con.Query<FeeColumns>(@"Select * from dbo.FeeColumns Where Id = @Id", new { @Id = dtId.Value }).FirstOrDefault();
                    con.Close();

                    lblHiddenId.Text = lst.Id.ToString();
                    Class_cb.Text = lst.Class;
                    FeeColumn_tb.Text = lst.FeeColumn;
                    Rate_tb.Text = lst.Rate.ToString();
                    
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

                        con.Execute("Delete from dbo.FeeColumns Where Id = @Id", new { @Id = dtId.Value });
                        con.Close();

                        MessageBox.Show("Data Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BindData();
                    };
                }
            }
        }
    }
}
