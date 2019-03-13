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

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
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
                txtStatus.Text != ""
                )
            {
                //Store data
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string contact = txtContact.Text;
                string email = txtEmail.Text;
                string registrationNumber = txtRegistrationNumber.Text;
                int status = Convert.ToInt32(txtStatus.Text);

                //insert data
                string cmd = "INSERT INTO Student VALUES('" + firstName + "', '" + lastName + "', '" + contact + "', '" + email + "', '" + registrationNumber + "', '" + status + "')";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            //Show data in datagridview
            //DisplayStudentData();
            //clear data
            ClearStudentData();

        }
        //Clear Data  
        public void ClearStudentData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegistrationNumber.Text = "";
            txtStatus.Text = "";
        }

        //Display Data in DataGridView  
        private void DisplayStudentData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Student", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void FormManageStudents_Load(object sender, EventArgs e)
        {
            //DisplayStudentData();
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
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" &&
                txtLastName.Text != "" &&
                txtContact.Text != "" &&
                txtEmail.Text != "" &&
                txtRegistrationNumber.Text != "" &&
                txtStatus.Text != ""
                )
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
                cmd.Parameters.AddWithValue("@st", txtStatus.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DisplayStudentData();
                ClearStudentData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
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
    }
}
