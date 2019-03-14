namespace ProjectB
{
    partial class ClassAttendanceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.lblAttendanceDate = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnGoBackToManageForm = new System.Windows.Forms.Button();
            this.btnAddAttendances = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(67, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.FlatAppearance.BorderSize = 0;
            this.btnAddAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAddAttendance.Location = new System.Drawing.Point(333, 107);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(170, 31);
            this.btnAddAttendance.TabIndex = 22;
            this.btnAddAttendance.Text = "Add Attendance";
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // lblAttendanceDate
            // 
            this.lblAttendanceDate.AutoSize = true;
            this.lblAttendanceDate.ForeColor = System.Drawing.Color.White;
            this.lblAttendanceDate.Location = new System.Drawing.Point(38, 57);
            this.lblAttendanceDate.Name = "lblAttendanceDate";
            this.lblAttendanceDate.Size = new System.Drawing.Size(153, 21);
            this.lblAttendanceDate.TabIndex = 20;
            this.lblAttendanceDate.Text = "Attendance Date";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(166, 121);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 51);
            this.panelLeft.TabIndex = 19;
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
            this.panel1.TabIndex = 18;
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
            this.btnGoBackToManageForm.Click += new System.EventHandler(this.btnGoBackToManageForm_Click);
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
            this.btnAddAttendances.Click += new System.EventHandler(this.btnAddAttendances_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(166, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 253);
            this.panel2.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.lblAttendanceDate);
            this.panel4.Controls.Add(this.btnAddAttendance);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(166, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 188);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 27);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // ClassAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(707, 529);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClassAttendanceForm";
            this.Text = "ClassAttendanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddAttendance;
        private System.Windows.Forms.Label lblAttendanceDate;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnGoBackToManageForm;
        private System.Windows.Forms.Button btnAddAttendances;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}