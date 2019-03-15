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
            DisplayData();
            panelLeft.Height = btnAddAttendances.Height;
            panelLeft.Top = btnAddAttendances.Top;
        }

        //Form Display Setting
        private static FormStudentAttendance instance;
        public static FormStudentAttendance SetGUIPlacements()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormStudentAttendance();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        //
        private void btnGoBackToManageForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnGoBackToManageForm.Height;
            panelLeft.Top = btnGoBackToManageForm.Top;
            MessageBox.Show("You are going to leave this page");
            this.Hide();
            FormManageStudents frm = FormManageStudents.SetGUIPlacements();
            frm.Show();
        }
        

        //function to load status
        public void LoadStatus()
        {
            //load status
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select LookupId from Lookup where Category = 'ATTENDANCE_STATUS' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //show Id's in combo box
            cmbStatus.ValueMember = "LookupId";
            cmbStatus.DataSource = dt;
            
        }
        //Function to Add Attendance ID's in combo Box
        public void LoadAttendanceIDs()
        {
            //load Attendance ID's
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Id from ClassAttendance", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //show Id's in combo box
            cmbAttendanceId.ValueMember = "Id";
            cmbAttendanceId.DataSource = dt;
        }

        public void DisplayData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM StudentAttendance", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
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
            LoadStatus();
            LoadAttendanceIDs();
            conn.Close();
        }

        private void btnAddStudentAttendance_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (cmbStudentIds.Text != "" &&
                cmbStatus.Text != ""
                )
            {
                //Store data
                if (!cmbAttendanceId.Text.All(Char.IsDigit))
                {
                    MessageBox.Show("Attendance ID Should be an integer!");
                }
                else if (!cmbStudentIds.Text.All(Char.IsDigit))
                {
                    MessageBox.Show("Student ID Should be an integer!");
                }
                else if (!cmbStatus.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Attendance Status Should be an integer!");
                }
                else
                {
                    int attendanceId = Convert.ToInt32(cmbAttendanceId.Text);
                    int studentId = Convert.ToInt32(cmbStudentIds.Text);
                    int attendanceStatus = Convert.ToInt32(cmbStatus.Text);

                    //insert data
                    string cmd = "INSERT INTO StudentAttendance VALUES('" + attendanceId + "','" + studentId + "', '" + attendanceStatus + "')";
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentIds_Click(object sender, EventArgs e)
        {

        }

        private void lblAttendanceStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmbStudentIds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStudentAttendanceForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnStudentAttendanceForm.Height;
            panelLeft.Top = btnStudentAttendanceForm.Top;
            MessageBox.Show("You are already on Student Attendance Form");
        }
    }
}
