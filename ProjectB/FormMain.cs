using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class FormMain : Form
    {
        string conURL = "Data Source=RANA-ADEEL;Initial Catalog=ProjectB;User ID=sa;Password=12345;MultipleActiveResultSets=True";
        
        public FormMain()
        {
            InitializeComponent();
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            MessageBox.Show("Connection is Open");
            conn.Close();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            //panel start
            panelLeft.Height = btnManageStudents.Height;
            panelLeft.Top = btnManageStudents.Top;
            //pannel close

            this.Hide();
            FormManageStudents manageStudent = new FormManageStudents();
            manageStudent.Show();
        }

        private void btnManageAssessments_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnManageAssessments.Height;
            panelLeft.Top = btnManageAssessments.Top;
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void btnManageCLOs_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnManageCLOs.Height;
            panelLeft.Top = btnManageCLOs.Top;

            //Start
            this.Hide();
            FormManageClos frm = new FormManageClos();
            frm.Show();
        }

        private void btnManageRubrics_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnManageRubrics.Height;
            panelLeft.Top = btnManageRubrics.Top;

            //start
            this.Hide();
            RubricForm frm = new RubricForm();
            frm.Show();
        }

        private void btnManageRubricsLevels_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnManageRubricsLevels.Height;
            panelLeft.Top = btnManageRubricsLevels.Top;

            //start
            this.Hide();
            FormRubricLevels frm = new FormRubricLevels();
            frm.Show();

            
        }

        private void btnMarkEvaluation_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnMarkEvaluation.Height;
            panelLeft.Top = btnMarkEvaluation.Top;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
