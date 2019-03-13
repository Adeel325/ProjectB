namespace ProjectB
{
    partial class FormAddStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.goBackToManageForm = new System.Windows.Forms.Button();
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.FlatAppearance.BorderSize = 0;
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMain.ForeColor = System.Drawing.Color.White;
            this.btnBackToMain.Location = new System.Drawing.Point(12, 454);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(166, 37);
            this.btnBackToMain.TabIndex = 14;
            this.btnBackToMain.Text = "Back to Main Page";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(488, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 348);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 166);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(412, 30);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(214, 27);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(412, 65);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(214, 27);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(412, 101);
            this.txtContact.Margin = new System.Windows.Forms.Padding(5);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(214, 27);
            this.txtContact.TabIndex = 5;
            this.txtContact.Validating += new System.ComponentModel.CancelEventHandler(this.txtContact_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(412, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 27);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(412, 171);
            this.txtRegistrationNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(214, 27);
            this.txtRegistrationNumber.TabIndex = 9;
            this.txtRegistrationNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtRegistrationNumber_Validating);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(412, 206);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(214, 27);
            this.txtStatus.TabIndex = 11;
            this.txtStatus.Validating += new System.ComponentModel.CancelEventHandler(this.txtStatus_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(212, 36);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 21);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(212, 71);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.ForeColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(212, 107);
            this.lblContact.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(78, 21);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(212, 142);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.ForeColor = System.Drawing.Color.White;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(212, 177);
            this.lblRegistrationNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(166, 21);
            this.lblRegistrationNumber.TabIndex = 8;
            this.lblRegistrationNumber.Text = "RegistrationNumber";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(212, 212);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 21);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Location = new System.Drawing.Point(640, 316);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(137, 32);
            this.btnDeleteStudent.TabIndex = 15;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.FlatAppearance.BorderSize = 0;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Location = new System.Drawing.Point(479, 318);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(146, 31);
            this.btnEditStudent.TabIndex = 16;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(167, 123);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 51);
            this.panelLeft.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.goBackToManageForm);
            this.panel1.Controls.Add(this.btnStudentForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 525);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 82);
            this.panel3.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(42, -13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(63, 79);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "p";
            // 
            // goBackToManageForm
            // 
            this.goBackToManageForm.FlatAppearance.BorderSize = 0;
            this.goBackToManageForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackToManageForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackToManageForm.ForeColor = System.Drawing.Color.White;
            this.goBackToManageForm.Location = new System.Drawing.Point(3, 195);
            this.goBackToManageForm.Name = "goBackToManageForm";
            this.goBackToManageForm.Size = new System.Drawing.Size(166, 95);
            this.goBackToManageForm.TabIndex = 2;
            this.goBackToManageForm.Text = "Go Back To Manage Student Form";
            this.goBackToManageForm.UseVisualStyleBackColor = true;
            this.goBackToManageForm.Click += new System.EventHandler(this.goBackToManageForm_Click);
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.FlatAppearance.BorderSize = 0;
            this.btnStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentForm.ForeColor = System.Drawing.Color.White;
            this.btnStudentForm.Location = new System.Drawing.Point(0, 123);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(166, 62);
            this.btnStudentForm.TabIndex = 2;
            this.btnStudentForm.Text = "Add Students Form";
            this.btnStudentForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentForm.UseVisualStyleBackColor = true;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // FormAddStudents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(814, 525);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRegistrationNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackToMain);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAddStudents";
            this.Text = "FormAddStudents";
            this.Load += new System.EventHandler(this.FormManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button goBackToManageForm;
        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}