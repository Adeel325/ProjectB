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
    public partial class ClassAttendanceForm : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        public ClassAttendanceForm()
        {
            InitializeComponent();
            DisplayData();
        }

        //Form Display Setting
        private static ClassAttendanceForm instance;
        public static ClassAttendanceForm SetGUIPlacements() {
            if(instance == null || instance.IsDisposed)
            {
                instance = new ClassAttendanceForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        //

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            //if data is not valid
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{
            //    MessageBox.Show(richTextBox1.Text, "Demo App - Message!");
            //    MessageBox.Show(txtMeasurementLevel.Text, "Demo App - Message!");
            //}
            //if data is valid
            
            if (Convert.ToDateTime(dateTimePicker1.Text).Date >= DateTime.Now.Date)
            {
                //Store data
                string strDateTime = dateTimePicker1.Text;
                DateTime dateTime = Convert.ToDateTime(strDateTime);
                

                //insert data
                string cmd = "INSERT INTO ClassAttendance VALUES('" + dateTime + "')";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
            }
            else
            {
                MessageBox.Show("Date is Incorrect");
            }
        }
        public void DisplayData()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM ClassAttendance", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
            conn.Close();
        }

        private void btnGoBackToManageForm_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnGoBackToManageForm.Height;
            panelLeft.Top = btnGoBackToManageForm.Top;
            MessageBox.Show("You are going to leave this Form");
            this.Hide();

            FormManageStudents frm = FormManageStudents.SetGUIPlacements();
            frm.Show();
        }

        private void btnAddAttendances_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAddAttendances.Height;
            panelLeft.Top = btnAddAttendances.Top;
            MessageBox.Show("You are already on Class Attendance Form");
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
