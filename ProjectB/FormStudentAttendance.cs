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
    public partial class FormStudentAttendance : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        public FormStudentAttendance()
        {
            InitializeComponent();
            panelLeft.Height = btnAddAttendances.Height;
            panelLeft.Top = btnAddAttendances.Top;
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAddAttendances.Height;
            panelLeft.Top = btnAddAttendances.Top;
            MessageBox.Show("You are going to leave this page");
            this.Hide();
            FormManageStudents frm = new FormManageStudents();
            frm.Show();
        }

        private void btnGoBackToManageForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnGoBackToManageForm.Height;
            panelLeft.Top = btnGoBackToManageForm.Top;
            MessageBox.Show("You are going to leave this page");
            this.Hide();
            FormManageStudents frm = new FormManageStudents();
            frm.Show();
        }
        //Display Data in DataGridView  
        private void DisplayStudentData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from StudentAttendance", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void FormStudentAttendance_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Id from Student", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //show Id's in combo box
            cmbStudentIds.ValueMember = "Id";
            cmbStudentIds.DataSource = dt;
            conn.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (cmbStudentIds.Text != "" &&
                txtAttendanceStatus.Text != ""
                )
            {
                //Store data
                int studentId = Convert.ToInt32(cmbStudentIds.Text);
                //
                MessageBox.Show(Convert.ToString(studentId));
                //
                int attendanceStatus = Convert.ToInt32(txtAttendanceStatus.Text);

                //insert data
                //string cmd = "INSERT INTO StudentAttendance VALUES('" + studentId + "', '" + attendanceStatus + "')";
                //SqlCommand command = new SqlCommand(cmd, conn);
                //command.ExecuteNonQuery();
                //MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            cmbStudentIds.Text = "";
            txtAttendanceStatus.Text = "";
        }
    }
}
