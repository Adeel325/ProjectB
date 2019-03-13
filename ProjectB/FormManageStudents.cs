﻿using System;
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

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAddStudents.Height;
            panelLeft.Top = btnAddStudents.Top;

            //Go to add student form
            FormStudentAttendance frm = new FormStudentAttendance();
            this.Hide();
            frm.Show();
        }

        private void btnAddStudentAttendance_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAddStudentAttendance.Height;
            panelLeft.Top = btnAddStudentAttendance.Top;

            //Go to add student attendance form
            FormStudentAttendance frm = new FormStudentAttendance();
            this.Hide();
            frm.Show();
        }

        private void FormManageStudents_Load(object sender, EventArgs e)
        {
            panelLeft.Height = btnAddStudents.Height;
            panelLeft.Top = btnAddStudents.Top;
        }
    }
}