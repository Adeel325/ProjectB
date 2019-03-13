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
    public partial class FormManageClos : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        public FormManageClos()
        {
            InitializeComponent();
            DisplayClos();
            panelLeft.Height = btnGoBackToMain.Height;
            panelLeft.Top = btnGoBackToMain.Top;
        }

        private void btnGoBackToMain_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnGoBackToMain.Height;
            panelLeft.Top = btnGoBackToMain.Top;

            MessageBox.Show("Alert! You are leaving this form!");
            this.Hide();
            FormMain frm = new FormMain();
            frm.Show();
        }

        private void buttonFormManageClos_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonFormManageClos.Height;
            panelLeft.Top = buttonFormManageClos.Top;
            MessageBox.Show("You are already on this form.");
        }

        private void btnAddClo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (txtName.Text != "" &&
                dateTimePicker1.Text != "" &&
                dateTimePicker2.Text != ""
                )
            {
                //Store data
                string Name = txtName.Text;
                var dateCreated = Convert.ToDateTime(dateTimePicker1.Text);
                var dateUpdated = Convert.ToDateTime(dateTimePicker2.Text);

                //insert data
                string cmd = "INSERT INTO Clo VALUES('" + Name + "', '" + dateCreated + "', '" + dateUpdated + "')";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
       
            //clear data
            ClearCloData();
        }
        //Display Data in DataGridView  
        private void DisplayClos()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Clo", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        public void ClearCloData()
        {
            txtName.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }
    }
}
