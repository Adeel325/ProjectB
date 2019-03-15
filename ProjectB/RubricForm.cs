using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class RubricForm : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        int ID = 0;
        public RubricForm()
        {
            InitializeComponent();
            DisplayData();
            panelLeft.Height = btnRubricsForm.Height;
            panelLeft.Top = btnRubricsForm.Top;
        }

        //Form Display Setting
        private static RubricForm instance;
        public static RubricForm SetGUIPlacements()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RubricForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        //

        private void btnRubricsForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnRubricsForm.Height;
            panelLeft.Top = btnRubricsForm.Top;
            MessageBox.Show("You are already on Rubrics Form!");
        }

        private void btnGoBackToMainPage_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnGoBackToMainPage.Height;
            panelLeft.Top = btnGoBackToMainPage.Top;

            //start
            this.Hide();
            FormMain frm = FormMain.SetGUIPlacements();
            frm.Show();
        }

        private void btnRubricLevel_Click(object sender, EventArgs e)
        {
            
        }

        private void RubricForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Id from Clo", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //show Id's in combo box
            cmbIds.ValueMember = "Id";
            cmbIds.DataSource = dt;
            
            conn.Close();
        }

        private void btnAddClo_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (cmbIds.Text != "" &&
                richTextBox1.Text != ""
                )
            {
                if (!Regex.IsMatch(txtRubricId.Text, @"[0-9]") || txtRubricId.Text == "")
                {
                    MessageBox.Show("Rubric ID Should be a number");
                }
                else
                {
                    //Check If Rubric Id already exist

                    SqlConnection conn1 = new SqlConnection(conURL);
                    conn1.Open();
                    string s = "SELECT COUNT(*) FROM Rubric WHERE Id = @id";

                    SqlCommand scommand = new SqlCommand(s, conn);
                    scommand.Parameters.AddWithValue("@id", txtRubricId.Text);
                    int records = (int)scommand.ExecuteScalar();

                    if (records == 0)
                    {
                        //Store data
                        string rubricId = txtRubricId.Text;
                        int cloId = Convert.ToInt32(cmbIds.Text);
                        string details = richTextBox1.Text;

                        //insert data

                        string cmd = "INSERT INTO Rubric VALUES('" + rubricId + "', '" + details + "', '" + cloId + "')";
                        SqlCommand command = new SqlCommand(cmd, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Successfully");
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Rubric with this ID already exist add another ID");
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            //clear data
            ClearData();
        }

        
        public void ClearData()
        {
            txtRubricId.Text = "";
            richTextBox1.Text = "";

        }
        public void DisplayData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            string query = "SELECT * FROM Rubric";
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
            conn.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ID = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                txtRubricId.Text = row.Cells["Id"].Value.ToString();
                cmbIds.Text = row.Cells["CloId"].Value.ToString();
                richTextBox1.Text = row.Cells["Details"].Value.ToString();
                
            }
        }

        private void txtRubricId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRubricId.Text))
            {
                e.Cancel = true;
                txtRubricId.Focus();
                errorProviderApp.SetError(txtRubricId, "Rubric Id should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtRubricId, "");
            }
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                e.Cancel = true;
                richTextBox1.Focus();
                errorProviderApp.SetError(richTextBox1, "Details should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(richTextBox1, "");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtRubricId.Text != "" &&
               cmbIds.Text != "" &&
               richTextBox1.Text != ""
               )
            {
                if (!Regex.IsMatch(txtRubricId.Text, @"[0-9]"))
                {
                    MessageBox.Show("Invalid Rubric ID");
                }
                else if (!Regex.IsMatch(cmbIds.Text, @"[0-9]"))
                {
                    MessageBox.Show("Invalid CLO ID");
                }
                else if (!Regex.IsMatch(richTextBox1.Text, @"[A-Za-z0-9-. ]"))
                {
                    MessageBox.Show("Invalid Details");
                }
               
                else
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update Rubric set Id=@id, Details=@details, CloId=@cloId where ID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@details", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@cloId", cmbIds.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    conn.Close();
                    DisplayData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Click on the record of datagridview to which you wanna update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                SqlCommand cmd = new SqlCommand("delete Rubric where ID=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
    
}
