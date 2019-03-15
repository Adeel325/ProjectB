using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class FormManageStudents : Form
    {
        public FormManageStudents()
        {
            InitializeComponent();
        }

        //Form Display Setting
        private static FormManageStudents instance;
        public static FormManageStudents SetGUIPlacements()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormManageStudents();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        
        private void FormManageStudents_Load(object sender, EventArgs e)
        {
            //Set the pannel height
            panelLeft.Height = btnAddStudents.Height;
            panelLeft.Top = btnAddStudents.Top;
        }

        private void btnGoBackToMain_Click(object sender, EventArgs e)
        {
            //Set the pannel height
            panelLeft.Height = btnGoBackToMain.Height;
            panelLeft.Top = btnGoBackToMain.Top;

            //Go to Main form
            FormMain frm = FormMain.SetGUIPlacements();
            this.Hide();
            frm.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Set the pannel height
            panelLeft.Height = btnAddStudent.Height;
            panelLeft.Top = btnAddStudent.Top;

            //Go to add student form
            FormAddStudents frm = FormAddStudents.SetGUIPlacements();
            this.Hide();
            frm.Show();
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            //Set the pannel height
            panelLeft.Height = btnAddAttendance.Height;
            panelLeft.Top = btnAddAttendance.Top;

            //Go to student Attendance form
            FormStudentAttendance frm = FormStudentAttendance.SetGUIPlacements();
            this.Hide();
            frm.Show();
        }

        private void btnAddClassAttendance_Click(object sender, EventArgs e)
        {
            //Set the pannel height
            panelLeft.Height = btnAddClassAttendance.Height;
            panelLeft.Top = btnAddClassAttendance.Top;

            // go to class Attendance form
            this.Hide();
            ClassAttendanceForm frm = ClassAttendanceForm.SetGUIPlacements();
            frm.Show();
        }
    }
}
