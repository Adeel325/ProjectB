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
    public partial class FormRubricLevels : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        public FormRubricLevels()
        {
            InitializeComponent();
            DisplayData();
            panelLeft.Height = btnRubricLevelForm.Height;
            panelLeft.Top = btnRubricLevelForm.Top;
        }

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
            FormMain frm = new FormMain();
            frm.Show();

        }

        private void btnAddRubricLevel_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            //if data is not valid
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(richTextBox1.Text, "Demo App - Message!");
                MessageBox.Show(txtMeasurementLevel.Text, "Demo App - Message!");
            }
            //if data is valid
            if(richTextBox1.Text !="" &&
                txtMeasurementLevel.Text !="")
            {
                //Store data
                string rubricid = cmbRubricIds.Text;
                string details = richTextBox1.Text;
                string measurementLevel = txtMeasurementLevel.Text;

                //insert data
                string cmd = "INSERT INTO RubricLevel VALUES('" + rubricid + "', '" + details + "', '" + measurementLevel + "')";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                //clear data
                ClearData();
            }
        }
        public void ClearData()
        {
            richTextBox1.Text = "";
            lblMeasurementLevel.Text = "";
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
    }
}
