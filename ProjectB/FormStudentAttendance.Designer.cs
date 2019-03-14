namespace ProjectB
{
    partial class FormStudentAttendance
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudentAttendanceForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnGoBackToManageForm = new System.Windows.Forms.Button();
            this.btnAddAttendances = new System.Windows.Forms.Button();
            this.lblStudentIds = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.btnAddStudentAttendance = new System.Windows.Forms.Button();
            this.cmbStudentIds = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.cmbAttendanceId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(167, 123);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 51);
            this.panelLeft.TabIndex = 11;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStudentAttendanceForm);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGoBackToManageForm);
            this.panel1.Controls.Add(this.btnAddAttendances);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 529);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStudentAttendanceForm
            // 
            this.btnStudentAttendanceForm.FlatAppearance.BorderSize = 0;
            this.btnStudentAttendanceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentAttendanceForm.ForeColor = System.Drawing.Color.White;
            this.btnStudentAttendanceForm.Location = new System.Drawing.Point(0, 112);
            this.btnStudentAttendanceForm.Name = "btnStudentAttendanceForm";
            this.btnStudentAttendanceForm.Size = new System.Drawing.Size(166, 62);
            this.btnStudentAttendanceForm.TabIndex = 7;
            this.btnStudentAttendanceForm.Text = "Student Attendance Form";
            this.btnStudentAttendanceForm.UseVisualStyleBackColor = true;
            this.btnStudentAttendanceForm.Click += new System.EventHandler(this.btnStudentAttendanceForm_Click);
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
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // btnGoBackToManageForm
            // 
            this.btnGoBackToManageForm.FlatAppearance.BorderSize = 0;
            this.btnGoBackToManageForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToManageForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackToManageForm.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToManageForm.Location = new System.Drawing.Point(0, 194);
            this.btnGoBackToManageForm.Name = "btnGoBackToManageForm";
            this.btnGoBackToManageForm.Size = new System.Drawing.Size(166, 76);
            this.btnGoBackToManageForm.TabIndex = 2;
            this.btnGoBackToManageForm.Text = "Go Back to Manage Student Form";
            this.btnGoBackToManageForm.UseVisualStyleBackColor = true;
            this.btnGoBackToManageForm.Click += new System.EventHandler(this.btnGoBackToManageForm_Click);
            // 
            // btnAddAttendances
            // 
            this.btnAddAttendances.Location = new System.Drawing.Point(0, 0);
            this.btnAddAttendances.Name = "btnAddAttendances";
            this.btnAddAttendances.Size = new System.Drawing.Size(75, 23);
            this.btnAddAttendances.TabIndex = 6;
            // 
            // lblStudentIds
            // 
            this.lblStudentIds.AutoSize = true;
            this.lblStudentIds.ForeColor = System.Drawing.Color.White;
            this.lblStudentIds.Location = new System.Drawing.Point(228, 78);
            this.lblStudentIds.Name = "lblStudentIds";
            this.lblStudentIds.Size = new System.Drawing.Size(103, 21);
            this.lblStudentIds.TabIndex = 13;
            this.lblStudentIds.Text = "Student ID\'s";
            this.lblStudentIds.Click += new System.EventHandler(this.lblStudentIds_Click);
            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.ForeColor = System.Drawing.Color.White;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(222, 123);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(162, 21);
            this.lblAttendanceStatus.TabIndex = 13;
            this.lblAttendanceStatus.Text = "Attendance Status";
            this.lblAttendanceStatus.Click += new System.EventHandler(this.lblAttendanceStatus_Click);
            // 
            // btnAddStudentAttendance
            // 
            this.btnAddStudentAttendance.FlatAppearance.BorderSize = 0;
            this.btnAddStudentAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAddStudentAttendance.Location = new System.Drawing.Point(491, 165);
            this.btnAddStudentAttendance.Name = "btnAddStudentAttendance";
            this.btnAddStudentAttendance.Size = new System.Drawing.Size(170, 31);
            this.btnAddStudentAttendance.TabIndex = 14;
            this.btnAddStudentAttendance.Text = "Add Attendance";
            this.btnAddStudentAttendance.UseVisualStyleBackColor = true;
            this.btnAddStudentAttendance.Click += new System.EventHandler(this.btnAddStudentAttendance_Click);
            // 
            // cmbStudentIds
            // 
            this.cmbStudentIds.FormattingEnabled = true;
            this.cmbStudentIds.Location = new System.Drawing.Point(408, 74);
            this.cmbStudentIds.Name = "cmbStudentIds";
            this.cmbStudentIds.Size = new System.Drawing.Size(237, 29);
            this.cmbStudentIds.TabIndex = 15;
            this.cmbStudentIds.SelectedIndexChanged += new System.EventHandler(this.cmbStudentIds_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 214);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(408, 123);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(237, 29);
            this.cmbStatus.TabIndex = 17;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblAttendanceId
            // 
            this.lblAttendanceId.AutoSize = true;
            this.lblAttendanceId.ForeColor = System.Drawing.Color.White;
            this.lblAttendanceId.Location = new System.Drawing.Point(228, 29);
            this.lblAttendanceId.Name = "lblAttendanceId";
            this.lblAttendanceId.Size = new System.Drawing.Size(130, 21);
            this.lblAttendanceId.TabIndex = 18;
            this.lblAttendanceId.Text = "Attendance ID";
            // 
            // cmbAttendanceId
            // 
            this.cmbAttendanceId.FormattingEnabled = true;
            this.cmbAttendanceId.Location = new System.Drawing.Point(408, 25);
            this.cmbAttendanceId.Name = "cmbAttendanceId";
            this.cmbAttendanceId.Size = new System.Drawing.Size(237, 29);
            this.cmbAttendanceId.TabIndex = 19;
            // 
            // FormStudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(763, 529);
            this.Controls.Add(this.cmbAttendanceId);
            this.Controls.Add(this.lblAttendanceId);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbStudentIds);
            this.Controls.Add(this.btnAddStudentAttendance);
            this.Controls.Add(this.lblAttendanceStatus);
            this.Controls.Add(this.lblStudentIds);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStudentAttendance";
            this.Text = "FormStudentAttendance";
            this.Load += new System.EventHandler(this.FormStudentAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnAddAttendances;
        private System.Windows.Forms.Label lblStudentIds;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Button btnAddStudentAttendance;
        private System.Windows.Forms.ComboBox cmbStudentIds;
        private System.Windows.Forms.Button btnGoBackToManageForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblAttendanceId;
        private System.Windows.Forms.ComboBox cmbAttendanceId;
        private System.Windows.Forms.Button btnStudentAttendanceForm;
    }
}