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
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public FormManageClos()
        {
            InitializeComponent();
            DisplayClos();
            panelLeft.Height = btnGoBackToMain.Height;
            panelLeft.Top = btnGoBackToMain.Top;
        }

        //Form Display Setting
        private static FormManageClos instance;
        public static FormManageClos SetGUIPlacements()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormManageClos();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        //

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

            if (txtName.Text != "")
            {
                //Store data
                string Name = txtName.Text;
                var dateCreated = DateTime.Now;
                var dateUpdated = DateTime.Now;

                //insert data
                string cmd = "INSERT INTO Clo VALUES('" + Name + "', '" + dateCreated + "', '" + dateUpdated + "')";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                DisplayClos();
                //clear data
                ClearCloData();
            }
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
            
        }

        private void FormManageClos_Load(object sender, EventArgs e)
        {

        }  

        private void btnEditClo_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Clo set Name=@name, DateUpdated=@dateUpdated where ID=@id", conn);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dateUpdated", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                DisplayClos();
                conn.Close();
                ClearCloData();
            }
            else
            {
                MessageBox.Show("Please Select Row from DataGridView which you wanna update");
            }
        }

        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    ID = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                    txtName.Text = row.Cells["Name"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProviderApp.SetError(txtName, "Status should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtName, "");
            }
        }

        private void btnDeleteClo_Click(object sender, EventArgs e)
        {
            //if (ID != 0)
            //{
            //    SqlConnection conn = new SqlConnection(conURL);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("delete Clo where ID=@id", conn); 
            //    cmd.Parameters.AddWithValue("@id", ID);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Record Deleted Successfully!");
            //    DisplayClos();
            //    ClearCloData();
            //    conn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Please Select Record to Delete");
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
