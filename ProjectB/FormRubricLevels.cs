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
    public partial class FormRubricLevels : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        int ID = 0;
        public FormRubricLevels()
        {
            InitializeComponent();
            DisplayData();
            panelLeft.Height = btnRubricLevelForm.Height;
            panelLeft.Top = btnRubricLevelForm.Top;
        }

        //Form Display Setting
        private static FormRubricLevels instance;
        public static FormRubricLevels SetGUIPlacements()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormRubricLevels();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        //

        private void btnRubricLevelForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnRubricLevelForm.Height;
            panelLeft.Top = btnRubricLevelForm.Top;
            MessageBox.Show("You are already on Rubrics Form!");
        }

        private void btnGoBackToMainForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnGoBackToMainForm.Height;
            panelLeft.Top = btnGoBackToMainForm.Top;

            //start
            this.Hide();
            FormMain frm = FormMain.SetGUIPlacements();
            frm.Show();

        }

        private void btnAddRubricLevel_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            
            //if data is valid
            if(richTextBox1.Text !="" &&
                txtMeasurementLevel.Text !="")
            {
                if (!Regex.IsMatch(cmbRubricIds.Text, @"[0-9]"))
                {
                    MessageBox.Show("Invalid Rubric ID");
                }
                else if (!Regex.IsMatch(richTextBox1.Text, @"[A-Za-z]"))
                {
                    MessageBox.Show("Invalid Details");
                }
                else if (!Regex.IsMatch(txtMeasurementLevel.Text, @"[0-9]") || Convert.ToInt32(txtMeasurementLevel.Text) > 4 || Convert.ToInt32(txtMeasurementLevel.Text) <= 0)
                {
                    MessageBox.Show("Invalid Measurement Level. It should be a number between 1-4");
                }
                else
                {
                    //Store data
                    string rubricid = cmbRubricIds.Text;
                    string details = richTextBox1.Text;
                    string measurementlvl = txtMeasurementLevel.Text;

                    //insert data
                    string cmd = "INSERT INTO RubricLevel VALUES('" + rubricid + "', '" + details + "', '" + measurementlvl + "')";
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully");
                    DisplayData();
                    //clear data
                    ClearData();
                }              
            }
            else
            {
                MessageBox.Show("Insert Data First!");
            }
        }
        public void ClearData()
        {
            richTextBox1.Text = "";
            txtMeasurementLevel.Text = "";
        }
        public void DisplayData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM RubricLevel", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
            conn.Close();
        }

        private void FormRubricLevels_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Id from Rubric", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //show Id's in combo box
            cmbRubricIds.ValueMember = "Id";
            cmbRubricIds.DataSource = dt;
            conn.Close();
        }

        //validation for details
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

        //validations
        private void txtMeasurementLevel_Validating(object sender, CancelEventArgs e)
        {
            //validation for measurement level
            if (string.IsNullOrWhiteSpace(txtMeasurementLevel.Text))
            {
                e.Cancel = true;
                //txtMeasurementLevel.Focus();
                errorProviderApp.SetError(txtMeasurementLevel, "Measurement Level should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtMeasurementLevel, "");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ID = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                cmbRubricIds.Text = row.Cells["RubricId"].Value.ToString();
                richTextBox1.Text = row.Cells["Details"].Value.ToString();
                txtMeasurementLevel.Text = row.Cells["MeasurementLevel"].Value.ToString();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMeasurementLevel.Text != "" &&
               richTextBox1.Text != "" &&
               cmbRubricIds.Text != ""
               )
            {
                if (!Regex.IsMatch(cmbRubricIds.Text, @"[0-9]"))
                {
                    MessageBox.Show("Invalid Rubric ID");
                }
                else if (!Regex.IsMatch(richTextBox1.Text, @"[A-Za-z]"))
                {
                    MessageBox.Show("Invalid Details");
                }
                else if (!Regex.IsMatch(txtMeasurementLevel.Text, @"[0-9]") || Convert.ToInt32(txtMeasurementLevel.Text) > 4 || Convert.ToInt32(txtMeasurementLevel.Text) <= 0)
                {
                    MessageBox.Show("Invalid Measurement Level. It should be a number between 1-4");
                }

                else
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update RubricLevel set RubricId=@rubricId, Details=@details, MeasurementLevel=@lvl where ID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@rubricId", cmbRubricIds.Text);
                    cmd.Parameters.AddWithValue("@details", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@lvl", txtMeasurementLevel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    DisplayData();
                    ClearData();
                    conn.Close();
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
                SqlCommand cmd = new SqlCommand("delete RubricLevel where ID=@id", conn);
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
