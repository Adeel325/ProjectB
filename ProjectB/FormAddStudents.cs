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
    public partial class FormAddStudents : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public FormAddStudents()
        {
            InitializeComponent();
            DisplayStudentData();
        }

        //Form Display Setting
        private static FormAddStudents instance;
        public static FormAddStudents SetGUIPlacements()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormAddStudents();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        //

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            //Set the pannel height
            this.Hide();
            FormMain main = new FormMain();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (txtFirstName.Text != "" && 
                txtLastName.Text != "" && 
                txtContact.Text != "" && 
                txtEmail.Text != "" &&
                txtRegistrationNumber.Text != "" &&
                cmbStatus.Text != ""
                )
            {
                //Store data
                if (!Regex.IsMatch(txtFirstName.Text, @"[A-Za-z]"))
                {
                    MessageBox.Show("Invalid First Name");
                }
                else if (!Regex.IsMatch(txtLastName.Text, @"[A-Za-z]"))
                {
                    MessageBox.Show("Invalid Contact");
                }
                else if(!Regex.IsMatch(txtContact.Text, @"[0-9]") || txtContact.Text.Length != 11)
                {
                    MessageBox.Show("Invalid Contact");
                }
                else if (!Regex.IsMatch(txtEmail.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    MessageBox.Show("Invalid Email");
                }
                else if (!Regex.IsMatch(txtRegistrationNumber.Text, @"[A-Za-z0-9-]") || txtRegistrationNumber.Text.Length < 6)
                {
                    MessageBox.Show("Invalid Registration Number");
                }
                else if (!Regex.IsMatch(cmbStatus.Text, @"[0-9]"))
                {
                    MessageBox.Show("Invalid Status");
                }
                else
                {
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string contact = txtContact.Text;
                    string email = txtEmail.Text;
                    string registrationNumber = txtRegistrationNumber.Text;
                    int status = Convert.ToInt32(cmbStatus.Text);

                    //insert data
                    string cmd = "INSERT INTO Student VALUES('" + firstName + "', '" + lastName + "', '" + contact + "', '" + email + "', '" + registrationNumber + "', '" + status + "')";
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully");
                    DisplayStudentData();
                    ClearStudentData();
                }
                
            }
        }
        //Clear Data  
        public void ClearStudentData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegistrationNumber.Text = "";
        }

        //Display Data in DataGridView  
        private void DisplayStudentData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Student", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
            conn.Close();
        }

        private void FormManageStudents_Load(object sender, EventArgs e)
        {
            //load data
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select LookupId from Lookup where Category = 'STUDENT_STATUS' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //show Id's in combo box
            cmbStatus.ValueMember = "LookupId";
            cmbStatus.DataSource = dt;
            conn.Close();

            //display data
            DisplayStudentData();
        }

        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ID = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtRegistrationNumber.Text = row.Cells["RegistrationNumber"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            
            if (txtFirstName.Text != "" &&
                txtLastName.Text != "" &&
                txtContact.Text != "" &&
                txtEmail.Text != "" &&
                txtRegistrationNumber.Text != "" &&
                cmbStatus.Text != ""
                )
            {
                if (!Regex.IsMatch(txtFirstName.Text, @"[A-Za-z]"))
                {
                    MessageBox.Show("Invalid First Name");
                }
                else if (!Regex.IsMatch(txtLastName.Text, @"[A-Za-z]"))
                {
                    MessageBox.Show("Invalid Contact");
                }
                else if (!Regex.IsMatch(txtContact.Text, @"[0-9]") || txtContact.Text.Length != 11)
                {
                    MessageBox.Show("Invalid Contact");
                }
                else if (!Regex.IsMatch(txtEmail.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    MessageBox.Show("Invalid Email");
                }
                else if (!Regex.IsMatch(txtRegistrationNumber.Text, @"[A-Za-z0-9-]") || txtRegistrationNumber.Text.Length < 6)
                {
                    MessageBox.Show("Invalid Registration Number");
                }
                else if (!Regex.IsMatch(cmbStatus.Text, @"[0-9]"))
                {
                    MessageBox.Show("Invalid Status");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update Student set FirstName=@fname, LastName=@lname, Contact=@con, Email=@em, RegistrationNumber=@regNum, Status=@st where ID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@con", txtContact.Text);
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@regNum", txtRegistrationNumber.Text);
                    cmd.Parameters.AddWithValue("@st", cmbStatus.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    DisplayStudentData();
                    conn.Close();
                    DisplayStudentData();
                    ClearStudentData();
                }
            }
            else
            {
                MessageBox.Show("Click on the record of datagridview to which you wanna update");
            }
        }

        //Delete Record
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                SqlCommand cmd = new SqlCommand("delete Student where ID=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayStudentData();
                ClearStudentData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnStudentForm.Height;
            panelLeft.Top = btnStudentForm.Top;
        }

        private void goBackToManageForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = goBackToManageForm.Height;
            panelLeft.Top = goBackToManageForm.Top;

            //Go to Manage Student Form

            this.Hide();
            FormManageStudents frm = new FormManageStudents();
            frm.Show();
        }

        //validations

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProviderApp.SetError(txtFirstName, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtLastName, "");
            }
        }

        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                e.Cancel = true;
                txtContact.Focus();
                errorProviderApp.SetError(txtContact, "Contact should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtContact, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderApp.SetError(txtEmail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtEmail, "");
            }
        }

        private void txtRegistrationNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationNumber.Text))
            {
                e.Cancel = true;
                txtRegistrationNumber.Focus();
                errorProviderApp.SetError(txtRegistrationNumber, "Registration Number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtRegistrationNumber, "");
            }
        }

        private void txtStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                e.Cancel = true;
                cmbStatus.Focus();
                errorProviderApp.SetError(cmbStatus, "Status should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(cmbStatus, "");
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
