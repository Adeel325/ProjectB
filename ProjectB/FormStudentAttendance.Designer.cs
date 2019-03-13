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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnGoBackToManageForm = new System.Windows.Forms.Button();
            this.btnAddAttendances = new System.Windows.Forms.Button();
            this.txtAttendanceStatus = new System.Windows.Forms.TextBox();
            this.lblStudentIds = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.cmbStudentIds = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGoBackToManageForm);
            this.panel1.Controls.Add(this.btnAddAttendances);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 529);
            this.panel1.TabIndex = 9;
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
            this.btnGoBackToManageForm.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // btnAddAttendances
            // 
            this.btnAddAttendances.FlatAppearance.BorderSize = 0;
            this.btnAddAttendances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAttendances.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttendances.ForeColor = System.Drawing.Color.White;
            this.btnAddAttendances.Location = new System.Drawing.Point(0, 124);
            this.btnAddAttendances.Name = "btnAddAttendances";
            this.btnAddAttendances.Size = new System.Drawing.Size(166, 49);
            this.btnAddAttendances.TabIndex = 2;
            this.btnAddAttendances.Text = "Add Attendances";
            this.btnAddAttendances.UseVisualStyleBackColor = true;
            this.btnAddAttendances.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // txtAttendanceStatus
            // 
            this.txtAttendanceStatus.Location = new System.Drawing.Point(408, 116);
            this.txtAttendanceStatus.Name = "txtAttendanceStatus";
            this.txtAttendanceStatus.Size = new System.Drawing.Size(237, 27);
            this.txtAttendanceStatus.TabIndex = 12;
            // 
            // lblStudentIds
            // 
            this.lblStudentIds.AutoSize = true;
            this.lblStudentIds.ForeColor = System.Drawing.Color.White;
            this.lblStudentIds.Location = new System.Drawing.Point(228, 65);
            this.lblStudentIds.Name = "lblStudentIds";
            this.lblStudentIds.Size = new System.Drawing.Size(103, 21);
            this.lblStudentIds.TabIndex = 13;
            this.lblStudentIds.Text = "Student ID\'s";
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
            // 
            // btnAttendance
            // 
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(491, 165);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(170, 31);
            this.btnAttendance.TabIndex = 14;
            this.btnAttendance.Text = "Add Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // cmbStudentIds
            // 
            this.cmbStudentIds.FormattingEnabled = true;
            this.cmbStudentIds.Location = new System.Drawing.Point(408, 57);
            this.cmbStudentIds.Name = "cmbStudentIds";
            this.cmbStudentIds.Size = new System.Drawing.Size(237, 29);
            this.cmbStudentIds.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 214);
            this.dataGridView1.TabIndex = 16;
            // 
            // FormStudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(763, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbStudentIds);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.lblAttendanceStatus);
            this.Controls.Add(this.lblStudentIds);
            this.Controls.Add(this.txtAttendanceStatus);
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
        private System.Windows.Forms.TextBox txtAttendanceStatus;
        private System.Windows.Forms.Label lblStudentIds;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.ComboBox cmbStudentIds;
        private System.Windows.Forms.Button btnGoBackToManageForm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}