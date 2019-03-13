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

namespace ProjectB
{
    public partial class RubricForm : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        public RubricForm()
        {
            InitializeComponent();
            DisplayData();
            panelLeft.Height = btnRubricsForm.Height;
            panelLeft.Top = btnRubricsForm.Top;
        }

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
            FormMain frm = new FormMain();
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtRubricId.Text, "Demo App - Message!");
                MessageBox.Show(richTextBox1.Text, "Demo App - Message!");
            }
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (txtRubricId.Text !="" &&
                cmbIds.Text != "" &&
                richTextBox1.Text != ""
                )
            {
                int check = CheckFunction(Convert.ToInt32(txtRubricId.Text));
                
                if(check == 0)
                {
                    MessageBox.Show("Rubric with this ID already exist add another ID");
                }
                else
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
                
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            //clear data
            ClearData();
        }
        public int CheckFunction(int id)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string cmd = "SELECT * FROM Rubric WHERE Id = id";
            SqlCommand command = new SqlCommand(cmd, conn);
            int rows = command.ExecuteNonQuery();
            return rows;
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
    }
    
}
